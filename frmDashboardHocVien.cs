using DoAnCuoiKy.Models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoAnCuoiKy
{
    public partial class frmDashboardHocVien : Form
    {
        private readonly NguoiDung _nguoiDungHienTai;
        private readonly Model1 _context;

        public frmDashboardHocVien(NguoiDung nguoiDung, Model1 context)
        {
            InitializeComponent();
            _nguoiDungHienTai = nguoiDung;
            _context = context;
        }


        private async void frmDashboard_Load(object sender, EventArgs e)
        {
            TaiDuLieuDashboard();
        }

        private async Task TaiDuLieuDashboard()
        {
            try
            {
                // Load dữ liệu khóa học phổ biến
                await TaiKhoaHoc1();
                await TaiTienDoHocTap();

                // Các phần khác sẽ thêm sau
                // await TaiDuLieuThongKe();
                // await TaiDuLieuTienDo();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải dữ liệu: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task TaiKhoaHoc1()
        {
            // 1. Số khóa học đã đăng ký
            var soKhoaHoc = await _context.DangKyKhoaHocs
                .CountAsync(d => d.MaHocVien == _nguoiDungHienTai.MaNguoiDung);
            lblSoKhoaHoc.Text = soKhoaHoc.ToString();

            // 2. Số khóa học đang học (chưa hoàn thành)
            var dangHoc = await _context.DangKyKhoaHocs
                .CountAsync(d => d.MaHocVien == _nguoiDungHienTai.MaNguoiDung &&
                                 d.DaHoanThanh == false);
            lblDangHoc.Text = dangHoc.ToString();

            // 3. Số khóa học đã hoàn thành
            var hoanThanh = await _context.DangKyKhoaHocs
                .CountAsync(d => d.MaHocVien == _nguoiDungHienTai.MaNguoiDung &&
                                 d.DaHoanThanh == true);
            lblHoanThanh.Text = hoanThanh.ToString();

          

            
        }
        private async Task TaiTienDoHocTap()
        {
            // Lấy 3 khóa học có tiến độ cao nhất
            var khoaHocDangHoc = await _context.DangKyKhoaHocs
                .Include(d => d.KhoaHoc)
                .Where(d => d.MaHocVien == _nguoiDungHienTai.MaNguoiDung)
                .OrderByDescending(d => d.PhanTramHoanThanh)
                .Take(3)
                .ToListAsync();

            // Cập nhật UI cho từng khóa học
            for (int i = 0; i < khoaHocDangHoc.Count; i++)
            {
                var dangKy = khoaHocDangHoc[i];

                switch (i)
                {
                    case 0:
                        CapNhatKhoaHocUI(lblTenKH1, progressBar1, lblPhanTram1, lblTrangThai1, dangKy);
                        break;
                    case 1:
                        CapNhatKhoaHocUI(lblTenKH2, progressBar2, lblPhanTram2, lblTrangThai2, dangKy);
                        break;
                    case 2:
                        CapNhatKhoaHocUI(lblTenKH3, progressBar3, lblPhanTram3, lblTrangThai3, dangKy);
                        break;
                }
            }
        }
        private void CapNhatKhoaHocUI(Label lblTen, System.Windows.Forms.ProgressBar progress, Label lblPhanTram, Label lblTrangThai, DangKyKhoaHoc dangKy)
        {
            // Tên khóa học
            lblTen.Text = dangKy.KhoaHoc.TieuDe;

            // Tiến độ
            int phanTram = (int)(dangKy.PhanTramHoanThanh ?? 0);
            progress.Value = phanTram;
            lblPhanTram.Text = $"{phanTram}%";

            // Trạng thái đơn giản
            if (phanTram == 100)
            {
                lblTrangThai.Text = "✅ Đã hoàn thành";
            }
          
            
            else
            {
                lblTrangThai.Text = "Chưa hoàn thành";
            }
        }

    }
}
