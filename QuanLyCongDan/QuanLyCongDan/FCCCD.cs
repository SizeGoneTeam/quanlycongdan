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
        CongDanDAO cdDao = new CongDanDAO();
        public FCCCD()
        {
            InitializeComponent();
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
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cc = new CCCD(txtCD.Text, txtSOCC.Text, add.Text, dTPNgayCap.Value.Date);
            ccDao.Xoa(cc);
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
            }
        }

        private void tim_Click(object sender, EventArgs e)
        {

        }
        //private void TimKiemCC(String id)
        //{
        //    try
        //    {
        //        cc = ccDao.TimKiem_ID(id);
        //        cd = cdDao.TimKiem(id);
        //        txtHoTen.Text = cd.HoTen;
        //        IDs.Text = cd.Id;
        //        txtQQ.Text = cd.QueQuan;
        //        soCCCD.Text = cc.SoCCCD;
        //        GioiTinh.Text = cd.GioiTinh;
        //        birth.Value = cd.NgaySinh;
        //        txtDanToc.Text = cd.DanToc;
        //        txtTonGiao.Text = cd.TonGiao;
        //    }
        //    catch { }
        //}
        //private void tim_Click(object sender, EventArgs e)
        //{
        //    TimKiemCC(txtTCCCD.Text);
        //}
    }
}
