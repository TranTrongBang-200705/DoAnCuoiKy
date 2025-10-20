namespace DoAnCuoiKy
{
    partial class frmCapNhatKhoaHoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.GridViewKhoaHoc = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.groupBoxQuanLy = new System.Windows.Forms.GroupBox();
            this.btnQLNguoiDung = new System.Windows.Forms.Button();
            this.groupBoxThongTin = new System.Windows.Forms.GroupBox();
            this.comboGiangVien = new System.Windows.Forms.ComboBox();
            this.comboTrinhDo = new System.Windows.Forms.ComboBox();
            this.comboDanhMuc = new System.Windows.Forms.ComboBox();
            this.lblDanhMuc = new System.Windows.Forms.Label();
            this.lblTrinhDo = new System.Windows.Forms.Label();
            this.lblGiangVien = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.lblTenKhoa = new System.Windows.Forms.Label();
            this.lblMaKhoa = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtTenKhoa = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewKhoaHoc)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBoxQuanLy.SuspendLayout();
            this.groupBoxThongTin.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ KHÓA HỌC";
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // GridViewKhoaHoc
            // 
            this.GridViewKhoaHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewKhoaHoc.Location = new System.Drawing.Point(306, 108);
            this.GridViewKhoaHoc.Name = "GridViewKhoaHoc";
            this.GridViewKhoaHoc.RowHeadersWidth = 51;
            this.GridViewKhoaHoc.RowTemplate.Height = 24;
            this.GridViewKhoaHoc.Size = new System.Drawing.Size(447, 252);
            this.GridViewKhoaHoc.TabIndex = 2;
            this.GridViewKhoaHoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewKhoaHoc_CellContentClick_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.lblTimKiem);
            this.panel1.Location = new System.Drawing.Point(306, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 79);
            this.panel1.TabIndex = 3;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(92, 44);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(99, 27);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click_1);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(114, 13);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(158, 22);
            this.txtTimKiem.TabIndex = 1;
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(16, 16);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(63, 16);
            this.lblTimKiem.TabIndex = 0;
            this.lblTimKiem.Text = "Tìm Kiếm";
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Location = new System.Drawing.Point(142, 21);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(124, 22);
            this.txtMaKhoa.TabIndex = 3;
            // 
            // groupBoxQuanLy
            // 
            this.groupBoxQuanLy.Controls.Add(this.btnQLNguoiDung);
            this.groupBoxQuanLy.Location = new System.Drawing.Point(3, 31);
            this.groupBoxQuanLy.Name = "groupBoxQuanLy";
            this.groupBoxQuanLy.Size = new System.Drawing.Size(297, 71);
            this.groupBoxQuanLy.TabIndex = 4;
            this.groupBoxQuanLy.TabStop = false;
            this.groupBoxQuanLy.Text = "Quản Lý";
            // 
            // btnQLNguoiDung
            // 
            this.btnQLNguoiDung.Location = new System.Drawing.Point(66, 21);
            this.btnQLNguoiDung.Name = "btnQLNguoiDung";
            this.btnQLNguoiDung.Size = new System.Drawing.Size(123, 31);
            this.btnQLNguoiDung.TabIndex = 0;
            this.btnQLNguoiDung.Text = "DùngQL Người ";
            this.btnQLNguoiDung.UseVisualStyleBackColor = true;
            this.btnQLNguoiDung.Click += new System.EventHandler(this.btnQLNguoiDung_Click);
            // 
            // groupBoxThongTin
            // 
            this.groupBoxThongTin.Controls.Add(this.comboGiangVien);
            this.groupBoxThongTin.Controls.Add(this.comboTrinhDo);
            this.groupBoxThongTin.Controls.Add(this.comboDanhMuc);
            this.groupBoxThongTin.Controls.Add(this.lblDanhMuc);
            this.groupBoxThongTin.Controls.Add(this.lblTrinhDo);
            this.groupBoxThongTin.Controls.Add(this.lblGiangVien);
            this.groupBoxThongTin.Controls.Add(this.lblMoTa);
            this.groupBoxThongTin.Controls.Add(this.lblTenKhoa);
            this.groupBoxThongTin.Controls.Add(this.lblMaKhoa);
            this.groupBoxThongTin.Controls.Add(this.txtMoTa);
            this.groupBoxThongTin.Controls.Add(this.txtTenKhoa);
            this.groupBoxThongTin.Controls.Add(this.txtMaKhoa);
            this.groupBoxThongTin.Location = new System.Drawing.Point(0, 101);
            this.groupBoxThongTin.Name = "groupBoxThongTin";
            this.groupBoxThongTin.Size = new System.Drawing.Size(301, 247);
            this.groupBoxThongTin.TabIndex = 5;
            this.groupBoxThongTin.TabStop = false;
            this.groupBoxThongTin.Text = "Thông Tin";
            // 
            // comboGiangVien
            // 
            this.comboGiangVien.FormattingEnabled = true;
            this.comboGiangVien.Location = new System.Drawing.Point(135, 169);
            this.comboGiangVien.Name = "comboGiangVien";
            this.comboGiangVien.Size = new System.Drawing.Size(146, 24);
            this.comboGiangVien.TabIndex = 5;
            // 
            // comboTrinhDo
            // 
            this.comboTrinhDo.FormattingEnabled = true;
            this.comboTrinhDo.Location = new System.Drawing.Point(135, 208);
            this.comboTrinhDo.Name = "comboTrinhDo";
            this.comboTrinhDo.Size = new System.Drawing.Size(146, 24);
            this.comboTrinhDo.TabIndex = 5;
            // 
            // comboDanhMuc
            // 
            this.comboDanhMuc.FormattingEnabled = true;
            this.comboDanhMuc.Location = new System.Drawing.Point(135, 135);
            this.comboDanhMuc.Name = "comboDanhMuc";
            this.comboDanhMuc.Size = new System.Drawing.Size(146, 24);
            this.comboDanhMuc.TabIndex = 5;
            // 
            // lblDanhMuc
            // 
            this.lblDanhMuc.AutoSize = true;
            this.lblDanhMuc.Location = new System.Drawing.Point(32, 138);
            this.lblDanhMuc.Name = "lblDanhMuc";
            this.lblDanhMuc.Size = new System.Drawing.Size(67, 16);
            this.lblDanhMuc.TabIndex = 4;
            this.lblDanhMuc.Text = "Danh Mục";
            // 
            // lblTrinhDo
            // 
            this.lblTrinhDo.AutoSize = true;
            this.lblTrinhDo.Location = new System.Drawing.Point(32, 216);
            this.lblTrinhDo.Name = "lblTrinhDo";
            this.lblTrinhDo.Size = new System.Drawing.Size(57, 16);
            this.lblTrinhDo.TabIndex = 4;
            this.lblTrinhDo.Text = "Trình Độ";
            // 
            // lblGiangVien
            // 
            this.lblGiangVien.Location = new System.Drawing.Point(32, 172);
            this.lblGiangVien.Name = "lblGiangVien";
            this.lblGiangVien.Size = new System.Drawing.Size(73, 16);
            this.lblGiangVien.TabIndex = 4;
            this.lblGiangVien.Text = "Giảng Viên";
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Location = new System.Drawing.Point(32, 101);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(46, 16);
            this.lblMoTa.TabIndex = 4;
            this.lblMoTa.Text = "Mô Tả";
            // 
            // lblTenKhoa
            // 
            this.lblTenKhoa.AutoSize = true;
            this.lblTenKhoa.Location = new System.Drawing.Point(32, 63);
            this.lblTenKhoa.Name = "lblTenKhoa";
            this.lblTenKhoa.Size = new System.Drawing.Size(93, 16);
            this.lblTenKhoa.TabIndex = 4;
            this.lblTenKhoa.Text = "Tên Khóa Học";
            // 
            // lblMaKhoa
            // 
            this.lblMaKhoa.AutoSize = true;
            this.lblMaKhoa.Location = new System.Drawing.Point(32, 24);
            this.lblMaKhoa.Name = "lblMaKhoa";
            this.lblMaKhoa.Size = new System.Drawing.Size(60, 16);
            this.lblMaKhoa.TabIndex = 4;
            this.lblMaKhoa.Text = "Mã Khoa";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(142, 98);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(124, 22);
            this.txtMoTa.TabIndex = 3;
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Location = new System.Drawing.Point(142, 60);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new System.Drawing.Size(124, 22);
            this.txtTenKhoa.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThoat);
            this.panel2.Controls.Add(this.btnHuy);
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Location = new System.Drawing.Point(99, 366);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 83);
            this.panel2.TabIndex = 6;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(272, 42);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(74, 29);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(163, 42);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(74, 29);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(58, 42);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(74, 29);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(274, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(72, 29);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(165, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(72, 29);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(60, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(72, 29);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // frmCapNhatKhoaHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBoxThongTin);
            this.Controls.Add(this.groupBoxQuanLy);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GridViewKhoaHoc);
            this.Controls.Add(this.label1);
            this.Name = "frmCapNhatKhoaHoc";
            this.Text = "frmCapNhatKhoaHoc";
            this.Load += new System.EventHandler(this.frmCapNhatKhoaHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewKhoaHoc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxQuanLy.ResumeLayout(false);
            this.groupBoxThongTin.ResumeLayout(false);
            this.groupBoxThongTin.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.DataGridView GridViewKhoaHoc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox groupBoxQuanLy;
        private System.Windows.Forms.GroupBox groupBoxThongTin;
        private System.Windows.Forms.Label lblMaKhoa;
        private System.Windows.Forms.Label lblDanhMuc;
        private System.Windows.Forms.Label lblTrinhDo;
        private System.Windows.Forms.Label lblGiangVien;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblTenKhoa;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtTenKhoa;
        private System.Windows.Forms.ComboBox comboGiangVien;
        private System.Windows.Forms.ComboBox comboTrinhDo;
        private System.Windows.Forms.ComboBox comboDanhMuc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnQLNguoiDung;
    }
}