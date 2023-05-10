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
    public partial class FTamTruTamVang : Form
    {
        public FTamTruTamVang()
        {
            InitializeComponent();
        }
        public FTamTruTamVang(string input): this()
        {
            string nhan;
            nhan = input;
            txtTCCCD.Text = nhan;
        }
        private void HienThiDanhSach()
        {
            /*cccd = cccdDAO.TimKiem_ID(txtTCCCD.Text);
            if(cccd != null)
            {
                this.Lichsudichuyen.DataSource = ttdao.LayDanhSachLichsu(cccd.IDCD);
            }
            else
                this.Lichsudichuyen.DataSource = null;*/
            using (var db = new QLCongDanEntities())
            {
                var cccd = db.CCCDs.FirstOrDefault(c => c.SoCC == txtTCCCD.Text);

                if (cccd != null)
                {
                    var lichSuDichuyen = from tt in db.TamTruTamVangs where tt.IDCD == cccd.IDCD select tt;
                    this.Lichsudichuyen.DataSource = lichSuDichuyen.ToList();
                }
                else
                {
                    this.Lichsudichuyen.DataSource = null;
                }
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            /*cccd = cccdDAO.TimKiem_ID(txtsoCC.Text);
            TamTruTamVang ttold;
            TamTruTamVang ttnew;
            ttold = ttdao.TimKiemTT(cccd.IDCD);
            ttnew = new TamTruTamVang(cccd.IDCD, Come.Value.Date, Leave.Value.Date, txtAdd.Text, txtLido.Text);
            if (txtsoCC.Text == "  ID Công Dân" ||
                txtAdd.Text == "  Số CCCD" ||
                txtLido.Text == "  Địa Chỉ" ||
                txtsoCC.Text == "" ||
                txtAdd.Text == "" ||
                txtLido.Text == "" ||
                Come.Value >= Leave.Value)
            {
                if (Come.Value >= Leave.Value) MessageBox.Show("Ngày đến không được vượt quá ngày đi.");
                else MessageBox.Show("Hãy Điền Thông Tin");
            }
            else if(ttnew.Come.Date >= ttold.Come.Date && ttnew.Come.Date <= ttold.Leave || ttnew.Leave.Date <= ttold.Leave.Date && ttnew.Leave.Date >= ttold.Come.Date)
            {
                MessageBox.Show("Trong Cùng Thời Gian Không Thể Tạm Trú Ở Hai Nơi Cùng Lúc.");
            }
            else
            {
                ttdao.Them(ttnew);
                MessageBox.Show("Hoàn Thành.");
                HienThiDanhSach();
            }*/
            using (var db = new QLCongDanEntities())
            {
                var cccd = db.CCCDs.FirstOrDefault(c => c.SoCC == txtsoCC.Text);

                if (cccd == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin Căn Cước Công Dân.");
                }
                else
                {
                    var ttNew = new TamTruTamVang
                    {
                        ID_CongDan = cccd.IDCD,
                        NgayDen = Come.Value.Date,
                        NgayDi = Leave.Value.Date,
                        DiaChi = txtAdd.Text,
                        LiDo = txtLido.Text
                    };

                    if (string.IsNullOrWhiteSpace(txtsoCC.Text) ||
                        string.IsNullOrWhiteSpace(txtAdd.Text) ||
                        string.IsNullOrWhiteSpace(txtLido.Text) ||
                        Come.Value >= Leave.Value)
                    {
                        if (Come.Value >= Leave.Value)
                        {
                            MessageBox.Show("Ngày đến không được vượt quá ngày đi.");
                        }
                        else
                        {
                            MessageBox.Show("Hãy Điền Thông Tin.");
                        }
                    }
                    else
                    {
                        var overlappingRecords = db.TamTruTamVangs.Where(tt => tt.IDCD == cccd.IDCD && ((tt.Come <= ttNew.NgayDen && tt.Leave >= ttNew.NgayDen) || (tt.Come <= ttNew.NgayDi && tt.Leave >= ttNew.NgayDi))).ToList();

                        if (overlappingRecords > 0)
                        {
                            MessageBox.Show("Trong Cùng Thời Gian Không Thể Tạm Trú Ở Hai Nơi Cùng Lúc.");
                        }
                        else
                        {
                            db.TamTruTamVangs.Add(ttNew);
                            db.SaveChanges();

                            MessageBox.Show("Hoàn Thành.");

                            HienThiDanhSach();
                        }
                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*if (txtsoCC.Text == "  ID Công Dân" ||
                txtsoCC.Text == "")
            {
                MessageBox.Show("Hãy Điền Thông Tin.");
            }
            else
            {
                cccd = cccdDAO.TimKiem_ID(txtsoCC.Text);
                tt = new TamTruTamVang(cccd.IDCD, Come.Value.Date, Leave.Value.Date, txtAdd.Text, txtLido.Text);
                ttdao.Xoa(tt);
                MessageBox.Show("Hoàn Thành.");
                HienThiDanhSach();
            }*/
            using (var db = new QLCongDanEntities())
            {
                if (string.IsNullOrWhiteSpace(txtsoCC.Text))
                {
                    MessageBox.Show("Hãy Điền Thông Tin.");
                }
                else
                {
                    var cccd = db.CCCDs.Where(c => c.SoCCCD == txtsoCC.Text).FirstOrDefault();
                    if (cccd == null)
                    {
                        MessageBox.Show("Không tìm thấy ID công dân tương ứng.");
                        return;
                    }

                    var tt = new TamTruTamVang()
                    {
                        ID_CongDan = cccd.IDCD,
                        NgayDen = Come.Value.Date,
                        NgayDi = Leave.Value.Date,
                        DiaChi = txtAdd.Text,
                        LiDo = txtLido.Text
                    };

                    db.TamTruTamVangs.Attach(tt);
                    db.Entry(tt).State = EntityState.Deleted;
                    db.SaveChanges();

                    MessageBox.Show("Hoàn Thành.");
                    HienThiDanhSach();
                }
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*if (txtsoCC.Text == "  ID Công Dân" ||
                txtAdd.Text == "  Số CCCD" ||
                txtLido.Text == "  Địa Chỉ" ||
                txtsoCC.Text == "" ||
                txtAdd.Text == "" ||
                txtLido.Text == "" ||
                Come.Value >= Leave.Value)
            {
                if (Come.Value >= Leave.Value) MessageBox.Show("Ngày đến không được vượt quá ngày đi.");
                else MessageBox.Show("Hãy Điền Thông Tin");
            }
            else
            {
                cccd = cccdDAO.TimKiem_ID(txtsoCC.Text);
                tt = new TamTruTamVang(cccd.IDCD, Come.Value.Date, Leave.Value.Date, txtAdd.Text, txtLido.Text);
                ttdao.Sua(tt);
                MessageBox.Show("Hoàn Thành.");
                HienThiDanhSach();
            }*/
            using (var db = new QLCongDanEntities())
            {
                if (string.IsNullOrWhiteSpace(txtsoCC.Text) ||
                    txtsoCC.Text == "  ID Công Dân" ||
                    string.IsNullOrWhiteSpace(txtAdd.Text) ||
                    txtAdd.Text == "  Số CCCD" ||
                    string.IsNullOrWhiteSpace(txtLido.Text) ||
                    txtLido.Text == "  Địa Chỉ" ||
                    Come.Value >= Leave.Value)
                {
                    if (Come.Value >= Leave.Value)
                        MessageBox.Show("Ngày đến không được vượt quá ngày đi.");
                    else
                        MessageBox.Show("Hãy Điền Thông Tin");
                }
                else
                {
                    var cccd = db.CCCDs.Where(c => c.SoCCCD == txtsoCC.Text).FirstOrDefault();
                    if (cccd == null)
                    {
                        MessageBox.Show("Không tìm thấy ID công dân tương ứng.");
                        return;
                    }

                    var tt = new TamTruTamVang()
                    {
                        ID_CongDan = cccd.IDCD,
                        NgayDen = Come.Value.Date,
                        NgayDi = Leave.Value.Date,
                        DiaChi = txtAdd.Text,
                        LiDo = txtLido.Text
                    };

                    db.TamTruTamVangs.Attach(tt);
                    db.Entry(tt).State = EntityState.Modified;
                    db.SaveChanges();

                    MessageBox.Show("Hoàn Thành.");
                    HienThiDanhSach();
                }
            }

        }
        private void tim_Click(object sender, EventArgs e)
        {
            /*cccd = cccdDAO.TimKiem_ID(txtTCCCD.Text);
            tt = ttdao.TimKiemTT(cccd.IDCD);
            cd = cddao.TimKiem(cccd.IDCD);
            if (tt != null)
            {
                txtIDCDs.Text = tt.IDCD;
                txtHoTen.Text = cd.HoTen;
                txtADDthuongtru.Text = cd.QueQuan;
            }
            HienThiDanhSach();*/

            using (var db = new QLCongDanEntities())
            {
                var cccd = db.CCCDs.Where(c => c.SoCCCD == txtTCCCD.Text).FirstOrDefault();
                if (cccd == null)
                {
                    MessageBox.Show("Không tìm thấy ID công dân tương ứng.");
                    return;
                }

                var tt = db.TamTruTamVangs.Where(t => t.IDCongDan == cccd.IDCD).FirstOrDefault();
                var cd = db.CongDans.Where(c => c.IDCD == cccd.IDCD).FirstOrDefault();

                if (tt != null)
                {
                    txtIDCDs.Text = tt.IDCD;
                    txtHoTen.Text = cd.HoTen;
                    txtADDthuongtru.Text = cd.QueQuan;
                }

                HienThiDanhSach();
            }

        }

        private void FTamTruTamVang_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }
        public static void enter(TextBox a)
        {
            if (a.Text != null || a.Text !="")
            {
                a.Text = "";
                a.ForeColor = Color.Black;
            }
        }
        private void txtTCCCD_Enter(object sender, EventArgs e)
        {
            enter(txtTCCCD);
        }

        private void txtsoCC_Enter(object sender, EventArgs e)
        {
            enter(txtsoCC);
        }

        private void txtAdd_Enter(object sender, EventArgs e)
        {
            enter(txtAdd);
        }

        private void txtLido_Enter(object sender, EventArgs e)
        {
            enter(txtLido);
        }

        private void btnDanhSachQuaHan_Click(object sender, EventArgs e)
        {
            /*Lichsudichuyen.DataSource = ttdao.LayDanhSachQuaHan();*/
        }
    }
}
