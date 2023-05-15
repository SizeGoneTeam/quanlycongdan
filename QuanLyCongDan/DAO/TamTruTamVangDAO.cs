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
            using (var dbConn = new QLCongDanEntities())
            {
                var tt = dbConn.TamTruTamVangs.FirstOrDefault(t => t.ID_CongDan == int.Parse(id));
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
