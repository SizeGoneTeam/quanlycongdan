using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCongDan.DAO
{
    internal class ThueDAO
    {

        public void ThemLichSuThue(LichSuThue lichSuThue)
        {
            using (var db = new QLCongDanEntities())
            {
                db.LichSuThues.Add(lichSuThue);
                db.SaveChanges();
            }
        }


        public DataTable LayLichSuThueTheoIDCongDan(int id_congdan)
        {
            using (var db = new QLCongDanEntities())
            {
                var query = from lichSuThue in db.LichSuThues
                            where lichSuThue.ID_CongDan == id_congdan
                            orderby lichSuThue.ID_LichSuThue descending
                            select lichSuThue;

                List<LichSuThue> lichSuThueList = query.ToList();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("ID_LichSuThue", typeof(int));
                dataTable.Columns.Add("ID_CongDan", typeof(int));
                dataTable.Columns.Add("NgayTao", typeof(DateTime));
                dataTable.Columns.Add("TenCongTy", typeof(string));
                dataTable.Columns.Add("SoTien", typeof(decimal));
                dataTable.Columns.Add("TrangThai", typeof(int));

                foreach (var lichSuThue in lichSuThueList)
                {
                    dataTable.Rows.Add(
                        lichSuThue.ID_LichSuThue,
                        lichSuThue.ID_CongDan,
                        lichSuThue.NgayTao,
                        lichSuThue.TenCongTy,
                        lichSuThue.SoTien,
                        lichSuThue.TrangThai
                    );
                }

                return dataTable;
            }
        }


        public DataTable LayLichSuThueTheoCongTY(string tenCongTy)
        {
            using (var db = new QLCongDanEntities())
            {
                var query = from lichSuThue in db.LichSuThues
                            where lichSuThue.TenCongTy == tenCongTy
                            orderby lichSuThue.ID_LichSuThue descending
                            select lichSuThue;

                List<LichSuThue> lichSuThueList = query.ToList();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("ID_LichSuThue", typeof(int));
                dataTable.Columns.Add("ID_CongDan", typeof(int));
                dataTable.Columns.Add("NgayTao", typeof(DateTime));
                dataTable.Columns.Add("TenCongTy", typeof(string));
                dataTable.Columns.Add("SoTien", typeof(decimal));
                dataTable.Columns.Add("TrangThai", typeof(int));

                foreach (var lichSuThue in lichSuThueList)
                {
                    dataTable.Rows.Add(
                        lichSuThue.ID_LichSuThue,
                        lichSuThue.ID_CongDan,
                        lichSuThue.NgayTao,
                        lichSuThue.TenCongTy,
                        lichSuThue.SoTien,
                        lichSuThue.TrangThai
                    );
                }

                return dataTable;
            }
        }


        public bool TimKiemThue(int idNhanVien, string tenCongTY, DateTime NgayTao)
        {
            using (var db = new QLCongDanEntities())
            {
                var query = from lichSuThue in db.LichSuThues
                            where lichSuThue.ID_CongDan == idNhanVien
                                  && lichSuThue.NgayTao == NgayTao
                                  && lichSuThue.TenCongTy == tenCongTY
                            select lichSuThue;

                return query.Any();
            }
        }

        public void NopThue(int idNhanVien)
        {
            using (var db = new QLCongDanEntities())
            {
                var lichSuThue = db.LichSuThues.FirstOrDefault(l => l.ID_CongDan == idNhanVien);
                if (lichSuThue != null)
                {
                    lichSuThue.TrangThai = true;
                    db.SaveChanges();
                }
            }
        }


        public DataTable LayCongDanChuaDongThue()
        {
            using (var db = new QLCongDanEntities())
            {
                var query = from lichSuThue in db.LichSuThues
                            where lichSuThue.TrangThai == false
                            group lichSuThue by lichSuThue.ID_CongDan into g
                            select new
                            {
                                ID_CongDan = g.Key,
                                SoPhieu = g.Count(),
                                TongTien = g.Sum(l => l.SoTien)
                            };

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("ID_CongDan", typeof(int));
                dataTable.Columns.Add("SoPhieu", typeof(int));
                dataTable.Columns.Add("TongTien", typeof(decimal));

                foreach (var result in query)
                {
                    dataTable.Rows.Add(result.ID_CongDan, result.SoPhieu, result.TongTien);
                }

                return dataTable;
            }
        }

    }

}
