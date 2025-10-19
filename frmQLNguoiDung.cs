using DoAnCuoiKy.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DoAnCuoiKy
{
    public partial class frmQLNguoiDung : Form
    {
        private readonly Model1 _context = new Model1();
        private Guid selectedUserId;

        public frmQLNguoiDung()
        {
            InitializeComponent();
            LoadData();
            LoadComboVaiTro();
        }

        // ====== LOAD DỮ LIỆU BAN ĐẦU ======
        private void LoadComboVaiTro()
        {
            comboVaiTro.Items.Clear();
            comboVaiTro.Items.AddRange(new object[]
            {
                "0 - Học viên",
                "1 - Giảng viên",
                "2 - Admin"
            });
        }

        private void LoadData()
        {
            var data = _context.NguoiDungs
                .Select(nd => new
                {
                    nd.MaNguoiDung,
                    HoTen = nd.Ho + " " + nd.Ten,
                    nd.Email,
                    nd.TenDangNhap,
                    VaiTro = nd.VaiTro == 0 ? "Học viên"
                           : nd.VaiTro == 1 ? "Giảng viên" : "Admin",
                    nd.NgayTao,
                    nd.DaKhoa
                })
                .ToList();

            dataGridViewUsers.DataSource = data;
            if (dataGridViewUsers.Columns["MaNguoiDung"] != null)
                dataGridViewUsers.Columns["MaNguoiDung"].Visible = false;
        }

        // ====== CLICK TRÊN DÒNG DỮ LIỆU ======
        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridViewUsers.Rows[e.RowIndex];
                selectedUserId = Guid.Parse(row.Cells["MaNguoiDung"].Value.ToString());

                var user = _context.NguoiDungs.FirstOrDefault(u => u.MaNguoiDung == selectedUserId);
                if (user != null)
                {
                    txtMaUser.Text = user.MaNguoiDung.ToString();
                    txtHoTen.Text = user.Ho + " " + user.Ten;
                    txtEmail.Text = user.Email;
                    txtTenDangNhap.Text = user.TenDangNhap;
                    txtMatKhau.Text = user.MatKhauHash;
                    comboVaiTro.SelectedIndex = user.VaiTro;
                }
            }
        }

        // ====== NÚT THÊM ======
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text) || string.IsNullOrWhiteSpace(txtMatKhau.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ Tên đăng nhập và Mật khẩu!", "Cảnh báo");
                    return;
                }

                var parts = txtHoTen.Text.Trim().Split(' ');
                var ho = parts.Length > 1 ? string.Join(" ", parts.Take(parts.Length - 1)) : txtHoTen.Text;
                var ten = parts.Length > 1 ? parts.Last() : "";

                var user = new NguoiDung
                {
                    MaNguoiDung = Guid.NewGuid(),
                    Ho = ho,
                    Ten = ten,
                    Email = txtEmail.Text.Trim(),
                    TenDangNhap = txtTenDangNhap.Text.Trim(),
                    MatKhauHash = txtMatKhau.Text,
                    VaiTro = comboVaiTro.SelectedIndex,
                    NgayTao = DateTime.Now,
                    DaKhoa = false
                };

                _context.NguoiDungs.Add(user);
                _context.SaveChanges();

                MessageBox.Show("Thêm người dùng thành công!", "Thông báo");
                LoadData();
                ClearInput();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message);
            }
        }

        // ====== NÚT SỬA ======
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                var user = _context.NguoiDungs.FirstOrDefault(u => u.MaNguoiDung == selectedUserId);
                if (user != null)
                {
                    var parts = txtHoTen.Text.Trim().Split(' ');
                    var ho = parts.Length > 1 ? string.Join(" ", parts.Take(parts.Length - 1)) : txtHoTen.Text;
                    var ten = parts.Length > 1 ? parts.Last() : "";

                    user.Ho = ho;
                    user.Ten = ten;
                    user.Email = txtEmail.Text.Trim();
                    user.TenDangNhap = txtTenDangNhap.Text.Trim();
                    user.MatKhauHash = txtMatKhau.Text;
                    user.VaiTro = comboVaiTro.SelectedIndex;

                    _context.SaveChanges();
                    MessageBox.Show("Cập nhật thành công!", "Thông báo");
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật: " + ex.Message);
            }
        }

        // ====== NÚT XÓA ======
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                var user = _context.NguoiDungs.FirstOrDefault(u => u.MaNguoiDung == selectedUserId);
                if (user != null)
                {
                    if (MessageBox.Show("Ngài có chắc chắn muốn xóa người dùng này không?",
                        "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _context.NguoiDungs.Remove(user);
                        _context.SaveChanges();
                        MessageBox.Show("Đã xóa!", "Thông báo");
                        LoadData();
                        ClearInput();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message);
            }
        }

        // ====== NÚT TÌM KIẾM ======
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var keyword = txtTimKiem.Text.Trim().ToLower();
            var data = _context.NguoiDungs
                .Where(u => u.TenDangNhap.ToLower().Contains(keyword)
                         || u.Email.ToLower().Contains(keyword)
                         || (u.Ho + " " + u.Ten).ToLower().Contains(keyword))
                .Select(u => new
                {
                    u.MaNguoiDung,
                    HoTen = u.Ho + " " + u.Ten,
                    u.Email,
                    u.TenDangNhap,
                    VaiTro = u.VaiTro == 0 ? "Học viên"
                           : u.VaiTro == 1 ? "Giảng viên" : "Admin",
                    u.NgayTao,
                    u.DaKhoa
                })
                .ToList();

            dataGridViewUsers.DataSource = data;
        }

        // ====== NÚT LƯU / HỦY / THOÁT ======
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                _context.SaveChanges();
                MessageBox.Show("Dữ liệu đã được lưu!", "Thông báo");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearInput();
            MessageBox.Show("Đã hủy thao tác!", "Thông báo");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // ====== HÀM TIỆN ÍCH ======
        private void ClearInput()
        {
            txtMaUser.Clear();
            txtHoTen.Clear();
            txtEmail.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            comboVaiTro.SelectedIndex = -1;
        }

        // ====== Chuyển Form ======
        private void quảnLýKhóaHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  frmCapNhatKhoaHoc f = new frmCapNhatKhoaHoc(); // Qua Form Cập Nhật Khóa Học
         //   f.Show();       // mở form mới
         //   this.Close();   // đóng form hiện tại
        }

    }
}
