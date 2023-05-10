using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using System.Data.Entity;

namespace QuanLyCongDan
{
    public partial class FCCCD : Form
    {
        public FCCCD()
        {
            InitializeComponent();
        }
        private void tim_Click(object sender, EventArgs e)
        {
            /*cccd = cccdDAO.TimKiem_ID(txtTcccd.Text);
            if (cccd != null)
            {
                cd = cddao.TimKiem(cccd.IDCD);
                if (cd != null)
                {
                    txtHoTen.Text = cd.HoTen;
                    IDs.Text = cccd.IDCD;
                    soCCCD.Text = txtTcccd.Text;
                    GioiTinh.Text = cd.GioiTinh;
                    birth.Text = cd.NgaySinh.Date.ToString();
                    txtDanToc.Text = cd.DanToc;
                    txtTonGiao.Text = cd.TonGiao;
                    txtQQ.Text = cd.QueQuan;
                    adds.Text = cccd.ADD;
                    dates.Text = cccd.NgayCap.Date.ToString();
                }
                else
                    MessageBox.Show("Số CCCD Sai, Xin Nhập Lại");
            }
            else
                MessageBox.Show("Số CCCD Sai, Xin Nhập Lại");*/

            using (var db = new QLCongDanEntities())
            {
                var cccd = db.CCCDs.FirstOrDefault(c => c.SoCCCD == txtTcccd.Text);
                if (cccd != null)
                {
                    var cd = db.CongDans.FirstOrDefault(c => c.IDCD == cccd.IDCD);
                    if (cd != null)
                    {
                        txtHoTen.Text = cd.HoTen;
                        IDs.Text = cccd.IDCD;
                        soCCCD.Text = txtTcccd.Text;
                        GioiTinh.Text = cd.GioiTinh;
                        birth.Text = cd.NgaySinh.Date.ToString();
                        txtDanToc.Text = cd.DanToc;
                        txtTonGiao.Text = cd.TonGiao;
                        txtQQ.Text = cd.QueQuan;
                        adds.Text = cccd.ADD;
                        dates.Text = cccd.NgayCap.Date.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Số CCCD Sai, Xin Nhập Lại");
                    }
                }
                else
                {
                    MessageBox.Show("Số CCCD Sai, Xin Nhập Lại");
                }
            }

        }
        public static void enter(TextBox a)
        {
            if (a.Text != null || a.Text != "")
            {
                a.Text = "";
                a.ForeColor = Color.Black;
            }
        }
        private void txtTcccd_Enter(object sender, EventArgs e)
        {
            enter(txtTcccd);
        }
        private void txtIDCD_Enter_1(object sender, EventArgs e)
        {
            enter(txtIDCD);
        }
        private void txtSOCC_Enter(object sender, EventArgs e)
        {
            enter(txtSOCC);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            /*DateTime now;
            now = DateTime.Now;
            cccdt = cccdDAO.TimKiem(txtIDCD.Text);
            if (txtIDCD.Text == "  ID Công Dân" ||
                txtSOCC.Text == "  Số CCCD" ||
                add.Text == "  Địa Chỉ" ||
                txtIDCD.Text == "" ||
                txtSOCC.Text == "" ||
                add.Text == "" ||
                dTPNgayCap.Value.Date > now)
            {
                if (dTPNgayCap.Value.Date > now) MessageBox.Show("Ngày cấp không được ở tương lai.");
                else MessageBox.Show("Hãy Điền Thông Tin.");
            }
            else if (cccdt.SoCC != "")
            {
                MessageBox.Show("Đã có căn cước công dân.\nXin hãy kiểm tra lại.");
            }
            else
            {
                cccd = new CCCD(txtIDCD.Text, txtSOCC.Text, dTPNgayCap.Value.Date, add.Text);
                cccdDAO.Them(cccd);
                MessageBox.Show("Hoàn Thành.");
            }*/
            using (var db = new QLCongDanEntities())
            {
                var now = DateTime.Now;
                var cccdt = db.CCCDs.Where(c => c.IDCD == txtIDCD.Text).FirstOrDefault();

                if (
                    txtIDCD.Text == "  ID Công Dân" ||
                    txtSOCC.Text == "  Số CCCD" ||
                    add.Text == "  Địa Chỉ" ||
                    string.IsNullOrWhiteSpace(txtIDCD.Text) ||
                    string.IsNullOrWhiteSpace(txtSOCC.Text) ||
                    string.IsNullOrWhiteSpace(add.Text) ||
                    dTPNgayCap.Value.Date > now
                )
                {
                    if (dTPNgayCap.Value.Date > now)
                    {
                        MessageBox.Show("Ngày cấp không được ở tương lai.");
                    }
                    else
                    {
                        MessageBox.Show("Hãy Điền Thông Tin.");
                    }
                }
                else if (cccdt != null)
                {
                    MessageBox.Show("Đã có căn cước công dân.\nXin hãy kiểm tra lại.");
                }
                else
                {
                    var cccd = new CCCD
                    {
                        ID_CongDan = Convert.ToInt32(txtIDCD.Text),
                        SoCCCD = txtSOCC.Text,
                        NgayCap = dTPNgayCap.Value.Date,
                        NoiCap = add.Text
                    };
                    db.CCCDs.Add(cccd);
                    db.SaveChanges();
                    MessageBox.Show("Hoàn Thành.");
                }
            }


        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            /*DateTime now;
            now = DateTime.Now;
            if (txtIDCD.Text == "  ID Công Dân" ||
                txtSOCC.Text == "  Số CCCD" ||
                add.Text == "  Địa Chỉ" ||
                txtIDCD.Text == "" ||
                txtSOCC.Text == "" ||
                add.Text == "" ||
                dTPNgayCap.Value.Date > now)
            {
                if (dTPNgayCap.Value.Date > now) MessageBox.Show("Ngày cấp không được ở tương lai.");
                else MessageBox.Show("Hãy Điền Thông Tin.");
            }
            else
            {
                cccd = new CCCD(txtIDCD.Text, txtSOCC.Text, dTPNgayCap.Value.Date, add.Text);
                cccdDAO.Sua(cccd);
                MessageBox.Show("Hoàn Thành.");
            }*/

            using (var db = new QLCongDanEntities())
            {
                var now = DateTime.Now;

                if (
                    txtIDCD.Text == "  ID Công Dân" ||
                    txtSOCC.Text == "  Số CCCD" ||
                    add.Text == "  Địa Chỉ" ||
                    string.IsNullOrWhiteSpace(txtIDCD.Text) ||
                    string.IsNullOrWhiteSpace(txtSOCC.Text) ||
                    string.IsNullOrWhiteSpace(add.Text) ||
                    dTPNgayCap.Value.Date > now
                )
                {
                    if (dTPNgayCap.Value.Date > now)
                    {
                        MessageBox.Show("Ngày cấp không được ở tương lai.");
                    }
                    else
                    {
                        MessageBox.Show("Hãy Điền Thông Tin.");
                    }
                }
                else
                {
                    var cccd = db.CCCDs.Where(c => c.IDCD == txtIDCD.Text).FirstOrDefault();

                    if (cccd != null)
                    {
                        cccd.SoCC = txtSOCC.Text;
                        cccd.NgayCap = dTPNgayCap.Value.Date;
                        cccd.DiaChi = add.Text;

                        db.SaveChanges();

                        MessageBox.Show("Hoàn Thành.");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin Căn Cước Công Dân.");
                    }
                }
            }

        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            /*cccd = new CCCD(txtIDCD.Text, txtSOCC.Text, dTPNgayCap.Value.Date, add.Text);
            if (txtIDCD.Text == "  ID Công Dân" ||
                txtIDCD.Text == "")
            {
                MessageBox.Show("Hãy Điền ID Công Dân để xóa.");
            }
            else
            {
                cccdDAO.Xoa(cccd);
                MessageBox.Show("Hoàn Thành.");
            }*/
            using (var db = new QLCongDanEntities())
            {
                if (txtIDCD.Text == "  ID Công Dân" || string.IsNullOrWhiteSpace(txtIDCD.Text))
                {
                    MessageBox.Show("Hãy Điền ID Công Dân để xóa.");
                }
                else
                {
                    var cccd = db.CCCDs.FirstOrDefault(c => c.IDCD == txtIDCD.Text);

                    if (cccd != null)
                    {
                        db.CCCDs.Remove(cccd);
                        db.SaveChanges();

                        MessageBox.Show("Hoàn Thành.");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin Căn Cước Công Dân.");
                    }
                }
            }

        }

        private void FCCCD_Load(object sender, EventArgs e)
        {

        }
    }
}
