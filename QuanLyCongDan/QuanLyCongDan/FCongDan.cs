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
            cboGioiTinh.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cd = new CongDan(txtHoTen.Text, txtQueQuan.Text, cboGioiTinh.SelectedItem.ToString(), dTPNgaySinh.Value, txtDanToc.Text, txtTonGiao.Text, txtSDT.Text, txtEmail.Text);
            cdDao.Them(cd);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            cd = new CongDan(txtID.Text,txtHoTen.Text, txtQueQuan.Text, cboGioiTinh.SelectedItem.ToString(), dTPNgaySinh.Value, txtDanToc.Text, txtTonGiao.Text, txtSDT.Text, txtEmail.Text);
            cdDao.Xoa(cd);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            cd = new CongDan(txtID.Text, txtHoTen.Text, txtQueQuan.Text, cboGioiTinh.SelectedItem.ToString(), dTPNgaySinh.Value, txtDanToc.Text, txtTonGiao.Text, txtSDT.Text, txtEmail.Text);
            cdDao.Sua(cd);
        }

        private void dTPNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            TimKiemCongDan(txtID.Text);
            if (String.IsNullOrEmpty(txtID.Text))
            {
                txtHoTen.Clear();
                txtQueQuan.Clear();
                dTPNgaySinh.Value = DateTime.Now;
                txtDanToc.Clear();
                txtTonGiao.Clear();
                txtSDT.Clear();
                txtEmail.Clear();
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
            else
            {
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void TimKiemCongDan(String id)
        {
            try
            {
                cd = cdDao.TimKiem(id);
                txtHoTen.Text = cd.HoTen;
                txtQueQuan.Text = cd.QueQuan;
                dTPNgaySinh.Value = cd.NgaySinh;
                txtDanToc.Text = cd.DanToc;
                txtTonGiao.Text = cd.TonGiao;
                txtSDT.Text = cd.Sdt;
                txtEmail.Text = cd.Email;
                if (cd.GioiTinh.Equals("Nam"))
                    cboGioiTinh.SelectedItem = 0;
                else if (cd.GioiTinh.Equals("Nữ"))
                    cboGioiTinh.SelectedItem = 1;
                else cboGioiTinh.SelectedItem = 2;
            }
            catch
            {

            }
            
        }
    }
}
