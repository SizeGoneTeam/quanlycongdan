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
using QuanLyCongDan.DAO;

namespace QuanLyCongDan.View
{
    public partial class FCongDan : Form
    {
        CongDan cd;
        CongDanDAO cdDao = new CongDanDAO();

        public FCongDan()
        {
            InitializeComponent();
            cboGioiTinh.SelectedIndex = 0;
            cboDanToc.SelectedIndex = 0;
            cboTonGiao.SelectedIndex = 0;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTin())
            {
                cd = new CongDan(txtHoTen.Text, txtQueQuan.Text, cboGioiTinh.SelectedItem.ToString(), dTPNgaySinh.Value, cboDanToc.SelectedItem.ToString(), cboTonGiao.SelectedItem.ToString(), txtSDT.Text, txtEmail.Text, txtNoiThuongTru.Text, "Việt Nam");
                cdDao.Them(cd);
                MessageBox.Show("Thêm thành công");
            }
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            cd = new CongDan(txtID.Text,txtHoTen.Text, txtQueQuan.Text, cboGioiTinh.SelectedItem.ToString(), dTPNgaySinh.Value, cboDanToc.SelectedItem.ToString(), cboTonGiao.SelectedItem.ToString(), txtSDT.Text, txtEmail.Text, txtNoiThuongTru.Text, "Việt Nam");
            cdDao.Xoa(cd);
            MessageBox.Show("Xoá thành công");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (KiemTraThongTin())
            {
                cd = new CongDan(txtID.Text, txtHoTen.Text, txtQueQuan.Text, cboGioiTinh.SelectedItem.ToString(), dTPNgaySinh.Value, cboDanToc.SelectedItem.ToString(), cboTonGiao.SelectedItem.ToString(), txtSDT.Text, txtEmail.Text, txtNoiThuongTru.Text, "");
                cdDao.Sua(cd);
                MessageBox.Show("Sửa thành công");
            }
            
        }

        private void dTPNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TimKiemCongDan(String id)
        {
            try
            {
                cd = cdDao.TimKiem(id);
                txtHoTen.Text = cd.HoTen;
                txtNoiThuongTru.Text = cd.NoiThuongTru;
                txtQueQuan.Text = cd.QueQuan;
                dTPNgaySinh.Value = cd.NgaySinh.Value;
                txtSDT.Text = cd.SDT;
                txtEmail.Text = cd.Email;

                int index = cboGioiTinh.FindStringExact(cd.GioiTinh);
                if (index >= 0)
                {
                    cboGioiTinh.SelectedIndex = index;
                }

                index = cboDanToc.FindStringExact(cd.DanToc);
                if (index >= 0)
                {
                    cboDanToc.SelectedIndex = index;
                }

                index = cboTonGiao.FindStringExact(cd.TonGiao);
                if (index >= 0)
                {
                    cboTonGiao.SelectedIndex = index;
                }
            }
            catch
            {
                txtHoTen.Text = "";

            }
            
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            try
            {
                TimKiemCongDan(txtID.Text);
                if (String.IsNullOrEmpty(txtHoTen.Text))
                {
                    txtHoTen.Clear();
                    txtQueQuan.Clear();
                    dTPNgaySinh.Value = DateTime.Now;
                    cboGioiTinh.SelectedIndex = 0;
                    cboDanToc.SelectedIndex = 0;
                    cboTonGiao.SelectedIndex = 0;
                    txtSDT.Clear();
                    txtEmail.Clear();
                    txtNoiThuongTru.Clear();
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                }
                else
                {
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                }
            }
            catch
            {

            }
            
        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            if (txtID.Text == "  ID Công Dân")
            {
                txtID.Text = "";
                txtID.ForeColor = Color.Black;
            }
        }

        private void txtHoTen_Enter(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "  Họ và Tên")
            {
                txtHoTen.Text = "";
                txtHoTen.ForeColor = Color.Black;
            }
        }

        private void txtQueQuan_Enter(object sender, EventArgs e)
        {
            if (txtQueQuan.Text == "  Quê Quán")
            {
                txtQueQuan.Text = "";
                txtQueQuan.ForeColor = Color.Black;
            }
        }

        private void txtCMND_Enter(object sender, EventArgs e)
        {
            if (txtNoiThuongTru.Text == "  Địa Chỉ")
            {
                txtNoiThuongTru.Text = "";
                txtNoiThuongTru.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "  Email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtSDT_Enter(object sender, EventArgs e)
        {
            if (txtSDT.Text == "  Số Điện Thoại")
            {
                txtSDT.Text = "";
                txtSDT.ForeColor = Color.Black;
            }
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == ' ')
            {
                e.Handled = true;
            }

            if (txtSDT.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private Boolean KiemTraThongTin()
        {
            if(!Regex.IsMatch(txtHoTen.Text, @"[a-z]{1,49}$") || string.IsNullOrEmpty(txtQueQuan.Text) || string.IsNullOrEmpty(txtNoiThuongTru.Text) || !IsValidEmail(txtEmail.Text) || !Regex.IsMatch(txtSDT.Text, @"^[0-9]{10}$") || (dTPNgaySinh.Value > DateTime.Now))
            {
                MessageBox.Show("Vui lòng nhập thông tin hợp lệ");
                return true;
            }
            return true;
        }

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Kiểm tra định dạng email với biểu thức chính quy
                return Regex.IsMatch(email,
                    @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                    + @"([a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-zA-Z0-9!#$%&'*+/=?^_`{|}~-]+)*))"
                    + @"(?<!\.)@[a-zA-Z0-9][a-zA-Z0-9-]{0,63}"
                    + @"(?:\.[a-zA-Z0-9][a-zA-Z0-9-]{0,63})+$",
                    RegexOptions.IgnoreCase);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
