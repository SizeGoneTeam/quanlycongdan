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
        CongDan cd;
        CongDanDAO cddao = new CongDanDAO();
        CCCDDAO cccdDAO = new CCCDDAO();
        CCCD cccd;

        public FCCCD()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            cccd = cccdDAO.TimKiem_ID(txtSOCC.Text);
            cccd = new CCCD(cccd.IDCD, txtSOCC.Text, add.Text, dTPNgayCap.Value.Date);
            if (String.IsNullOrEmpty(txtSOCC.Text) ||
                String.IsNullOrEmpty(add.Text))
            {
                MessageBox.Show("Them That bai");
            }
            else
            {
                cccdDAO.Them(cccd);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cccd = cccdDAO.TimKiem_ID(txtSOCC.Text);
            cccd = new CCCD(cccd.IDCD, txtSOCC.Text, add.Text, dTPNgayCap.Value.Date);
            cccdDAO.Xoa(cccd);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSOCC.Text) ||
                String.IsNullOrEmpty(txtSOCC.Text) ||
                String.IsNullOrEmpty(add.Text))
            {
                MessageBox.Show("Sua That bai");
            }
            else
            {
                cccd = cccdDAO.TimKiem_ID(txtSOCC.Text);
                cccd = new CCCD(cccd.IDCD, txtSOCC.Text, add.Text, dTPNgayCap.Value.Date);
                cccdDAO.Sua(cccd);
            }
        }

        private void tim_Click(object sender, EventArgs e)
        {
            cccd = cccdDAO.TimKiem_ID(txtTcccd.Text);
            cd = cddao.TimKiem(cccd.IDCD);
            if (cd != null)
            {
                txtHoTen.Text = cd.HoTen;
                IDs.Text = cd.Id;
                soCCCD.Text = txtTcccd.Text;
                GioiTinh.Text = cd.GioiTinh;
                birth.Text= cd.NgaySinh.Date.ToString();
                txtDanToc.Text = cd.DanToc;
                txtTonGiao.Text = cd.TonGiao;
                txtQQ.Text = cd.QueQuan;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FTamTruTamVang child = new FTamTruTamVang(txtTcccd.Text);
            child.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FKhaiSinh f = new FKhaiSinh();
            f.Show();
        }
    }
}
