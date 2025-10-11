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
    public partial class frmDashboard : Form
    {
        private readonly NguoiDung _nguoiDungHienTai;
        private readonly Model1 _context;

        public frmDashboard(NguoiDung nguoiDung, Model1 context)
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
            try
            {
                var khoaHocPhoBienNhat = await _context.KhoaHocs
                    .Where(k => k.TrangThai == 1)
                    .OrderByDescending(k => k.TongHocVien)
                    .FirstOrDefaultAsync();

                if (khoaHocPhoBienNhat != null)
                {
                    // HIỂN THỊ DỮ LIỆU THẬT
                    lblTenKhoaHoc1.Text = khoaHocPhoBienNhat.TieuDe.ToUpper();
                    lblHocVien1.Text = $"👥 {khoaHocPhoBienNhat.TongHocVien} học viên";
                    lblDanhGia1.Text = $"⭐ {khoaHocPhoBienNhat.DiemDanhGiaTB:0.0}/5";

                    int phanTram = (int)(khoaHocPhoBienNhat.DiemDanhGiaTB * 20);
                    progressBar1.Value = Math.Min(phanTram, 100);
                    lblPhanTram1.Text = $"{progressBar1.Value}%";
                }
                else
                {
                    // HIỂN THỊ DỮ LIỆU MẶC ĐỊNH (TẠM THỜI)
                    lblTenKhoaHoc1.Text = "C# CƠ BẢN";
                    lblHocVien1.Text = "👥 89 học viên";
                    lblDanhGia1.Text = "⭐ 4.8/5";
                    progressBar1.Value = 96; // 4.8 * 20 = 96
                    lblPhanTram1.Text = "96%";

                    MessageBox.Show("Chưa có dữ liệu thật, đang hiển thị dữ liệu mẫu");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }
    }
}
