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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.GridViewKhoaHoc = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnSuu = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboGiangVien = new System.Windows.Forms.ComboBox();
            this.comboTrinhDo = new System.Windows.Forms.ComboBox();
            this.comboDanhMuc = new System.Windows.Forms.ComboBox();
            this.lblTrinhDo = new System.Windows.Forms.Label();
            this.lblGiangVien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtTenKhoa = new System.Windows.Forms.TextBox();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.lblTenKhoa = new System.Windows.Forms.Label();
            this.lblMaKhoa = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewKhoaHoc)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Khóa Học";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.lblTimKiem);
            this.panel1.Location = new System.Drawing.Point(324, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 79);
            this.panel1.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(103, 36);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(92, 40);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(124, 8);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(152, 22);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged_1);
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(35, 11);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(66, 16);
            this.lblTimKiem.TabIndex = 0;
            this.lblTimKiem.Text = "Tìm Kiếm ";
            // 
            // GridViewKhoaHoc
            // 
            this.GridViewKhoaHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewKhoaHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.GridViewKhoaHoc.Location = new System.Drawing.Point(326, 132);
            this.GridViewKhoaHoc.Name = "GridViewKhoaHoc";
            this.GridViewKhoaHoc.RowHeadersWidth = 51;
            this.GridViewKhoaHoc.RowTemplate.Height = 24;
            this.GridViewKhoaHoc.Size = new System.Drawing.Size(473, 218);
            this.GridViewKhoaHoc.TabIndex = 2;
            this.GridViewKhoaHoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewKhoaHoc_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Khóa Học";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Giảng Viên ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Trình Dộ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Link khóa học";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnThoat);
            this.panel3.Controls.Add(this.btnHuy);
            this.panel3.Controls.Add(this.btnLuu);
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.btnSuu);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Location = new System.Drawing.Point(197, 361);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(423, 88);
            this.panel3.TabIndex = 4;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(281, 44);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 44);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_1);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(173, 44);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 44);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click_1);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(66, 44);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 44);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "💾 Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(281, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 41);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(281, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 41);
            this.button6.TabIndex = 0;
            this.button6.Text = "➕ Thêm\r\n";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnSuu
            // 
            this.btnSuu.Location = new System.Drawing.Point(173, 3);
            this.btnSuu.Name = "btnSuu";
            this.btnSuu.Size = new System.Drawing.Size(75, 41);
            this.btnSuu.TabIndex = 0;
            this.btnSuu.Text = " Sửa";
            this.btnSuu.UseVisualStyleBackColor = true;
            this.btnSuu.Click += new System.EventHandler(this.btnSuu_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(173, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 41);
            this.button3.TabIndex = 0;
            this.button3.Text = "➕ Thêm\r\n";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(66, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 41);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "➕ Thêm\r\n";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(5, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 308);
            this.panel2.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtLink);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboGiangVien);
            this.groupBox2.Controls.Add(this.comboTrinhDo);
            this.groupBox2.Controls.Add(this.comboDanhMuc);
            this.groupBox2.Controls.Add(this.lblTrinhDo);
            this.groupBox2.Controls.Add(this.lblGiangVien);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtMoTa);
            this.groupBox2.Controls.Add(this.txtTenKhoa);
            this.groupBox2.Controls.Add(this.txtMaKhoa);
            this.groupBox2.Controls.Add(this.lblMoTa);
            this.groupBox2.Controls.Add(this.lblTenKhoa);
            this.groupBox2.Controls.Add(this.lblMaKhoa);
            this.groupBox2.Location = new System.Drawing.Point(3, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 254);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(110, 217);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(119, 22);
            this.txtLink.TabIndex = 13;
