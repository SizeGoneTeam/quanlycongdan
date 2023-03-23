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
    public partial class FTamTruTamVang : Form
    {
        TamTruTamVang tt;
        TamTruTamVangDAO ttdao = new TamTruTamVangDAO();
        CongDan cd;
        CongDanDAO cddao = new CongDanDAO();
        CCCDDAO cccdDAO = new CCCDDAO();
        CCCD cccd;
        public FTamTruTamVang()
        {
            InitializeComponent();
        }
        private void HienThiDanhSach()
        {
            cccd = cccdDAO.TimKiem_ID(txtTCCCD.Text);
            this.Lichsudichuyen.DataSource = ttdao.LayDanhSachLichsu(cccd.CD);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            cccd = cccdDAO.TimKiem_ID(txtsoCC.Text);
            tt = new TamTruTamVang(cccd.CD, Come.Value.Date, Leave.Value.Date, txtAdd.Text, txtLido.Text);
            if (String.IsNullOrEmpty(txtsoCC.Text) ||
                String.IsNullOrEmpty(txtAdd.Text) ||
                String.IsNullOrEmpty(txtLido.Text))
            {
                MessageBox.Show("Them That bai");
            }
            else
            {
                ttdao.Them(tt);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cccd = cccdDAO.TimKiem_ID(txtsoCC.Text);
            tt = new TamTruTamVang(cccd.CD, Come.Value.Date, Leave.Value.Date, txtAdd.Text, txtLido.Text);
            ttdao.Xoa(tt);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtsoCC.Text) ||
                String.IsNullOrEmpty(txtAdd.Text) ||
                String.IsNullOrEmpty(txtLido.Text))
            {
                MessageBox.Show("Sua That bai");
            }
            else
            {
                cccd = cccdDAO.TimKiem_ID(txtsoCC.Text);
                tt = new TamTruTamVang(cccd.CD, Come.Value.Date, Leave.Value.Date, txtAdd.Text, txtLido.Text);
                ttdao.Sua(tt);
            }
        }
        private void tim_Click(object sender, EventArgs e)
        {
            cccd = cccdDAO.TimKiem_ID(txtTCCCD.Text);
            tt = ttdao.TimKiemTT(cccd.CD);
            cd = cddao.TimKiem(cccd.CD);
            if (tt != null)
            {
                txtIDCDs.Text = tt.IDCD;
                txtHoTen.Text = cd.HoTen;
                txtADDthuongtru.Text = cd.QueQuan;
            }
            HienThiDanhSach();
        }

        private void FTamTruTamVang_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }

    }
}
