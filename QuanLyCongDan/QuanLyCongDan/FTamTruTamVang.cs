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
        public FTamTruTamVang()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtIDCD.Text) ||
                String.IsNullOrEmpty(txtAdd.Text) ||
                String.IsNullOrEmpty(txtLido.Text))
            {
                MessageBox.Show("Them That bai");
            }
            else
            {
                tt = new TamTruTamVang(txtIDCD.Text, Come.Value.Date, Leave.Value.Date, txtAdd.Text, txtLido.Text);
                ttdao.Them(tt);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tt = new TamTruTamVang(txtIDCD.Text, Come.Value.Date, Leave.Value.Date, txtAdd.Text, txtLido.Text);
            ttdao.Xoa(tt);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtIDCD.Text) ||
                String.IsNullOrEmpty(txtAdd.Text) ||
                String.IsNullOrEmpty(txtLido.Text))
            {
                MessageBox.Show("Sua That bai");
            }
            else
            {
                tt = new TamTruTamVang(txtIDCD.Text, Come.Value.Date, Leave.Value.Date, txtAdd.Text, txtLido.Text);
                ttdao.Sua(tt);
            }
        }
        private void TimKiem(String id)
        {
            try
            {
                tt = ttdao.TimKiem(id);
                txtIDCDs.Text = tt.IDCD;
                Comes.Value = tt.Come;
                Leaves.Value = tt.Leave;
                txtADDtamtru.Text = tt.Add;
                txtWhys.Text = tt.Why;
            }
            catch { }
        }
        private void tim_Click(object sender, EventArgs e)
        {
            //TimKiem(txtTCCCD.Text);
            int id;

            if (int.TryParse(txtTCCCD.Text, out id))
            {
                TamTruTamVang tt = ttdao.TimKiemTT(id);
                if (tt != null)
                {
                    txtIDCDs.Text = tt.IDCD;
                    Comes.Value = tt.Come;
                    Leave.Value = tt.Leave;
                    txtADDtamtru.Text = tt.Add;
                    txtWhys.Text=tt.Why;
                }
            }
        }
    }
}
