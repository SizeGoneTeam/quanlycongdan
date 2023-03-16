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
    }
}
