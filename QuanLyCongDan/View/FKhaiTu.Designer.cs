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
            this.txtIDNguoiYeuCau = new System.Windows.Forms.TextBox();
            this.txtQuanHe = new System.Windows.Forms.TextBox();
            this.txtHoVaTenNguoiYeuCau = new System.Windows.Forms.TextBox();
            this.pkThoiGianChet = new System.Windows.Forms.DateTimePicker();
            this.btnTimKiemNguoiYeuCau = new System.Windows.Forms.Button();
            this.txtIDCongDan = new System.Windows.Forms.TextBox();
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
            this.btnTimKiem.Location = new System.Drawing.Point(311, 310);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 31);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.Location = new System.Drawing.Point(131, 308);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(172, 30);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.Text = "  Số Khai Tử";
            this.txtTimKiem.Enter += new System.EventHandler(this.txtTimKiem_Enter);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1369, 911);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.Color.Salmon;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(217, 114);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(919, 734);
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
            this.panel1.Controls.Add(this.txtIDNguoiYeuCau);
            this.panel1.Controls.Add(this.txtQuanHe);
            this.panel1.Controls.Add(this.txtHoVaTenNguoiYeuCau);
            this.panel1.Controls.Add(this.pkThoiGianChet);
            this.panel1.Controls.Add(this.btnTimKiemNguoiYeuCau);
            this.panel1.Controls.Add(this.txtIDCongDan);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtHoVaTenCongDan);
            this.panel1.Controls.Add(this.txtNoiChet);
            this.panel1.Controls.Add(this.btnTimKiemCongDan);
            this.panel1.Location = new System.Drawing.Point(15, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 689);
            this.panel1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(288, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Điền Thông Tin Để Tra Khảo";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSua.Location = new System.Drawing.Point(621, 586);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(135, 45);
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
            this.btnXoa.Location = new System.Drawing.Point(375, 586);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(143, 45);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtNoiDangKy
            // 
            this.txtNoiDangKy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoiDangKy.Location = new System.Drawing.Point(131, 539);
            this.txtNoiDangKy.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoiDangKy.Name = "txtNoiDangKy";
            this.txtNoiDangKy.Size = new System.Drawing.Size(280, 30);
            this.txtNoiDangKy.TabIndex = 10;
            this.txtNoiDangKy.Text = "  Nơi Đăng Ký";
            this.txtNoiDangKy.Enter += new System.EventHandler(this.txtNoiDangKy_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(487, 512);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 23);
            this.label10.TabIndex = 6;
            this.label10.Text = "Ngày thực hiện";
            // 
            // pkNgayThucHien
            // 
            this.pkNgayThucHien.Location = new System.Drawing.Point(491, 539);
            this.pkNgayThucHien.Margin = new System.Windows.Forms.Padding(4);
            this.pkNgayThucHien.Name = "pkNgayThucHien";
            this.pkNgayThucHien.Size = new System.Drawing.Size(265, 30);
            this.pkNgayThucHien.TabIndex = 8;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.Location = new System.Drawing.Point(131, 586);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(150, 45);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(305, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thông Tin Khai Tử";
            // 
            // txtNguyenNhan
            // 
            this.txtNguyenNhan.BackColor = System.Drawing.Color.DarkGray;
            this.txtNguyenNhan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNguyenNhan.Location = new System.Drawing.Point(131, 346);
            this.txtNguyenNhan.Margin = new System.Windows.Forms.Padding(4);
            this.txtNguyenNhan.Multiline = true;
            this.txtNguyenNhan.Name = "txtNguyenNhan";
            this.txtNguyenNhan.Size = new System.Drawing.Size(625, 162);
            this.txtNguyenNhan.TabIndex = 9;
            // 
            // txtIDNguoiYeuCau
            // 
            this.txtIDNguoiYeuCau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDNguoiYeuCau.Location = new System.Drawing.Point(131, 117);
            this.txtIDNguoiYeuCau.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDNguoiYeuCau.Name = "txtIDNguoiYeuCau";
            this.txtIDNguoiYeuCau.Size = new System.Drawing.Size(241, 30);
            this.txtIDNguoiYeuCau.TabIndex = 2;
            this.txtIDNguoiYeuCau.Text = "  ID Người Yêu Cầu";
            this.txtIDNguoiYeuCau.Enter += new System.EventHandler(this.txtIDNguoiYeuCau_Enter);
            // 
            // txtQuanHe
            // 
            this.txtQuanHe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuanHe.Location = new System.Drawing.Point(131, 245);
            this.txtQuanHe.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuanHe.Name = "txtQuanHe";
            this.txtQuanHe.Size = new System.Drawing.Size(241, 30);
            this.txtQuanHe.TabIndex = 2;
            this.txtQuanHe.Text = "  Quan Hệ";
            this.txtQuanHe.Enter += new System.EventHandler(this.txtQuanHe_Enter);
            // 
            // txtHoVaTenNguoiYeuCau
            // 
            this.txtHoVaTenNguoiYeuCau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHoVaTenNguoiYeuCau.Location = new System.Drawing.Point(131, 196);
            this.txtHoVaTenNguoiYeuCau.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoVaTenNguoiYeuCau.Name = "txtHoVaTenNguoiYeuCau";
            this.txtHoVaTenNguoiYeuCau.ReadOnly = true;
            this.txtHoVaTenNguoiYeuCau.Size = new System.Drawing.Size(241, 30);
            this.txtHoVaTenNguoiYeuCau.TabIndex = 2;
            this.txtHoVaTenNguoiYeuCau.Text = "  Họ Và Tên";
            // 
            // pkThoiGianChet
            // 
            this.pkThoiGianChet.Location = new System.Drawing.Point(488, 308);
            this.pkThoiGianChet.Margin = new System.Windows.Forms.Padding(4);
            this.pkThoiGianChet.Name = "pkThoiGianChet";
            this.pkThoiGianChet.Size = new System.Drawing.Size(268, 30);
            this.pkThoiGianChet.TabIndex = 7;
            // 
            // btnTimKiemNguoiYeuCau
            // 
            this.btnTimKiemNguoiYeuCau.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnTimKiemNguoiYeuCau.FlatAppearance.BorderSize = 0;
            this.btnTimKiemNguoiYeuCau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemNguoiYeuCau.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTimKiemNguoiYeuCau.Location = new System.Drawing.Point(131, 157);
            this.btnTimKiemNguoiYeuCau.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiemNguoiYeuCau.Name = "btnTimKiemNguoiYeuCau";
            this.btnTimKiemNguoiYeuCau.Size = new System.Drawing.Size(100, 31);
            this.btnTimKiemNguoiYeuCau.TabIndex = 4;
            this.btnTimKiemNguoiYeuCau.Text = "Tìm kiếm";
            this.btnTimKiemNguoiYeuCau.UseVisualStyleBackColor = false;
            this.btnTimKiemNguoiYeuCau.Click += new System.EventHandler(this.btnTimKiemNguoiYeuCau_Click);
            // 
            // txtIDCongDan
            // 
            this.txtIDCongDan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDCongDan.Location = new System.Drawing.Point(488, 117);
            this.txtIDCongDan.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDCongDan.Name = "txtIDCongDan";
            this.txtIDCongDan.Size = new System.Drawing.Size(268, 30);
            this.txtIDCongDan.TabIndex = 3;
            this.txtIDCongDan.Text = "  ID Người Tử";
            this.txtIDCongDan.Enter += new System.EventHandler(this.txtIDCongDan_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(487, 281);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Thời gian chết";
            // 
            // txtHoVaTenCongDan
            // 
            this.txtHoVaTenCongDan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHoVaTenCongDan.Location = new System.Drawing.Point(488, 196);
            this.txtHoVaTenCongDan.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoVaTenCongDan.Name = "txtHoVaTenCongDan";
            this.txtHoVaTenCongDan.ReadOnly = true;
            this.txtHoVaTenCongDan.Size = new System.Drawing.Size(268, 30);
            this.txtHoVaTenCongDan.TabIndex = 2;
            this.txtHoVaTenCongDan.Text = "  Họ Và Tên";
            this.txtHoVaTenCongDan.TextChanged += new System.EventHandler(this.txtHoVaTenCongDan_TextChanged);
            // 
            // txtNoiChet
            // 
            this.txtNoiChet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoiChet.Location = new System.Drawing.Point(487, 245);
            this.txtNoiChet.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoiChet.Name = "txtNoiChet";
            this.txtNoiChet.Size = new System.Drawing.Size(269, 30);
            this.txtNoiChet.TabIndex = 9;
            this.txtNoiChet.Text = "  Nơi Chết";
            this.txtNoiChet.Enter += new System.EventHandler(this.txtNoiChet_Enter);
            // 
            // btnTimKiemCongDan
            // 
            this.btnTimKiemCongDan.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnTimKiemCongDan.FlatAppearance.BorderSize = 0;
            this.btnTimKiemCongDan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemCongDan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTimKiemCongDan.Location = new System.Drawing.Point(487, 157);
            this.btnTimKiemCongDan.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiemCongDan.Name = "btnTimKiemCongDan";
            this.btnTimKiemCongDan.Size = new System.Drawing.Size(100, 31);
            this.btnTimKiemCongDan.TabIndex = 4;
            this.btnTimKiemCongDan.Text = "Tìm kiếm";
            this.btnTimKiemCongDan.UseVisualStyleBackColor = false;
            this.btnTimKiemCongDan.Click += new System.EventHandler(this.btnTimKiemCongDan_Click);
            // 
            // FKhaiTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 911);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.TextBox txtIDCongDan;
        private System.Windows.Forms.TextBox txtIDNguoiYeuCau;
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