using DoAnCuoiKy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy
{
    public partial class frmKhoaGiangDay : Form
    {
        private readonly Model1 _context = new Model1();
        private Guid _maGiangVien;
        public frmKhoaGiangDay(Guid maGiangVien)
        {
            InitializeComponent();
            _maGiangVien = maGiangVien;

        }

        private void frmKhoaGiangDay_Load(object sender, EventArgs e)
        {
            LoadLichGiangDay();
        }
        private void LoadLichGiangDay()
        {
            var data = (from ld in _context.LichDays
                        join mh in _context.MonHocs on ld.MaMon equals mh.MaMon
                        select new
                        {
                            ld.Tiet,
                            MonHoc = mh.TenMon,
                            ld.Lop,
                            ld.Phong
                        }).ToList();

            dgvLichDay.DataSource = data;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim().ToLower();

            var data = (from ld in _context.LichDays
                        join mh in _context.MonHocs on ld.MaMon equals mh.MaMon
                        where mh.TenMon.ToLower().Contains(keyword)
                        select new
                        {
                            ld.Tiet,
                            MonHoc = mh.TenMon,
                            ld.Lop,
                            ld.Phong
                        }).ToList();

            dgvLichDay.DataSource = data;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvLichDay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
