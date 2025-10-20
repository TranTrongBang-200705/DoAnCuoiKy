namespace DoAnCuoiKy
{
    partial class frmMainGiangVien
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
            this.components = new System.ComponentModel.Container();
<<<<<<< HEAD
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainGiangVien));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuTrangChu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhoaGiangDay = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuanLyBaiTap = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHoSo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThongTinCaNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvPhongHoc = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblBaiTapDaCham = new System.Windows.Forms.Label();
            this.lblBaiTapDaGiao = new System.Windows.Forms.Label();
            this.lblKhoaHoc = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongHoc)).BeginInit();
            this.groupBox2.SuspendLayout();
=======
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trangCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khóaGiảngDạyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýBàiTậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hồSơToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
>>>>>>> 1a62cc8b5e3d27547199f85edea8ce1443939d29
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
<<<<<<< HEAD
            this.menuTrangChu,
            this.mnuKhoaGiangDay,
            this.menuQuanLyBaiTap,
            this.menuHoSo});
=======
            this.trangCToolStripMenuItem,
            this.khóaGiảngDạyToolStripMenuItem,
            this.quảnLýBàiTậpToolStripMenuItem,
            this.hồSơToolStripMenuItem});
>>>>>>> 1a62cc8b5e3d27547199f85edea8ce1443939d29
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
<<<<<<< HEAD
            // menuTrangChu
            // 
            this.menuTrangChu.Name = "menuTrangChu";
            this.menuTrangChu.Size = new System.Drawing.Size(89, 24);
            this.menuTrangChu.Text = "Trang Chủ";
            // 
            // mnuKhoaGiangDay
            // 
            this.mnuKhoaGiangDay.Name = "mnuKhoaGiangDay";
            this.mnuKhoaGiangDay.Size = new System.Drawing.Size(130, 24);
            this.mnuKhoaGiangDay.Text = "Khóa Giảng Dạy";
            this.mnuKhoaGiangDay.Click += new System.EventHandler(this.mnuKhoaGiangDay_Click);
            // 
            // menuQuanLyBaiTap
            // 
            this.menuQuanLyBaiTap.Name = "menuQuanLyBaiTap";
            this.menuQuanLyBaiTap.Size = new System.Drawing.Size(129, 24);
            this.menuQuanLyBaiTap.Text = "Quản Lý Bài Tập";
            this.menuQuanLyBaiTap.Click += new System.EventHandler(this.menuQuanLyBaiTap_Click);
            // 
            // menuHoSo
            // 
            this.menuHoSo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuThongTinCaNhan,
            this.menuDoiMatKhau,
            this.toolStripSeparator1,
            this.menuDangXuat});
            this.menuHoSo.Name = "menuHoSo";
            this.menuHoSo.Size = new System.Drawing.Size(64, 24);
            this.menuHoSo.Text = "Hồ Sơ";
            // 
            // menuThongTinCaNhan
            // 
            this.menuThongTinCaNhan.Name = "menuThongTinCaNhan";
            this.menuThongTinCaNhan.Size = new System.Drawing.Size(210, 26);
            this.menuThongTinCaNhan.Text = "Thông tin cá nhân";
            // 
            // menuDoiMatKhau
            // 
            this.menuDoiMatKhau.Name = "menuDoiMatKhau";
            this.menuDoiMatKhau.Size = new System.Drawing.Size(210, 26);
            this.menuDoiMatKhau.Text = "Đổi mật khẩu";
=======
            // trangCToolStripMenuItem
            // 
            this.trangCToolStripMenuItem.Name = "trangCToolStripMenuItem";
            this.trangCToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.trangCToolStripMenuItem.Text = "Trang Chủ";
            // 
            // khóaGiảngDạyToolStripMenuItem
            // 
            this.khóaGiảngDạyToolStripMenuItem.Name = "khóaGiảngDạyToolStripMenuItem";
            this.khóaGiảngDạyToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.khóaGiảngDạyToolStripMenuItem.Text = "Khóa Giảng Dạy";
            // 
            // quảnLýBàiTậpToolStripMenuItem
            // 
            this.quảnLýBàiTậpToolStripMenuItem.Name = "quảnLýBàiTậpToolStripMenuItem";
            this.quảnLýBàiTậpToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.quảnLýBàiTậpToolStripMenuItem.Text = "Quản Lý Bài Tập";
            // 
            // hồSơToolStripMenuItem
            // 
            this.hồSơToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đổiMậtKhẩuToolStripMenuItem,
            this.toolStripSeparator1,
            this.đăngXuấtToolStripMenuItem});
            this.hồSơToolStripMenuItem.Name = "hồSơToolStripMenuItem";
            this.hồSơToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.hồSơToolStripMenuItem.Text = "Hồ Sơ";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            this.đổiMậtKhẩuToolStripMenuItem.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
