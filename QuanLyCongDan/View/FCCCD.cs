using QuanLyCongDan.DAO;
using QuanLyCongDan.Model;
using QuanLyCongDan.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongDan
{
    public partial class FCCCD : Form
    {
        CongDan cd;
        CongDanDAO cddao = new CongDanDAO();
        CCCDDAO cccdDAO = new CCCDDAO();
        CCCD cccd;
        public FCCCD()
        {
            InitializeComponent();
        }
        private void tim_Click(object sender, EventArgs e)
        {
            cccd = cccdDAO.TimKiem_ID(txtTcccd.Text);
            if (cccd != null)
            {
                cd = cddao.TimKiem(cccd.IDCD);
                if (cd != null)
                {
                    txtHoTen.Text = cd.HoTen;
                    IDs.Text = cd.Id;
                    soCCCD.Text = txtTcccd.Text;
                    GioiTinh.Text = cd.GioiTinh;
                    birth.Text = cd.NgaySinh.Date.ToString();
                    txtDanToc.Text = cd.DanToc;
                    txtTonGiao.Text = cd.TonGiao;
                    txtQQ.Text = cd.QueQuan;
                    adds.Text = cccd.Add;
                    dates.Text = cccd.NgayCap.Date.ToString();
                }
                else
                    MessageBox.Show("Xin Nhập Số CCCD");
            }
            else
                MessageBox.Show("Xin Nhập Số CCCD");
        }
        private void txtTcccd_Enter(object sender, EventArgs e)
        {
            if(txtTcccd.Text == "  CCCD")
            {
                txtTcccd.Text = "";
                txtTcccd.ForeColor= Color.Black;
            }
        }

        private void txtHoTen_Enter(object sender, EventArgs e)
        {
            if( txtHoTen.Text =="  Họ Và Tên")
            {
                txtHoTen.Text = "";
                txtHoTen.ForeColor= Color.Black;
            }
        }

        private void IDs_Enter(object sender, EventArgs e)
        {
            if (IDs.Text == "  ID Công Dân")
            {
                IDs.Text = "";
                IDs.ForeColor = Color.Black;
            }
        }

        private void soCCCD_Enter(object sender, EventArgs e)
        {
            if (soCCCD.Text == "  Số CCCD")
            {
                soCCCD.Text = "";
                soCCCD.ForeColor = Color.Black;
            }
        }

        private void GioiTinh_Enter(object sender, EventArgs e)
        {
            if (GioiTinh.Text == "  Giới Tính")
            {
                GioiTinh.Text = "";
                GioiTinh.ForeColor = Color.Black;
            }
        }

        private void birth_Enter(object sender, EventArgs e)
        {
            if (birth.Text == "  Ngày Sinh")
            {
                birth.Text = "";
                birth.ForeColor = Color.Black;
            }
        }

        private void txtDanToc_Enter(object sender, EventArgs e)
        {
            if (txtDanToc.Text == "  Dân Tộc")
            {
                txtDanToc.Text = "";
                txtDanToc.ForeColor = Color.Black;
            }
        }

        private void txtTonGiao_Enter(object sender, EventArgs e)
        {
            if (txtTonGiao.Text == "  Tôn Giáo")
            {
                txtTonGiao.Text = "";
                txtTonGiao.ForeColor = Color.Black;
            }
        }

        private void txtQQ_Enter(object sender, EventArgs e)
        {
            if (txtQQ.Text == "  Quê Quán")
            {
                txtQQ.Text = "";
                txtQQ.ForeColor = Color.Black;
            }
        }

        private void birth_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTonGiao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDanToc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQQ_TextChanged(object sender, EventArgs e)
        {

        }

        private void adds_Enter(object sender, EventArgs e)
        {
            if (adds.Text == "  Nơi Cấp")
            {
                adds.Text = "";
                adds.ForeColor = Color.Black;
            }
        }

        private void dates_Enter(object sender, EventArgs e)
        {
            if (dates.Text == "  Ngày Cấp")
            {
                dates.Text = "";
                dates.ForeColor = Color.Black;
            }
        }

        private void btndangky_Click(object sender, EventArgs e)
        {
            FDKCCCD dk =new FDKCCCD();
            FMainMenu f =new FMainMenu();
            f.OpenChildForm2(dk, sender);
        }
    }
}
