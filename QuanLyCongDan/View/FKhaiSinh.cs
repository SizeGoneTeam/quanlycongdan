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

namespace QuanLyCongDan
{
    public partial class FKhaiSinh : Form
    {

        KhaiSinhDAO dao = new KhaiSinhDAO();
        CongDanDAO congDanDAO = new CongDanDAO();

        public FKhaiSinh()
        {
            InitializeComponent();
        }

        private void btnTimKiemNguoiYeuCau_Click(object sender, EventArgs e)
        {
            int id;

            if (int.TryParse(txtIDNguoiYeuCau.Text, out id))
            {
                CongDan dt = congDanDAO.TimKiem(id.ToString());
                if (dt != null)
                {
                    txtHoTenNguoiYeuCau.Text = dt.HoTen;
                    txtDiaChiNguoiYeuCau.Text = dt.QueQuan;
                    txtCCCDNguoiYeuCau.Text = dt.Id;
                }
            }
        }

        private void btnTimKiemNguoiMe_Click(object sender, EventArgs e)
        {
            int id;

            if (int.TryParse(txtIDNguoiMe.Text, out id))
            {
                CongDan dt = congDanDAO.TimKiem(id.ToString());
                if (dt != null)
                {
                    txtHoTenNguoiMe.Text = dt.HoTen;
                    txtNamSinhNguoiMe.Text = dt.NgaySinh.Year.ToString();
                    txtDanTocNguoiMe.Text = dt.DanToc;
                    txtQuocTichNguoiMe.Text = "";
                    txtDiaChiNguoiMe.Text = dt.QueQuan;
                }
            }
        }

        private void btnTimKiemNguoiCha_Click(object sender, EventArgs e)
        {
            int id;

            if (int.TryParse(txtIDNguoiCha.Text, out id))
            {
                CongDan dt = congDanDAO.TimKiem(id.ToString());
                if (dt != null)
                {
                    txtHoTenNguoiCha.Text = dt.HoTen;
                    txtNamSinhNguoiCha.Text = dt.NgaySinh.Year.ToString();
                    txtDanTocNguoiCha.Text = dt.DanToc;
                    txtQuocTichNguoiCha.Text = "";
                    txtDiaChiNguoiCha.Text = dt.QueQuan;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            CongDan cd = new CongDan(txtHoTen.Text, txtQueQuan.Text, cbGioiTinh.Text, pkNgaySinh.Value.Date, txtDanToc.Text, "", "", "");
            congDanDAO.Them(cd);
            int id = congDanDAO.LayDanhSachCongDan().Rows.Count;
            dao.Them(new KhaiSinh(id, int.Parse(txtIDNguoiYeuCau.Text), int.Parse(txtIDNguoiCha.Text), int.Parse(txtIDNguoiMe.Text), txtNoiDangKy.Text, pkNgayDangKy.Value.Date));
        }

        private void btnSua_Click(object sender, EventArgs e)
        { 
            int id;

            if (int.TryParse(txtID.Text, out id))
            {
                KhaiSinh ks = dao.TimKiem(id);
                if (ks != null)
                {
                    CongDan dt = congDanDAO.TimKiem(id.ToString());
                    if (dt != null)
                    {
                        CongDan cd = new CongDan(dt.Id, txtHoTen.Text, txtQueQuan.Text, cbGioiTinh.Text, pkNgaySinh.Value.Date, txtDanToc.Text, "", "", "");
                        congDanDAO.Sua(cd);
                        dao.Sua(new KhaiSinh(id, int.Parse(dt.Id), int.Parse(txtIDNguoiYeuCau.Text), int.Parse(txtIDNguoiCha.Text), int.Parse(txtIDNguoiMe.Text), txtNoiDangKy.Text, pkNgayDangKy.Value.Date));
                    }
                }
            }

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            int id;

            if (int.TryParse(txtID.Text, out id))
            {
                KhaiSinh ks = dao.TimKiem(id);
                if (ks != null)
                {
                    txtIDNguoiYeuCau.Text = ks.IDNguoiYeuCau.ToString();
                    txtIDNguoiCha.Text = ks.IDCha.ToString();
                    txtIDNguoiMe.Text = ks.IDMe.ToString();
                    btnTimKiemNguoiYeuCau_Click(sender, e);
                    btnTimKiemNguoiCha_Click(sender, e);
                    btnTimKiemNguoiMe_Click(sender, e);
                    txtNoiDangKy.Text = ks.NoiDangKy;
                    pkNgayDangKy.Value = ks.NgayThucHien;

                    CongDan dt = congDanDAO.TimKiem(id.ToString());
                    if (dt != null)
                    {
                        txtHoTen.Text = dt.HoTen.ToString();
                        txtQueQuan.Text = dt.QueQuan.ToString();
                        cbGioiTinh.Text = dt.GioiTinh.ToString();
                        pkNgaySinh.Value = dt.NgaySinh;
                        txtDanToc.Text = dt.DanToc.ToString();
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int id;

            if (int.TryParse(txtID.Text, out id))
            {
                if (dao.Xoa(id))
                {
                    MessageBox.Show("Xóa thành công");
                } 
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }

    }
}