using DoAnCuoiKy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace DoAnCuoiKy
{
    public partial class frmQLBT : Form
    {
        private Model1 _context = new Model1();
        private string _selectedFilePath = "";
        private bool _isLoading = true;

        public frmQLBT()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn file đề bài tập";
                ofd.Filter = "Tất cả file (*.*)|*.*|PDF (*.pdf)|*.pdf|Word (*.docx)|*.docx|Zip (*.zip)|*.zip";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _selectedFilePath = ofd.FileName;
                    cmbTaiLen.Text = Path.GetFileName(_selectedFilePath);
                }
            }
        }

        private void frmQLBT_Load(object sender, EventArgs e)
        {
            _isLoading = true;
            var listLop = _context.Lops.Select(l => l.MaLop).ToList();
            cmbMaLop.DataSource = listLop;

            cmbTrangThai.Items.AddRange(new string[] { "Đang mở", "Đã đóng" });
            cmbTrangThai.SelectedIndex = 0;

            cmbTaiLen.Text = "(chưa chọn file)";

            LoadAllData();

            _isLoading = false;
        }
        private void LoadAllData()
        {
            try
            {
                // Bước 1: Lấy dữ liệu trực tiếp bằng Entity Framework
                var list = _context.GiaoBaiTaps.ToList(); // EF sẽ dịch SQL và load về

                // Bước 2: Xử lý phần tên file sau khi EF đã lấy dữ liệu (trong bộ nhớ)
                var data = list.Select(x => new
                {
                    x.MaLop,
                    x.TenBaiTap,
                    x.HanNop,
                    x.TrangThai,
                    x.DaNop,
                    ChiTiet = string.IsNullOrEmpty(x.ChiTiet) ? "(chưa có file)" : Path.GetFileName(x.ChiTiet)
                }).ToList();

                dgvBaiTap.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message,
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnTim_Click(object sender, EventArgs e)
        {
            string maLop = txtMaLop.Text.Trim();

            if (string.IsNullOrEmpty(maLop))
            {
                MessageBox.Show("Vui lòng nhập mã lớp để tìm!", "Thông báo");
                return;
            }

            try
            {
                // ✅ Bước 1: Lấy dữ liệu từ DB về bộ nhớ (ToList)
                var list = _context.GiaoBaiTaps
                    .Where(x => x.MaLop.Contains(maLop))
                    .ToList(); // lấy toàn bộ dữ liệu về RAM

                // ✅ Bước 2: Xử lý dữ liệu trong bộ nhớ (LINQ thuần C#)
                var data = list.Select(x => new
                {
                    x.MaLop,
                    x.TenBaiTap,
                    x.HanNop,
                    x.TrangThai,
                    x.DaNop,
                    ChiTiet = string.IsNullOrEmpty(x.ChiTiet)
                        ? "(chưa có file)"
                        : Path.GetFileName(x.ChiTiet)
                }).ToList();

                dgvBaiTap.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm bài tập: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbTaiLen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoading) return; // 🔹 tránh chạy khi form mới load

            if (cmbTaiLen.SelectedIndex == 0)
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Title = "Chọn file đề bài tập";
                    ofd.Filter = "Tất cả file (*.*)|*.*|PDF (*.pdf)|*.pdf|Word (*.docx)|*.docx|Zip (*.zip)|*.zip";

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        _selectedFilePath = ofd.FileName;
                        cmbTaiLen.Text = Path.GetFileName(_selectedFilePath);
                    }
                }
            }
        }

        private void btnThemSua_Click(object sender, EventArgs e)
        {
            string maLop = cmbMaLop.SelectedItem?.ToString();
            string tenBai = txtTenBaiTap.Text.Trim();
            DateTime hanNop = dtpHanNop.Value;
            string trangThai = cmbTrangThai.SelectedItem.ToString();

            if (string.IsNullOrEmpty(maLop) || string.IsNullOrEmpty(tenBai))
            {
                MessageBox.Show("Vui lòng nhập mã lớp và tên bài tập!", "Thông báo");
                return;
            }

            // Thư mục lưu file
            string destFolder = Path.Combine(Application.StartupPath, "Files", "BaiTap");
            if (!Directory.Exists(destFolder))
                Directory.CreateDirectory(destFolder);

            string fileName = Path.GetFileName(_selectedFilePath);
            string destPath = string.IsNullOrEmpty(fileName) ? "" : Path.Combine(destFolder, fileName);

            if (!string.IsNullOrEmpty(_selectedFilePath) && !_selectedFilePath.Equals(destPath))
                File.Copy(_selectedFilePath, destPath, true);

            var bt = _context.GiaoBaiTaps.FirstOrDefault(x => x.MaLop == maLop && x.TenBaiTap == tenBai);

            if (bt != null)
            {
                bt.HanNop = hanNop;
                bt.TrangThai = trangThai;
                bt.ChiTiet = destPath;
                _context.SaveChanges();
                MessageBox.Show("Cập nhật bài tập thành công!", "Thông báo");
            }
            else
            {
                GiaoBaiTap newBT = new GiaoBaiTap
                {
                    MaLop = maLop,
                    TenBaiTap = tenBai,
                    HanNop = hanNop,
                    TrangThai = trangThai,
                    DaNop = "0/0",
                    ChiTiet = destPath
                };
                _context.GiaoBaiTaps.Add(newBT);
                _context.SaveChanges();
                MessageBox.Show("Thêm bài tập mới thành công!", "Thông báo");
            }

            LoadAllData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvBaiTap.CurrentRow == null) return;

            string tenBaiTap = dgvBaiTap.CurrentRow.Cells["TenBaiTap"].Value?.ToString();
            string maLop = dgvBaiTap.CurrentRow.Cells["MaLop"].Value?.ToString();

            if (string.IsNullOrEmpty(maLop) || string.IsNullOrEmpty(tenBaiTap))
                return;

            var bt = _context.GiaoBaiTaps.FirstOrDefault(x => x.MaLop == maLop && x.TenBaiTap == tenBaiTap);
            if (bt != null)
            {
                _context.GiaoBaiTaps.Remove(bt);
                _context.SaveChanges();
                MessageBox.Show("Đã xóa bài tập.", "Thông báo");
                LoadAllData();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvBaiTap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy tên cột
                string columnName = dgvBaiTap.Columns[e.ColumnIndex].Name;

                // Nếu cột được bấm là "DaNop" thì mở form chấm bài
                if (columnName == "DaNop")
                {
                    string maLop = dgvBaiTap.Rows[e.RowIndex].Cells["MaLop"].Value?.ToString();
                    string tenBaiTap = dgvBaiTap.Rows[e.RowIndex].Cells["TenBaiTap"].Value?.ToString();

                    if (!string.IsNullOrEmpty(maLop) && !string.IsNullOrEmpty(tenBaiTap))
                    {
                        // Mở form chấm bài
                        frmChamBai frm = new frmChamBai(maLop, tenBaiTap);
                        frm.StartPosition = FormStartPosition.CenterScreen;
                        frm.ShowDialog();
                    }
                }
            }
        }
    }
}
