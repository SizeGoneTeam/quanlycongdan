namespace QuanLyCongDan
{
    partial class FHonNhan
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
            this.btnTimKiemChong = new System.Windows.Forms.Button();
            this.txtID_Chong = new System.Windows.Forms.TextBox();
            this.lblID_Chong = new System.Windows.Forms.Label();
            this.lblNgaySinhChong = new System.Windows.Forms.Label();
            this.lblHoTenChong = new System.Windows.Forms.Label();
            this.btnTimKiemVo = new System.Windows.Forms.Button();
            this.txtID_Vo = new System.Windows.Forms.TextBox();
            this.lblID_Vo = new System.Windows.Forms.Label();
            this.lblNgaySinhVo = new System.Windows.Forms.Label();
            this.lblHoTenVo = new System.Windows.Forms.Label();
            this.cboNoiDK = new System.Windows.Forms.ComboBox();
            this.lblNoiDK = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTimKiemChong
            // 
            this.btnTimKiemChong.Location = new System.Drawing.Point(212, 21);
            this.btnTimKiemChong.Name = "btnTimKiemChong";
            this.btnTimKiemChong.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiemChong.TabIndex = 37;
            this.btnTimKiemChong.Text = "Tìm Kiếm";
            this.btnTimKiemChong.UseVisualStyleBackColor = true;
            this.btnTimKiemChong.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtID_Chong
            // 
            this.txtID_Chong.Location = new System.Drawing.Point(89, 21);
            this.txtID_Chong.Name = "txtID_Chong";
            this.txtID_Chong.Size = new System.Drawing.Size(67, 22);
            this.txtID_Chong.TabIndex = 36;
            // 
            // lblID_Chong
            // 
            this.lblID_Chong.AutoSize = true;
            this.lblID_Chong.Location = new System.Drawing.Point(28, 24);
            this.lblID_Chong.Name = "lblID_Chong";
            this.lblID_Chong.Size = new System.Drawing.Size(20, 16);
            this.lblID_Chong.TabIndex = 35;
            this.lblID_Chong.Text = "ID";
            // 
            // lblNgaySinhChong
            // 
            this.lblNgaySinhChong.AutoSize = true;
            this.lblNgaySinhChong.Location = new System.Drawing.Point(28, 113);
            this.lblNgaySinhChong.Name = "lblNgaySinhChong";
            this.lblNgaySinhChong.Size = new System.Drawing.Size(0, 16);
            this.lblNgaySinhChong.TabIndex = 31;
            // 
            // lblHoTenChong
            // 
            this.lblHoTenChong.AutoSize = true;
            this.lblHoTenChong.Location = new System.Drawing.Point(28, 84);
            this.lblHoTenChong.Name = "lblHoTenChong";
            this.lblHoTenChong.Size = new System.Drawing.Size(0, 16);
            this.lblHoTenChong.TabIndex = 29;
            // 
            // btnTimKiemVo
            // 
            this.btnTimKiemVo.Location = new System.Drawing.Point(212, 182);
            this.btnTimKiemVo.Name = "btnTimKiemVo";
            this.btnTimKiemVo.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiemVo.TabIndex = 40;
            this.btnTimKiemVo.Text = "Tìm Kiếm";
            this.btnTimKiemVo.UseVisualStyleBackColor = true;
            this.btnTimKiemVo.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtID_Vo
            // 
            this.txtID_Vo.Location = new System.Drawing.Point(92, 183);
            this.txtID_Vo.Name = "txtID_Vo";
            this.txtID_Vo.Size = new System.Drawing.Size(67, 22);
            this.txtID_Vo.TabIndex = 39;
            // 
            // lblID_Vo
            // 
            this.lblID_Vo.AutoSize = true;
            this.lblID_Vo.Location = new System.Drawing.Point(31, 186);
            this.lblID_Vo.Name = "lblID_Vo";
            this.lblID_Vo.Size = new System.Drawing.Size(20, 16);
            this.lblID_Vo.TabIndex = 38;
            this.lblID_Vo.Text = "ID";
            // 
            // lblNgaySinhVo
            // 
            this.lblNgaySinhVo.AutoSize = true;
            this.lblNgaySinhVo.Location = new System.Drawing.Point(31, 275);
            this.lblNgaySinhVo.Name = "lblNgaySinhVo";
            this.lblNgaySinhVo.Size = new System.Drawing.Size(0, 16);
            this.lblNgaySinhVo.TabIndex = 42;
            // 
            // lblHoTenVo
            // 
            this.lblHoTenVo.AutoSize = true;
            this.lblHoTenVo.Location = new System.Drawing.Point(31, 246);
            this.lblHoTenVo.Name = "lblHoTenVo";
            this.lblHoTenVo.Size = new System.Drawing.Size(0, 16);
            this.lblHoTenVo.TabIndex = 41;
            // 
            // cboNoiDK
            // 
            this.cboNoiDK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNoiDK.FormattingEnabled = true;
            this.cboNoiDK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboNoiDK.Items.AddRange(new object[] {
            "An Giang",
            "Bà Rịa – Vũng Tàu",
            "Bắc Giang",
            "Bắc Kạn",
            "Bạc Liêu",
            "Bắc Ninh",
            "Bến Tre",
            "Bình Định",
            "Bình Dương",
            "Bình Phước",
            "Bình Thuận",
            "Cà Mau",
            "Cần Thơ",
            "Cao Bằng",
            "Đà Nẵng",
            "Đắk Lắk",
            "Đắk Nông",
            "Điện Biên",
            "Đồng Nai",
            "Đồng Tháp",
            "Gia Lai",
            "Hà Giang",
            "Hà Nam",
            "Hà Nội",
            "Hà Tĩnh",
            "Hải Dương",
            "Hải Phòng",
            "Hậu Giang",
            "Hòa Bình",
            "Hưng Yên",
            "Khánh Hòa",
            "Kiên Giang",
            "Kon Tum",
            "Lai Châu",
            "Lâm Đồng",
            "Lạng Sơn",
            "Lào Cai",
            "Long An",
            "Nam Định",
            "Nghệ An",
            "Ninh Bình",
            "Ninh Thuận",
            "Phú Thọ",
            "Phú Yên",
            "Quảng Bình",
            "Quảng Nam",
            "Quảng Ngãi",
            "Quảng Ninh",
            "Quảng Trị",
            "Sóc Trăng",
            "Sơn La",
            "Tây Ninh",
            "Thái Bình",
            "Thái Nguyên",
            "Thanh Hóa",
            "Thừa Thiên Huế",
            "Tiền Giang",
            "TP Hồ Chí Minh",
            "Trà Vinh",
            "Tuyên Quang",
            "Vĩnh Long",
            "Vĩnh Phúc",
            "Yên Bái"});
            this.cboNoiDK.Location = new System.Drawing.Point(121, 352);
            this.cboNoiDK.Name = "cboNoiDK";
            this.cboNoiDK.Size = new System.Drawing.Size(166, 24);
            this.cboNoiDK.TabIndex = 44;
            // 
            // lblNoiDK
            // 
            this.lblNoiDK.AutoSize = true;
            this.lblNoiDK.Location = new System.Drawing.Point(28, 360);
            this.lblNoiDK.Name = "lblNoiDK";
            this.lblNoiDK.Size = new System.Drawing.Size(79, 16);
            this.lblNoiDK.TabIndex = 43;
            this.lblNoiDK.Text = "Nơi đăng ký";
            // 
            // FHonNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 450);
            this.Controls.Add(this.cboNoiDK);
            this.Controls.Add(this.lblNoiDK);
            this.Controls.Add(this.lblNgaySinhVo);
            this.Controls.Add(this.lblHoTenVo);
            this.Controls.Add(this.btnTimKiemVo);
            this.Controls.Add(this.txtID_Vo);
            this.Controls.Add(this.lblID_Vo);
            this.Controls.Add(this.btnTimKiemChong);
            this.Controls.Add(this.txtID_Chong);
            this.Controls.Add(this.lblID_Chong);
            this.Controls.Add(this.lblNgaySinhChong);
            this.Controls.Add(this.lblHoTenChong);
            this.Name = "FHonNhan";
            this.Text = "FHonNhan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimKiemChong;
        private System.Windows.Forms.TextBox txtID_Chong;
        private System.Windows.Forms.Label lblID_Chong;
        private System.Windows.Forms.Label lblNgaySinhChong;
        private System.Windows.Forms.Label lblHoTenChong;
        private System.Windows.Forms.Button btnTimKiemVo;
        private System.Windows.Forms.TextBox txtID_Vo;
        private System.Windows.Forms.Label lblID_Vo;
        private System.Windows.Forms.Label lblNgaySinhVo;
        private System.Windows.Forms.Label lblHoTenVo;
        private System.Windows.Forms.ComboBox cboNoiDK;
        private System.Windows.Forms.Label lblNoiDK;
    }
}