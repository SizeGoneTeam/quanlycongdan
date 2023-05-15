using QuanLyCongDan.DAO;
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
        CongDan cd;

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
                cd = cdDAO.TimKiem(cccd.ID_CongDan.ToString());
                List<CongTy_NhanVien> ctnvList = ctDAO.LayCongTyNhanVien(cd.ID_CongDan);
                foreach (CongTy_NhanVien ctnv in ctnvList)
                {
                    ct = ctDAO.LayCongTy(ctnv.ID_CongTy ?? 0);
                    int yearDiff = GetYearsDiff(ctnv.NgayVao ?? DateTime.Now);
                    if (yearDiff > 0)
                    {
                        for (int i = 0; i < yearDiff; i++)
                        {
                            DateTime ngayVaoPlusYears = (ctnv.NgayVao ?? DateTime.Now).AddYears(i + 1);
                            if (!thueDAO.TimKiemThue(ctnv.ID_NhanVien??0, ct.TenCongTy, ngayVaoPlusYears))
                            {
                                LichSuThue lsThue = new LichSuThue(ctnv.ID_NhanVien, ct.TenCongTy, ctnv.Luong * 20 / 100, ngayVaoPlusYears);
                                thueDAO.ThemLichSuThue(lsThue);
                            }
                        }
                    }
                }

                this.gvThue.DataSource = thueDAO.LayLichSuThueTheoIDCongDan(cd.ID_CongDan);
            }
            catch
            {

            }

        }

        private void btnCongTy_Click(object sender, EventArgs e)
        {
            try
            {
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

        }

        private void txtIDT_Enter(object sender, EventArgs e)
        {

        }

        private void FThue_Load_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNopThue_Click(object sender, EventArgs e)
        {
            thueDAO.NopThue(cd.ID_CongDan);
            this.gvThue.DataSource = thueDAO.LayLichSuThueTheoIDCongDan(cd.ID_CongDan);
        }

        public int GetYearsDiff(DateTime firstDate)
        {
            int yearsDiff = DateTime.Now.Year - firstDate.Year;
            if (yearsDiff > 0)
            {
                return yearsDiff;
            }
            return 0;
        }

        private void btnChuaDongThue_Click(object sender, EventArgs e)
        {
            this.dgvDanhSach.DataSource = thueDAO.LayCongDanChuaDongThue();
        }
    }
}
