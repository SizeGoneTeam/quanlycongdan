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
    public partial class FHonNhan : Form
    {
        CongDan cd = new CongDan();
        CongDanDAO cdDAO = new CongDanDAO();
        HonNhanDAO honNhanDAO = new HonNhanDAO();
        HonNhan hn;
        CCCD cccd;
        CCCDDAO cccdDAO = new CCCDDAO();
        public FHonNhan()
        {
            InitializeComponent();
            cboNoiDK.SelectedIndex = 0;
            btnLyHon.Enabled = false;
            btnThem.Enabled = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            //Chồng
            try
            {
                cccd = cccdDAO.TimKiem_ID(txtID_Chong.Text);
                cd = cdDAO.TimKiem(cccd.IDCD);
                lblHoTenChong.Text = cd.HoTen;
                lblNgaySinhChong.Text = cd.NgaySinh.Date.ToString();
                if(lblHoTenChong.Text != "" && lblHoTenVo.Text != "") btnThem.Enabled=true;
                else btnThem.Enabled=false;
            }
            catch
            {
                lblHoTenChong.Text = "";
                lblNgaySinhChong.Text = "";
                btnThem.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Vợ
            try
            {
                cccd = cccdDAO.TimKiem_ID(txtID_Vo.Text);
                cd = cdDAO.TimKiem(cccd.IDCD);
                lblHoTenVo.Text = cd.HoTen;
                lblNgaySinhVo.Text = cd.NgaySinh.Date.ToString();
                if (lblHoTenChong.Text != "" && lblHoTenVo.Text != "") btnThem.Enabled = true;
                else btnThem.Enabled = false;
            }
            catch
            {
                lblHoTenVo.Text = "";
                lblNgaySinhVo.Text = "";
                btnThem.Enabled = false;
            }
        }

        private void cboThem_Click(object sender, EventArgs e)
        {
            HonNhan honNhan = new HonNhan(Int32.Parse(txtID_Chong.Text), Int32.Parse(txtID_Vo.Text), cboNoiDK.SelectedItem.ToString());
            honNhanDAO.Them(honNhan);
            HonNhanMoi();
        }

        private void cboTimKiem_Click(object sender, EventArgs e)
        {
            TimKiemHonNhan(int.Parse(txtIdHonNhan.Text));
        }

        private void TimKiemHonNhan(int idHonNhan)
        {
            try
            {
                hn = honNhanDAO.TimKiemId(idHonNhan);
                lblTK_IdChong_txt.Text = hn.IdChong.ToString();
                lblTK_IdVo_txt.Text = hn.IdVo.ToString();
                lblTK_NgayDK_txt.Text = hn.NgayDangKy.ToString();
                lblTK_NoiDK_txt.Text = hn.NoiDangKy.ToString();
                if (hn.TrangThai) lblTrangThai_txt.Text = "Kết Hôn";
                else lblTrangThai_txt.Text = "Ly Hôn";
                btnLyHon.Enabled = true;

            }
            catch
            {
                lblTK_IdChong_txt.Text = "";
                lblTK_IdVo_txt.Text = "";
                lblTK_NgayDK_txt.Text = "";
                lblTK_NoiDK_txt.Text = "";
                lblTrangThai_txt.Text = "";
                btnLyHon.Enabled = false;
            }
        }

        private void HonNhanMoi()
        {
            try
            {
                DataRow row = honNhanDAO.LayHonNhanMoi().Rows[0];
                txtIdHonNhan.Text = row["ID_HonNhan"].ToString();
                lblTK_IdChong_txt.Text = row["ID_Chong"].ToString();
                lblTK_IdVo_txt.Text = row["ID_Chong"].ToString();
                lblTK_NgayDK_txt.Text = row["NgayDangKy"].ToString();
                lblTK_NoiDK_txt.Text = row["NoiDangKy"].ToString();
                if (row["TrangThai"].ToString().Equals("True")) lblTrangThai_txt.Text = "Kết Hôn";
                else lblTrangThai_txt.Text = "Ly Hôn";
            }
            catch
            {
                lblTK_IdChong_txt.Text = "";
                lblTK_IdVo_txt.Text = "";
                lblTK_NgayDK_txt.Text = "";
                lblTK_NoiDK_txt.Text = "";
                lblTrangThai_txt.Text = "";
            }
        }

        private void TimKiemHonNhan_ChongVo(int idChong, int idVo)
        {
            try
            {
                hn = honNhanDAO.TimKiem_ChongVo(idChong, idVo);
                lblTK_IdChong_txt.Text = hn.IdChong.ToString();
                lblTK_IdVo_txt.Text = hn.IdVo.ToString();
                lblTK_NgayDK_txt.Text = hn.NgayDangKy.ToString();
                lblTK_NoiDK_txt.Text = hn.NoiDangKy.ToString();
                if (hn.TrangThai) lblTrangThai_txt.Text = "Kết Hôn";
                else lblTrangThai_txt.Text = "Ly Hôn";
                btnLyHon.Enabled = true;

            }
            catch
            {
                lblTK_IdChong_txt.Text = "";
                lblTK_IdVo_txt.Text = "";
                lblTK_NgayDK_txt.Text = "";
                lblTK_NoiDK_txt.Text = "";
                lblTrangThai_txt.Text = "";
                btnLyHon.Enabled = false;
            }
        }

        private void btnLyHon_Click(object sender, EventArgs e)
        {
            honNhanDAO.LyHon(lblTK_IdChong_txt.Text,lblTK_IdVo_txt.Text);
            TimKiemHonNhan(int.Parse(txtIdHonNhan.Text));
        }
    }
}
