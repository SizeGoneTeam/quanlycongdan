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
        public FTamTruTamVang()
        {
            InitializeComponent();
        }
        private void HienThiDanhSach()
        {
            this.gvTTTV.DataSource = ttdao.LayDanhSachTamTruTamVang();
        }
        private void FTamTruTamVang_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }

        private void gvTTTV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gvTTTV.Rows[e.RowIndex];
                txtIDTT.Text = row.Cells[1].Value.ToString();
                txtIDCD.Text = row.Cells[2].Value.ToString();
                txtAdd.Text = row.Cells[5].Value.ToString();
                try
                {
                    Come.Value = (DateTime)row.Cells[3].Value;
                    Leave.Value = (DateTime)row.Cells[4].Value;
                }
                catch
                {
                    Come.Value = DateTime.Now;
                    Leave.Value = DateTime.Now;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tt = new TamTruTamVang(txtIDTT.Text, txtIDCD.Text, Come.Value.Date, Leave.Value.Date, txtAdd.Text);
            ttdao.Them(tt);
            HienThiDanhSach();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tt = new TamTruTamVang(txtIDTT.Text, txtIDCD.Text, Come.Value.Date, Leave.Value.Date, txtAdd.Text);
            ttdao.Xoa(tt);
            HienThiDanhSach();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tt = new TamTruTamVang(txtIDTT.Text, txtIDCD.Text, Come.Value.Date, Leave.Value.Date, txtAdd.Text);
            ttdao.Sua(tt);
            HienThiDanhSach();
        }
    }
}
