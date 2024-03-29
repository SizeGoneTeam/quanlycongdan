﻿using QuanLyCongDan.DAO;
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
    public partial class FThanhVien : Form
    {
        
        private SoHoKhauThanhVien thanhVien;
        private CongDan congDan;
        private List<SoHoKhauThanhVien> danhSachThanhVien;

        private CongDanDAO congDanDAO = new CongDanDAO();
        private CCCDDAO cccdDAO = new CCCDDAO();

        private bool isAddMode;

        public FThanhVien()
        {
            InitializeComponent();
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

        internal List<SoHoKhauThanhVien> DanhSachThanhVien { get => danhSachThanhVien; set => danhSachThanhVien = value; }

        #region Methods
        public void ModeAdd()
        {
            switchToAddMode();
            thanhVien = null;
            congDan = null;
            updateContent();
            updateFromContent();
        }

        public void ModeUpdate(string id)
        {
            switchToEditMode();
            thanhVien = DanhSachThanhVien.FirstOrDefault(tv => tv.CongDan.Id == id);
            congDan = thanhVien.CongDan;
            updateContent();
        }

        private void updateFromContent()
        {
            if (isAddMode && thanhVien is null)
            {
                thanhVien = new SoHoKhauThanhVien();
            }
            ThanhVien.QuanHe = txtQuanHe.Text;
            ThanhVien.NgheNghiepNoiLamViec = txtNgheNghiepNoiLamViec.Text;
            ThanhVien.NoiThuongTruTruoc = txtNoiThuongTruTruoc.Text;
            ThanhVien.CanBoDangKy = txtCanBoDangKy.Text;
            ThanhVien.NgayDangKy = pkNgayDangKy.Value;
        }

        private void updateContent()
        {
            txtQuanHe.Text = ThanhVien is null ? "" : ThanhVien.QuanHe;
            txtNgheNghiepNoiLamViec.Text = ThanhVien is null ? "" : ThanhVien.NgheNghiepNoiLamViec;
            txtNoiThuongTruTruoc.Text = ThanhVien is null ? "" : ThanhVien.NoiThuongTruTruoc;
            txtCanBoDangKy.Text = ThanhVien is null ? "" : ThanhVien.CanBoDangKy;
            pkNgayDangKy.Value = ThanhVien is null || ThanhVien.NgayDangKy == DateTime.MinValue ? DateTime.Now : ThanhVien.NgayDangKy;

            txtCCCD.Text = "";
            txtHoTen.Text = congDan is null ? "" : congDan.HoTen;
            txtNgaySinh.Text = congDan is null ? "" : congDan.NgaySinh.ToShortDateString();
            txtGioiTinh.Text = congDan is null ? "" : congDan.GioiTinh;
            txtNguyenQuan.Text = congDan is null ? "" : congDan.QueQuan;
            //txtDanToc.Text = ThanhVien.CongDan.DanToc;
            //txtQuocTich.Text = ThanhVien.CongDan.QuocTich;
        }

        private void switchToAddMode()
        {
            isAddMode = true;

            btnXoa.Enabled = false;
        }

        private void switchToEditMode()
        {
            isAddMode = false;

            btnXoa.Enabled = true;
        }

        private bool isEnoughContext()
        {
            if (congDan is null)
            {
                MessageBox.Show("Thiếu thông tin");
                return false;
            }
            return true;
        }

        private bool isDublicate()
        {
            return DanhSachThanhVien.Any(tv => tv.CongDan.Id == congDan.Id);
        }
        #endregion

        #region Events
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string cccd = txtCCCD.Text;
            int id = cccdDAO.toIdCongDan(cccd);
            congDan = thanhVien.CongDan = congDanDAO.TimKiem(id.ToString());
            if (congDan is null)
            {
                MessageBox.Show("Không tìm thấy");
            }
            else if (isDublicate())
            {
                MessageBox.Show("Trùng người!");
                congDan = null;
            }
            updateContent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (isEnoughContext())
            {
                updateFromContent();
                if (isAddMode)
                {
                    DanhSachThanhVien.Add(thanhVien);
                }
                else
                {

                }
                this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SoHoKhauThanhVien thanhVienToRemove = danhSachThanhVien.FirstOrDefault(tv => tv.CongDan.Id == congDan.Id);
            if (thanhVienToRemove != null)
            {
                danhSachThanhVien.Remove(thanhVienToRemove);
            }
            this.Close();
        }
        #endregion
    }
}
