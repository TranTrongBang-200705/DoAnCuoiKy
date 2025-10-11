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
    public partial class frmInfo : Form
    {
        private readonly NguoiDung _nguoiDung;
        private readonly Model1 _context;
        public frmInfo(NguoiDung nguoiDung, Model1 context)
        {
            InitializeComponent();
            _nguoiDung = nguoiDung;
            _context = context;
            HienThiThongTin();
        }
        private void HienThiThongTin()
        {
            txtHo.Text = _nguoiDung.Ho;
            txtTen.Text = _nguoiDung.Ten;
            txtEmail.Text = _nguoiDung.Email;
            txtRole.Text = LayTenVaiTro(_nguoiDung.VaiTro);
        }
        public string LayTenVaiTro(int vaiTro)
        {
            return vaiTro switch
            {
                0 => "Học viên",
                1 => "Giảng viên",
                2 => "Quản trị viên",
                _ => "Không xác định"
            };
        }
        private void frmInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
