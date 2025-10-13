using DoAnCuoiKy.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy
{
    public partial class frmBaiHoc : Form
    {
        private readonly Model1 _context;
        private readonly string _maKhoaHoc;
        private readonly string _maHocVien;
        private List<ChuongHoc> _danhSachChuong;
        private List<BaiHoc> _danhSachBaiHoc;
        private List<TienDoHocTap> _tienDoHocVien;
        private BaiHoc _baiHocHienTai;
        private int _baiHocIndex = 0;

        public frmBaiHoc(string maKhoaHoc, string maHocVien, Model1 context)
        {
            InitializeComponent();

            _maKhoaHoc = maKhoaHoc;
            _maHocVien = maHocVien;
            _context = context;

            Load += async (s, e) => await TaiDuLieuKhoaHoc();
        }

        private async Task TaiDuLieuKhoaHoc()
        {
            try
            {
                // KHỞI TẠO WEBVIEW2 TRƯỚC KHI DÙNG
                await webView2Video.EnsureCoreWebView2Async(null);

                // 1. Load thông tin khóa học
                var khoaHoc = await _context.KhoaHocs
                    .FirstOrDefaultAsync(kh => kh.MaKhoaHoc.ToString() == _maKhoaHoc);

                lblTenKhoaHoc.Text = khoaHoc?.TieuDe ?? "Khóa học";

                // 2. Load danh sách chương học
                _danhSachChuong = await _context.ChuongHocs
                    .Where(ch => ch.MaKhoaHoc.ToString() == _maKhoaHoc)
                    .OrderBy(ch => ch.ThuTu)
                    .ToListAsync();

                // 3. Load danh sách bài học
                var maChuongs = _danhSachChuong.Select(ch => ch.MaChuong).ToList();
                _danhSachBaiHoc = await _context.BaiHocs
                    .Where(bh => maChuongs.Contains(bh.MaChuong) && bh.TrangThai == 1)
                    .OrderBy(bh => bh.ThuTu)
                    .ToListAsync();

                // 4. Load tiến độ học tập
                var maBaiHocs = _danhSachBaiHoc.Select(bh => bh.MaBaiHoc).ToList();
                _tienDoHocVien = await _context.TienDoHocTaps
                    .Where(td => td.MaHocVien.ToString() == _maHocVien &&
                                 maBaiHocs.Contains(td.MaBaiHoc))
                    .ToListAsync();

                // 5. Hiển thị danh sách bài học
                HienThiDanhSachBaiHoc();

                // 6. Hiển thị bài học đầu tiên
                if (_danhSachBaiHoc.Any())
                {
                    _baiHocHienTai = _danhSachBaiHoc.First();
                    HienThiBaiHoc(_baiHocHienTai);
                }

                // 7. Cập nhật thống kê
                CapNhatThongKe();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải dữ liệu: {ex.Message}");
            }
        }

        private void HienThiDanhSachBaiHoc()
        {
            treeViewBaiHoc.Nodes.Clear();

            foreach (var chuong in _danhSachChuong)
            {
                var nodeChuong = new TreeNode($"Chương {chuong.ThuTu}: {chuong.TieuDeChuong}");

                var baiHocTrongChuong = _danhSachBaiHoc
                    .Where(bh => bh.MaChuong == chuong.MaChuong)
                    .OrderBy(bh => bh.ThuTu)
                    .ToList();

                foreach (var baiHoc in baiHocTrongChuong)
                {
                    var tienDo = _tienDoHocVien.FirstOrDefault(td => td.MaBaiHoc == baiHoc.MaBaiHoc);
                    var icon = GetIconForBaiHoc(tienDo);
                    var nodeBai = new TreeNode($"{icon} Bài {baiHoc.ThuTu}: {baiHoc.TieuDeBaiHoc} ({baiHoc.ThoiLuong} phút)");
                    nodeBai.Tag = baiHoc;
                    nodeChuong.Nodes.Add(nodeBai);
                }

                treeViewBaiHoc.Nodes.Add(nodeChuong);
                nodeChuong.Expand();
            }

            treeViewBaiHoc.AfterSelect += TreeViewBaiHoc_AfterSelect;
        }

        private string GetIconForBaiHoc(TienDoHocTap tienDo)
        {
            if (tienDo == null) return "○";
            if (tienDo.TiLeHoanThanh >= 90) return "✓";
            if (tienDo.TiLeHoanThanh > 0) return "►";
            return "○";
        }

        private void TreeViewBaiHoc_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is BaiHoc baiHoc)
            {
                _baiHocHienTai = baiHoc;
                _baiHocIndex = _danhSachBaiHoc.IndexOf(baiHoc);
                HienThiBaiHoc(baiHoc);
            }
        }

        private void HienThiBaiHoc(BaiHoc baiHoc)
        {
            // Hiển thị tiêu đề
            lblTieuDeBaiHoc.Text = baiHoc.TieuDeBaiHoc;

            // Hiển thị video (nếu có) - DÙNG WEBVIEW2
            XuLyHienThiVideo(baiHoc);

            // Hiển thị nội dung bài học
            rtbNoiDung.Text = baiHoc.NoiDung;

            // Hiển thị thông tin bài học
            lblThongTinBaiHoc.Text = $"🕒 Thời lượng: {baiHoc.ThoiLuong} phút\n" +
                                   $"🎯 Loại bài: {GetKieuBaiHocText(baiHoc.KieuBaiHoc)}";

            // Cập nhật nút điều hướng
            btnTruoc.Enabled = _baiHocIndex > 0;
            btnSau.Enabled = _baiHocIndex < _danhSachBaiHoc.Count - 1;

            // Cập nhật tiến độ bài học
            var tienDo = _tienDoHocVien.FirstOrDefault(td => td.MaBaiHoc == baiHoc.MaBaiHoc);
            if (tienDo != null)
            {
                progressBaiHoc.Value = (int)tienDo.TiLeHoanThanh;
                lblTienDoBaiHoc.Text = $"{tienDo.TiLeHoanThanh:0}% hoàn thành";
            }
            else
            {
                progressBaiHoc.Value = 0;
                lblTienDoBaiHoc.Text = "0% hoàn thành";
            }
        }

        private void XuLyHienThiVideo(BaiHoc baiHoc)
        {
            if (string.IsNullOrEmpty(baiHoc.DuongDanVideo))
            {
                webView2Video.Visible = false;
                return;
            }

            webView2Video.Visible = true;

            // WEBVIEW2 LOAD TRỰC TIẾP YOUTUBE LINK
            try
            {
                webView2Video.CoreWebView2?.Navigate(baiHoc.DuongDanVideo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi load video: {ex.Message}");
            }
        }

        private string GetKieuBaiHocText(int kieuBaiHoc)
        {
            return kieuBaiHoc switch
            {
                0 => "Video",
                1 => "Văn bản",
                2 => "Quiz",
                _ => "Không xác định"
            };
        }

        private void CapNhatThongKe()
        {
            var tongBaiHoc = _danhSachBaiHoc.Count;
            var baiHocDaHoanThanh = _tienDoHocVien.Count(td => td.TiLeHoanThanh >= 90);
            var tongThoiLuong = _danhSachBaiHoc.Sum(bh => bh.ThoiLuong);
            var thoiGianDaHoc = _tienDoHocVien.Sum(td => td.ThoiGianXem) / 60;

            var phanTramHoanThanh = tongBaiHoc > 0 ? (baiHocDaHoanThanh * 100) / tongBaiHoc : 0;

            lblThongKe.Text = $"📊 THỐNG KÊ:\n" +
                            $"• {baiHocDaHoanThanh}/{tongBaiHoc} bài ✓\n" +
                            $"• {thoiGianDaHoc}/{tongThoiLuong} phút\n" +
                            $"• {phanTramHoanThanh}% hoàn thành";

            progressTongQuat.Value = phanTramHoanThanh;
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            if (_baiHocIndex > 0)
            {
                _baiHocIndex--;
                _baiHocHienTai = _danhSachBaiHoc[_baiHocIndex];
                HienThiBaiHoc(_baiHocHienTai);
            }
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            if (_baiHocIndex < _danhSachBaiHoc.Count - 1)
            {
                _baiHocIndex++;
                _baiHocHienTai = _danhSachBaiHoc[_baiHocIndex];
                HienThiBaiHoc(_baiHocHienTai);
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sử dụng controls trên video player để điều khiển");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBaiHoc_Load(object sender, EventArgs e)
        {
            // Khởi tạo thêm nếu cần
        }
    }
}