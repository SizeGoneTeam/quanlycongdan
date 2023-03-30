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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyCongDan.View
{
    public partial class FCongTy : Form
    {
        CongTyDAO ctDAO = new CongTyDAO();
        CongTy ct;
        CCCDDAO cccdDAO =  new CCCDDAO();
        CongDanDAO cdDAO = new CongDanDAO();
        CongDan cd;
        CongTyNhanVien ctnv;
        LichSuThue lichSuThue;
        Thue thue;
        ThueDAO thueDAO = new ThueDAO();
        CCCD cccd;
        public FCongTy()
        {
            InitializeComponent();
            TatButton();

        }

        private void txtLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự không phải số
            }
        }

        private void btnThemCongTy_Click(object sender, EventArgs e)
        {
            ct = new CongTy(txtCongTy.Text);
            if (ctDAO.KiemTraCongTyTonTai(ct)){
                // Nếu công ty đã tồn tại
                MessageBox.Show("Công ty đã tồn tại");
                TatButton();
                HienThiDanhSachCongTy();
            }
            else
            {
                // Nếu chưa tồn tại
                ctDAO.ThemCongTy(ct);
                MessageBox.Show("Thêm thành công");
                HienThiDanhSachCongTy();
            }
            

        }

        private void btnTraLuong_Click(object sender, EventArgs e)
        {
            cccd = cccdDAO.TimKiem_ID(txtCCCD.Text);
            thue = thueDAO.TimKiem_ID(int.Parse(cd.Id));
            lichSuThue = new LichSuThue(int.Parse(thue.IDCongDan), int.Parse(thue.IDThue), ct.TenCongTy, ctnv.Luong * 20 /100);
        }

        private void HienThiDanhSachCongTy()
        {
            this.gvCongTy.DataSource = ctDAO.LayDanhSachCongTy();
        }

        private void HienThiDanhSachCongTyNhanVien()
        {
            this.gvCongTy.DataSource = ctDAO.LayDanhSachCongTyNhanVien();
        }


        private void txtCongTy_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCongTy.Text))
            {
                TatButton();
            }
            else
            {
                btnThemCongTy.Enabled = true;
                KiemTraThemNhanVien();
            }
        }

        private void TatButton()
        {
            btnThemCongTy.Enabled = false;
            btnThemNhanVien.Enabled = false;
            btnNghiViec.Enabled = false;
            btnSuaLuong.Enabled = false;
            btnTraLuong.Enabled = false;
            btnXemCongTy.Enabled = false;
            btnXemCCCD.Enabled = false;
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {

            ctnv = new CongTyNhanVien(ct.Id_CongTy,int.Parse(cd.Id), long.Parse(txtLuong.Text));
            ctDAO.ThemCongTyNhanVien(ctnv);
            HienThiDanhSachCongTyNhanVien();
        }

        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtCCCD.Text))
            {
                btnThemNhanVien.Enabled=false;
            }
            else
            {
                KiemTraThemNhanVien();
            }

            if (KiemTraCCCD()) btnXemCCCD.Enabled = true;
            else btnXemCCCD.Enabled = false;

        }

        private void btnXemCCCD_Click(object sender, EventArgs e)
        {
            try
            {
                cccd = cccdDAO.TimKiem_ID(txtCCCD.Text);
                cd = cdDAO.TimKiem(cccd.IDCC);
                this.gvCongTy.DataSource = ctDAO.LayDanhSachCongTyNhanVien(cd);
            }
            catch
            {

            }

        }

        private void txtCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Chặn ký tự không phải số
            }
        }

        private bool KiemTraCCCD()
        {
            try
            {
                cccd = cccdDAO.TimKiem_ID(txtCCCD.Text);
                cd = cdDAO.TimKiem(cccd.IDCC);
                return cd != null;
            }
            catch
            {
                return false;
            }

        }

        private bool KiemTraCongTy()
        {
            try
            {
                ct = ctDAO.TimKiem(txtCongTy.Text);
                return ct != null;
            }
            catch
            {
                return false;
            }

        }

        private void KiemTraThemNhanVien()
        {
            if (!string.IsNullOrWhiteSpace(txtCongTy.Text) && KiemTraCCCD() && KiemTraCongTy() && !string.IsNullOrWhiteSpace(txtLuong.Text)) btnThemNhanVien.Enabled = true;
            else btnThemNhanVien.Enabled = false;
        }

        private void txtLuong_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCongTy.Text) && KiemTraCCCD() && KiemTraCongTy() && !string.IsNullOrWhiteSpace(txtLuong.Text)) btnThemNhanVien.Enabled = true;
            else btnThemNhanVien.Enabled = false;
        }

        private void btnThemNhanVien_EnabledChanged(object sender, EventArgs e)
        {
            if (btnThemNhanVien.Enabled) btnTraLuong.Enabled = true;
            else btnTraLuong.Enabled = false;
        }
    }
}
