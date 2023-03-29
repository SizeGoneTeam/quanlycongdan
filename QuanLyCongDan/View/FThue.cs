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
    public partial class FThue : Form
    {
        Thue thue;
        ThueDAO thueDAO = new ThueDAO();
        public FThue()
        {
            InitializeComponent();
        }
        private void HienThiDanhSach()
        {
            this.gvThue.DataSource = thueDAO.LayDanhSachThue();
        }
        private void FThue_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtIDT.Text) ||
                String.IsNullOrEmpty(txtID.Text) ||
                String.IsNullOrEmpty(txtMso.Text))
            {
                MessageBox.Show("Them That bai");
            }
            else
            {
                thue = new Thue(txtIDT.Text, txtID.Text, txtMso.Text, dTPNgayUp.Value.Date);
                thueDAO.Them(thue);
                HienThiDanhSach();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            thue = new Thue(txtIDT.Text, txtID.Text, txtMso.Text, dTPNgayUp.Value.Date);
            thueDAO.Xoa(thue);
            HienThiDanhSach();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtIDT.Text) ||
                String.IsNullOrEmpty(txtID.Text) ||
                String.IsNullOrEmpty(txtMso.Text))
            {
                MessageBox.Show("Sua That bai");
            }
            else
            {
                thue = new Thue(txtIDT.Text, txtID.Text, txtMso.Text, dTPNgayUp.Value.Date);
                thueDAO.Sua(thue);
                HienThiDanhSach();
            }
        }
        private void gvThue_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = gvThue.Rows[e.RowIndex];
                txtIDT.Text = row.Cells[0].Value.ToString();
                txtID.Text = row.Cells[1].Value.ToString();
                txtMso.Text = row.Cells[2].Value.ToString();
                try
                {
                    dTPNgayUp.Value = (DateTime)row.Cells[3].Value;
                }
                catch
                {
                    dTPNgayUp.Value = DateTime.Now;
                }
            }
        }

        private void FThue_Load_1(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }
    }
}
