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
        private CongDanDAO congDanDao = new CongDanDAO();
        private CCCDDAO cccdDao = new CCCDDAO();

        private bool isAddMode;

        public FKhaiTu()
        {
            InitializeComponent();
        }

        #region Events
        private void FKhaiTu_Load(object sender, EventArgs e)
        {
            LoadTheme();
            switchToAddMode();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (isAddMode)
            {
                updateFromContent();
                if (isEnoughContext() && !isDublicate())
                {
                    if (khaiTuDAO.Them(khaiTu))
                    {
                        MessageBox.Show("Thêm thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại!");
                    }
                }
            }
            else
            {
                switchToAddMode();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            updateFromContent();
            if (!isInAddMode() && isEnoughContext() && !isDublicate())
            {
                if (khaiTuDAO.Sua(khaiTu))
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
            if (isAddMode)
            {
                MessageBox.Show("Đang ở add mode!");
            }
            else
            {
                if (isEnoughContext() && !isDublicate())
                {
                    if (khaiTuDAO.Xoa(khaiTu.ID))
                    {
                        MessageBox.Show("Xóa thành công!");
                        khaiTu = null;
                        updateContent();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!");
                    }
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
                }
                else
                {
                    switchToEditMode();
                }
            }
            else
            {
                MessageBox.Show("ID không hợp lệ!");
                khaiTu = null;
            }
            updateContent();
        }

        private void btnTimKiemCongDan_Click(object sender, EventArgs e)
        {
            string cccd = txtCCCDCongDan.Text;
            int id = cccdDao.toIdCongDan(cccd);
            congDan = congDanDao.TimKiem(id.ToString());

            if (congDan is null)
            {
                MessageBox.Show("Không tìm thấy");
            }
            else
            {
                updateContentCongDan();
            }
        }

        private void btnTimKiemNguoiYeuCau_Click(object sender, EventArgs e)
        {
            string cccd = txtCCCDNguoiYeuCau.Text;
            int id = cccdDao.toIdCongDan(cccd);
            nguoiYeuCau = congDanDao.TimKiem(id.ToString());
            if (nguoiYeuCau is null)
            {
                MessageBox.Show("Không tìm thấy");
            }
            updateContentNguoiYeuCau();
        }
        #endregion

        #region Methods
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
        }

        private bool isEnoughContext()
        {
            if (congDan is null || nguoiYeuCau == null || khaiTu is null)
            {
                MessageBox.Show("Thiếu thông tin");
                return false;
            }
            return true;
        }

        private bool isDublicate()
        {
            if (congDan.Id == nguoiYeuCau.Id)
            {
                MessageBox.Show("Người yêu cầu không là người tử!");

                congDan = null;
                nguoiYeuCau = null;

                updateContentCongDan();
                updateContentNguoiYeuCau();
                return true;
            }
            return false;
        }

        private bool isInAddMode()
        {
            if (isAddMode)
            {
                MessageBox.Show("Đang ở add mode!");
                return true;
            }
            return false;
        }

        private void switchToAddMode()
        {
            isAddMode = true;

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void switchToEditMode()
        {
            isAddMode = false;

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void updateFromContent()
        {
            if (isAddMode && khaiTu is null)
            {
                khaiTu = new KhaiTu();
            }
            khaiTu.QuanHe = txtQuanHe.Text;
            khaiTu.NoiChet = txtNoiChet.Text;
            khaiTu.ThoiGianChet = pkThoiGianChet.Value;
            khaiTu.NoiDangKy = txtNoiDangKy.Text;
            khaiTu.NgayThucHien = pkNgayThucHien.Value;
            khaiTu.IDCongDan = int.Parse(congDan.Id);
            khaiTu.IDNguoiYeuCau = int.Parse(nguoiYeuCau.Id);
        }

        private void updateContent()
        {
            txtTimKiem.Text = "";
            txtQuanHe.Text = khaiTu is null ? "" : khaiTu.QuanHe;
            txtNoiChet.Text = khaiTu is null ? "" : khaiTu.NoiChet;
            txtNoiDangKy.Text = khaiTu is null ? "" : khaiTu.NoiDangKy;
            txtNguyenNhan.Text = khaiTu is null ? "" : khaiTu.NguyenNhan;
            pkThoiGianChet.Value = khaiTu is null ? DateTime.Now : khaiTu.ThoiGianChet;
            pkNgayThucHien.Value = khaiTu is null ? DateTime.Now : khaiTu.NgayThucHien;

            congDan = khaiTu is null ? null : congDanDao.TimKiem(khaiTu.IDCongDan.ToString());
            nguoiYeuCau = khaiTu is null ? null : congDanDao.TimKiem(khaiTu.IDNguoiYeuCau.ToString());

            updateContentCongDan();
            updateContentNguoiYeuCau();
        }

        private void updateContentCongDan()
        {
            txtCCCDCongDan.Text = "";
            txtHoVaTenCongDan.Text = congDan is null ? "" : congDan.HoTen;
        }

        private void updateContentNguoiYeuCau()
        {
            txtCCCDNguoiYeuCau.Text = "";
            txtHoVaTenNguoiYeuCau.Text = nguoiYeuCau is null ? "" : nguoiYeuCau.HoTen;
        }
        #endregion
    }
}
