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
    public partial class frmMainGiangVien : Form
    {
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
        }
    }
}
