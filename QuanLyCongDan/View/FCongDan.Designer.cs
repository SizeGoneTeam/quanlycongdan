namespace QuanLyCongDan.View
{
    partial class FCongDan
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
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.dTPNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblQueQuan = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblNamSinh = new System.Windows.Forms.Label();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblDanToc = new System.Windows.Forms.Label();
            this.lblTonGiao = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.cboTonGiao = new System.Windows.Forms.ComboBox();
            this.cboDanToc = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(21, 69);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(70, 16);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Ho va Ten";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(183, 142);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(245, 22);
            this.txtCMND.TabIndex = 1;
            // 
            // dTPNgaySinh
            // 
            this.dTPNgaySinh.Location = new System.Drawing.Point(183, 407);
            this.dTPNgaySinh.Name = "dTPNgaySinh";
            this.dTPNgaySinh.Size = new System.Drawing.Size(200, 22);
            this.dTPNgaySinh.TabIndex = 2;
            this.dTPNgaySinh.ValueChanged += new System.EventHandler(this.dTPNgaySinh_ValueChanged);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(51, 470);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblQueQuan
            // 
            this.lblQueQuan.AutoSize = true;
            this.lblQueQuan.Location = new System.Drawing.Point(21, 107);
            this.lblQueQuan.Name = "lblQueQuan";
            this.lblQueQuan.Size = new System.Drawing.Size(67, 16);
            this.lblQueQuan.TabIndex = 5;
            this.lblQueQuan.Text = "Que Quan";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(24, 148);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(49, 16);
            this.lblDiaChi.TabIndex = 6;
            this.lblDiaChi.Text = "Địa Chỉ";
            // 
            // lblNamSinh
            // 
            this.lblNamSinh.AutoSize = true;
            this.lblNamSinh.Location = new System.Drawing.Point(24, 412);
            this.lblNamSinh.Name = "lblNamSinh";
            this.lblNamSinh.Size = new System.Drawing.Size(143, 16);
            this.lblNamSinh.TabIndex = 7;
            this.lblNamSinh.Text = "Ngay Thang Nam Sinh";
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(183, 101);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(245, 22);
            this.txtQueQuan.TabIndex = 8;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(183, 63);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(245, 22);
            this.txtHoTen.TabIndex = 9;
            // 
            // btnXoa
            // 
            this.btnXoa.Enabled = false;
            this.btnXoa.Location = new System.Drawing.Point(233, 470);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Enabled = false;
            this.btnSua.Location = new System.Drawing.Point(422, 470);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(183, 18);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(245, 22);
            this.txtID.TabIndex = 13;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(21, 18);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 16);
            this.lblID.TabIndex = 12;
            this.lblID.Text = "ID";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(24, 189);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(183, 183);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(245, 22);
            this.txtEmail.TabIndex = 16;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(24, 238);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(34, 16);
            this.lblSDT.TabIndex = 19;
            this.lblSDT.Text = "SĐT";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(183, 232);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(245, 22);
            this.txtSDT.TabIndex = 18;
            // 
            // lblDanToc
            // 
            this.lblDanToc.AutoSize = true;
            this.lblDanToc.Location = new System.Drawing.Point(24, 278);
            this.lblDanToc.Name = "lblDanToc";
            this.lblDanToc.Size = new System.Drawing.Size(59, 16);
            this.lblDanToc.TabIndex = 21;
            this.lblDanToc.Text = "Dân Tộc";
            // 
            // lblTonGiao
            // 
            this.lblTonGiao.AutoSize = true;
            this.lblTonGiao.Location = new System.Drawing.Point(24, 321);
            this.lblTonGiao.Name = "lblTonGiao";
            this.lblTonGiao.Size = new System.Drawing.Size(63, 16);
            this.lblTonGiao.TabIndex = 23;
            this.lblTonGiao.Text = "Tôn Giáo";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(24, 361);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(60, 16);
            this.lblGioiTinh.TabIndex = 24;
            this.lblGioiTinh.Text = "Giới Tính";
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cboGioiTinh.Location = new System.Drawing.Point(183, 352);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(125, 24);
            this.cboGioiTinh.TabIndex = 25;
            // 
            // cboTonGiao
            // 
            this.cboTonGiao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTonGiao.FormattingEnabled = true;
            this.cboTonGiao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboTonGiao.Items.AddRange(new object[] {
            "Không",
            "Phật giáo",
            "Thiên chúa giáo",
            "Công giáo Rôma",
            "Hòa hảo",
            "Cao đài",
            "Hồi giáo",
            "Tin Lành",
            "Baháí",
            "Hindu",
            "Sikh"});
            this.cboTonGiao.Location = new System.Drawing.Point(183, 313);
            this.cboTonGiao.Name = "cboTonGiao";
            this.cboTonGiao.Size = new System.Drawing.Size(125, 24);
            this.cboTonGiao.TabIndex = 26;
            // 
            // cboDanToc
            // 
            this.cboDanToc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDanToc.FormattingEnabled = true;
            this.cboDanToc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboDanToc.Items.AddRange(new object[] {
            "Kinh",
            "Tày",
            "Thái",
            "Mường",
            "Khmer",
            "Hoa",
            "Nùng",
            "H\'Mông",
            "Dao",
            "Gia Rai",
            "Ê Đê",
            "Ba Na",
            "Sán Chay",
            "Chăm",
            "Kơ Ho",
            "Xơ Đăng",
            "Sán Dìu",
            "Hrê",
            "Ra Glai",
            "Mnông",
            "Thổ",
            "Stiêng",
            "Khơ mú",
            "Bru - Vân Kiều",
            "Cơ Tu",
            "Giáy",
            "Tà Ôi",
            "Mạ",
            "Giẻ-Triêng",
            "Co",
            "Chơ Ro",
            "Xinh Mun",
            "Hà Nhì",
            "Chu Ru",
            "Lào",
            "La Chí",
            "Kháng",
            "Phù Lá",
            "La Hủ",
            "La Ha",
            "Pà Thẻn",
            "Lự",
            "Ngái",
            "Chứt",
            "Lô Lô",
            "Mảng",
            "Cơ Lao",
            "Bố Y",
            "Cống",
            "Si La",
            "Pu Péo",
            "Rơ Măm",
            "Brâu",
            "Ơ Đu"});
            this.cboDanToc.Location = new System.Drawing.Point(183, 275);
            this.cboDanToc.Name = "cboDanToc";
            this.cboDanToc.Size = new System.Drawing.Size(125, 24);
            this.cboDanToc.TabIndex = 27;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(447, 18);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 28;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click_1);
            // 
            // FCongDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 535);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.cboDanToc);
            this.Controls.Add(this.cboTonGiao);
            this.Controls.Add(this.cboGioiTinh);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblTonGiao);
            this.Controls.Add(this.lblDanToc);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtQueQuan);
            this.Controls.Add(this.lblNamSinh);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblQueQuan);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dTPNgaySinh);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.lblHoTen);
            this.Name = "FCongDan";
            this.Text = "Quản Lý Công Dân";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.DateTimePicker dTPNgaySinh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblQueQuan;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblNamSinh;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblDanToc;
        private System.Windows.Forms.Label lblTonGiao;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.ComboBox cboTonGiao;
        private System.Windows.Forms.ComboBox cboDanToc;
        private System.Windows.Forms.Button btnTimKiem;
    }
}

