using DoAnCuoiKy.Models;
using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy
{
    public partial class frmCapNhatKhoaHoc : Form
    {
        private readonly Model1 _context;
        private readonly NguoiDung _currentUser;
        private BindingList<KhoaHocView> _bindingList;
        private KhoaHoc _currentKhoaHoc;
        private string _mode = "";
        public frmCapNhatKhoaHoc()
        {
            InitializeComponent();
        }

        // Constructor bổ sung để gọi từ frmMainQuanTri
        public frmCapNhatKhoaHoc(NguoiDung currentUser, Model1 context)
        {
            InitializeComponent();
            _context = context;
            _currentUser = currentUser;
        }
        private void SetEditing(bool editing)
        {
            txtTenKhoa.ReadOnly = !editing;
            txtMoTa.ReadOnly = !editing;
            //txtLink.ReadOnly = !editing;
            comboGiangVien.Enabled = editing;
            comboDanhMuc.Enabled = editing;
            comboTrinhDo.Enabled = editing;

            btnLuu.Enabled = editing;
            btnHuy.Enabled = editing;

            btnThem.Enabled = !editing;
            btnSua.Enabled = !editing;
            btnXoa.Enabled = !editing;
        }
        private async void frmCapNhatKhoaHoc_Load(object sender, EventArgs e)
        {
            if (_context == null) return;

            GridViewKhoaHoc.AutoGenerateColumns = false;
            if (GridViewKhoaHoc.Columns.Count >= 5)
            {
                GridViewKhoaHoc.Columns[0].DataPropertyName = "MaKhoaHoc";
                GridViewKhoaHoc.Columns[1].DataPropertyName = "TieuDe";
                GridViewKhoaHoc.Columns[2].DataPropertyName = "TenGiangVien";
                GridViewKhoaHoc.Columns[3].DataPropertyName = "TrinhDoText";
               // GridViewKhoaHoc.Columns[4].DataPropertyName = "Link";
            }

            await LoadComboBoxAsync();
            await LoadDataAsync();
            SetEditing(false);
        }

        private async Task LoadComboBoxAsync()
        {
            var giangVien = await _context.NguoiDungs
                .Where(x => x.VaiTro == 1)
                .OrderBy(x => x.TenDangNhap)
                .ToListAsync();

            comboGiangVien.DataSource = giangVien;
            comboGiangVien.DisplayMember = "TenDangNhap";
            comboGiangVien.ValueMember = "MaNguoiDung";

            var danhMuc = await _context.DanhMucs
                .OrderBy(x => x.TenDanhMuc)
                .ToListAsync();

            comboDanhMuc.DataSource = danhMuc;
            comboDanhMuc.DisplayMember = "TenDanhMuc";
            comboDanhMuc.ValueMember = "MaDanhMuc";

            comboTrinhDo.Items.Clear();
            comboTrinhDo.Items.Add("Cơ bản");
            comboTrinhDo.Items.Add("Trung cấp");
            comboTrinhDo.Items.Add("Nâng cao");
        }

        // Load data from EF with optional filter
        private async Task LoadDataAsync(string filter)
        {
            var query = _context.KhoaHocs
                .Include(k => k.NguoiDung)
                .Include(k => k.DanhMuc)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(filter))
            {
                string f = filter.ToLower();
                query = query.Where(k =>
                    (k.TieuDe ?? "").ToLower().Contains(f) ||
                    (k.MoTa ?? "").ToLower().Contains(f) ||
                    (k.NguoiDung.TenDangNhap ?? "").ToLower().Contains(f) ||
                    (k.DanhMuc.TenDanhMuc ?? "").ToLower().Contains(f)
                );
            }

            var list = await query
                .OrderBy(k => k.TieuDe)
                .Select(k => new KhoaHocView
                {
                    MaKhoaHoc = k.MaKhoaHoc,
                    TieuDe = k.TieuDe,
                    MoTa = k.MoTa,
                    //Link = k.Link,
                    MaGiangVien = k.MaGiangVien,
                    TenGiangVien = k.NguoiDung.TenDangNhap,
                    MaDanhMuc = k.MaDanhMuc,
                    TenDanhMuc = k.DanhMuc.TenDanhMuc,
                    TrinhDo = k.TrinhDo,
                    TrinhDoText = k.TrinhDo == 0 ? "Cơ bản" : (k.TrinhDo == 1 ? "Trung cấp" : "Nâng cao")
                })
                .ToListAsync();

            _bindingList = new BindingList<KhoaHocView>(list);
            GridViewKhoaHoc.DataSource = _bindingList;
        }
        private async Task LoadDataAsync()
        {
            await LoadDataAsync(null);
        }
        private void ClearInput()
        {
            txtMaKhoa.Text = "";
            txtTenKhoa.Text = "";
            txtMoTa.Text = "";
           // txtLink.Text = "";
            comboGiangVien.SelectedIndex = -1;
            comboDanhMuc.SelectedIndex = -1;
            comboTrinhDo.SelectedIndex = -1;
        }
        private async void FillForm(KhoaHocView k)
        {
            if (k == null) return;
            txtMaKhoa.Text = k.MaKhoaHoc.ToString();
            txtTenKhoa.Text = k.TieuDe;
            txtMoTa.Text = k.MoTa;
           // txtLink.Text = k.Link;
            comboGiangVien.SelectedValue = k.MaGiangVien;
            comboDanhMuc.SelectedValue = k.MaDanhMuc;
            comboTrinhDo.SelectedIndex = k.TrinhDo;
        }
        // event: live search when text changes
        

        // event: search when button clicked
       

        // Keep other existing handlers (no-op) so Designer remains consistent

       

        // lightweight DTO used for binding the grid
        private class KhoaHocView
        {
            public Guid MaKhoaHoc { get; set; }
            public string TieuDe { get; set; }
            public string MoTa { get; set; }
            public string Link { get; set; }
            public Guid MaGiangVien { get; set; }
            public string TenGiangVien { get; set; }
            public Guid MaDanhMuc { get; set; }
            public string TenDanhMuc { get; set; }
            public int TrinhDo { get; set; }
            public string TrinhDoText { get; set; }
        }

      


        private void btnQLNguoiDung_Click(object sender, EventArgs e)
        {
            groupBoxQuanLy.Visible = false;
            groupBoxThongTin.Visible = true;

            // Xóa dữ liệu cũ để chuẩn bị nhập mới
            ClearInput();
            

            // Đưa con trỏ vào textbox đầu tiên
            txtTenKhoa.Focus();
        }

        private async void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            await LoadDataAsync(txtTimKiem.Text);
        }

        private async void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKhoa.Text))
            {
                MessageBox.Show("Vui lòng chọn khóa học để sửa.");
                return;
            }

            _mode = "EDIT";
            SetEditing(true);
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            ClearInput();
            _mode = "ADD";
            SetEditing(true);
        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKhoa.Text))
            {
                MessageBox.Show("Vui lòng chọn khóa học để xóa.");
                return;
            }

            Guid id = Guid.Parse(txtMaKhoa.Text);
            var kh = await _context.KhoaHocs.FindAsync(id);
            if (kh == null)
            {
                MessageBox.Show("Không tìm thấy khóa học.");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa khóa học này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _context.KhoaHocs.Remove(kh);
                await _context.SaveChangesAsync();
                MessageBox.Show("Đã xóa khóa học!");
                await LoadDataAsync();
                ClearInput();
            }
        }

        private async void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (_mode == "ADD")
                {
                    var newKH = new KhoaHoc
                    {
                        MaKhoaHoc = Guid.NewGuid(),
                        TieuDe = txtTenKhoa.Text.Trim(),
                        MoTa = txtMoTa.Text.Trim(),
                        // Link = txtLink.Text.Trim(),
                        MaGiangVien = (Guid)comboGiangVien.SelectedValue,
                        MaDanhMuc = (Guid)comboDanhMuc.SelectedValue,
                        TrinhDo = comboTrinhDo.SelectedIndex
                    };

                    _context.KhoaHocs.Add(newKH);
                    await _context.SaveChangesAsync();
                    MessageBox.Show("Thêm khóa học thành công!");
                }
                else if (_mode == "EDIT")
                {
                    Guid id = Guid.Parse(txtMaKhoa.Text);
                    var kh = await _context.KhoaHocs.FindAsync(id);
                    if (kh == null) return;

                    kh.TieuDe = txtTenKhoa.Text.Trim();
                    kh.MoTa = txtMoTa.Text.Trim();
                    //kh.Link = txtLink.Text.Trim();
                    kh.MaGiangVien = (Guid)comboGiangVien.SelectedValue;
                    kh.MaDanhMuc = (Guid)comboDanhMuc.SelectedValue;
                    kh.TrinhDo = comboTrinhDo.SelectedIndex;

                    await _context.SaveChangesAsync();
                    MessageBox.Show("Cập nhật khóa học thành công!");
                }

                await LoadDataAsync();
                ClearInput();
                SetEditing(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearInput();
            SetEditing(false);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GridViewKhoaHoc_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (GridViewKhoaHoc.CurrentRow == null) return;
            var item = GridViewKhoaHoc.CurrentRow.DataBoundItem as KhoaHocView;
            if (item == null) return;
            FillForm(item);
            SetEditing(false);
        }
    }
}