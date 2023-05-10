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
    public partial class FTamTruTamVang : Form
    {
        TamTruTamVang tt;
        /*TamTruTamVangDAO ttdao = new TamTruTamVangDAO();*/
        CongDan cd;
        /*CongDanDAO cddao = new CongDanDAO();
        CCCDDAO cccdDAO = new CCCDDAO();*/
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
            /*cccd = cccdDAO.TimKiem_ID(txtTCCCD.Text);
            if(cccd != null)
            {
                this.Lichsudichuyen.DataSource = ttdao.LayDanhSachLichsu(cccd.IDCD);
            }
            else
                this.Lichsudichuyen.DataSource = null;*/
        }
        private void button1_Click(object sender, EventArgs e)
        {
            /*cccd = cccdDAO.TimKiem_ID(txtsoCC.Text);
            TamTruTamVang ttold;
            TamTruTamVang ttnew;
            ttold = ttdao.TimKiemTT(cccd.IDCD);
            ttnew = new TamTruTamVang(cccd.IDCD, Come.Value.Date, Leave.Value.Date, txtAdd.Text, txtLido.Text);
            if (txtsoCC.Text == "  ID Công Dân" ||
                txtAdd.Text == "  Số CCCD" ||
                txtLido.Text == "  Địa Chỉ" ||
                txtsoCC.Text == "" ||
                txtAdd.Text == "" ||
                txtLido.Text == "" ||
                Come.Value >= Leave.Value)
            {
                if (Come.Value >= Leave.Value) MessageBox.Show("Ngày đến không được vượt quá ngày đi.");
                else MessageBox.Show("Hãy Điền Thông Tin");
            }
            else if(ttnew.Come.Date >= ttold.Come.Date && ttnew.Come.Date <= ttold.Leave || ttnew.Leave.Date <= ttold.Leave.Date && ttnew.Leave.Date >= ttold.Come.Date)
            {
                MessageBox.Show("Trong Cùng Thời Gian Không Thể Tạm Trú Ở Hai Nơi Cùng Lúc.");
            }
            else
            {
                ttdao.Them(ttnew);
                MessageBox.Show("Hoàn Thành.");
                HienThiDanhSach();
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*if (txtsoCC.Text == "  ID Công Dân" ||
                txtsoCC.Text == "")
            {
                MessageBox.Show("Hãy Điền Thông Tin.");
            }
            else
            {
                cccd = cccdDAO.TimKiem_ID(txtsoCC.Text);
                tt = new TamTruTamVang(cccd.IDCD, Come.Value.Date, Leave.Value.Date, txtAdd.Text, txtLido.Text);
                ttdao.Xoa(tt);
                MessageBox.Show("Hoàn Thành.");
                HienThiDanhSach();
            }*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtsoCC.Text == "  ID Công Dân" ||
                txtAdd.Text == "  Số CCCD" ||
                txtLido.Text == "  Địa Chỉ" ||
                txtsoCC.Text == "" ||
                txtAdd.Text == "" ||
                txtLido.Text == "" ||
                Come.Value >= Leave.Value)
            {
                if (Come.Value >= Leave.Value) MessageBox.Show("Ngày đến không được vượt quá ngày đi.");
                else MessageBox.Show("Hãy Điền Thông Tin");
            }
            else
            {
                /*cccd = cccdDAO.TimKiem_ID(txtsoCC.Text);
                tt = new TamTruTamVang(cccd.IDCD, Come.Value.Date, Leave.Value.Date, txtAdd.Text, txtLido.Text);
                ttdao.Sua(tt);
                MessageBox.Show("Hoàn Thành.");
                HienThiDanhSach();*/
            }
        }
        private void tim_Click(object sender, EventArgs e)
        {
            /*cccd = cccdDAO.TimKiem_ID(txtTCCCD.Text);
            tt = ttdao.TimKiemTT(cccd.IDCD);
            cd = cddao.TimKiem(cccd.IDCD);
            if (tt != null)
            {
                txtIDCDs.Text = tt.IDCD;
                txtHoTen.Text = cd.HoTen;
                txtADDthuongtru.Text = cd.QueQuan;
            }
            HienThiDanhSach();*/
        }

        private void FTamTruTamVang_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }
        public static void enter(TextBox a)
        {
            if (a.Text != null || a.Text !="")
            {
                a.Text = "";
                a.ForeColor = Color.Black;
            }
        }
        private void txtTCCCD_Enter(object sender, EventArgs e)
        {
            enter(txtTCCCD);
        }

        private void txtsoCC_Enter(object sender, EventArgs e)
        {
            enter(txtsoCC);
        }

        private void txtAdd_Enter(object sender, EventArgs e)
        {
            enter(txtAdd);
        }

        private void txtLido_Enter(object sender, EventArgs e)
        {
            enter(txtLido);
        }

        private void btnDanhSachQuaHan_Click(object sender, EventArgs e)
        {
            /*Lichsudichuyen.DataSource = ttdao.LayDanhSachQuaHan();*/
        }
    }
}
