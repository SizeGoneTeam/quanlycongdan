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
    public partial class FCCCD : Form
    {
        CCCD cc;
        CCCDDAO ccDao = new CCCDDAO();
        public FCCCD()
        {
            InitializeComponent();
        }
        private void HienThiDanhSach()
        {
            this.gvCCCD.DataSource = ccDao.LayDanhSachCCCD();
        }
        private void FCCCD_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            //cd = new CongDan(txtID.Text, txtHoTen.Text, txtQueQuan.Text, txtCMND.Text, dTPNgaySinh.Value.Date, txtEmail.Text, txtSDT.Text);
            /*if (string.IsNullOrEmpty(ccDao.KiemTraDuLieu(cc)))*/ ccDao.Them(cc);
            //else MessageBox.Show(ccDao.KiemTraDuLieu(cc));
            HienThiDanhSach();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            //cd = new CongDan(txtID.Text, txtHoTen.Text, txtQueQuan.Text, txtCMND.Text, dTPNgaySinh.Value.Date, txtEmail.Text, txtSDT.Text);
            ccDao.Xoa(cc);
            HienThiDanhSach();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            //cd = new CongDan(txtID.Text, txtHoTen.Text, txtQueQuan.Text, txtCMND.Text, dTPNgaySinh.Value.Date, txtEmail.Text, txtSDT.Text);
            /*if (string.IsNullOrEmpty(ccDao.KiemTraDuLieu(cc)))*/ ccDao.Sua(cc);
            //else MessageBox.Show(ccDao.KiemTraDuLieu(cc));
            HienThiDanhSach();
        }

        private void gvCCCD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gvCCCD.Rows[e.RowIndex];
                txtIDCCCD.Text = row.Cells[0].Value.ToString();
                txtCD.Text = row.Cells[1].Value.ToString();
                txtSOCC.Text = row.Cells[2].Value.ToString();
                txtAdd.Text = row.Cells[3].Value.ToString();
                try
                {
                    dTPNgayCap.Value = (DateTime)row.Cells[4].Value;
                }
                catch
                {
                    dTPNgayCap.Value = DateTime.Now;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //cd = new CongDan(txtID.Text, txtHoTen.Text, txtQueQuan.Text, txtCMND.Text, dTPNgaySinh.Value.Date, txtEmail.Text, txtSDT.Text);
            /*if (string.IsNullOrEmpty(cdDao.KiemTraDuLieu(cc)))*/ ccDao.Them(cc);
            //else MessageBox.Show(cdDao.KiemTraDuLieu(cc));
            HienThiDanhSach();
        }
    }
}
