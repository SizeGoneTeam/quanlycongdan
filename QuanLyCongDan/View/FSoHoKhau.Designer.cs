namespace QuanLyCongDan.View
{
    partial class FSoHoKhau
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
            this.pkNgayDangKy = new System.Windows.Forms.DateTimePicker();
            this.txtIDToSo = new System.Windows.Forms.TextBox();
            this.txtIDSoDangKyThuongTru = new System.Windows.Forms.TextBox();
            this.txtNoiThuongTru = new System.Windows.Forms.TextBox();
            this.txtIDHoSoHoKhau = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThemThanhVien = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gvThanhVien = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ID_CongDan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoVaTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuanHe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgheNghiep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiThuongTruTruoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CanBoDangKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDangKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvThanhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTimKiem.Location = new System.Drawing.Point(523, 119);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(138, 37);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.Location = new System.Drawing.Point(73, 126);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(363, 30);
            this.txtTimKiem.TabIndex = 2;
            this.txtTimKiem.Text = "  ID";
            this.txtTimKiem.Enter += new System.EventHandler(this.txtTimKiem_Enter);
            // 
            // pkNgayDangKy
            // 
            this.pkNgayDangKy.Location = new System.Drawing.Point(73, 330);
            this.pkNgayDangKy.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.pkNgayDangKy.Name = "pkNgayDangKy";
            this.pkNgayDangKy.Size = new System.Drawing.Size(363, 30);
            this.pkNgayDangKy.TabIndex = 7;
            // 
            // txtIDToSo
            // 
            this.txtIDToSo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDToSo.Location = new System.Drawing.Point(481, 270);
            this.txtIDToSo.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtIDToSo.Name = "txtIDToSo";
            this.txtIDToSo.Size = new System.Drawing.Size(180, 30);
            this.txtIDToSo.TabIndex = 6;
            this.txtIDToSo.Text = "  Tờ Số";
            this.txtIDToSo.Enter += new System.EventHandler(this.txtIDToSo_Enter);
            // 
            // txtIDSoDangKyThuongTru
            // 
            this.txtIDSoDangKyThuongTru.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDSoDangKyThuongTru.Location = new System.Drawing.Point(73, 270);
            this.txtIDSoDangKyThuongTru.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtIDSoDangKyThuongTru.Name = "txtIDSoDangKyThuongTru";
            this.txtIDSoDangKyThuongTru.Size = new System.Drawing.Size(363, 30);
            this.txtIDSoDangKyThuongTru.TabIndex = 6;
            this.txtIDSoDangKyThuongTru.Text = "  Số Sổ Đăng Ký Thường Trú";
            this.txtIDSoDangKyThuongTru.Enter += new System.EventHandler(this.txtIDSoDangKyThuongTru_Enter);
            // 
            // txtNoiThuongTru
            // 
            this.txtNoiThuongTru.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoiThuongTru.Location = new System.Drawing.Point(73, 222);
            this.txtNoiThuongTru.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtNoiThuongTru.Name = "txtNoiThuongTru";
            this.txtNoiThuongTru.Size = new System.Drawing.Size(363, 30);
            this.txtNoiThuongTru.TabIndex = 6;
            this.txtNoiThuongTru.Text = "  Nơi Thường Trú";
            this.txtNoiThuongTru.Enter += new System.EventHandler(this.txtNoiThuongTru_Enter);
            // 
            // txtIDHoSoHoKhau
            // 
            this.txtIDHoSoHoKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDHoSoHoKhau.Location = new System.Drawing.Point(73, 174);
            this.txtIDHoSoHoKhau.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtIDHoSoHoKhau.Name = "txtIDHoSoHoKhau";
            this.txtIDHoSoHoKhau.Size = new System.Drawing.Size(363, 30);
            this.txtIDHoSoHoKhau.TabIndex = 5;
            this.txtIDHoSoHoKhau.Text = "  Số Hồ Sơ";
            this.txtIDHoSoHoKhau.Enter += new System.EventHandler(this.txtIDHoSoHoKhau_Enter);
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Location = new System.Drawing.Point(481, 222);
            this.txtID.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(180, 30);
            this.txtID.TabIndex = 2;
            this.txtID.Text = "  Số Hộ Khẩu";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoa.Location = new System.Drawing.Point(523, 584);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(6);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(138, 40);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSua.Location = new System.Drawing.Point(300, 584);
            this.btnSua.Margin = new System.Windows.Forms.Padding(6);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(138, 40);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.Location = new System.Drawing.Point(73, 584);
            this.btnThem.Margin = new System.Windows.Forms.Padding(6);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(138, 40);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThemThanhVien
            // 
            this.btnThemThanhVien.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnThemThanhVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemThanhVien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThemThanhVien.Location = new System.Drawing.Point(485, 330);
            this.btnThemThanhVien.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.btnThemThanhVien.Name = "btnThemThanhVien";
            this.btnThemThanhVien.Size = new System.Drawing.Size(176, 33);
            this.btnThemThanhVien.TabIndex = 4;
            this.btnThemThanhVien.Text = "Thêm thành viên";
            this.btnThemThanhVien.UseVisualStyleBackColor = false;
            this.btnThemThanhVien.Click += new System.EventHandler(this.btnThemThanhVien_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Salmon;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(239, 78);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 719);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.gvThanhVien);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pkNgayDangKy);
            this.panel2.Controls.Add(this.btnTimKiem);
            this.panel2.Controls.Add(this.txtIDToSo);
            this.panel2.Controls.Add(this.txtTimKiem);
            this.panel2.Controls.Add(this.btnThemThanhVien);
            this.panel2.Controls.Add(this.txtIDHoSoHoKhau);
            this.panel2.Controls.Add(this.txtIDSoDangKyThuongTru);
            this.panel2.Controls.Add(this.txtNoiThuongTru);
            this.panel2.Location = new System.Drawing.Point(21, 19);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(730, 674);
            this.panel2.TabIndex = 16;
            // 
            // gvThanhVien
            // 
            this.gvThanhVien.AllowUserToAddRows = false;
            this.gvThanhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvThanhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_CongDan,
            this.HoVaTen,
            this.QuanHe,
            this.NgheNghiep,
            this.NoiThuongTruTruoc,
            this.CanBoDangKy,
            this.NgayDangKy});
            this.gvThanhVien.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gvThanhVien.Location = new System.Drawing.Point(73, 386);
            this.gvThanhVien.Name = "gvThanhVien";
            this.gvThanhVien.RowHeadersWidth = 51;
            this.gvThanhVien.Size = new System.Drawing.Size(588, 169);
            this.gvThanhVien.TabIndex = 9;
            this.gvThanhVien.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvThanhVien_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(79, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ngày Đăng Ký:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(219, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(299, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Điền Thông Tin Để Tra Khảo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(232, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thông Tin Hộ Khẩu";
            // 
            // ID_CongDan
            // 
            this.ID_CongDan.HeaderText = "ID_CongDan";
            this.ID_CongDan.MinimumWidth = 6;
            this.ID_CongDan.Name = "ID_CongDan";
            this.ID_CongDan.Visible = false;
            this.ID_CongDan.Width = 125;
            // 
            // HoVaTen
            // 
            this.HoVaTen.HeaderText = "Họ và tên";
            this.HoVaTen.MinimumWidth = 6;
            this.HoVaTen.Name = "HoVaTen";
            this.HoVaTen.Width = 125;
            // 
            // QuanHe
            // 
            this.QuanHe.HeaderText = "Quan Hệ";
            this.QuanHe.MinimumWidth = 6;
            this.QuanHe.Name = "QuanHe";
            this.QuanHe.Width = 125;
            // 
            // NgheNghiep
            // 
            this.NgheNghiep.HeaderText = "Nghề Nghiệp";
            this.NgheNghiep.MinimumWidth = 6;
            this.NgheNghiep.Name = "NgheNghiep";
            this.NgheNghiep.Width = 125;
            // 
            // NoiThuongTruTruoc
            // 
            this.NoiThuongTruTruoc.HeaderText = "Nơi thường trú trước";
            this.NoiThuongTruTruoc.MinimumWidth = 6;
            this.NoiThuongTruTruoc.Name = "NoiThuongTruTruoc";
            this.NoiThuongTruTruoc.Width = 125;
            // 
            // CanBoDangKy
            // 
            this.CanBoDangKy.HeaderText = "Cán bộ đăng ký";
            this.CanBoDangKy.MinimumWidth = 6;
            this.CanBoDangKy.Name = "CanBoDangKy";
            this.CanBoDangKy.Width = 125;
            // 
            // NgayDangKy
            // 
            this.NgayDangKy.HeaderText = "Ngày đăng ký";
            this.NgayDangKy.MinimumWidth = 6;
            this.NgayDangKy.Name = "NgayDangKy";
            this.NgayDangKy.Width = 125;
            // 
            // FSoHoKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1237, 876);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FSoHoKhau";
            this.Text = "Quản Lý Sổ Hộ Khẩu";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvThanhVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtIDHoSoHoKhau;
        private System.Windows.Forms.TextBox txtNoiThuongTru;
        private System.Windows.Forms.TextBox txtIDSoDangKyThuongTru;
        private System.Windows.Forms.TextBox txtIDToSo;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DateTimePicker pkNgayDangKy;
        private System.Windows.Forms.Button btnThemThanhVien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gvThanhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CongDan;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoVaTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuanHe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgheNghiep;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiThuongTruTruoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn CanBoDangKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDangKy;
    }
}