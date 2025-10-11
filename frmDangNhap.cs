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

namespace DoAnCuoiKy
{
    public partial class frmDangNhap : Form
    {
        private readonly Model1 _context;

        public frmDangNhap()
        {
            _context = new Model1();
            InitializeComponent();
            txtMatKhau.UseSystemPasswordChar = true;
            this.chkMK.CheckedChanged += chkMK_CheckedChanged;
            btnDN.MouseEnter += (s, e) => btnDN.BackColor = Color.FromArgb(35, 120, 160);
            btnDN.MouseLeave += (s, e) => btnDN.BackColor = Color.FromArgb(46, 134, 171);
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private async void btnDN_Click(object sender, EventArgs e)
        {
            try
            {
                string tenDangNhap = txtTaiKhoan.Text.Trim();
                string matKhau = txtMatKhau.Text;

                // Validate
                if (string.IsNullOrEmpty(tenDangNhap))
                {
                    MessageBox.Show("Vui lòng nhập tài khoản!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTaiKhoan.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(matKhau))
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMatKhau.Focus();
                    return;
                }

                // Tìm người dùng trong database
                var nguoiDung = await _context.NguoiDungs.FirstOrDefaultAsync(u => u.TenDangNhap == tenDangNhap);

                if (nguoiDung == null)
                {
                    MessageBox.Show("Tài khoản không tồn tại!", "Lỗi đăng nhập",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTaiKhoan.Focus();
                    return;
                }

                // Kiểm tra mật khẩu (giả lập - thực tế cần hash)
                if (matKhau == "123456") // Thay bằng: KiemTraMatKhau(matKhau, nguoiDung.MatKhauHash)
                {
                    // Đăng nhập thành công
                    this.Hide();
                    var frmMain = new frmMain(nguoiDung, _context);
                    frmMain.Show();
                }
                else
                {
                    MessageBox.Show("Mật khẩu không đúng!", "Lỗi đăng nhập",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMatKhau.Focus();
                    txtMatKhau.SelectAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi hệ thống: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkMK_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = !chkMK.Checked;
        }
    }
}
