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
        /*ThueDAO thueDAO = new ThueDAO();
        CCCDDAO cccdDAO = new CCCDDAO();
        CongDanDAO cdDAO = new CongDanDAO();*/
        CongTy ct;
/*        CongTyDAO ctDAO = new CongTyDAO();
*/        CongDan cd;

        public FThue()
        {
            InitializeComponent();
        }
        private void HienThiLichSuThue(int idCD)
        {
/*            this.gvThue.DataSource = thueDAO.LayLichSuThueTheoIDCongDan(idCD);
*/        }
        private void FThue_Load(object sender, EventArgs e)
        {

        }

        private void btnCCCD_Click(object sender, EventArgs e)
        {
            /*try
            {
                CCCD cccd = cccdDAO.TimKiem_ID(txtCCCD.Text);
                cd = cdDAO.TimKiem(cccd.IDCD);
                List<CongTyNhanVien> ctnvList = ctDAO.LayCongTyNhanVien(int.Parse(cd.Id));
                foreach (CongTyNhanVien ctnv in ctnvList)
                {
                    ct = ctDAO.LayCongTy(ctnv.Id_CongTy);
                    int yearDiff = GetYearsDiff(ctnv.NgayVao);
                    if (yearDiff > 0)
                    {
                        for (int i = 0; i < yearDiff; i++)
                        {
                            if (!thueDAO.TimKiemThue(ctnv.Id_NhanVien, ct.TenCongTy, ctnv.NgayVao.AddYears(i+1)))
                            {
                                LichSuThue lsThue = new LichSuThue(ctnv.Id_NhanVien, ct.TenCongTy, ctnv.Luong * 20/100, ctnv.NgayVao.AddYears(i + 1));
                                thueDAO.ThemLichSuThue(lsThue);
                            }
                        }
                    }
                }

                this.gvThue.DataSource = thueDAO.LayLichSuThueTheoIDCongDan(int.Parse(cd.Id));
            }
            catch
            {

            }*/
        }

        private void btnCongTy_Click(object sender, EventArgs e)
        {
            /*try
            {
                this.gvThue.DataSource = thueDAO.LayLichSuThueTheoCongTY(ct.TenCongTy);
            }
            catch
            {

            }*/
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
            /*thueDAO.NopThue(int.Parse(cd.Id));
            this.gvThue.DataSource = thueDAO.LayLichSuThueTheoIDCongDan(int.Parse(cd.Id));*/
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
           /* this.dgvDanhSach.DataSource = thueDAO.LayCongDanChuaDongThue();*/
        }
    }
}
