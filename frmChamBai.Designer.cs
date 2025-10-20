namespace DoAnCuoiKy
{
    partial class frmChamBai
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
            this.lblTieuDeBaiTap = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvChamBai = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnLuuDiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamBai)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDeBaiTap
            // 
            this.lblTieuDeBaiTap.AutoSize = true;
            this.lblTieuDeBaiTap.Location = new System.Drawing.Point(322, -17);
            this.lblTieuDeBaiTap.Name = "lblTieuDeBaiTap";
            this.lblTieuDeBaiTap.Size = new System.Drawing.Size(100, 16);
            this.lblTieuDeBaiTap.TabIndex = 18;
            this.lblTieuDeBaiTap.Text = "Tiêu đề bài tập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, -114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 36);
            this.label1.TabIndex = 17;
            this.label1.Text = "📚 BÀI TẬP KHÓA HỌC";
            // 
            // dgvChamBai
            // 
            this.dgvChamBai.AllowUserToAddRows = false;
            this.dgvChamBai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChamBai.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvChamBai.Location = new System.Drawing.Point(12, 153);
            this.dgvChamBai.Name = "dgvChamBai";
            this.dgvChamBai.RowHeadersWidth = 51;
            this.dgvChamBai.RowTemplate.Height = 24;
            this.dgvChamBai.Size = new System.Drawing.Size(1065, 268);
            this.dgvChamBai.TabIndex = 19;
            this.dgvChamBai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChamBai_CellContentClick);
            this.dgvChamBai.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChamBai_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "MSSV";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(289, 117);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(177, 22);
            this.txtMSSV.TabIndex = 22;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(492, 120);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 24;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLuuDiem
            // 
            this.btnLuuDiem.Location = new System.Drawing.Point(596, 120);
            this.btnLuuDiem.Name = "btnLuuDiem";
            this.btnLuuDiem.Size = new System.Drawing.Size(75, 23);
            this.btnLuuDiem.TabIndex = 25;
            this.btnLuuDiem.Text = "Lưu điểm";
            this.btnLuuDiem.UseVisualStyleBackColor = true;
            this.btnLuuDiem.Click += new System.EventHandler(this.btnLuuDiem_Click);
            // 
            // frmChamBai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 596);
            this.Controls.Add(this.btnLuuDiem);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txtMSSV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvChamBai);
            this.Controls.Add(this.lblTieuDeBaiTap);
            this.Controls.Add(this.label1);
            this.Name = "frmChamBai";
            this.Text = "frmChamBai";
            this.Load += new System.EventHandler(this.frmChamBai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamBai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTieuDeBaiTap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvChamBai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnLuuDiem;
    }
}