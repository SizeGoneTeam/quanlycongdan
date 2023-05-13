using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongDan.DAO
{
    internal class CongTyDAO
    {

        public void ThemCongTy(CongTy ct)
        {
            using (var dbConn = new QLCongDanEntities())
            {
                dbConn.CongTies.Add(ct);
                dbConn.SaveChanges();
            }
        }


        public DataTable LayDanhSachCongTyNhanVien()
        {
            using (var dbConn = new QLCongDanEntities())
            {
                var query = from ctNv in dbConn.CongTy_NhanVien
                            orderby ctNv.ID_CongTyNhanVien descending
                            select new
                            {
                                ctNv.ID_CongTyNhanVien,
                                ctNv.ID_CongTy,
                                ctNv.ID_NhanVien,
                                ctNv.Luong,
                                ctNv.TrangThai,
                                ctNv.NgayVao,
                            };

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("ID_CongTyNhanVien", typeof(int));
                dataTable.Columns.Add("ID_CongTy", typeof(string));
                dataTable.Columns.Add("ID_NhanVien", typeof(string));

                dataTable.Columns.Add("NgayVao", typeof(DateTime));
                dataTable.Columns.Add("TrangThai", typeof(int));

                foreach (var row in query)
                {
                    dataTable.Rows.Add(row.ID_CongTyNhanVien, row.ID_CongTy, row.ID_NhanVien, row.NgayVao, row.TrangThai);
                }

                return dataTable;
            }
        }

        public DataTable LayDanhSachCongTy()
        {
            using (var db = new QLCongDanEntities())
            {
                var query = from congTy in db.CongTies
                            orderby congTy.ID_CongTy descending
                            select congTy;

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("ID_CongTy", typeof(int));
                dataTable.Columns.Add("TenCongTy", typeof(string));
                dataTable.Columns.Add("NgayTao", typeof(DateTime));

                foreach (var congTy in query)
                {
                    dataTable.Rows.Add(congTy.ID_CongTy, congTy.TenCongTy, congTy.NgayTao);
                }

                return dataTable;
            }
        }



        public DataTable LayDanhSachCongTyNhanVien(CongTy ct)
        {
            using (var db = new QLCongDanEntities())
            {
                var query = from ctNv in db.CongTy_NhanVien
                            where ctNv.ID_CongTy == ct.ID_CongTy
                            select ctNv;

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("ID_CongTyNhanVien", typeof(int));
                dataTable.Columns.Add("ID_CongTy", typeof(int));
                dataTable.Columns.Add("ID_NhanVien", typeof(int));
                dataTable.Columns.Add("Luong", typeof(decimal));
                dataTable.Columns.Add("TrangThai", typeof(bool));
                dataTable.Columns.Add("NgayVao", typeof(DateTime));

                foreach (var row in query)
                {
                    dataTable.Rows.Add(row.ID_CongTyNhanVien, row.ID_CongTy, row.ID_NhanVien, row.Luong, row.TrangThai, row.NgayVao);
                }

                return dataTable;
            }
        }

        public DataTable LayDanhSachCongTyNhanVien(CongDan cd)
        {
            using (var db = new QLCongDanEntities())
            {
                var query = from ctNv in db.CongTy_NhanVien
                            where ctNv.ID_NhanVien == cd.ID_CongDan
                            orderby ctNv.ID_CongTyNhanVien descending
                            select ctNv;

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("ID_CongTyNhanVien", typeof(int));
                dataTable.Columns.Add("ID_CongTy", typeof(int));
                dataTable.Columns.Add("ID_NhanVien", typeof(int));
                dataTable.Columns.Add("Luong", typeof(decimal));
                dataTable.Columns.Add("TrangThai", typeof(bool));
                dataTable.Columns.Add("NgayVao", typeof(DateTime));

                foreach (var row in query)
                {
                    dataTable.Rows.Add(row.ID_CongTyNhanVien, row.ID_CongTy, row.ID_NhanVien, row.Luong, row.TrangThai, row.NgayVao);
                }

                return dataTable;
            }
        }

        public bool KiemTraNhanVienCoDiLamCongTy(CongDan cd, int idCongTy)
        {
            using (var db = new QLCongDanEntities())
            {
                var query = from ctNv in db.CongTy_NhanVien
                            where ctNv.ID_NhanVien == cd.ID_CongDan && ctNv.TrangThai == true && ctNv.ID_CongTy == idCongTy
                            select ctNv;

                return query.Any();
            }
        }

        public bool KiemTraCongTyTonTai(CongTy ct)
        {
            using (var db = new QLCongDanEntities())
            {
                var query = from c in db.CongTies
                            where c.TenCongTy == ct.TenCongTy
                            select c;

                return query.Any();
            }
        }

        public void ThemCongTyNhanVien(CongTy_NhanVien ct_nv)
        {
            using (var db = new QLCongDanEntities())
            {
                db.CongTy_NhanVien.Add(ct_nv);
                db.SaveChanges();
            }
        }

        public void SuaLuong(CongTy_NhanVien ct_nv)
        {
            using (var db = new QLCongDanEntities())
            {
                var query = from ctNv in db.CongTy_NhanVien
                            where ctNv.ID_NhanVien == ct_nv.ID_NhanVien && ctNv.TrangThai == true && ctNv.ID_CongTy == ct_nv.ID_CongTy
                            select ctNv;

                foreach (var row in query)
                {
                    row.Luong = ct_nv.Luong;
                }

                db.SaveChanges();
            }
        }

        public void NghiViec(CongTy_NhanVien ct_nv)
        {
            using (var db = new QLCongDanEntities())
            {
                var query = from ctNv in db.CongTy_NhanVien
                            where ctNv.ID_NhanVien == ct_nv.ID_NhanVien && ctNv.ID_CongTy == ct_nv.ID_CongTy
                            select ctNv;

                foreach (var row in query)
                {
                    row.TrangThai = false;
                }

                db.SaveChanges();
            }
        }


        public CongTy LayCongTy(int idCongTy)
        {
            using (var db = new QLCongDanEntities())
            {
                var ct = db.CongTies.FirstOrDefault(c => c.ID_CongTy == idCongTy);

                if (ct != null)
                {
                    return new CongTy(
                        ct.ID_CongTy,
                        ct.TenCongTy,
                        ct.NgayTao
                    );
                }

                return null;
            }
        }

        public CongTy_NhanVien LayCongTyNhanVien(int idNhanVien, int idCongTy)
        {
            using (var db = new QLCongDanEntities())
            {
                var ctNv = db.CongTy_NhanVien.FirstOrDefault(c => c.ID_NhanVien == idNhanVien && c.TrangThai == true && c.ID_CongTy == idCongTy);

                if (ctNv != null)
                {
                    return new CongTy_NhanVien(
                        ctNv.ID_CongTyNhanVien,
                        ctNv.ID_CongTy,
                        ctNv.ID_NhanVien,
                        ctNv.NgayVao,
                        ctNv.TrangThai,
                        ctNv.Luong
                    );
                }

                return null;
            }
        }

        public List<CongTy_NhanVien> LayCongTyNhanVien(int idNhanVien)
        {
            using (var db = new QLCongDanEntities())
            {
                var query = from ctNv in db.CongTy_NhanVien
                            where ctNv.ID_NhanVien == idNhanVien && ctNv.TrangThai == true
                            select new CongTy_NhanVien(
                        ctNv.ID_CongTyNhanVien,
                        ctNv.ID_CongTy,
                        ctNv.ID_NhanVien,
                        ctNv.NgayVao,
                        ctNv.TrangThai,
                        ctNv.Luong
                    );

                return query.ToList();
            }
        }

        public CongTy LayCongTyBangTen(string tenCongTy)
        {
            using (var db = new QLCongDanEntities())
            {
                var ct = db.CongTies.FirstOrDefault(c => c.TenCongTy == tenCongTy);

                if (ct != null)
                {
                    return new CongTy(
                        ct.ID_CongTy,
                        ct.TenCongTy,
                        ct.NgayTao
                    );
                }

                return null;
            }
        }


        public CongTy TimKiem(string tenCongTy)
        {
            using (var db = new QLCongDanEntities())
            {
                var ct = db.CongTies.FirstOrDefault(c => c.TenCongTy.Contains(tenCongTy));

                if (ct != null)
                {
                    return new CongTy(
                        ct.ID_CongTy,
                        ct.TenCongTy,
                        ct.NgayTao
                    );
                }

                return null;
            }
        }
    }
}
