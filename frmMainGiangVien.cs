<<<<<<< HEAD
﻿using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DoAnCuoiKy.Models;
=======
﻿using DoAnCuoiKy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
>>>>>>> 1a62cc8b5e3d27547199f85edea8ce1443939d29

namespace DoAnCuoiKy
{
    public partial class frmMainGiangVien : Form
    {
<<<<<<< HEAD
        // 🔹 Biến toàn cục
        private Model1 _context;
        private NguoiDung _nguoiDung;

        // 🔹 Hàm khởi tạo có tham số (nhận thông tin người đăng nhập)
        public frmMainGiangVien(NguoiDung nguoiDung, Model1 context)
        {
            InitializeComponent();
            _nguoiDung = nguoiDung;
            _context = context;
        }

        // 🔹 Sự kiện khi form load
        private void frmMainGiangVien_Load(object sender, EventArgs e)
        {
            LoadThongKe();
            LoadCoSo();
        }

        // 🔹 Hàm hiển thị danh sách cơ sở (nếu có dgvPhongHoc)
        private void LoadCoSo()
        {
            var listCoSo = _context.CoSoes
                .Select(c => new { c.TenCoSo, c.KyHieuPhong, c.DiaChi })
                .ToList();
            dgvPhongHoc.DataSource = listCoSo;
        }

        // 🔹 Hàm thống kê nhanh
        private void LoadThongKe()
        {
            Guid maGiangVien = _nguoiDung.MaNguoiDung;

            int soKhoaHoc = _context.KhoaHocs.Count(k => k.MaGiangVien == maGiangVien);
            lblKhoaHoc.Text = $"Khóa học đang dạy: {soKhoaHoc}";

            // 2️⃣ Bài tập đã giao
            int soBaiTap = (from k in _context.KhoaHocs
                            join c in _context.ChuongHocs on k.MaKhoaHoc equals c.MaKhoaHoc
                            join b in _context.BaiHocs on c.MaChuong equals b.MaChuong
                            join bt in _context.BaiTaps on b.MaBaiHoc equals bt.MaBaiHoc
                            where k.MaGiangVien == maGiangVien
                            select bt).Count();
            lblBaiTapDaGiao.Text = $"Bài tập đã giao: {soBaiTap}";

            // 3️⃣ Bài tập đã chấm
            int soBaiCham = (from bt in _context.BaiTaps
                             join nb in _context.NopBaiTaps on bt.MaBaiTap equals nb.MaBaiTap
                             join bh in _context.BaiHocs on bt.MaBaiHoc equals bh.MaBaiHoc
                             join ch in _context.ChuongHocs on bh.MaChuong equals ch.MaChuong
                             join kh in _context.KhoaHocs on ch.MaKhoaHoc equals kh.MaKhoaHoc
                             where kh.MaGiangVien == maGiangVien && nb.TrangThai == 1
                             select nb).Count();
            lblBaiTapDaCham.Text = $"Bài tập đã chấm: {soBaiCham}";
        }
       


        private void mnuKhoaGiangDay_Click(object sender, EventArgs e)
        {
            var maGV = _nguoiDung.MaNguoiDung; // kiểu Guid
            frmKhoaGiangDay frm = new frmKhoaGiangDay(maGV);
            frm.ShowDialog();

        }

        private void menuQuanLyBaiTap_Click(object sender, EventArgs e)
        {
            frmQLBT f = new frmQLBT();
            f.StartPosition = FormStartPosition.CenterScreen; // căn giữa màn hình
            f.ShowDialog();
=======
        private readonly Model1 _context;
        private readonly NguoiDung _nguoiDunghientai;
        public frmMainGiangVien(NguoiDung nguoiDung, Model1 context)
        {
            InitializeComponent();
        }

        private void frmMainGiangVien_Load(object sender, EventArgs e)
        {

        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Gọi form thông tin cá nhân
            var frmThongTin = new frmInfo(_nguoiDunghientai, _context);
            frmThongTin.MdiParent = this; // Đặt làm form con của Main
            frmThongTin.WindowState = FormWindowState.Normal;
            frmThongTin.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmDoiMK = new frmDoiMK(_nguoiDunghientai, _context);
            frmDoiMK.MdiParent = this;
            frmDoiMK.WindowState = FormWindowState.Normal;
            frmDoiMK.Show();
>>>>>>> 1a62cc8b5e3d27547199f85edea8ce1443939d29
        }
    }
}
