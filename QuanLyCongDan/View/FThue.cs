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

namespace QuanLyCongDan.View
{
    public partial class FThue : Form
    {
        ThueDAO thueDAO = new ThueDAO();
        CCCDDAO cccdDAO = new CCCDDAO();
        CongDanDAO cdDAO = new CongDanDAO();
        CongTy ct;
        CongTyDAO ctDAO = new CongTyDAO();
        public FThue()
        {
            InitializeComponent();
        }
        private void HienThiLichSuThue(int idCD)
        {
            this.gvThue.DataSource = thueDAO.LayLichSuThueTheoIDCongDan(idCD);
        }
        private void FThue_Load(object sender, EventArgs e)
        {

        }

        private void btnCCCD_Click(object sender, EventArgs e)
        {
            try
            {
                CCCD cccd = cccdDAO.TimKiem_ID(txtCCCD.Text);
                CongDan cd = cdDAO.TimKiem(cccd.IDCD);
                this.gvThue.DataSource = thueDAO.LayLichSuThueTheoIDCongDan(int.Parse(cd.Id));
            }
            catch
            {

            }
        }

        private void btnCongTy_Click(object sender, EventArgs e)
        {
            try
            {
                ct = ctDAO.LayCongTyBangTen(txtCongTy.Text);
                this.gvThue.DataSource = thueDAO.LayLichSuThueTheoCongTY(ct.TenCongTy);
            }
            catch
            {

            }
        }

        private void txtCCCD_Enter(object sender, EventArgs e)
        {
            if (txtCCCD.Text == "  CCCD")
            {
                txtCCCD.Text = "";
                txtCCCD.ForeColor = Color.Black;
            }
        }

        private void txtCongTy_Enter(object sender, EventArgs e)
        {
            if (txtCongTy.Text == "  Tên Công Ty")
            {
                txtCongTy.Text = "";
                txtCongTy.ForeColor = Color.Black;
            }
        }

        private void txtIDT_Enter(object sender, EventArgs e)
        {
            if (txtIDT.Text == "  ID Thuế")
            {
                txtIDT.Text = "";
                txtIDT.ForeColor = Color.Black;
            }
        }
    }
}
