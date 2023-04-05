namespace QuanLyCongDan.View
{
    partial class FCongTy
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThemNhanVien = new System.Windows.Forms.Button();
            this.btnXemCongTy = new System.Windows.Forms.Button();
            this.btnXemCCCD = new System.Windows.Forms.Button();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.btnThemCongTy = new System.Windows.Forms.Button();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.lblCongTy = new System.Windows.Forms.Label();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.lblLuong = new System.Windows.Forms.Label();
            this.txtCongTy = new System.Windows.Forms.TextBox();
            this.btnSuaLuong = new System.Windows.Forms.Button();
            this.btnNghiViec = new System.Windows.Forms.Button();
            this.btnTraLuong = new System.Windows.Forms.Button();
            this.gvCongTy = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCongTy)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThemNhanVien);
            this.panel1.Controls.Add(this.btnXemCongTy);
            this.panel1.Controls.Add(this.btnXemCCCD);
            this.panel1.Controls.Add(this.lblCCCD);
            this.panel1.Controls.Add(this.btnThemCongTy);
            this.panel1.Controls.Add(this.txtCCCD);
            this.panel1.Controls.Add(this.lblCongTy);
            this.panel1.Controls.Add(this.txtLuong);
            this.panel1.Controls.Add(this.lblLuong);
            this.panel1.Controls.Add(this.txtCongTy);
            this.panel1.Location = new System.Drawing.Point(228, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 217);
            this.panel1.TabIndex = 21;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnThemNhanVien
            // 
            this.btnThemNhanVien.Location = new System.Drawing.Point(286, 173);
            this.btnThemNhanVien.Name = "btnThemNhanVien";
            this.btnThemNhanVien.Size = new System.Drawing.Size(143, 35);
            this.btnThemNhanVien.TabIndex = 27;
            this.btnThemNhanVien.Text = "Thêm Nhân Viên";
            this.btnThemNhanVien.UseVisualStyleBackColor = true;
            this.btnThemNhanVien.EnabledChanged += new System.EventHandler(this.btnThemNhanVien_EnabledChanged);
            this.btnThemNhanVien.Click += new System.EventHandler(this.btnThemNhanVien_Click);
            // 
            // btnXemCongTy
            // 
            this.btnXemCongTy.Location = new System.Drawing.Point(368, 79);
            this.btnXemCongTy.Name = "btnXemCongTy";
            this.btnXemCongTy.Size = new System.Drawing.Size(75, 23);
            this.btnXemCongTy.TabIndex = 17;
            this.btnXemCongTy.Text = "Xem";
            this.btnXemCongTy.UseVisualStyleBackColor = true;
            this.btnXemCongTy.Click += new System.EventHandler(this.btnXemCongTy_Click);
            // 
            // btnXemCCCD
            // 
            this.btnXemCCCD.Location = new System.Drawing.Point(368, 39);
            this.btnXemCCCD.Name = "btnXemCCCD";
            this.btnXemCCCD.Size = new System.Drawing.Size(75, 23);
            this.btnXemCCCD.TabIndex = 16;
            this.btnXemCCCD.Text = "Xem";
            this.btnXemCCCD.UseVisualStyleBackColor = true;
            this.btnXemCCCD.Click += new System.EventHandler(this.btnXemCCCD_Click);
            // 
            // lblCCCD
            // 
            this.lblCCCD.AllowDrop = true;
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Location = new System.Drawing.Point(16, 39);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(44, 16);
            this.lblCCCD.TabIndex = 13;
            this.lblCCCD.Text = "CCCD";
            // 
            // btnThemCongTy
            // 
            this.btnThemCongTy.Location = new System.Drawing.Point(32, 173);
            this.btnThemCongTy.Name = "btnThemCongTy";
            this.btnThemCongTy.Size = new System.Drawing.Size(144, 35);
            this.btnThemCongTy.TabIndex = 22;
            this.btnThemCongTy.Text = "Thêm Công Ty";
            this.btnThemCongTy.UseVisualStyleBackColor = true;
            this.btnThemCongTy.Click += new System.EventHandler(this.btnThemCongTy_Click);
            // 
            // txtCCCD
            // 
            this.txtCCCD.AllowDrop = true;
            this.txtCCCD.Location = new System.Drawing.Point(115, 39);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(230, 22);
            this.txtCCCD.TabIndex = 14;
            this.txtCCCD.TextChanged += new System.EventHandler(this.txtCCCD_TextChanged);
            this.txtCCCD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCCCD_KeyPress);
            // 
            // lblCongTy
            // 
            this.lblCongTy.AutoSize = true;
            this.lblCongTy.Location = new System.Drawing.Point(16, 80);
            this.lblCongTy.Name = "lblCongTy";
            this.lblCongTy.Size = new System.Drawing.Size(85, 16);
            this.lblCongTy.TabIndex = 6;
            this.lblCongTy.Text = "Tên Công Ty";
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(115, 127);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(230, 22);
            this.txtLuong.TabIndex = 12;
            this.txtLuong.TextChanged += new System.EventHandler(this.txtLuong_TextChanged);
            this.txtLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLuong_KeyPress);
            // 
            // lblLuong
            // 
            this.lblLuong.AutoSize = true;
            this.lblLuong.Location = new System.Drawing.Point(16, 127);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(44, 16);
            this.lblLuong.TabIndex = 8;
            this.lblLuong.Text = "Lương";
            // 
            // txtCongTy
            // 
            this.txtCongTy.Location = new System.Drawing.Point(115, 80);
            this.txtCongTy.Name = "txtCongTy";
            this.txtCongTy.Size = new System.Drawing.Size(230, 22);
            this.txtCongTy.TabIndex = 10;
            this.txtCongTy.TextChanged += new System.EventHandler(this.txtCongTy_TextChanged);
            // 
            // btnSuaLuong
            // 
            this.btnSuaLuong.Location = new System.Drawing.Point(388, 544);
            this.btnSuaLuong.Name = "btnSuaLuong";
            this.btnSuaLuong.Size = new System.Drawing.Size(129, 35);
            this.btnSuaLuong.TabIndex = 24;
            this.btnSuaLuong.Text = "Sửa Lương";
            this.btnSuaLuong.UseVisualStyleBackColor = true;
            this.btnSuaLuong.Click += new System.EventHandler(this.btnSuaLuong_Click);
            // 
            // btnNghiViec
            // 
            this.btnNghiViec.Location = new System.Drawing.Point(545, 542);
            this.btnNghiViec.Name = "btnNghiViec";
            this.btnNghiViec.Size = new System.Drawing.Size(129, 35);
            this.btnNghiViec.TabIndex = 23;
            this.btnNghiViec.Text = "Nghỉ việc";
            this.btnNghiViec.UseVisualStyleBackColor = true;
            this.btnNghiViec.Click += new System.EventHandler(this.btnNghiViec_Click);
            // 
            // btnTraLuong
            // 
            this.btnTraLuong.Location = new System.Drawing.Point(231, 546);
            this.btnTraLuong.Name = "btnTraLuong";
            this.btnTraLuong.Size = new System.Drawing.Size(129, 31);
            this.btnTraLuong.TabIndex = 25;
            this.btnTraLuong.Text = "Trả Lương";
            this.btnTraLuong.UseVisualStyleBackColor = true;
            this.btnTraLuong.Click += new System.EventHandler(this.btnTraLuong_Click);
            // 
            // gvCongTy
            // 
            this.gvCongTy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCongTy.Location = new System.Drawing.Point(55, 235);
            this.gvCongTy.Name = "gvCongTy";
            this.gvCongTy.ReadOnly = true;
            this.gvCongTy.RowHeadersWidth = 51;
            this.gvCongTy.RowTemplate.Height = 24;
            this.gvCongTy.Size = new System.Drawing.Size(802, 288);
            this.gvCongTy.TabIndex = 26;
            // 
            // FCongTy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 589);
            this.Controls.Add(this.gvCongTy);
            this.Controls.Add(this.btnTraLuong);
            this.Controls.Add(this.btnSuaLuong);
            this.Controls.Add(this.btnNghiViec);
            this.Controls.Add(this.panel1);
            this.Name = "FCongTy";
            this.Text = "FCongTy";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCongTy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label lblCongTy;
        private System.Windows.Forms.TextBox txtCongTy;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.Button btnSuaLuong;
        private System.Windows.Forms.Button btnNghiViec;
        private System.Windows.Forms.Button btnThemCongTy;
        private System.Windows.Forms.Button btnTraLuong;
        private System.Windows.Forms.Button btnXemCongTy;
        private System.Windows.Forms.Button btnXemCCCD;
        private System.Windows.Forms.DataGridView gvCongTy;
        private System.Windows.Forms.Button btnThemNhanVien;
    }
}