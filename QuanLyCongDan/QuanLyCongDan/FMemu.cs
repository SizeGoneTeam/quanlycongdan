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
    public partial class FMemu : Form
    {
        public FMemu()
        {
            InitializeComponent();
        }

        private void btnCongDan_Click(object sender, EventArgs e)
        {
            FCongDan fCongDan = new FCongDan();
            fCongDan.Show();
        }

        private void btnCCCD_Click(object sender, EventArgs e)
        {
            FCCCD fCCCD = new FCCCD();
            fCCCD.Show();
        }

        private void btnHonNhan_Click(object sender, EventArgs e)
        {
            FHonNhan fHonNhan = new FHonNhan();
            fHonNhan.Show();
        }
        private void btnKhaiSinh_Click(object sender, EventArgs e)
        {
            FKhaiSinh f = new FKhaiSinh();
            f.Show();
        }
        private void btnThue_Click(object sender, EventArgs e)
        {
            FThue f = new FThue();
            f.Show();
        }

        private void btnTTTV_Click(object sender, EventArgs e)
        {
            FTamTruTamVang f = new FTamTruTamVang();
            f.Show();
        }
    }
}