//            this.txtLink.TextChanged += new System.EventHandler(this.txtLink_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Link";
            // 
            // comboGiangVien
            // 
            this.comboGiangVien.FormattingEnabled = true;
            this.comboGiangVien.Location = new System.Drawing.Point(110, 157);
            this.comboGiangVien.Name = "comboGiangVien";
            this.comboGiangVien.Size = new System.Drawing.Size(121, 24);
            this.comboGiangVien.TabIndex = 11;
            // 
            // comboTrinhDo
            // 
            this.comboTrinhDo.FormattingEnabled = true;
            this.comboTrinhDo.Location = new System.Drawing.Point(110, 187);
            this.comboTrinhDo.Name = "comboTrinhDo";
            this.comboTrinhDo.Size = new System.Drawing.Size(121, 24);
            this.comboTrinhDo.TabIndex = 10;
            // 
            // comboDanhMuc
            // 
            this.comboDanhMuc.FormattingEnabled = true;
            this.comboDanhMuc.Location = new System.Drawing.Point(110, 121);
            this.comboDanhMuc.Name = "comboDanhMuc";
            this.comboDanhMuc.Size = new System.Drawing.Size(136, 24);
            this.comboDanhMuc.TabIndex = 9;
            // 
            // lblTrinhDo
            // 
            this.lblTrinhDo.AutoSize = true;
            this.lblTrinhDo.Location = new System.Drawing.Point(15, 191);
            this.lblTrinhDo.Name = "lblTrinhDo";
            this.lblTrinhDo.Size = new System.Drawing.Size(57, 16);
            this.lblTrinhDo.TabIndex = 8;
            this.lblTrinhDo.Text = "Trình Độ";
            // 
            // lblGiangVien
            // 
            this.lblGiangVien.AutoSize = true;
            this.lblGiangVien.Location = new System.Drawing.Point(15, 160);
            this.lblGiangVien.Name = "lblGiangVien";
            this.lblGiangVien.Size = new System.Drawing.Size(73, 16);
            this.lblGiangVien.TabIndex = 7;
            this.lblGiangVien.Text = "Giảng Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Danh mục";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(110, 94);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(142, 22);
            this.txtMoTa.TabIndex = 5;
//            this.txtMoTa.TextChanged += new System.EventHandler(this.txtMoTa_TextChanged);
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Location = new System.Drawing.Point(110, 61);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new System.Drawing.Size(142, 22);
            this.txtTenKhoa.TabIndex = 4;
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Location = new System.Drawing.Point(110, 21);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(142, 22);
            this.txtMaKhoa.TabIndex = 3;
//            this.txtMaKhoa.TextChanged += new System.EventHandler(this.txtMaKhoa_TextChanged);
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Location = new System.Drawing.Point(15, 94);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(40, 16);
            this.lblMoTa.TabIndex = 2;
            this.lblMoTa.Text = "Mô tả";
            // 
            // lblTenKhoa
            // 
            this.lblTenKhoa.AutoSize = true;
            this.lblTenKhoa.Location = new System.Drawing.Point(6, 61);
            this.lblTenKhoa.Name = "lblTenKhoa";
            this.lblTenKhoa.Size = new System.Drawing.Size(89, 16);
            this.lblTenKhoa.TabIndex = 1;
            this.lblTenKhoa.Text = "Tên khóa học";
            // 
            // lblMaKhoa
            // 
            this.lblMaKhoa.AutoSize = true;
            this.lblMaKhoa.Location = new System.Drawing.Point(6, 24);
            this.lblMaKhoa.Name = "lblMaKhoa";
            this.lblMaKhoa.Size = new System.Drawing.Size(60, 16);
            this.lblMaKhoa.TabIndex = 0;
            this.lblMaKhoa.Text = "Mã Khoa";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(2, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // frmCapNhatKhoaHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.GridViewKhoaHoc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "frmCapNhatKhoaHoc";
            this.Text = "frmCapNhatKhoaHoc";
            this.Load += new System.EventHandler(this.frmCapNhatKhoaHoc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewKhoaHoc)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.DataGridView GridViewKhoaHoc;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTenKhoa;
        private System.Windows.Forms.Label lblMaKhoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtTenKhoa;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblTrinhDo;
        private System.Windows.Forms.Label lblGiangVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboGiangVien;
        private System.Windows.Forms.ComboBox comboTrinhDo;
        private System.Windows.Forms.ComboBox comboDanhMuc;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnSuu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}