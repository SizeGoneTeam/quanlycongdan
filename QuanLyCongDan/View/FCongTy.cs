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


        private void HienThiDanhSachCongTy()
        {
            this.gvCongTy.DataSource = ctDAO.LayDanhSachCongTy();
        }

        private void HienThiDanhSachCongTyNhanVien()
        {
            this.gvCongTy.DataSource = ctDAO.LayDanhSachCongTyNhanVien(cd);
        }


        private void txtCongTy_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCongTy.Text))
            {
                btnThemCongTy.Enabled = false;
            }
            else
            {
                KiemTraThemNhanVien();
                try
                {
                    if(KiemTraCongTy(txtCongTy.Text)) btnThemCongTy.Enabled = false;
                    else btnThemCongTy.Enabled=true;
                }
                catch
                {
                    btnThemCongTy.Enabled = false;
                }

            }
        }

        private void TatButton()
        {
            btnThemCongTy.Enabled = false;
            btnThemNhanVien.Enabled = false;
            btnNghiViec.Enabled = false;
            btnSuaLuong.Enabled = false;
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {

            ctnv = new CongTyNhanVien(ct.Id_CongTy,int.Parse(cd.Id), long.Parse(txtLuong.Text));
            ctDAO.ThemCongTyNhanVien(ctnv);
            HienThiDanhSachCongTyNhanVien();
            try
            {
                cccd = cccdDAO.TimKiem_ID(txtCCCD.Text);
                cd = cdDAO.TimKiem(cccd.IDCD);
            }
            catch
            {

            }
            btnThemNhanVien.Enabled = false;
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

            if (KiemTraCCCDTonTai()) btnXemCCCD.Enabled = true;
            else btnXemCCCD.Enabled = false;

        }

        private void btnXemCCCD_Click(object sender, EventArgs e)
        {
            try
            {
                cccd = cccdDAO.TimKiem_ID(txtCCCD.Text);
                cd = cdDAO.TimKiem(cccd.IDCD);
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

        private bool KiemTraCCCDDiLam()
        {
            try
            {
                cccd = cccdDAO.TimKiem_ID(txtCCCD.Text);
                cd = cdDAO.TimKiem(cccd.IDCD);
                ct = ctDAO.TimKiem(txtCongTy.Text);
                return ctDAO.KiemTraNhanVienCoDiLamCongTy(cd,ct.Id_CongTy);
            }
            catch
            {
                return false;
            }

        }

        private bool KiemTraCCCDTonTai()
        {
            try
            {
                cccd = cccdDAO.TimKiem_ID(txtCCCD.Text);
                cd = cdDAO.TimKiem(cccd.IDCD);
                return cd != null;
            }
            catch
            {
                return false;
            }

        }

        private bool KiemTraCongTy(String tenCongTy)
        {
            try
            {
                ct = ctDAO.TimKiem(tenCongTy);
                return ct != null;
            }
            catch
            {
                return false;
            }

        }

        private void KiemTraThemNhanVien()
        {
            if (!string.IsNullOrWhiteSpace(txtCongTy.Text) && !KiemTraCCCDDiLam() && KiemTraCongTy(txtCongTy.Text) && !string.IsNullOrWhiteSpace(txtLuong.Text)) btnThemNhanVien.Enabled = true;
            else btnThemNhanVien.Enabled = false;

            if (KiemTraCCCDDiLam())
            {
                btnNghiViec.Enabled = true;
                if(!string.IsNullOrWhiteSpace(txtLuong.Text)) btnSuaLuong.Enabled = true;
                else btnSuaLuong.Enabled = false;
            }

            else
            {
                btnNghiViec.Enabled = false;
                btnSuaLuong.Enabled = false;
            }
        }

        private void txtLuong_TextChanged(object sender, EventArgs e)
        {
            KiemTraThemNhanVien();

        }

        private void btnThemNhanVien_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void btnXemCongTy_Click(object sender, EventArgs e)
        {
            try
            {
                ct = ctDAO.LayCongTyBangTen(txtCongTy.Text);
                this.gvCongTy.DataSource = ctDAO.LayDanhSachCongTyNhanVien(ct);
            }
            catch
            {

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSuaLuong_Click(object sender, EventArgs e)
        {
            cccd = cccdDAO.TimKiem_ID(txtCCCD.Text);
            cd = cdDAO.TimKiem(cccd.IDCD);
            ct = ctDAO.TimKiem(txtCongTy.Text);
            ctnv = ctDAO.LayCongTyNhanVien(int.Parse(cd.Id),ct.Id_CongTy);
            ctnv.Luong = decimal.Parse(txtLuong.Text);
            ctDAO.SuaLuong(ctnv);
            this.gvCongTy.DataSource = ctDAO.LayDanhSachCongTyNhanVien(cd);
        }

        private void btnNghiViec_Click(object sender, EventArgs e)
        {
            cccd = cccdDAO.TimKiem_ID(txtCCCD.Text);
            cd = cdDAO.TimKiem(cccd.IDCD);
            ct = ctDAO.LayCongTyBangTen(txtCongTy.Text);
            ctnv = ctDAO.LayCongTyNhanVien(int.Parse(cd.Id),ct.Id_CongTy);
            ctDAO.NghiViec(ctnv);
            this.gvCongTy.DataSource = ctDAO.LayDanhSachCongTyNhanVien(cd);
            TatButton();
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

        private void txtLuong_Enter(object sender, EventArgs e)
        {
            if (txtLuong.Text == "  Lương")
            {
                txtLuong.Text = "";
                txtLuong.ForeColor = Color.Black;
            }
        }
    }
}
