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
        public FTamTruTamVang(string input): this()
        {
            string nhan;
            nhan = input;
            txtTCCCD.Text = nhan;
        }
        private void HienThiDanhSach()
        {
            cccd = cccdDAO.TimKiem_ID(txtTCCCD.Text);
            if(cccd != null)
            {
                this.Lichsudichuyen.DataSource = ttdao.LayDanhSachLichsu(cccd.IDCD);
            }
            else
                this.Lichsudichuyen.DataSource = null;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            cccd = cccdDAO.TimKiem_ID(txtsoCC.Text);
            tt = new TamTruTamVang(cccd.IDCD, Come.Value.Date, Leave.Value.Date, txtAdd.Text, txtLido.Text);
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
            tt = new TamTruTamVang(cccd.IDCD, Come.Value.Date, Leave.Value.Date, txtAdd.Text, txtLido.Text);
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
                tt = new TamTruTamVang(cccd.IDCD, Come.Value.Date, Leave.Value.Date, txtAdd.Text, txtLido.Text);
                ttdao.Sua(tt);
            }
        }
        private void tim_Click(object sender, EventArgs e)
        {
            cccd = cccdDAO.TimKiem_ID(txtTCCCD.Text);
            tt = ttdao.TimKiemTT(cccd.IDCD);
            cd = cddao.TimKiem(cccd.IDCD);
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
            if (string.IsNullOrEmpty(txtTCCCD.Text))
                HienThiDanhSach();
            else
            {
                HienThiDanhSach();
                tim.PerformClick();
            }
        }
    }
}