>>>>>>> 1a62cc8b5e3d27547199f85edea8ce1443939d29
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
<<<<<<< HEAD
            this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
            // 
            // menuDangXuat
            // 
            this.menuDangXuat.Name = "menuDangXuat";
            this.menuDangXuat.Size = new System.Drawing.Size(210, 26);
            this.menuDangXuat.Text = "Đăng xuất";
=======
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
>>>>>>> 1a62cc8b5e3d27547199f85edea8ce1443939d29
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
<<<<<<< HEAD
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(347, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trang chủ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(387, 248);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 191);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Báo";
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(9, 156);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(20, 19);
            this.button4.TabIndex = 11;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(9, 117);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(20, 19);
            this.button3.TabIndex = 10;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(9, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(20, 19);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(35, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "2 Yêu cầu phúc khảo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(215, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Báo cáo cuối kỳ 30/12/2025";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(257, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "5 Sinh viên mới đăng ký khóa học";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(9, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 19);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "3 Bài tập mới cần chấm";
            // 
            // dgvPhongHoc
            // 
            this.dgvPhongHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongHoc.Location = new System.Drawing.Point(121, 81);
            this.dgvPhongHoc.Name = "dgvPhongHoc";
            this.dgvPhongHoc.RowHeadersWidth = 51;
            this.dgvPhongHoc.RowTemplate.Height = 24;
            this.dgvPhongHoc.Size = new System.Drawing.Size(567, 150);
            this.dgvPhongHoc.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblBaiTapDaCham);
            this.groupBox2.Controls.Add(this.lblBaiTapDaGiao);
            this.groupBox2.Controls.Add(this.lblKhoaHoc);
            this.groupBox2.Location = new System.Drawing.Point(39, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 192);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thống kê nhanh";
            // 
            // lblBaiTapDaCham
            // 
            this.lblBaiTapDaCham.AutoSize = true;
            this.lblBaiTapDaCham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaiTapDaCham.Location = new System.Drawing.Point(29, 117);
            this.lblBaiTapDaCham.Name = "lblBaiTapDaCham";
            this.lblBaiTapDaCham.Size = new System.Drawing.Size(159, 20);
            this.lblBaiTapDaCham.TabIndex = 7;
            this.lblBaiTapDaCham.Text = "Bài tập đã chấm: 20";
            // 
            // lblBaiTapDaGiao
            // 
            this.lblBaiTapDaGiao.AutoSize = true;
            this.lblBaiTapDaGiao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaiTapDaGiao.Location = new System.Drawing.Point(29, 76);
            this.lblBaiTapDaGiao.Name = "lblBaiTapDaGiao";
            this.lblBaiTapDaGiao.Size = new System.Drawing.Size(149, 20);
            this.lblBaiTapDaGiao.TabIndex = 6;
            this.lblBaiTapDaGiao.Text = "Bài tập đã giao: 25";
            // 
            // lblKhoaHoc
            // 
            this.lblKhoaHoc.AutoSize = true;
            this.lblKhoaHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhoaHoc.Location = new System.Drawing.Point(29, 36);
            this.lblKhoaHoc.Name = "lblKhoaHoc";
            this.lblKhoaHoc.Size = new System.Drawing.Size(170, 20);
            this.lblKhoaHoc.TabIndex = 5;
            this.lblKhoaHoc.Text = "Khóa học đang dạy: 5";
            // 
=======
>>>>>>> 1a62cc8b5e3d27547199f85edea8ce1443939d29
            // frmMainGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
<<<<<<< HEAD
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvPhongHoc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
=======
>>>>>>> 1a62cc8b5e3d27547199f85edea8ce1443939d29
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainGiangVien";
            this.Text = "frmMainGiangVien";
            this.Load += new System.EventHandler(this.frmMainGiangVien_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
<<<<<<< HEAD
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongHoc)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
=======
>>>>>>> 1a62cc8b5e3d27547199f85edea8ce1443939d29
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
<<<<<<< HEAD
        private System.Windows.Forms.ToolStripMenuItem menuTrangChu;
        private System.Windows.Forms.ToolStripMenuItem menuHoSo;
        private System.Windows.Forms.ToolStripMenuItem menuThongTinCaNhan;
        private System.Windows.Forms.ToolStripMenuItem menuDoiMatKhau;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuKhoaGiangDay;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuQuanLyBaiTap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvPhongHoc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblKhoaHoc;
        private System.Windows.Forms.Label lblBaiTapDaCham;
        private System.Windows.Forms.Label lblBaiTapDaGiao;
=======
        private System.Windows.Forms.ToolStripMenuItem trangCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hồSơToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khóaGiảngDạyToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýBàiTậpToolStripMenuItem;
>>>>>>> 1a62cc8b5e3d27547199f85edea8ce1443939d29
    }
}