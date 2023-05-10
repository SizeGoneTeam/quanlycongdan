using QuanLyCongDan.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongDan
{
    public partial class FKhaiSinh : Form
    {
        private KhaiSinh khaiSinh;
        private CongDan congDan;
        private CongDan nguoiMe;
        private CongDan nguoiCha;
        private CongDan nguoiYeuCau;

        /*private KhaiSinhDAO khaiSinhDao = new KhaiSinhDAO();
        private CongDanDAO congDanDao = new CongDanDAO();
        private CCCDDAO cccdDao = new CCCDDAO();*/

        private bool isAddMode;

        public FKhaiSinh()
        {
            InitializeComponent();
        }

        #region Events
        private void btnTimKiemNguoiYeuCau_Click(object sender, EventArgs e)
        {
            string cccd = txtCCCDNguoiYeuCau.Text;
            /*int id = cccdDao.toIdCongDan(cccd);
            nguoiYeuCau = congDanDao.TimKiem(id.ToString());*/

            if (nguoiYeuCau is null)
            {
                MessageBox.Show("Không tìm thấy");
            }
            else
            {
                updateContentNguoiYeuCau();
            }
        }

        private void btnTimKiemNguoiMe_Click(object sender, EventArgs e)
        {
            string cccd = txtCCCDNguoiMe.Text;
            /*int id = cccdDao.toIdCongDan(cccd);
            nguoiMe = congDanDao.TimKiem(id.ToString());*/

            if (nguoiMe is null || !isFemale())
            {
                MessageBox.Show("Không tìm thấy");
            }
            else
            {
                updateContentMe();
            }
        }

        private void btnTimKiemNguoiCha_Click(object sender, EventArgs e)
        {
            string cccd = txtCCCDNguoiCha.Text;
            /*int id = cccdDao.toIdCongDan(cccd);
            nguoiCha = congDanDao.TimKiem(id.ToString());*/

            if (nguoiCha is null || !isMale())
            {
                MessageBox.Show("Không tìm thấy");
            }
            else
            {
                updateContentCha();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            /*if (isAddMode)
            {
                updateFromContent();
                if (isEnoughContext())
                {
                    congDanDao.Them(congDan);
                    int count = congDanDao.LayDanhSachCongDan().Rows.Count;
                    congDan.Id = congDanDao.LayDanhSachCongDan().Rows[count - 1]["ID_CongDan"].ToString();
                    khaiSinh.IDCongDan = int.Parse(congDan.Id);
                    if (khaiSinhDao.Them(khaiSinh))
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
            }*/
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            /*updateFromContent();
            if (!isInAddMode() && isEnoughContext())
            {
                if (khaiSinhDao.Sua(khaiSinh))
                {
                    congDanDao.Sua(congDan);
                    MessageBox.Show("Sửa thành công!");
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!");
                }
            }*/
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            /*int id;

            if (int.TryParse(txtID.Text, out id))
            {
                khaiSinh = khaiSinhDao.TimKiem(id);
                if (khaiSinh is null)
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
                khaiSinh = null;
            }
            updateContent();*/
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            /*if (isAddMode)
            {
                MessageBox.Show("Đang ở add mode!");
            }
            else
            {
                if (isEnoughContext())
                {
                    if (khaiSinhDao.Xoa(khaiSinh.ID))
                    {
                        MessageBox.Show("Xóa thành công!");
                        khaiSinh = null;
                        updateContent();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!");
                    }
                }
            }*/
        }

        private void txtHoTen_Enter(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "  Họ Và Tên")
            {
                txtHoTen.Text = "";
                txtHoTen.ForeColor = Color.Black;
            }
        }

        private void FKhaiSinh_Load(object sender, EventArgs e)
        {
            dangky.Visible = true;
            cha.Visible = false;
            me.Visible = false;
            yc.Visible = false;

            switchToAddMode();
        }

        private void next_Click(object sender, EventArgs e)
        {
            dangky.Visible = false;
            me.Visible = true;
        }

        private void meprev_Click(object sender, EventArgs e)
        {
            dangky.Visible = true;
            me.Visible = false;
        }

        private void menext_Click(object sender, EventArgs e)
        {
            me.Visible= false;
            cha.Visible = true;
        }

        private void txtIDNguoiCha_Enter(object sender, EventArgs e)
        {
            if (txtCCCDNguoiCha.Text == "  ID")
            {
                txtCCCDNguoiCha.Text = "";
                txtCCCDNguoiCha.ForeColor = Color.Black;
            }
        }

        private void chaprev_Click(object sender, EventArgs e)
        {
            cha.Visible = false;
            me.Visible= true;
        }

        private void chanext_Click(object sender, EventArgs e)
        {
            cha.Visible= false;
            yc.Visible = true;
        }

        private void txtIDNguoiYeuCau_Enter(object sender, EventArgs e)
        {
            if (txtCCCDNguoiYeuCau.Text == "  ID")
            {
                txtCCCDNguoiYeuCau.Text = "";
                txtCCCDNguoiYeuCau.ForeColor = Color.Black;
            }
        }

        private void ycprev_Click(object sender, EventArgs e)
        {
            yc.Visible = false;
            cha.Visible= true;
        }

        private void ycnext_Click(object sender, EventArgs e)
        {
            yc.Visible= false;
            dangky.Visible = true;
        }
        #endregion

        #region Methods
        private bool isEnoughContext()
        {
            if (congDan is null || nguoiCha is null || nguoiMe is null || nguoiYeuCau is null || khaiSinh is null)
            {
                MessageBox.Show("Thiếu thông tin");
                return false;
            }
            return true;
        }

        private bool isMale()
        {
            if (nguoiCha.GioiTinh == "Nam")
            {
                return true;
            }
            return false;
        }

        private bool isFemale()
        {
            if (nguoiMe.GioiTinh == "Nữ")
            {
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
            if (isAddMode && khaiSinh is null)
            {
                khaiSinh = new KhaiSinh();
            }
            if (isAddMode && congDan is null)
            {
                congDan = new CongDan();
            }
            khaiSinh.NoiDangKy = txtNoiDangKy.Text;
            khaiSinh.NgayThucHien = pkNgayDangKy.Value;
            /*khaiSinh.IDNguoiYeuCau = nguoiYeuCau is null ? -1 : int.Parse(nguoiYeuCau.Id);
            khaiSinh.IDCha = nguoiCha is null ? -1 : int.Parse(nguoiCha.Id);
            khaiSinh.IDMe = nguoiMe is null ? -1 : int.Parse(nguoiMe.Id);*/
            congDan.HoTen = txtHoTen.Text;
            congDan.NgaySinh = pkNgaySinh.Value;
            congDan.NoiSinh = txtNoiSinh.Text;
            congDan.GioiTinh = cbGioiTinh.Text;
            congDan.QueQuan = txtQueQuan.Text;
            congDan.DanToc = cboDanToc.Text;
        }

        private void updateContent()
        {
            /*congDan = khaiSinh is null ? null : congDanDao.TimKiem(khaiSinh.IDCongDan.ToString());
            nguoiCha = khaiSinh is null ? null : congDanDao.TimKiem(khaiSinh.IDCha.ToString());
            nguoiMe = khaiSinh is null ? null : congDanDao.TimKiem(khaiSinh.IDMe.ToString());
            nguoiYeuCau = khaiSinh is null ? null : congDanDao.TimKiem(khaiSinh.IDNguoiYeuCau.ToString());
*/
            updateContentCongDan();
            updateContentCha();
            updateContentMe();
            updateContentNguoiYeuCau();
        }

        private void updateContentCongDan()
        {
            /*txtID.Text = "";
            txtHoTen.Text = congDan is null ? "" : congDan.HoTen;
            txtQuocTich.Text = congDan is null ? "" : "Việt Nam";
            pkNgaySinh.Value = congDan is null ? DateTime.Now : congDan.NgaySinh;
            txtNoiSinh.Text = congDan is null ? "" : congDan.NoiSinh;
            cbGioiTinh.Text = congDan is null ? "" : congDan.GioiTinh;
            txtQueQuan.Text = congDan is null ? "" : congDan.QueQuan;
            cboDanToc.Text = congDan is null ? "" : congDan.DanToc;
            txtNoiDangKy.Text = khaiSinh is null ? "" : khaiSinh.NoiDangKy;
            pkNgayDangKy.Value = khaiSinh is null ? DateTime.Now : khaiSinh.NgayThucHien;*/
        }

        private void updateContentCha()
        {
            /*txtCCCDNguoiCha.Text = "";
            txtHoTenNguoiCha.Text = nguoiCha is null ? "" : nguoiCha.HoTen;
            txtNamSinhNguoiCha.Text = nguoiCha is null ? "" : nguoiCha.NgaySinh.Year.ToString();
            txtDanTocNguoiCha.Text = nguoiCha is null ? "" : nguoiCha.DanToc;
            txtQuocTichNguoiCha.Text = nguoiCha is null ? "" : "Việt Nam";
            txtDiaChiNguoiCha.Text = nguoiCha is null ? "" : nguoiCha.NoiThuongTru;*/
        }

        private void updateContentMe()
        {
            /*txtCCCDNguoiMe.Text = "";
            txtHoTenNguoiMe.Text = nguoiMe is null ? "" : nguoiMe.HoTen;
            txtNamSinhNguoiMe.Text = nguoiMe is null ? "" : nguoiMe.NgaySinh.Year.ToString();
            txtDanTocNguoiMe.Text = nguoiMe is null ? "" : nguoiMe.DanToc;
            txtQuocTichNguoiMe.Text = nguoiMe is null ? "" : "Việt Nam";
            txtDiaChiNguoiMe.Text = nguoiMe is null ? "" : nguoiMe.NoiThuongTru;*/
        }

        private void updateContentNguoiYeuCau()
        {
            txtCCCDNguoiYeuCau.Text = "";
            txtHoTenNguoiYeuCau.Text = nguoiYeuCau is null ? "" : nguoiYeuCau.HoTen;
            txtDiaChiNguoiYeuCau.Text = nguoiYeuCau is null ? "" : nguoiYeuCau.NoiThuongTru;
            txtQuanHe.Text = khaiSinh is null ? "" : "Quan hệ";
        }
        #endregion
    }
}