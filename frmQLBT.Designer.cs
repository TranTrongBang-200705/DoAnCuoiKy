namespace DoAnCuoiKy
{
    partial class frmQLBT
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
            this.dgvBaiTap = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThemSua = new System.Windows.Forms.Button();
            this.btnChonFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenBaiTap = new System.Windows.Forms.TextBox();
            this.cmbTrangThai = new System.Windows.Forms.ComboBox();
            this.dtpHanNop = new System.Windows.Forms.DateTimePicker();
            this.cmbTaiLen = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbMaLop = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaiTap)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBaiTap
            // 
            this.dgvBaiTap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaiTap.Location = new System.Drawing.Point(379, 98);
            this.dgvBaiTap.Name = "dgvBaiTap";
            this.dgvBaiTap.RowHeadersWidth = 51;
            this.dgvBaiTap.RowTemplate.Height = 24;
            this.dgvBaiTap.Size = new System.Drawing.Size(454, 294);
            this.dgvBaiTap.TabIndex = 0;
            this.dgvBaiTap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBaiTap_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(475, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Lớp";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbMaLop);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbTaiLen);
            this.groupBox1.Controls.Add(this.dtpHanNop);
            this.groupBox1.Controls.Add(this.cmbTrangThai);
            this.groupBox1.Controls.Add(this.txtTenBaiTap);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThemSua);
            this.groupBox1.Controls.Add(this.btnChonFile);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 294);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bài Tập ";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(163, 237);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(66, 41);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThemSua
            // 
            this.btnThemSua.Location = new System.Drawing.Point(65, 237);
            this.btnThemSua.Name = "btnThemSua";
            this.btnThemSua.Size = new System.Drawing.Size(92, 41);
            this.btnThemSua.TabIndex = 9;
            this.btnThemSua.Text = "Thêm/Sửa";
            this.btnThemSua.UseVisualStyleBackColor = true;
            this.btnThemSua.Click += new System.EventHandler(this.btnThemSua_Click);
            // 
            // btnChonFile
            // 
            this.btnChonFile.Location = new System.Drawing.Point(252, 190);
            this.btnChonFile.Name = "btnChonFile";
            this.btnChonFile.Size = new System.Drawing.Size(45, 23);
            this.btnChonFile.TabIndex = 8;
            this.btnChonFile.Text = "...";
            this.btnChonFile.UseVisualStyleBackColor = true;
            this.btnChonFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tải lên";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(533, 70);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(129, 22);
            this.txtMaLop.TabIndex = 6;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(668, 69);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(71, 25);
            this.btnTim.TabIndex = 9;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(696, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 25);
            this.button1.TabIndex = 10;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tên bài tập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Hạn nộp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Trạng thái";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 14;
            // 
            // txtTenBaiTap
            // 
            this.txtTenBaiTap.Location = new System.Drawing.Point(108, 60);
            this.txtTenBaiTap.Name = "txtTenBaiTap";
            this.txtTenBaiTap.Size = new System.Drawing.Size(138, 22);
            this.txtTenBaiTap.TabIndex = 15;
            // 
            // cmbTrangThai
            // 
            this.cmbTrangThai.FormattingEnabled = true;
            this.cmbTrangThai.Location = new System.Drawing.Point(108, 141);
            this.cmbTrangThai.Name = "cmbTrangThai";
            this.cmbTrangThai.Size = new System.Drawing.Size(121, 24);
            this.cmbTrangThai.TabIndex = 16;
            // 
            // dtpHanNop
            // 
            this.dtpHanNop.Location = new System.Drawing.Point(108, 98);
            this.dtpHanNop.Name = "dtpHanNop";
            this.dtpHanNop.Size = new System.Drawing.Size(200, 22);
            this.dtpHanNop.TabIndex = 11;
            // 
            // cmbTaiLen
            // 
            this.cmbTaiLen.FormattingEnabled = true;
            this.cmbTaiLen.Location = new System.Drawing.Point(108, 189);
            this.cmbTaiLen.Name = "cmbTaiLen";
            this.cmbTaiLen.Size = new System.Drawing.Size(121, 24);
            this.cmbTaiLen.TabIndex = 17;
            this.cmbTaiLen.SelectedIndexChanged += new System.EventHandler(this.cmbTaiLen_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Mã lớp";
            // 
            // cmbMaLop
            // 
            this.cmbMaLop.FormattingEnabled = true;
            this.cmbMaLop.Location = new System.Drawing.Point(108, 22);
            this.cmbMaLop.Name = "cmbMaLop";
            this.cmbMaLop.Size = new System.Drawing.Size(121, 24);
            this.cmbMaLop.TabIndex = 19;
            // 
            // frmQLBT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBaiTap);
            this.Name = "frmQLBT";
            this.Text = "frmQLBT";
            this.Load += new System.EventHandler(this.frmQLBT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaiTap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBaiTap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChonFile;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThemSua;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbTrangThai;
        private System.Windows.Forms.TextBox txtTenBaiTap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpHanNop;
        private System.Windows.Forms.ComboBox cmbTaiLen;
        private System.Windows.Forms.ComboBox cmbMaLop;
        private System.Windows.Forms.Label label7;
    }
}