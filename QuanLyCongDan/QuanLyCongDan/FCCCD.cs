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

        private void gvCCCD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gvCCCD.Rows[e.RowIndex];
                txtCD.Text = row.Cells[1].Value.ToString();
                txtSOCC.Text = row.Cells[2].Value.ToString();
                add.Text = row.Cells[3].Value.ToString();
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
            if (String.IsNullOrEmpty(txtCD.Text) ||
                String.IsNullOrEmpty(txtSOCC.Text) ||
                String.IsNullOrEmpty(add.Text))
            {
                MessageBox.Show("Them That bai");
            }
            else
            {
                cc = new CCCD(txtCD.Text, txtSOCC.Text, add.Text, dTPNgayCap.Value.Date);
                ccDao.Them(cc);
                HienThiDanhSach();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cc = new CCCD(txtCD.Text, txtSOCC.Text, add.Text, dTPNgayCap.Value.Date);
            ccDao.Xoa(cc);
            HienThiDanhSach();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCD.Text) ||
                String.IsNullOrEmpty(txtSOCC.Text) ||
                String.IsNullOrEmpty(add.Text))
            {
                MessageBox.Show("Sua That bai");
            }
            else
            {
                cc = new CCCD(txtCD.Text, txtSOCC.Text, add.Text, dTPNgayCap.Value.Date);
                ccDao.Sua(cc);
                HienThiDanhSach();
            }
        }
    }
}
