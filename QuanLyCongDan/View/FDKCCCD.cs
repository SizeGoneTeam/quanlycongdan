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
    public partial class FDKCCCD : Form
    {
        CongDan cd;
        CongDanDAO cddao = new CongDanDAO();
        CCCDDAO cccdDAO = new CCCDDAO();
        CCCD cccd;
        public FDKCCCD()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cccd = cccdDAO.TimKiem_ID(txtSOCC.Text);
            cccd = new CCCD(cccd.IDCD, txtSOCC.Text, add.Text, dTPNgayCap.Value.Date);
            cccdDAO.Xoa(cccd);
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSOCC.Text) ||
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
    }
}
