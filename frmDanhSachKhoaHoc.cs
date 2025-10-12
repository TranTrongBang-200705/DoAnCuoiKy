using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnCuoiKy.Models;

namespace DoAnCuoiKy
{
    public partial class frmDanhSachKhoaHoc : Form
    {
        private readonly Model1 _context;
        private readonly NguoiDung _nguoiDungHienTai;

        public frmDanhSachKhoaHoc(NguoiDung nguoiDung, Model1 context)
        {
            InitializeComponent();
            _nguoiDungHienTai = nguoiDung;
            _context = context;
        }

        private async void frmDanhSachKhoaHoc_Load(object sender, EventArgs e)
        {
            await TaiDanhMucFilter();
             TaiTrinhDoFilter();
            await TaiDanhSachKhoaHoc();
        }

        private async Task TaiDanhMucFilter()
        {
            try
            {
                // Xóa items cũ trước khi thêm mới
                cmbDanhMuc.Items.Clear();

                // Lấy danh mục từ CSDL bằng Entity Framework - DISTINCT để loại bỏ trùng
                var danhMucs = await _context.DanhMucs
                    .Select(dm => dm.TenDanhMuc)
                    .Distinct() // QUAN TRỌNG: Loại bỏ tên danh mục trùng
                    .OrderBy(ten => ten)
                    .ToListAsync();

                // Thêm item mặc định
                cmbDanhMuc.Items.Add("Tất cả danh mục");

                // Thêm danh mục từ CSDL (đã được DISTINCT)
                foreach (var tenDanhMuc in danhMucs)
                {
                    cmbDanhMuc.Items.Add(tenDanhMuc);
                }

                cmbDanhMuc.SelectedIndex = 0; // Chọn "Tất cả danh mục"
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải danh mục: {ex.Message}");
            }
        }

        private async void TaiTrinhDoFilter()
        {
            cmbTrinhDo.Items.Add("Tất cả trình độ");
            cmbTrinhDo.Items.Add("Cơ bản");
            cmbTrinhDo.Items.Add("Trung cấp");
            cmbTrinhDo.Items.Add("Nâng cao");
            cmbTrinhDo.SelectedIndex = 0;
        }

        private async Task TaiDanhSachKhoaHoc(string timKiem = "", string danhMuc = "", string trinhDo = "")
        {
            try
            {
                var query = _context.KhoaHocs
                    .Include(k => k.DanhMuc)
                    .Include(k => k.NguoiDung)
                    .Where(k => k.TrangThai == 1);

                if (!string.IsNullOrEmpty(timKiem))
                {
                    query = query.Where(k => k.TieuDe.Contains(timKiem) || k.MoTa.Contains(timKiem));
                }

                if (!string.IsNullOrEmpty(danhMuc) && danhMuc != "Tất cả danh mục")
                {
                    query = query.Where(k => k.DanhMuc.TenDanhMuc == danhMuc);
                }

                if (!string.IsNullOrEmpty(trinhDo) && trinhDo != "Tất cả trình độ")
                {
                    int trinhDoValue = trinhDo switch
                    {
                        "Cơ bản" => 0,
                        "Trung cấp" => 1,
                        "Nâng cao" => 2,
                        _ => -1
                    };
                    if (trinhDoValue != -1)
                    {
                        query = query.Where(k => k.TrinhDo == trinhDoValue);
                    }
                }

                var khoaHocs = await query
                    .OrderByDescending(k => k.NgayTao)
                    .ToListAsync();

                HienThiDuLieuLenPanel(khoaHocs);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải danh sách khóa học: {ex.Message}");
            }
        }

        private void HienThiDuLieuLenPanel(List<KhoaHoc> khoaHocs)
        {
            // Ẩn tất cả panel trước
            panelKhoaHoc1.Visible = false;
            panelKhoaHoc2.Visible = false;
            panelKhoaHoc3.Visible = false;

            // Hiển thị dữ liệu lên từng panel có sẵn
            for (int i = 0; i < Math.Min(khoaHocs.Count, 3); i++)
            {
                var khoaHoc = khoaHocs[i];

                switch (i)
                {
                    case 0:
                        HienThiKhoaHocLenPanel(panelKhoaHoc1, khoaHoc);
                        break;
                    case 1:
                        HienThiKhoaHocLenPanel(panelKhoaHoc2, khoaHoc);
                        break;
                    case 2:
                        HienThiKhoaHocLenPanel(panelKhoaHoc3, khoaHoc);
                        break;
                }
            }

            lblThongBao.Text = $"Tìm thấy {khoaHocs.Count} khóa học";
        }

