using QuanLyCongDan.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongDan
{
    internal partial class UCThanhVien : UserControl
    {
        private SoHoKhauThanhVien thanhVien;

        public UCThanhVien()
        {
            InitializeComponent();
        }

        public UCThanhVien(SoHoKhauThanhVien thanhVien)
        {
            InitializeComponent();

            ThanhVien = thanhVien;

            UpdateContent();
        }

        internal SoHoKhauThanhVien ThanhVien
        {
            get
            {
                return thanhVien;
            }

            set
            {
                thanhVien = value;
            }
        }

        public void UpdateContent()
        {
            txtQuanHe.Text = ThanhVien.QuanHe;
            txtHoTen.Text = ThanhVien.CongDan.HoTen;
            txtNgaySinh.Text = ThanhVien.CongDan.NgaySinh.ToShortDateString();
            txtGioiTinh.Text = ThanhVien.CongDan.GioiTinh;
            txtNguyenQuan.Text = ThanhVien.CongDan.QueQuan;
            //txtDanToc.Text = ThanhVien.CongDan.DanToc;
            //txtQuocTich.Text = ThanhVien.CongDan.QuocTich;
            txtNgheNghiepNoiLamViec.Text = ThanhVien.NgheNghiepNoiLamViec;
            txtNoiThuongTruTruoc.Text = ThanhVien.NoiThuongTruTruoc;
            txtCanBoDangKy.Text = ThanhVien.CanBoDangKy;
            pkNgayDangKy.Value = ThanhVien.NgayDangKy;
        }

        private void txtQuanHe_Enter(object sender, EventArgs e)
        {
            if (txtQuanHe.Text == "  Quan Hệ Chủ Hộ")
            {
                txtQuanHe.Text = "";
                txtQuanHe.ForeColor = Color.Black;
            }
        }

        private void txtNgheNghiepNoiLamViec_TextChanged(object sender, EventArgs e)
        {
            if (txtNgheNghiepNoiLamViec.Text == "  Nghề Nghiệp")
            {
                txtNgheNghiepNoiLamViec.Text = "";
                txtNgheNghiepNoiLamViec.ForeColor = Color.Black;
            }
        }

        private void txtNoiThuongTruTruoc_Enter(object sender, EventArgs e)
        {
            if (txtNoiThuongTruTruoc.Text == "  Nơi Thường Trú Trước")
            {
                txtNoiThuongTruTruoc.Text = "";
                txtNoiThuongTruTruoc.ForeColor = Color.Black;
            }
        }

        private void txtCanBoDangKy_Enter(object sender, EventArgs e)
        {
            if (txtCanBoDangKy.Text == "  Cán Bộ Đăng Ký")
            {
                txtCanBoDangKy.Text = "";
                txtCanBoDangKy.ForeColor = Color.Black;
            }
        }
    }
}
