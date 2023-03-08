using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Text.RegularExpressions;



namespace Week2
{
    public partial class FCongDan : Form
    {
        CongDan cd;
        CongDanDAO cdDao = new CongDanDAO();

        public FCongDan()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }

        private void HienThiDanhSach()
        {
            this.gvCongDan.DataSource = cdDao.LayDanhSachCongDan();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //cd = new CongDan(txtID.Text, txtHoTen.Text, txtQueQuan.Text, txtCMND.Text, dTPNgaySinh.Value.Date, txtEmail.Text, txtSDT.Text);
            if (string.IsNullOrEmpty(cdDao.KiemTraDuLieu(cd))) cdDao.Them(cd);
            else MessageBox.Show(cdDao.KiemTraDuLieu(cd));
            HienThiDanhSach();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //cd = new CongDan(txtID.Text, txtHoTen.Text, txtQueQuan.Text, txtCMND.Text, dTPNgaySinh.Value.Date, txtEmail.Text, txtSDT.Text);
            cdDao.Xoa(cd);
            HienThiDanhSach();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           //cd = new CongDan(txtID.Text, txtHoTen.Text, txtQueQuan.Text, txtCMND.Text, dTPNgaySinh.Value.Date, txtEmail.Text, txtSDT.Text);
            if (string.IsNullOrEmpty(cdDao.KiemTraDuLieu(cd))) cdDao.Sua(cd);
            else MessageBox.Show(cdDao.KiemTraDuLieu(cd));
            HienThiDanhSach();
        }

        private void gvHsinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gvCongDan.Rows[e.RowIndex];
                txtID.Text = row.Cells[0].Value.ToString();
                txtHoTen.Text = row.Cells[1].Value.ToString();
                txtQueQuan.Text = row.Cells[2].Value.ToString();
                txtCMND.Text = row.Cells[3].Value.ToString();
                txtEmail.Text = row.Cells[5].Value.ToString();
                txtSDT.Text = row.Cells[6].Value.ToString();
                try
                {
                    dTPNgaySinh.Value = (DateTime)row.Cells[4].Value;
                }
                catch
                {
                    dTPNgaySinh.Value = DateTime.Now;
                }
            }
        }
    }
}
