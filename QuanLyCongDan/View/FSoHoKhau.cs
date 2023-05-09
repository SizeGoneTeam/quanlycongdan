using QuanLyCongDan.DAO;
using QuanLyCongDan.Model;
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

namespace QuanLyCongDan.View
{
    public partial class FSoHoKhau : Form
    {
        private SoHoKhauDAO dao = new SoHoKhauDAO();
        private SoHoKhauThanhVienDAO thanhVienDAO = new SoHoKhauThanhVienDAO();

        private FThanhVien fThanhVien = new FThanhVien();

        public FSoHoKhau()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            int id;

            if (int.TryParse(txtTimKiem.Text, out id))
            {
                SoHoKhau soHoKhau = dao.TimKiem(id);

                if (soHoKhau is null)
                {
                    MessageBox.Show("Không tìm thấy");
                    clear();
                }
                else
                {
                    txtID.Text = soHoKhau.ID.ToString();
                    txtIDHoSoHoKhau.Text = soHoKhau.IDHoSoHoKhau.ToString();
                    txtIDSoDangKyThuongTru.Text = soHoKhau.IDSoDangKyThuongTru;
                    txtIDToSo.Text = soHoKhau.IDToSo;
                    txtNoiThuongTru.Text = soHoKhau.NoiThuongTru;
                    pkNgayDangKy.Value = soHoKhau.NgayDangKy;

                    foreach (SoHoKhauThanhVien thanhVien in thanhVienDAO.LayDanhSach(soHoKhau.ID))
                    {
                        //fpnThanhVien.Controls.Add(new UCThanhVien(thanhVien));
                    }
                }
            }
            else
            {
                MessageBox.Show("ID Tìm kiếm không hợp lệ");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int idHoSoHoKhau;
            int.TryParse(txtIDHoSoHoKhau.Text, out idHoSoHoKhau);

            if (dao.Them(
                new SoHoKhau(
                    idHoSoHoKhau,
                    txtIDSoDangKyThuongTru.Text,
                    txtIDToSo.Text,
                    txtNoiThuongTru.Text,
                    pkNgayDangKy.Value.Date)))
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int idHoSoHoKhau;
            int.TryParse(txtIDHoSoHoKhau.Text, out idHoSoHoKhau);

            if (dao.Sua(
                new SoHoKhau(
                    int.Parse(txtID.Text),
                    idHoSoHoKhau,
                    txtIDSoDangKyThuongTru.Text,
                    txtIDToSo.Text,
                    txtNoiThuongTru.Text,
                    pkNgayDangKy.Value.Date)))
            {
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dao.Xoa(int.Parse(txtID.Text)))
            {
                MessageBox.Show("Xóa thành công");
                clear();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void clear()
        {
            txtID.Text = "";
            txtIDHoSoHoKhau.Text = "";
            txtIDSoDangKyThuongTru.Text = "";
            txtIDToSo.Text = "";
            txtNoiThuongTru.Text = "";
            pkNgayDangKy.Value = DateTime.Now;
            //fpnThanhVien.Controls.Clear();
        }

        private void btnThemThanhVien_Click(object sender, EventArgs e)
        {
            fThanhVien.ModeAdd();
            fThanhVien.ShowDialog();
            if (!fThanhVien.Canceled)
            {
                gvThanhVien.Rows.Add(
                    fThanhVien.ThanhVien.CongDan.Id, 
                    fThanhVien.ThanhVien.CongDan.HoTen, 
                    fThanhVien.ThanhVien.QuanHe,
                    fThanhVien.ThanhVien.NgheNghiepNoiLamViec,
                    fThanhVien.ThanhVien.NoiThuongTruTruoc,
                    fThanhVien.ThanhVien.CanBoDangKy,
                    fThanhVien.ThanhVien.NgayDangKy.ToShortDateString());
            }
        }
        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "  ID")
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Black;
            }
        }

        private void txtIDHoSoHoKhau_Enter(object sender, EventArgs e)
        {
            if (txtIDHoSoHoKhau.Text == "  Số Hồ Sơ")
            {
                txtIDHoSoHoKhau.Text = "";
                txtIDHoSoHoKhau.ForeColor = Color.Black;
            }
        }

        private void txtNoiThuongTru_Enter(object sender, EventArgs e)
        {
            if (txtNoiThuongTru.Text == "  Nơi Thường Trú")
            {
                txtNoiThuongTru.Text = "";
                txtNoiThuongTru.ForeColor = Color.Black;
            }
        }

        private void txtIDSoDangKyThuongTru_Enter(object sender, EventArgs e)
        {
            if (txtIDSoDangKyThuongTru.Text == "  Số Sổ Đăng Ký Thường Trú")
            {
                txtIDSoDangKyThuongTru.Text = "";
                txtIDSoDangKyThuongTru.ForeColor = Color.Black;
            }
        }

        private void txtIDToSo_Enter(object sender, EventArgs e)
        {
            if (txtIDToSo.Text == "  Tờ Số")
            {
                txtIDToSo.Text = "";
                txtIDToSo.ForeColor = Color.Black;
            }
        }

        private void gvThanhVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                fThanhVien.ModeUpdate();
                fThanhVien.ShowDialog();
            }
        }
    }
}
