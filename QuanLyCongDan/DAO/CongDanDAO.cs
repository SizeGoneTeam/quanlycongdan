using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCongDan.DAO
{
    internal class CongDanDAO
    {
        public void Them(CongDan cd)
        {
            using (var dbConn = new QLCongDanEntities())
            {
                var newCongDan = new CongDan
                {
                    HoTen = cd.HoTen,
                    GioiTinh = cd.GioiTinh,
                    NgaySinh = cd.NgaySinh,
                    QueQuan = cd.QueQuan,
                    DanToc = cd.DanToc,
                    TonGiao = cd.TonGiao,
                    SDT = cd.SDT,
                    Email = cd.Email,
                    NoiThuongTru = cd.NoiThuongTru
                };

                dbConn.CongDans.Add(newCongDan);
                dbConn.SaveChanges();
            }
        }

        public void Xoa(CongDan cd)
        {
            using (var dbConn = new QLCongDanEntities())
            {
                var congDanToDelete = dbConn.CongDans.SingleOrDefault(c => c.ID_CongDan == cd.ID_CongDan);
                if (congDanToDelete != null)
                {
                    dbConn.CongDans.Remove(congDanToDelete);
                    dbConn.SaveChanges();
                }
            }
        }

        public void Sua(CongDan cd)
        {
            using (var dbConn = new QLCongDanEntities())
            {
                var congDanToUpdate = dbConn.CongDans.FirstOrDefault(c => c.ID_CongDan == cd.ID_CongDan);
                if (congDanToUpdate != null)
                {
                    congDanToUpdate.HoTen = cd.HoTen;
                    congDanToUpdate.GioiTinh = cd.GioiTinh;
                    congDanToUpdate.NgaySinh = cd.NgaySinh;
                    congDanToUpdate.QueQuan = cd.QueQuan;
                    congDanToUpdate.DanToc = cd.DanToc;
                    congDanToUpdate.TonGiao = cd.TonGiao;
                    congDanToUpdate.SDT = cd.SDT;
                    congDanToUpdate.Email = cd.Email;
                    congDanToUpdate.NoiThuongTru = cd.NoiThuongTru;
                    dbConn.SaveChanges();
                }
            }
        }

        public CongDan TimKiem(string id)
        {
            if (int.TryParse(id, out int idInt))
            {
                using (var dbConn = new QLCongDanEntities())
                {
                    var congDan = dbConn.CongDans
                        .Where(c => c.ID_CongDan == idInt)
                        .Select(c => new CongDan(
                            c.ID_CongDan,
                            c.HoTen,
                            c.QuocTich,
                            c.QueQuan,
                            c.GioiTinh,
                            c.NgaySinh,
                            c.DanToc,
                            c.TonGiao,
                            c.SDT,
                            c.Email,
                            c.NoiThuongTru,
                            c.NoiSinh))
                        .FirstOrDefault();

                    return congDan;
                }
            }

            return null;
        }

        public DataTable LayDanhSachCongDan()
        {
            using (var dbConn = new QLCongDanEntities())
            {
                var congDans = dbConn.CongDans.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("ID_CongDan", typeof(int));
                dt.Columns.Add("HoTen", typeof(string));
                dt.Columns.Add("QueQuan", typeof(string));
                dt.Columns.Add("GioiTinh", typeof(string));
                dt.Columns.Add("NgaySinh", typeof(DateTime));
                dt.Columns.Add("DanToc", typeof(string));
                dt.Columns.Add("TonGiao", typeof(string));
                dt.Columns.Add("SDT", typeof(string));
                dt.Columns.Add("Email", typeof(string));
                dt.Columns.Add("NoiThuongTru", typeof(string));
                dt.Columns.Add("NoiSinh", typeof(string));

                foreach (var congDan in congDans)
                {
                    var dr = dt.NewRow();
                    dr["ID_CongDan"] = congDan.ID_CongDan;
                    dr["HoTen"] = congDan.HoTen;
                    dr["QueQuan"] = congDan.QueQuan;
                    dr["GioiTinh"] = congDan.GioiTinh;
                    dr["NgaySinh"] = congDan.NgaySinh;
                    dr["DanToc"] = congDan.DanToc;
                    dr["TonGiao"] = congDan.TonGiao;
                    dr["SDT"] = congDan.SDT;
                    dr["Email"] = congDan.Email;
                    dr["NoiThuongTru"] = congDan.NoiThuongTru;
                    dr["NoiSinh"] = congDan.NoiSinh;
                    dt.Rows.Add(dr);
                }

                return dt;
            }
        }

        private Boolean checkEmail_SDT(CongDan cd)
        {
            bool isValidPhoneNumber = Regex.IsMatch(cd.SDT, @"^\d{10}$");
            bool isValidEmail = Regex.IsMatch(cd.Email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (isValidPhoneNumber && isValidEmail) return true;
            return false;
        }

        public int getLatestRowIndex()
        {
            using (var dbConn = new QLCongDanEntities()) // replace QLCongDanEntities with the name of your DbContext class
            {
                var latestCongDan = dbConn.CongDans.OrderByDescending(c => c.ID_CongDan).FirstOrDefault();
                if (latestCongDan != null)
                {
                    return latestCongDan.ID_CongDan;
                }
                else
                {
                    return -1;
                }
            }
        }
    }
}
