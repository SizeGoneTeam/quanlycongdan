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
            cboDanToc.SelectedIndex = 0;
            cboTonGiao.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cd = new CongDan(txtHoTen.Text, txtQueQuan.Text, cboGioiTinh.SelectedItem.ToString(), dTPNgaySinh.Value, cboDanToc.SelectedItem.ToString(), cboTonGiao.SelectedItem.ToString(), txtSDT.Text, txtEmail.Text);
            cdDao.Them(cd);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            cd = new CongDan(txtID.Text,txtHoTen.Text, txtQueQuan.Text, cboGioiTinh.SelectedItem.ToString(), dTPNgaySinh.Value, cboDanToc.SelectedItem.ToString(), cboTonGiao.SelectedItem.ToString(), txtSDT.Text, txtEmail.Text);
            cdDao.Xoa(cd);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            cd = new CongDan(txtID.Text, txtHoTen.Text, txtQueQuan.Text, cboGioiTinh.SelectedItem.ToString(), dTPNgaySinh.Value, cboDanToc.SelectedItem.ToString(), cboTonGiao.SelectedItem.ToString(), txtSDT.Text, txtEmail.Text);
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
            
        }

        private void TimKiemCongDan(String id)
        {
            try
            {
                cd = cdDao.TimKiem(id);
                txtHoTen.Text = cd.HoTen;
                txtQueQuan.Text = cd.QueQuan;
                dTPNgaySinh.Value = cd.NgaySinh;
                txtSDT.Text = cd.Sdt;
                txtEmail.Text = cd.Email;

                if (cd.GioiTinh.Equals("Nam"))
                    cboGioiTinh.SelectedItem = "Nam";
                else if (cd.GioiTinh.Equals("Nữ"))
                    cboGioiTinh.SelectedItem = "Nữ";
                else cboGioiTinh.SelectedItem = 2;

                if (cd.TonGiao.Equals("Không"))
                    cboTonGiao.SelectedItem = "Không";
                else if (cd.TonGiao.Equals("Phật giáo"))
                    cboTonGiao.SelectedItem = "Phật giáo";
                else if (cd.TonGiao.Equals("Thiên chúa giáo"))
                    cboTonGiao.SelectedItem = "Thiên chúa giáo";
                else if (cd.TonGiao.Equals("Công giáo Rôma"))
                    cboTonGiao.SelectedItem = "Công giáo Rôma";
                else if (cd.TonGiao.Equals("Hòa hảo"))
                    cboTonGiao.SelectedItem = "Hòa hảo";
                else if (cd.TonGiao.Equals("Cao đài"))
                    cboTonGiao.SelectedItem = "Cao đài";
                else if (cd.TonGiao.Equals("Hồi giáo"))
                    cboTonGiao.SelectedItem = "Hồi giáo";
                else if (cd.TonGiao.Equals("Tin Lành"))
                    cboTonGiao.SelectedItem = "Tin Lành";
                else if (cd.TonGiao.Equals("Bahá'í"))
                    cboTonGiao.SelectedItem = "Bahá'í";
                else if (cd.TonGiao.Equals("Hindu"))
                    cboTonGiao.SelectedItem = "Hindu";
                else if (cd.TonGiao.Equals("Sikh"));

                if (cd.DanToc.Equals("Kinh"))
                    cboDanToc.SelectedItem = "Kinh";
                else if (cd.DanToc.Equals("Tày"))
                    cboDanToc.SelectedItem = "Tày";
                else if (cd.DanToc.Equals("Thái"))
                    cboDanToc.SelectedItem = "Thái";
                else if (cd.DanToc.Equals("Mường"))
                    cboDanToc.SelectedItem = "Mường";
                else if (cd.DanToc.Equals("Khmer"))
                    cboDanToc.SelectedItem = "Khmer";
                else if (cd.DanToc.Equals("Hoa"))
                    cboDanToc.SelectedItem = "Hoa";
                else if (cd.DanToc.Equals("Nùng"))
                    cboDanToc.SelectedItem = "Nùng";
                else if (cd.DanToc.Equals("H'Mông"))
                    cboDanToc.SelectedItem = "H'Mông";
                else if (cd.DanToc.Equals("Dao"))
                    cboDanToc.SelectedItem = "Dao";
                else if (cd.DanToc.Equals("Gia Rai"))
                    cboDanToc.SelectedItem = "Gia Rai";
                else if (cd.DanToc.Equals("Ê Đê"))
                    cboDanToc.SelectedItem = "Ê Đê";
                else if (cd.DanToc.Equals("Ba Na"))
                    cboDanToc.SelectedItem = "Ba Na";
                else if (cd.DanToc.Equals("Sán Chay"))
                    cboDanToc.SelectedItem = "Sán Chay";
                else if (cd.DanToc.Equals("Chăm"))
                    cboDanToc.SelectedItem = "Chăm";
                else if (cd.DanToc.Equals("Kơ Ho"))
                    cboDanToc.SelectedItem = "Kơ Ho";
                else if (cd.DanToc.Equals("Xơ Đăng"))
                    cboDanToc.SelectedItem = "Xơ Đăng";
                else if (cd.DanToc.Equals("Sán Dìu"))
                    cboDanToc.SelectedItem = "Sán Dìu";
                else if (cd.DanToc.Equals("Hrê"))
                    cboDanToc.SelectedItem = "Hrê";
                else if (cd.DanToc.Equals("Ra Glai"))
                    cboDanToc.SelectedItem = "Ra Glai";
                else if (cd.DanToc.Equals("Mnông"))
                    cboDanToc.SelectedItem = "Mnông";
                else if (cd.DanToc.Equals("Thổ"))
                    cboDanToc.SelectedItem = "Thổ";
                else if (cd.DanToc.Equals("Stiêng"))
                    cboDanToc.SelectedItem = "Stiêng";
                else if (cd.DanToc.Equals("Khơ mú"))
                    cboDanToc.SelectedItem = "Khơ mú";
                else if (cd.DanToc.Equals("Bru - Vân Kiều"))
                    cboDanToc.SelectedItem = "Bru - Vân Kiều";
                else if (cd.DanToc.Equals("Cơ Tu"))
                    cboDanToc.SelectedItem = "Cơ Tu";
                else if (cd.DanToc.Equals("Giáy"))
                    cboDanToc.SelectedItem = "Giáy";
                else if (cd.DanToc.Equals("Tà Ôi"))
                    cboDanToc.SelectedItem = "Tà Ôi";
                else if (cd.DanToc.Equals("Mạ"))
                    cboDanToc.SelectedItem = "Mạ";
                else if (cd.DanToc.Equals("Giẻ-Triêng"))
                    cboDanToc.SelectedItem = "Giẻ-Triêng";
                else if (cd.DanToc.Equals("Co"))
                    cboDanToc.SelectedItem = "Co";
                else if (cd.DanToc.Equals("Chơ Ro"))
                    cboDanToc.SelectedItem = "Chơ Ro";
                else if (cd.DanToc.Equals("Xinh Mun"))
                    cboDanToc.SelectedItem = "Xinh Mun";
                else if (cd.DanToc.Equals("Hà Nhì"))
                    cboDanToc.SelectedItem = "Hà Nhì";
                else if (cd.DanToc.Equals("Chu Ru"))
                    cboDanToc.SelectedItem = "Chu Ru";
                else if (cd.DanToc.Equals("Lào"))
                    cboDanToc.SelectedItem = "Lào";
                else if (cd.DanToc.Equals("La Chí"))
                    cboDanToc.SelectedItem = "La Chí";
                else if (cd.DanToc.Equals("Kháng"))
                    cboDanToc.SelectedItem = "Kháng";
                else if (cd.DanToc.Equals("Phù Lá"))
                    cboDanToc.SelectedItem = "Phù Lá";
                else if (cd.DanToc.Equals("La Hủ"))
                    cboDanToc.SelectedItem = "La Hủ";
                else if (cd.DanToc.Equals("La Ha"))
                    cboDanToc.SelectedItem = "La Ha";
                else if (cd.DanToc.Equals("Pà Thẻn"))
                    cboDanToc.SelectedItem = "Pà Thẻn";
                else if (cd.DanToc.Equals("Lự"))
                    cboDanToc.SelectedItem = "Lự";
                else if (cd.DanToc.Equals("Ngái"))
                    cboDanToc.SelectedItem = "Ngái";
                else if (cd.DanToc.Equals("Chứt"))
                    cboDanToc.SelectedItem = "Chứt";
                else if (cd.DanToc.Equals("Lô Lô"))
                    cboDanToc.SelectedItem = "Lô Lô";
                else if (cd.DanToc.Equals("Mảng"))
                    cboDanToc.SelectedItem = "Mảng";
                else if (cd.DanToc.Equals("Cơ Lao"))
                    cboDanToc.SelectedItem = "Cơ Lao";
                else if (cd.DanToc.Equals("Bố Y"))
                    cboDanToc.SelectedItem = "Bố Y";
                else if (cd.DanToc.Equals("Cống"))
                    cboDanToc.SelectedItem = "Cống";
                else if (cd.DanToc.Equals("Si La"))
                    cboDanToc.SelectedItem = "Si La";
                else if (cd.DanToc.Equals("Pu Péo"))
                    cboDanToc.SelectedItem = "Pu Péo";
                else if (cd.DanToc.Equals("Rơ Măm"))
                    cboDanToc.SelectedItem = "Rơ Măm";
                else if (cd.DanToc.Equals("Brâu"))
                    cboDanToc.SelectedItem = "Brâu";
                else if (cd.DanToc.Equals("Ơ Đu"))
                    cboDanToc.SelectedItem = "Ơ Đu";
            }
            catch
            {

            }
            
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
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
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
            else
            {
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }
    }
}
