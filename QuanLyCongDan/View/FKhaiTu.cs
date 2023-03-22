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
using Week2;

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

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (congDan != null && nguoiYeuCau != null)
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
            else
            {
                MessageBox.Show("Thiếu thông tin!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (khaiTu != null && congDan != null && nguoiYeuCau != null)
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
            else
            {
                MessageBox.Show("Thiếu thông tin!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (khaiTu != null)
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
            else
            {
                MessageBox.Show("Xóa thất bại!");
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

                    Controls.Clear();
                    InitializeComponent();
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

                Controls.Clear();
                InitializeComponent();
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
    }
}
