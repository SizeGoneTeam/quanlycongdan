namespace QuanLyCongDan
{
    partial class FMemu
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
            this.btnCongDan = new System.Windows.Forms.Button();
            this.btnCCCD = new System.Windows.Forms.Button();
            this.btnHonNhan = new System.Windows.Forms.Button();
            this.btnTTTV = new System.Windows.Forms.Button();
            this.btnThue = new System.Windows.Forms.Button();
            this.btnSoHoKhau = new System.Windows.Forms.Button();
            this.btnKhaiSinh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCongDan
            // 
            this.btnCongDan.Location = new System.Drawing.Point(61, 39);
            this.btnCongDan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCongDan.Name = "btnCongDan";
            this.btnCongDan.Size = new System.Drawing.Size(143, 38);
            this.btnCongDan.TabIndex = 0;
            this.btnCongDan.Text = "Công Dân";
            this.btnCongDan.UseVisualStyleBackColor = true;
            this.btnCongDan.Click += new System.EventHandler(this.btnCongDan_Click);
            // 
            // btnCCCD
            // 
            this.btnCCCD.Location = new System.Drawing.Point(296, 39);
            this.btnCCCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCCCD.Name = "btnCCCD";
            this.btnCCCD.Size = new System.Drawing.Size(128, 38);
            this.btnCCCD.TabIndex = 1;
            this.btnCCCD.Text = "CCCD";
            this.btnCCCD.UseVisualStyleBackColor = true;
            this.btnCCCD.Click += new System.EventHandler(this.btnCCCD_Click);
            // 
            // btnHonNhan
            // 
            this.btnHonNhan.Location = new System.Drawing.Point(524, 39);
            this.btnHonNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHonNhan.Name = "btnHonNhan";
            this.btnHonNhan.Size = new System.Drawing.Size(128, 38);
            this.btnHonNhan.TabIndex = 2;
            this.btnHonNhan.Text = "Hôn Nhân";
            this.btnHonNhan.UseVisualStyleBackColor = true;
            this.btnHonNhan.Click += new System.EventHandler(this.btnHonNhan_Click);
            // 
            // btnTTTV
            // 
            this.btnTTTV.Location = new System.Drawing.Point(61, 143);
            this.btnTTTV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTTTV.Name = "btnTTTV";
            this.btnTTTV.Size = new System.Drawing.Size(143, 38);
            this.btnTTTV.TabIndex = 3;
            this.btnTTTV.Text = "Tạm Trú Tạm Vắng";
            this.btnTTTV.UseVisualStyleBackColor = true;
            this.btnTTTV.Click += new System.EventHandler(this.btnTTTV_Click);
            // 
            // btnThue
            // 
            this.btnThue.Location = new System.Drawing.Point(296, 143);
            this.btnThue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThue.Name = "btnThue";
            this.btnThue.Size = new System.Drawing.Size(128, 38);
            this.btnThue.TabIndex = 4;
            this.btnThue.Text = "Thuế";
            this.btnThue.UseVisualStyleBackColor = true;
            this.btnThue.Click += new System.EventHandler(this.btnThue_Click);
            // 
            // btnSoHoKhau
            // 
            this.btnSoHoKhau.Location = new System.Drawing.Point(524, 143);
            this.btnSoHoKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSoHoKhau.Name = "btnSoHoKhau";
            this.btnSoHoKhau.Size = new System.Drawing.Size(128, 38);
            this.btnSoHoKhau.TabIndex = 5;
            this.btnSoHoKhau.Text = "Sổ Hổ Khẩu";
            this.btnSoHoKhau.UseVisualStyleBackColor = true;
            // 
            // btnKhaiSinh
            // 
            this.btnKhaiSinh.Location = new System.Drawing.Point(61, 256);
            this.btnKhaiSinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKhaiSinh.Name = "btnKhaiSinh";
            this.btnKhaiSinh.Size = new System.Drawing.Size(143, 37);
            this.btnKhaiSinh.TabIndex = 6;
            this.btnKhaiSinh.Text = "Khai Sinh";
            this.btnKhaiSinh.UseVisualStyleBackColor = true;
            this.btnKhaiSinh.Click += new System.EventHandler(this.btnKhaiSinh_Click);
            // 
            // FMemu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKhaiSinh);
            this.Controls.Add(this.btnSoHoKhau);
            this.Controls.Add(this.btnThue);
            this.Controls.Add(this.btnTTTV);
            this.Controls.Add(this.btnHonNhan);
            this.Controls.Add(this.btnCCCD);
            this.Controls.Add(this.btnCongDan);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FMemu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FMemu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCongDan;
        private System.Windows.Forms.Button btnCCCD;
        private System.Windows.Forms.Button btnHonNhan;
        private System.Windows.Forms.Button btnTTTV;
        private System.Windows.Forms.Button btnThue;
        private System.Windows.Forms.Button btnSoHoKhau;
        private System.Windows.Forms.Button btnKhaiSinh;
    }
}