        private void HienThiKhoaHocLenPanel(Panel panel, KhoaHoc khoaHoc)
        {
            panel.Visible = true;

            // Tìm các controls trong panel và gán dữ liệu
            foreach (Control control in panel.Controls)
            {
                switch (control.Name)
                {
                    case "lblTenKH1":
                    case "lblTenKH2":
                    case "lblTenKH3":
                        control.Text = khoaHoc.TieuDe;
                        break;
                    case "lblMoTa1":
                    case "lblMoTa2":
                    case "lblMoTa3":
                        control.Text = khoaHoc.MoTa?.Length > 100 ?
                            khoaHoc.MoTa.Substring(0, 100) + "..." : khoaHoc.MoTa;
                        break;
                    case "lblGiangVien1":
                    case "lblGiangVien2":
                    case "lblGiangVien3":
                        control.Text = $"👤 Giảng viên: {khoaHoc.NguoiDung?.Ho} {khoaHoc.NguoiDung?.Ten}";
                        break;
                    case "lblThongTin1":
                    case "lblThongTin2":
                    case "lblThongTin3":
                        control.Text = $"📚 {khoaHoc.TongBaiHoc} bài | ⭐ {khoaHoc.DiemDanhGiaTB:0.0} | 👥 {khoaHoc.TongHocVien} HV";
                        break;
                    case "lblGia1":
                    case "lblGia2":
                    case "lblGia3":
                        control.Text = khoaHoc.GiaTien == 0 ? "🆓 Miễn phí" : $"💵 {khoaHoc.GiaTien:N0} VNĐ";
                        break;
                    case "btnDangKy1":
                    case "btnDangKy2":
                    case "btnDangKy3":
                        var button = (Button)control;
                        button.Tag = khoaHoc.MaKhoaHoc;
                        button.Click += BtnDangKy_Click;
                        break;
                }
            }
        }

        private  void BtnDangKy_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            
        }

        private async void btnDangKy1_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var maKhoaHoc = (Guid)button.Tag;

            try
            {
                var daDangKy = await _context.DangKyKhoaHocs
                    .AnyAsync(dk => dk.MaHocVien == _nguoiDungHienTai.MaNguoiDung && dk.MaKhoaHoc == maKhoaHoc);

                if (daDangKy)
                {
                    MessageBox.Show("Bạn đã đăng ký khóa học này rồi!", "Thông báo");
                    return;
                }

                var dangKy = new DangKyKhoaHoc
                {
                    MaDangKy = Guid.NewGuid(),
                    MaHocVien = _nguoiDungHienTai.MaNguoiDung,
                    MaKhoaHoc = maKhoaHoc,
                    NgayDangKy = DateTime.Now,
                    PhanTramHoanThanh = 0,
                    DaHoanThanh = false
                };

                _context.DangKyKhoaHocs.Add(dangKy);
                await _context.SaveChangesAsync();

                MessageBox.Show("Đăng ký khóa học thành công!", "Thành công");
                button.Enabled = false;
                button.Text = "Đã đăng ký";
                button.BackColor = Color.Gray;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi đăng ký: {ex.Message}", "Lỗi");
            }
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            string timKiem = txtTimKiem.Text.Trim();
            string danhMuc = cmbDanhMuc.SelectedItem?.ToString() ?? "";
            string trinhDo = cmbTrinhDo.SelectedItem?.ToString() ?? "";

            TaiDanhSachKhoaHoc(timKiem, danhMuc, trinhDo);
        }

        private async void btnDangKy2_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var maKhoaHoc = (Guid)button.Tag;

            try
            {
                var daDangKy = await _context.DangKyKhoaHocs
                    .AnyAsync(dk => dk.MaHocVien == _nguoiDungHienTai.MaNguoiDung && dk.MaKhoaHoc == maKhoaHoc);

                if (daDangKy)
                {
                    MessageBox.Show("Bạn đã đăng ký khóa học này rồi!", "Thông báo");
                    return;
                }

                var dangKy = new DangKyKhoaHoc
                {
                    MaDangKy = Guid.NewGuid(),
                    MaHocVien = _nguoiDungHienTai.MaNguoiDung,
                    MaKhoaHoc = maKhoaHoc,
                    NgayDangKy = DateTime.Now,
                    PhanTramHoanThanh = 0,
                    DaHoanThanh = false
                };

                _context.DangKyKhoaHocs.Add(dangKy);
                await _context.SaveChangesAsync();

                MessageBox.Show("Đăng ký khóa học thành công!", "Thành công");
                button.Enabled = false;
                button.Text = "Đã đăng ký";
                button.BackColor = Color.Gray;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi đăng ký: {ex.Message}", "Lỗi");
            }
        }

        private async void btnDangKy3_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var maKhoaHoc = (Guid)button.Tag;

            try
            {
                var daDangKy = await _context.DangKyKhoaHocs
                    .AnyAsync(dk => dk.MaHocVien == _nguoiDungHienTai.MaNguoiDung && dk.MaKhoaHoc == maKhoaHoc);

                if (daDangKy)
                {
                    MessageBox.Show("Bạn đã đăng ký khóa học này rồi!", "Thông báo");
                    return;
                }

                var dangKy = new DangKyKhoaHoc
                {
                    MaDangKy = Guid.NewGuid(),
                    MaHocVien = _nguoiDungHienTai.MaNguoiDung,
                    MaKhoaHoc = maKhoaHoc,
                    NgayDangKy = DateTime.Now,
                    PhanTramHoanThanh = 0,
                    DaHoanThanh = false
                };

                _context.DangKyKhoaHocs.Add(dangKy);
                await _context.SaveChangesAsync();

                MessageBox.Show("Đăng ký khóa học thành công!", "Thành công");
                button.Enabled = false;
                button.Text = "Đã đăng ký";
                button.BackColor = Color.Gray;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi đăng ký: {ex.Message}", "Lỗi");
            }
        }
    }
}