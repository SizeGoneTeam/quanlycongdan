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
            this.btnThemNhanVien = new System.Windows.Forms.Button();
            this.btnXemCongTy = new System.Windows.Forms.Button();
            this.btnXemCCCD = new System.Windows.Forms.Button();
            this.btnThemCongTy = new System.Windows.Forms.Button();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.txtCongTy = new System.Windows.Forms.TextBox();
            this.btnSuaLuong = new System.Windows.Forms.Button();
            this.btnNghiViec = new System.Windows.Forms.Button();
            this.btnTraLuong = new System.Windows.Forms.Button();
            this.gvCongTy = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvCongTy)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThemNhanVien
            // 
            this.btnThemNhanVien.BackColor = System.Drawing.Color.SandyBrown;
            this.btnThemNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemNhanVien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThemNhanVien.Location = new System.Drawing.Point(318, 226);
            this.btnThemNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemNhanVien.Name = "btnThemNhanVien";
            this.btnThemNhanVien.Size = new System.Drawing.Size(217, 50);
            this.btnThemNhanVien.TabIndex = 27;
            this.btnThemNhanVien.Text = "Thêm Nhân Viên";
            this.btnThemNhanVien.UseVisualStyleBackColor = false;
            this.btnThemNhanVien.EnabledChanged += new System.EventHandler(this.btnThemNhanVien_EnabledChanged);
            this.btnThemNhanVien.Click += new System.EventHandler(this.btnThemNhanVien_Click);
            // 
            // btnXemCongTy
            // 
            this.btnXemCongTy.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnXemCongTy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemCongTy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXemCongTy.Location = new System.Drawing.Point(432, 147);
            this.btnXemCongTy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXemCongTy.Name = "btnXemCongTy";
            this.btnXemCongTy.Size = new System.Drawing.Size(103, 33);
            this.btnXemCongTy.TabIndex = 17;
            this.btnXemCongTy.Text = "Xem";
            this.btnXemCongTy.UseVisualStyleBackColor = false;
            this.btnXemCongTy.Click += new System.EventHandler(this.btnXemCongTy_Click);
            // 
            // btnXemCCCD
            // 
            this.btnXemCCCD.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnXemCCCD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemCCCD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXemCCCD.Location = new System.Drawing.Point(432, 109);
            this.btnXemCCCD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXemCCCD.Name = "btnXemCCCD";
            this.btnXemCCCD.Size = new System.Drawing.Size(103, 33);
            this.btnXemCCCD.TabIndex = 16;
            this.btnXemCCCD.Text = "Xem";
            this.btnXemCCCD.UseVisualStyleBackColor = false;
            this.btnXemCCCD.Click += new System.EventHandler(this.btnXemCCCD_Click);
            // 
            // btnThemCongTy
            // 
            this.btnThemCongTy.BackColor = System.Drawing.Color.SandyBrown;
            this.btnThemCongTy.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnThemCongTy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemCongTy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThemCongTy.Location = new System.Drawing.Point(67, 226);
            this.btnThemCongTy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemCongTy.Name = "btnThemCongTy";
            this.btnThemCongTy.Size = new System.Drawing.Size(243, 50);
            this.btnThemCongTy.TabIndex = 22;
            this.btnThemCongTy.Text = "Thêm Công Ty";
            this.btnThemCongTy.UseVisualStyleBackColor = false;
            this.btnThemCongTy.Click += new System.EventHandler(this.btnThemCongTy_Click);
            // 
            // txtCCCD
            // 
            this.txtCCCD.AllowDrop = true;
            this.txtCCCD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCCCD.Location = new System.Drawing.Point(67, 112);
            this.txtCCCD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(351, 30);
            this.txtCCCD.TabIndex = 14;
            this.txtCCCD.Text = "  CCCD";
            this.txtCCCD.TextChanged += new System.EventHandler(this.txtCCCD_TextChanged);
            this.txtCCCD.Enter += new System.EventHandler(this.txtCCCD_Enter);
            this.txtCCCD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCCCD_KeyPress);
            // 
            // txtLuong
            // 
            this.txtLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLuong.Location = new System.Drawing.Point(67, 188);
            this.txtLuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(351, 30);
            this.txtLuong.TabIndex = 12;
            this.txtLuong.Text = "  Lương";
            this.txtLuong.TextChanged += new System.EventHandler(this.txtLuong_TextChanged);
            this.txtLuong.Enter += new System.EventHandler(this.txtLuong_Enter);
            this.txtLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLuong_KeyPress);
            // 
            // txtCongTy
            // 
            this.txtCongTy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCongTy.Location = new System.Drawing.Point(67, 150);
            this.txtCongTy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCongTy.Name = "txtCongTy";
            this.txtCongTy.Size = new System.Drawing.Size(351, 30);
            this.txtCongTy.TabIndex = 10;
            this.txtCongTy.Text = "  Tên Công Ty";
            this.txtCongTy.TextChanged += new System.EventHandler(this.txtCongTy_TextChanged);
            this.txtCongTy.Enter += new System.EventHandler(this.txtCongTy_Enter);
            // 
            // btnSuaLuong
            // 
            this.btnSuaLuong.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSuaLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaLuong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSuaLuong.Location = new System.Drawing.Point(318, 485);
            this.btnSuaLuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSuaLuong.Name = "btnSuaLuong";
            this.btnSuaLuong.Size = new System.Drawing.Size(217, 50);
            this.btnSuaLuong.TabIndex = 24;
            this.btnSuaLuong.Text = "Sửa Lương";
            this.btnSuaLuong.UseVisualStyleBackColor = false;
            this.btnSuaLuong.Click += new System.EventHandler(this.btnSuaLuong_Click);
            // 
            // btnNghiViec
            // 
            this.btnNghiViec.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnNghiViec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNghiViec.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNghiViec.Location = new System.Drawing.Point(185, 543);
            this.btnNghiViec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNghiViec.Name = "btnNghiViec";
            this.btnNghiViec.Size = new System.Drawing.Size(233, 50);
            this.btnNghiViec.TabIndex = 23;
            this.btnNghiViec.Text = "Nghỉ việc";
            this.btnNghiViec.UseVisualStyleBackColor = false;
            this.btnNghiViec.Click += new System.EventHandler(this.btnNghiViec_Click);
            // 
            // btnTraLuong
            // 
            this.btnTraLuong.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnTraLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraLuong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTraLuong.Location = new System.Drawing.Point(67, 485);
            this.btnTraLuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTraLuong.Name = "btnTraLuong";
            this.btnTraLuong.Size = new System.Drawing.Size(243, 50);
            this.btnTraLuong.TabIndex = 25;
            this.btnTraLuong.Text = "Trả Lương";
            this.btnTraLuong.UseVisualStyleBackColor = false;
            this.btnTraLuong.Click += new System.EventHandler(this.btnTraLuong_Click);
            // 
            // gvCongTy
            // 
            this.gvCongTy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCongTy.Location = new System.Drawing.Point(67, 284);
            this.gvCongTy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gvCongTy.Name = "gvCongTy";
            this.gvCongTy.ReadOnly = true;
            this.gvCongTy.RowHeadersWidth = 51;
            this.gvCongTy.RowTemplate.Height = 24;
            this.gvCongTy.Size = new System.Drawing.Size(468, 193);
            this.gvCongTy.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.Color.Salmon;
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(105, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(613, 656);
            this.panel3.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnThemNhanVien);
            this.panel2.Controls.Add(this.btnNghiViec);
            this.panel2.Controls.Add(this.btnSuaLuong);
            this.panel2.Controls.Add(this.btnTraLuong);
            this.panel2.Controls.Add(this.gvCongTy);
            this.panel2.Controls.Add(this.btnThemCongTy);
            this.panel2.Controls.Add(this.btnXemCongTy);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtCCCD);
            this.panel2.Controls.Add(this.btnXemCCCD);
            this.panel2.Controls.Add(this.txtCongTy);
            this.panel2.Controls.Add(this.txtLuong);
            this.panel2.Location = new System.Drawing.Point(15, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(582, 604);
            this.panel2.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(158, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Điền Thông Tin Để Tra Khảo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(179, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thông Tin Công Ty";
            // 
            // FCongTy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(854, 689);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FCongTy";
            this.Text = "FCongTy";
            ((System.ComponentModel.ISupportInitialize)(this.gvCongTy)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.TextBox txtCongTy;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.Button btnSuaLuong;
        private System.Windows.Forms.Button btnNghiViec;
        private System.Windows.Forms.Button btnThemCongTy;
        private System.Windows.Forms.Button btnTraLuong;
        private System.Windows.Forms.Button btnXemCongTy;
        private System.Windows.Forms.Button btnXemCCCD;
        private System.Windows.Forms.DataGridView gvCongTy;
        private System.Windows.Forms.Button btnThemNhanVien;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}