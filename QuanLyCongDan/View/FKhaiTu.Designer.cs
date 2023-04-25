namespace QuanLyCongDan.View
{
    partial class FKhaiTu
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
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtNoiDangKy = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pkNgayThucHien = new System.Windows.Forms.DateTimePicker();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNguyenNhan = new System.Windows.Forms.TextBox();
            this.txtCCCDNguoiYeuCau = new System.Windows.Forms.TextBox();
            this.txtQuanHe = new System.Windows.Forms.TextBox();
            this.txtHoVaTenNguoiYeuCau = new System.Windows.Forms.TextBox();
            this.pkThoiGianChet = new System.Windows.Forms.DateTimePicker();
            this.btnTimKiemNguoiYeuCau = new System.Windows.Forms.Button();
            this.txtCCCDCongDan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHoVaTenCongDan = new System.Windows.Forms.TextBox();
            this.txtNoiChet = new System.Windows.Forms.TextBox();
            this.btnTimKiemCongDan = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTimKiem.Location = new System.Drawing.Point(233, 252);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 25);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.Location = new System.Drawing.Point(98, 250);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(130, 26);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.Text = "  Số Khai Tử";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1027, 740);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.Color.Salmon;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(163, 93);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(689, 596);
            this.panel3.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.txtNoiDangKy);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.pkNgayThucHien);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.txtNguyenNhan);
            this.panel1.Controls.Add(this.txtCCCDNguoiYeuCau);
            this.panel1.Controls.Add(this.txtQuanHe);
            this.panel1.Controls.Add(this.txtHoVaTenNguoiYeuCau);
            this.panel1.Controls.Add(this.pkThoiGianChet);
            this.panel1.Controls.Add(this.btnTimKiemNguoiYeuCau);
            this.panel1.Controls.Add(this.txtCCCDCongDan);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtHoVaTenCongDan);
            this.panel1.Controls.Add(this.txtNoiChet);
            this.panel1.Controls.Add(this.btnTimKiemCongDan);
            this.panel1.Location = new System.Drawing.Point(11, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 560);
            this.panel1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(216, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Điền Thông Tin Để Tra Khảo";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSua.Location = new System.Drawing.Point(466, 476);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(101, 37);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoa.Location = new System.Drawing.Point(281, 476);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(107, 37);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtNoiDangKy
            // 
            this.txtNoiDangKy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoiDangKy.Location = new System.Drawing.Point(98, 438);
            this.txtNoiDangKy.Name = "txtNoiDangKy";
            this.txtNoiDangKy.Size = new System.Drawing.Size(210, 26);
            this.txtNoiDangKy.TabIndex = 10;
            this.txtNoiDangKy.Text = "  Nơi Đăng Ký";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(365, 416);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 18);
            this.label10.TabIndex = 6;
            this.label10.Text = "Ngày thực hiện";
            // 
            // pkNgayThucHien
            // 
            this.pkNgayThucHien.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pkNgayThucHien.Location = new System.Drawing.Point(368, 438);
            this.pkNgayThucHien.Name = "pkNgayThucHien";
            this.pkNgayThucHien.Size = new System.Drawing.Size(200, 26);
            this.pkNgayThucHien.TabIndex = 8;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.Location = new System.Drawing.Point(98, 476);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 37);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(229, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thông Tin Khai Tử";
            // 
            // txtNguyenNhan
            // 
            this.txtNguyenNhan.BackColor = System.Drawing.Color.DarkGray;
            this.txtNguyenNhan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNguyenNhan.Location = new System.Drawing.Point(98, 281);
            this.txtNguyenNhan.Multiline = true;
            this.txtNguyenNhan.Name = "txtNguyenNhan";
            this.txtNguyenNhan.Size = new System.Drawing.Size(469, 132);
            this.txtNguyenNhan.TabIndex = 9;
            // 
            // txtCCCDNguoiYeuCau
            // 
            this.txtCCCDNguoiYeuCau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCCCDNguoiYeuCau.Location = new System.Drawing.Point(98, 95);
            this.txtCCCDNguoiYeuCau.Name = "txtCCCDNguoiYeuCau";
            this.txtCCCDNguoiYeuCau.Size = new System.Drawing.Size(181, 26);
            this.txtCCCDNguoiYeuCau.TabIndex = 2;
            this.txtCCCDNguoiYeuCau.Text = "  CCCD Người Yêu Cầu";
            // 
            // txtQuanHe
            // 
            this.txtQuanHe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuanHe.Location = new System.Drawing.Point(98, 199);
            this.txtQuanHe.Name = "txtQuanHe";
            this.txtQuanHe.Size = new System.Drawing.Size(181, 26);
            this.txtQuanHe.TabIndex = 2;
            this.txtQuanHe.Text = "  Quan Hệ";
            // 
            // txtHoVaTenNguoiYeuCau
            // 
            this.txtHoVaTenNguoiYeuCau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHoVaTenNguoiYeuCau.Location = new System.Drawing.Point(98, 159);
            this.txtHoVaTenNguoiYeuCau.Name = "txtHoVaTenNguoiYeuCau";
            this.txtHoVaTenNguoiYeuCau.ReadOnly = true;
            this.txtHoVaTenNguoiYeuCau.Size = new System.Drawing.Size(181, 26);
            this.txtHoVaTenNguoiYeuCau.TabIndex = 2;
            this.txtHoVaTenNguoiYeuCau.Text = "  Họ Và Tên";
            // 
            // pkThoiGianChet
            // 
            this.pkThoiGianChet.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pkThoiGianChet.Location = new System.Drawing.Point(366, 250);
            this.pkThoiGianChet.Name = "pkThoiGianChet";
            this.pkThoiGianChet.Size = new System.Drawing.Size(202, 26);
            this.pkThoiGianChet.TabIndex = 7;
            // 
            // btnTimKiemNguoiYeuCau
            // 
            this.btnTimKiemNguoiYeuCau.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnTimKiemNguoiYeuCau.FlatAppearance.BorderSize = 0;
            this.btnTimKiemNguoiYeuCau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemNguoiYeuCau.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTimKiemNguoiYeuCau.Location = new System.Drawing.Point(98, 128);
            this.btnTimKiemNguoiYeuCau.Name = "btnTimKiemNguoiYeuCau";
            this.btnTimKiemNguoiYeuCau.Size = new System.Drawing.Size(75, 25);
            this.btnTimKiemNguoiYeuCau.TabIndex = 4;
            this.btnTimKiemNguoiYeuCau.Text = "Tìm kiếm";
            this.btnTimKiemNguoiYeuCau.UseVisualStyleBackColor = false;
            this.btnTimKiemNguoiYeuCau.Click += new System.EventHandler(this.btnTimKiemNguoiYeuCau_Click);
            // 
            // txtCCCDCongDan
            // 
            this.txtCCCDCongDan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCCCDCongDan.Location = new System.Drawing.Point(366, 95);
            this.txtCCCDCongDan.Name = "txtCCCDCongDan";
            this.txtCCCDCongDan.Size = new System.Drawing.Size(202, 26);
            this.txtCCCDCongDan.TabIndex = 3;
            this.txtCCCDCongDan.Text = "  CCCD Người Tử";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(365, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Thời gian chết";
            // 
            // txtHoVaTenCongDan
            // 
            this.txtHoVaTenCongDan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHoVaTenCongDan.Location = new System.Drawing.Point(366, 159);
            this.txtHoVaTenCongDan.Name = "txtHoVaTenCongDan";
            this.txtHoVaTenCongDan.ReadOnly = true;
            this.txtHoVaTenCongDan.Size = new System.Drawing.Size(202, 26);
            this.txtHoVaTenCongDan.TabIndex = 2;
            this.txtHoVaTenCongDan.Text = "  Họ Và Tên";
            // 
            // txtNoiChet
            // 
            this.txtNoiChet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoiChet.Location = new System.Drawing.Point(365, 199);
            this.txtNoiChet.Name = "txtNoiChet";
            this.txtNoiChet.Size = new System.Drawing.Size(202, 26);
            this.txtNoiChet.TabIndex = 9;
            this.txtNoiChet.Text = "  Nơi Chết";
            // 
            // btnTimKiemCongDan
            // 
            this.btnTimKiemCongDan.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnTimKiemCongDan.FlatAppearance.BorderSize = 0;
            this.btnTimKiemCongDan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemCongDan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTimKiemCongDan.Location = new System.Drawing.Point(365, 128);
            this.btnTimKiemCongDan.Name = "btnTimKiemCongDan";
            this.btnTimKiemCongDan.Size = new System.Drawing.Size(75, 25);
            this.btnTimKiemCongDan.TabIndex = 4;
            this.btnTimKiemCongDan.Text = "Tìm kiếm";
            this.btnTimKiemCongDan.UseVisualStyleBackColor = false;
            this.btnTimKiemCongDan.Click += new System.EventHandler(this.btnTimKiemCongDan_Click);
            // 
            // FKhaiTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 740);
            this.Controls.Add(this.panel2);
            this.Name = "FKhaiTu";
            this.Text = "Quản Lý Khai Tử";
            this.Load += new System.EventHandler(this.FKhaiTu_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiemCongDan;
        private System.Windows.Forms.Button btnTimKiemNguoiYeuCau;
        private System.Windows.Forms.TextBox txtCCCDCongDan;
        private System.Windows.Forms.TextBox txtCCCDNguoiYeuCau;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtHoVaTenCongDan;
        private System.Windows.Forms.TextBox txtHoVaTenNguoiYeuCau;
        private System.Windows.Forms.TextBox txtQuanHe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNoiDangKy;
        private System.Windows.Forms.TextBox txtNoiChet;
        private System.Windows.Forms.DateTimePicker pkNgayThucHien;
        private System.Windows.Forms.DateTimePicker pkThoiGianChet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNguyenNhan;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}