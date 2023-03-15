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
        CongDanDAO cdao = new CongDanDAO();

        public FKhaiSinh()
        {
            InitializeComponent();
        }

        private void btnTimKiemNguoiYeuCau_Click(object sender, EventArgs e)
        {
            int id;

            if (int.TryParse(txtIDNguoiYeuCau.Text, out id))
            {
                CongDan dt = dao.TimKiemNguoi(id);
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
                CongDan dt = dao.TimKiemNguoi(id);
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
                CongDan dt = dao.TimKiemNguoi(id);
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
            cdao.Them(cd);
            int id = cdao.LayDanhSachCongDan().Rows.Count;
            dao.Them(new KhaiSinh(id, int.Parse(txtIDNguoiYeuCau.Text), int.Parse(txtIDNguoiCha.Text), int.Parse(txtIDNguoiMe.Text), txtNoiDangKy.Text, pkNgayDangKy.Value.Date));
        }
    }
}