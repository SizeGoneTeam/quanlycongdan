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
    public partial class FThanhVien : Form
    {
        
        private SoHoKhauThanhVien thanhVien = new SoHoKhauThanhVien();
        private List<string> usedIdCongDan = new List<string>();

        private CongDanDAO congDanDAO = new CongDanDAO();
        private CCCDDAO cccdDAO = new CCCDDAO();

        private bool isAddMode;
        private bool canceled;

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

        public bool Canceled { get => canceled; }

        #region Methods
        private void updateFromContent()
        {
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
            txtHoTen.Text = ThanhVien.CongDan is null ? "" : ThanhVien.CongDan.HoTen;
            txtNgaySinh.Text = ThanhVien.CongDan is null ? "" : ThanhVien.CongDan.NgaySinh.ToShortDateString();
            txtGioiTinh.Text = ThanhVien.CongDan is null ? "" : ThanhVien.CongDan.GioiTinh;
            txtNguyenQuan.Text = ThanhVien.CongDan is null ? "" : ThanhVien.CongDan.QueQuan;
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
            if (thanhVien.CongDan is null)
            {
                MessageBox.Show("Thiếu thông tin");
                return false;
            }
            return true;
        }

        private bool isDublicate()
        {
            return usedIdCongDan.Contains(thanhVien.CongDan.Id);
        }
        #endregion


        private void btnHuy_Click(object sender, EventArgs e)
        {
            canceled = true;
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (isEnoughContext())
            {
                updateFromContent();
                usedIdCongDan.Add(thanhVien.CongDan.Id);
                canceled = false;
                this.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        

        #region Events
        private void FThanhVien_Load(object sender, EventArgs e)
        {
            switchToAddMode();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string cccd = txtCCCD.Text;
            int id = cccdDAO.toIdCongDan(cccd);
            thanhVien.CongDan = congDanDAO.TimKiem(id.ToString());
            if (thanhVien.CongDan is null)
            {
                MessageBox.Show("Không tìm thấy");
            }
            else if (isDublicate())
            {
                MessageBox.Show("Trùng người!");
                thanhVien.CongDan = null;
            }
            updateContent();
        }
        #endregion
    }
}
