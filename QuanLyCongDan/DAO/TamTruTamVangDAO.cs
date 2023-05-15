using QuanLyCongDan.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongDan.DAO
{
    internal class TamTruTamVangDAO
    {
        public void Them(TamTruTamVang tt)
        {
            /*String sqlStr = string.Format("INSERT INTO TamTruTamVang(ID_CongDan,NgayDen,NgayDi,DiaChi,LiDo) VALUES ('{0}','{1}','{2}',N'{3}',N'{4}') ",tt.IDCD,tt.Come.Date,tt.Leave.Date, tt.Add,tt.Why);
            dbConn.ThucThi(sqlStr);*/

            using (var dbConn = new QLCongDanEntities())
            {
                var newTT = new TamTruTamVang
                {
                    ID_CongDan = tt.ID_CongDan,
                    NgayDen = tt.NgayDen,
                    NgayDi = tt.NgayDi,
                    DiaChi = tt.DiaChi,
                    LiDo = tt.LiDo,
                };

                dbConn.TamTruTamVangs.Add(newTT);
                dbConn.SaveChanges();
            }
        }

        public void Xoa(TamTruTamVang tt)
        {
            /*String sqlStr = string.Format("UPDATE TamTruTamVang SET NgayDen = '',NgayDi = '', LiDo ='', DiaChi='' WHERE ID_CongDan = '{0}' and NgayDen='{1}'", tt.IDCD, tt.Come.Date);
            dbConn.ThucThi(sqlStr);*/
            using (var dbConn = new QLCongDanEntities())
            {
                var delTT = dbConn.TamTruTamVangs.SingleOrDefault(t => t.ID_CongDan == tt.ID_CongDan);
                if (delTT != null)
                {
                    dbConn.TamTruTamVangs.Remove(delTT);
                    dbConn.SaveChanges();
                }
            }
        }

        public void Sua(TamTruTamVang tt)
        {
            /*String sqlStr = string.Format("UPDATE TamTruTamVang SET NgayDen = '{0}',NgayDi = '{1}',LiDo = N'{2}',DiaChi=N'{3}' where ID_CongDan = '{4}' and NgayDen ='{5}'", tt.Come,tt.Leave, tt.Why, tt.Add,tt.IDCD,tt.Come.Date);
            dbConn.ThucThi(sqlStr);*/
            using (var dbConn = new QLCongDanEntities())
            {
                var ttToUpdate = dbConn.TamTruTamVangs.FirstOrDefault(t => t.ID_CongDan == tt.ID_CongDan &&  t.NgayDen == tt.NgayDen);
                if (ttToUpdate != null)
                {
                    ttToUpdate.NgayDen = tt.NgayDen;
                    ttToUpdate.NgayDi = tt.NgayDi;
                    ttToUpdate.LiDo = tt.LiDo;
                    ttToUpdate.DiaChi = tt.DiaChi;
                    dbConn.SaveChanges();
                }
            }

        }

        public DataTable LayDanhSachTamTruTamVang()
        {
            /*string sqlStr = string.Format("SELECT * FROM TamTruTamVang");
            return dbConn.LayDanhSach(sqlStr);*/
            using (var dbConn = new QLCongDanEntities())
            {
                var TTTV = dbConn.TamTruTamVangs.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("ID_CongDan", typeof(int));
                dt.Columns.Add("NgayDen", typeof(DateTime));
                dt.Columns.Add("NgayDi", typeof(DateTime));
                dt.Columns.Add("DiaChi", typeof(string));
                dt.Columns.Add("LiDo", typeof(string));
                foreach (var cc in TTTV)
                {
                    var dr = dt.NewRow();
                    dr["ID_CongDan"] = cc.ID_CongDan;
                    dr["NgayDen"] = cc.NgayDen;
                    dr["NgayDi"] = cc.NgayDi;
                    dr["DiaChi"] = cc.DiaChi;
                    dr["LiDo"] = cc.LiDo;
                    dt.Rows.Add(dr);
                }

                return dt;

            }
        }
        public TamTruTamVang TimKiemTT(string id)
        {
                /*string sqlStr = string.Format("select ID_CongDan, NgayDen, NgayDi, DiaChi, Lido from TamTruTamVang where ID_CongDan = '{0}'", id);
                DataTable dt = dbConn.LayDanhSach(sqlStr);

                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        DataRow row = dt.Rows[0];
                        return new TamTruTamVang(
                            row["ID_CongDan"].ToString(),
                            Convert.ToDateTime(row["NgayDen"]),
                            Convert.ToDateTime(row["NgayDi"]),
                            row["DiaChi"].ToString(),
                            row["Lido"].ToString());
                    }
                }

                return null;*/
                using (var dbConn = new QLCongDanEntities())
                {
                    var tt = dbConn.TamTruTamVangs
                                 .FirstOrDefault(t => t.ID_CongDan == int.Parse(id));
                    if (tt != null)
                    {
                        return new TamTruTamVang(
                            tt.ID_CongDan,
                            tt.NgayDen,
                            tt.NgayDi,
                            tt.DiaChi,
                            tt.LiDo);
                    }

                    return null;
                }

        }
        public DataTable LayDanhSachLichsu(string id)
        {
            /*string sqlStr = string.Format("SELECT NgayDen as TuNgay, NgayDi as DenNgay, DiaChi, LiDo FROM TamTruTamVang where ID_CongDan = '{0}'",id);
            return dbConn.LayDanhSach(sqlStr);*/
            using (var dbConn = new QLCongDanEntities())
            {
                var ttList = dbConn.TamTruTamVangs
                                    .Where(t => t.ID_CongDan == int.Parse(id))
                                    .Select(t => new
                                    {
                                        TuNgay = t.NgayDen,
                                        DenNgay = t.NgayDi,
                                        t.DiaChi,
                                        t.LiDo
                                    })
                                    .ToList();
                return ConvertToDataTable(ttList);
            }
        }
            // Helper method to convert List<T> to DataTable
        public DataTable ConvertToDataTable<T>(IEnumerable<T> data)
        {
            var table = new DataTable();
            var properties = typeof(T).GetProperties();
            foreach (var prop in properties)
            {
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }
            foreach (var item in data)
            {
                var row = table.NewRow();
                foreach (var prop in properties)
                {
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                }
                table.Rows.Add(row);
            }
            return table;
        }
        public DataTable LayDanhSachQuaHan()
        {
            using (var dbConn = new QLCongDanEntities())
            {
                var ttList = dbConn.TamTruTamVangs
                                 .Where(t => DbFunctions.DiffDays(t.NgayDi, DateTime.Today) > 1)
                                 .ToList();
                return ConvertToDataTable(ttList);
            }

        }
    }
}
