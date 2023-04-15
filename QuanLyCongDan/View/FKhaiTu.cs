using QuanLyCongDan.DAO;
using QuanLyCongDan.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongDan.View
{
    public partial class FKhaiTu : Form
    {
        private KhaiTu khaiTu;
        private CongDan congDan;
        private CongDan nguoiYeuCau;

        private KhaiTuDAO khaiTuDAO = new KhaiTuDAO();
        private CongDanDAO congDanDAO = new CongDanDAO();

        public FKhaiTu()
        {
            InitializeComponent();
        }

        private void FKhaiTu_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void LoadTheme()
        {
            foreach (Control pns in this.Controls)
            {
                if (pns.GetType() == typeof(Panel))
                {
                    foreach (Control btns in pns.Controls)
                    {
                        if (btns.GetType() == typeof(Button))
                        {
                            Button btn = (Button)btns;
                            btn.BackColor = ThemeColor.PrimaryColor;
                            btn.ForeColor = Color.White;
                            btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                        }
                    }
                }
            }
            //label4.ForeColor = ThemeColor.SecondaryColor;
            //label5.ForeColor = ThemeColor.PrimaryColor;
        }

        #region Events
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (congDan is null || nguoiYeuCau is null)
            {
                MessageBox.Show("Thiếu thông tin!");
            }
            else if (congDan.Id == nguoiYeuCau.Id)
            {
                MessageBox.Show("Người yêu cầu không là người tử!");

                congDan = null;
                nguoiYeuCau = null;

                reload();
            }
            else
            {
                if (khaiTuDAO.Them(new KhaiTu(
                            int.Parse(congDan.Id),
                            int.Parse(nguoiYeuCau.Id),
                            txtQuanHe.Text,
                            pkThoiGianChet.Value,
                            txtNoiChet.Text,
                            txtNguyenNhan.Text,
                            txtNoiDangKy.Text,
                            pkNgayThucHien.Value.Date)
                        )
                    )
                {
                    MessageBox.Show("Thêm thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (congDan is null || nguoiYeuCau is null)
            {
                MessageBox.Show("Thiếu thông tin!");
            }
            else if (congDan.Id == nguoiYeuCau.Id)
            {
                MessageBox.Show("Người yêu cầu không là người tử!");

                congDan = null;
                nguoiYeuCau = null;

                reload();
            }
            else
            {
                if (khaiTuDAO.Sua(new KhaiTu(
                            khaiTu.ID,
                            int.Parse(congDan.Id),
                            int.Parse(nguoiYeuCau.Id),
                            txtQuanHe.Text,
                            pkThoiGianChet.Value,
                            txtNoiChet.Text,
                            txtNguyenNhan.Text,
                            txtNoiDangKy.Text,
                            pkNgayThucHien.Value.Date)
                        )
                    )
                {
                    MessageBox.Show("Sửa thành công!");
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (khaiTu is null)
            {
                MessageBox.Show("Chưa chọn khai tử!");
            }
            else
            {
                if (khaiTuDAO.Xoa(khaiTu.ID))
                {
                    MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            int iD;
            
            if (int.TryParse(txtTimKiem.Text, out iD))
            {
                khaiTu = khaiTuDAO.TimKiem(iD);
                if (khaiTu is null)
                {
                    MessageBox.Show("Không tìm thấy!");

                    reload();
                }
                else
                {
                    congDan = congDanDAO.TimKiem(khaiTu.IDCongDan.ToString());
                    nguoiYeuCau = congDanDAO.TimKiem(khaiTu.IDNguoiYeuCau.ToString());
                    
                    updateContent();
                }
            }
            else
            {
                MessageBox.Show("ID không hợp lệ!");

                khaiTu = null;
                congDan = null;
                nguoiYeuCau = null;

                reload();
            }
        }

        private void btnTimKiemCongDan_Click(object sender, EventArgs e)
        {
            int iD;
            
            if (int.TryParse(txtIDCongDan.Text, out iD))
            {
                congDan = congDanDAO.TimKiem(iD.ToString());

                updateContentCongDan();
            }
            else
            {
                MessageBox.Show("ID công dân không hợp lệ!");

                congDan = null;
                txtHoVaTenCongDan.Clear();
            }
        }

        private void btnTimKiemNguoiYeuCau_Click(object sender, EventArgs e)
        {
            int iD;

            if (int.TryParse(txtIDNguoiYeuCau.Text, out iD))
            {
                nguoiYeuCau = congDanDAO.TimKiem(iD.ToString());

                updateContentNguoiYeuCau();
            }
            else
            {
                MessageBox.Show("ID người yêu cầu không hợp lệ!");

                nguoiYeuCau = null;
                txtHoVaTenNguoiYeuCau.Clear();
            }
        }
        #endregion

        #region Methods
        private void updateContent()
        {
            txtQuanHe.Text = khaiTu.QuanHe;
            txtNoiChet.Text = khaiTu.NoiChet;
            txtNoiDangKy.Text = khaiTu.NoiDangKy;
            txtNguyenNhan.Text = khaiTu.NguyenNhan;
            pkThoiGianChet.Value = khaiTu.ThoiGianChet;
            pkNgayThucHien.Value = khaiTu.NgayThucHien;
            
            updateContentCongDan();
            updateContentNguoiYeuCau();
        }

        private void updateContentCongDan()
        {
            txtHoVaTenCongDan.Text = congDan.HoTen;
        }

        private void updateContentNguoiYeuCau()
        {
            txtHoVaTenNguoiYeuCau.Text = nguoiYeuCau.HoTen;
        }

        private void reload()
        {
            Controls.Clear();
            InitializeComponent();
        }
        #endregion

        private void txtHoVaTenCongDan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIDNguoiYeuCau_Enter(object sender, EventArgs e)
        {
            if (txtIDNguoiYeuCau.Text == "  ID Người Yêu Cầu")
            {
                txtIDNguoiYeuCau.Text = "";
                txtIDNguoiYeuCau.ForeColor = Color.Black;
            }
        }

        private void txtIDCongDan_Enter(object sender, EventArgs e)
        {
            if (txtIDCongDan.Text == "  ID Người Tử")
            {
                txtIDCongDan.Text = "";
                txtIDCongDan.ForeColor = Color.Black;
            }
        }

        private void txtQuanHe_Enter(object sender, EventArgs e)
        {
            if (txtQuanHe.Text == "  Quan Hệ")
            {
                txtQuanHe.Text = "";
                txtQuanHe.ForeColor = Color.Black;
            }
        }

        private void txtNoiChet_Enter(object sender, EventArgs e)
        {
            if (txtNoiChet.Text == "  Nơi Chết")
            {
                txtNoiChet.Text = "";
                txtNoiChet.ForeColor = Color.Black;
            }
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "  Số Khai Tử")
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Black;
            }
        }

        private void txtNoiDangKy_Enter(object sender, EventArgs e)
        {
            if (txtNoiDangKy.Text == "  Nơi Đăng Ký")
            {
                txtNoiDangKy.Text = "";
                txtNoiDangKy.ForeColor = Color.Black;
            }
        }
    }
}
