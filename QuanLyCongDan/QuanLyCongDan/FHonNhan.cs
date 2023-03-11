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
    public partial class FHonNhan : Form
    {
        CongDan cd = new CongDan();
        CongDanDAO cdDao = new CongDanDAO();
        public FHonNhan()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            //Chồng
            try
            {
                cd = cdDao.TimKiem(txtID_Chong.Text);
                lblHoTenChong.Text = cd.HoTen;
                lblNgaySinhChong.Text = cd.NgaySinh.Date.ToString();

            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Vợ
            try
            {
                cd = cdDao.TimKiem(txtID_Vo.Text);
                lblHoTenVo.Text = cd.HoTen;
                lblNgaySinhVo.Text = cd.NgaySinh.Date.ToString();

            }
            catch
            {

            }
        }
    }
}
