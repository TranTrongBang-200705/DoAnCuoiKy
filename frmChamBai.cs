using DoAnCuoiKy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace DoAnCuoiKy
{
    public partial class frmChamBai : Form
    {
        private Model1 db = new Model1();


        public frmChamBai(string maLop, string tenBaiTap)
        {
            InitializeComponent();
          
        }

        private void frmChamBai_Load(object sender, EventArgs e)
        {

            LoadChamBai();

        }

        private void LoadChamBai(string keyword = "")
        {
            var data = from c in db.ChamBais
                       join nd in db.NguoiDungs on c.MaHocVien equals nd.MaNguoiDung
                       where nd.VaiTro == 0
                       && (keyword == "" || nd.TenDangNhap.Contains(keyword))
                       select new
                       {
                           MSSV = nd.TenDangNhap,
                           HoTen = nd.Ho + " " + nd.Ten,
                           NoiDungNop = c.NoiDungNop,
                           Diem = c.Diem
                       };

            dgvChamBai.DataSource = data.ToList();

            dgvChamBai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChamBai.RowHeadersVisible = false;
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvChamBai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var id = (Guid)dgvChamBai.Rows[e.RowIndex].Cells["MaChamBai"].Value;
                var chamBai = db.ChamBais.Find(id);

                if (chamBai != null)
                {
                    if (dgvChamBai.Columns[e.ColumnIndex].Name == "Diem")
                    {
                        var val = dgvChamBai.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                        if (decimal.TryParse(val?.ToString(), out decimal diem))
                        {
                            chamBai.Diem = diem;
                            chamBai.TrangThai = 1; // đã chấm
                        }
                    }
                    else if (dgvChamBai.Columns[e.ColumnIndex].Name == "NhanXet")
                    {
                        chamBai.NhanXet = dgvChamBai.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();
                    }

                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu điểm: " + ex.Message);
            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mssv = txtMSSV.Text.Trim();
            LoadChamBai(mssv);
        }

        private void btnLuuDiem_Click(object sender, EventArgs e)
        {
            try
    {
        foreach (DataGridViewRow row in dgvChamBai.Rows)
        {
            if (row.IsNewRow) continue;

            // Lấy MSSV và điểm từ DataGridView
            string mssv = row.Cells["MSSV"].Value?.ToString();
            string diemText = row.Cells["Diem"].Value?.ToString();

            if (string.IsNullOrEmpty(mssv) || string.IsNullOrEmpty(diemText))
                continue;

            if (decimal.TryParse(diemText, out decimal diem))
            {
                // Tìm sinh viên tương ứng trong DB
                var cham = (from c in db.ChamBais
                            join nd in db.NguoiDungs on c.MaHocVien equals nd.MaNguoiDung
                            where nd.TenDangNhap == mssv
                            select c).FirstOrDefault();

                if (cham != null)
                {
                    cham.Diem = diem; // Gán điểm mới
                }
            }
        }

        db.SaveChanges(); // Lưu toàn bộ thay đổi
        MessageBox.Show("✅ Lưu điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        LoadChamBai(); // Refresh lại dữ liệu
    }
    catch (Exception ex)
    {
        MessageBox.Show("❌ Lỗi khi lưu điểm: " + ex.Message);
    }
        }
    }
}
