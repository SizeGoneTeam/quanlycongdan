using QuanLyCongDan.Model;
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
        DBconnection dbConn = new DBconnection();

        public void ThemCongTy(CongTy ct)
        {
            string sqlStr = string.Format("INSERT INTO CongTy(tenCongTy, NgayTao) VALUES ('{0}', '{1}')", ct.TenCongTy, ct.NgayTao.ToString("yyyy-MM-dd"));
            dbConn.ThucThi(sqlStr);
        }

        public void NghiViec(int id)
        {
            string sqlStr = string.Format("UPDATE CongTy SET TrangThai = {0} WHERE ID_CongTy = {1}", 0 ,id);
            dbConn.ThucThi(sqlStr);
        }

        public void SuaLuong(CongTy ct)
        {
            string sqlStr = string.Format("UPDATE CongTy SET Luong = {0} WHERE ID_CongTy = {1}", ct.TenCongTy, ct.Id_CongTy);
            dbConn.ThucThi(sqlStr);
        }
        public DataTable LayDanhSachCongTy()
        {
            string sqlStr = string.Format("SELECT * FROM CongTy ORDER BY ID_CongTy DESC");
            return dbConn.LayDanhSach(sqlStr);
        }

        public DataTable LayDanhSachCongTyNhanVien()
        {
            string sqlStr = string.Format("SELECT * FROM CongTy_NhanVien ORDER BY ID_CongTyNhanVien DESC");
            return dbConn.LayDanhSach(sqlStr);
        }

        public DataTable LayDanhSachCongTyNhanVien(CongTy ct)
        {
            string sqlStr = string.Format("SELECT * FROM CongTy_NhanVien Where ID_CongTy = '{0}'", ct.Id_CongTy);
            return dbConn.LayDanhSach(sqlStr);
        }

        public DataTable LayDanhSachCongTyNhanVien(CongDan cd)
        {
            string sqlStr = string.Format("SELECT * FROM CongTy_NhanVien Where ID_NhanVien = {0} ORDER BY ID_CongTyNhanVien DESC",cd.Id);
            return dbConn.LayDanhSach(sqlStr);
        }

        public bool KiemTraNhanVienCoDiLamCongTy(CongDan cd, int idCongTy)
        {
            string sqlStr = string.Format("SELECT * FROM CongTy_NhanVien Where ID_NhanVien = {0} and TrangThai = 1 and ID_CongTy = {1}", cd.Id, idCongTy);
            DataTable data = dbConn.LayDanhSach(sqlStr);
            return data.Rows.Count > 0;
        }

        public bool KiemTraCongTyTonTai(CongTy ct)
        {
            string sqlStr = string.Format("SELECT * FROM CongTy WHERE tenCongTy = N'{0}'", ct.TenCongTy);
            DataTable data = dbConn.LayDanhSach(sqlStr);
            return data.Rows.Count > 0;
        }

        public void ThemCongTyNhanVien(CongTyNhanVien ct_nv)
        {
            string sqlStr = string.Format("INSERT INTO CongTy_NhanVien(ID_CongTy, ID_NhanVien, Luong, NgayVao, TrangThai) VALUES ({0}, {1}, {2}, '{3}',1)", ct_nv.Id_CongTy, ct_nv.Id_NhanVien, ct_nv.Luong, ct_nv.NgayVao.ToString("yyyy-MM-dd"));
            dbConn.ThucThi(sqlStr);
        }

        public void SuaLuong(CongTyNhanVien ct_nv)
        {
            string sqlStr = string.Format("UPDATE CongTy_NhanVien SET Luong = {0} WHERE ID_NhanVien = {1} and TrangThai = 1 AND ID_CongTy = {2}", ct_nv.Luong, ct_nv.Id_NhanVien, ct_nv.Id_CongTy);
            dbConn.ThucThi(sqlStr);
        }

        public void NghiViec(CongTyNhanVien ct_nv)
        {
            string sqlStr = string.Format("UPDATE CongTy_NhanVien SET TrangThai = 0 WHERE ID_NhanVien = {0} AND ID_CongTy = {1}", ct_nv.Id_NhanVien, ct_nv.Id_CongTy);
            dbConn.ThucThi(sqlStr);
        }


        public CongTy LayCongTy(int idCongTy)
        {
            try
            {
                string sqlStr = string.Format("SELECT * FROM CongTy WHERE ID_CongTy = '{0}'", idCongTy);
                DataTable dt = dbConn.LayDanhSach(sqlStr);

                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        DataRow row = dt.Rows[0];
                        return new CongTy(
                            Convert.ToInt32(row["ID_CongTy"].ToString()),
                            row["tenCongTy"].ToString(),
                            Convert.ToDateTime(row["NgayTao"].ToString())
                        );
                    }
                }

                return null;
            }
            catch
            {
                return null;
            }
        }

        public CongTyNhanVien LayCongTyNhanVien(int idNhanVien, int idCongTy)
        {
            try
            {
                string sqlStr = string.Format("SELECT * FROM CongTy_NhanVien WHERE ID_NhanVien = '{0}' and TrangThai = 1 and ID_CongTy = {1}", idNhanVien,idCongTy);
                DataTable dt = dbConn.LayDanhSach(sqlStr);

                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        DataRow row = dt.Rows[0];
                        return new CongTyNhanVien(
                            Convert.ToInt32(row["ID_CongTy"].ToString()),
                            Convert.ToInt32(row["ID_NhanVien"].ToString()),
                            Convert.ToDecimal(row["Luong"].ToString())
                        );
                    }
                }

                return null;
            }
            catch
            {
                return null;
            }
        }

        public List<CongTyNhanVien> LayCongTyNhanVien(int idNhanVien)
        {
            try
            {
                string sqlStr = string.Format("SELECT * FROM CongTy_NhanVien WHERE ID_NhanVien = '{0}' and TrangThai = 1", idNhanVien);
                DataTable dt = dbConn.LayDanhSach(sqlStr);

                if (dt != null)
                {
                    List<CongTyNhanVien> list = new List<CongTyNhanVien>();

                    foreach (DataRow row in dt.Rows) 
                    {
                        list.Add(new CongTyNhanVien(
                            Convert.ToInt32(row["ID_CongTy"].ToString()),
                            Convert.ToInt32(row["ID_NhanVien"].ToString()),
                            Convert.ToDecimal(row["Luong"].ToString()),
                            Convert.ToDateTime(row["NgayVao"].ToString())
                        ));
                    }

                    return list;
                }

                return null;
            }
            catch
            {
                return null;
            }
        }


        public CongTy LayCongTyBangTen(String tenCongTy)
        {
            try
            {
                string sqlStr = string.Format("SELECT * FROM CongTy WHERE tenCongTy Like N'{0}'", tenCongTy);
                DataTable dt = dbConn.LayDanhSach(sqlStr);

                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        DataRow row = dt.Rows[0];
                        return new CongTy(
                            Convert.ToInt32(row["ID_CongTy"].ToString()),
                            row["tenCongTy"].ToString(),
                            Convert.ToDateTime(row["NgayTao"].ToString())
                        );
                    }
                }

                return null;
            }
            catch
            {
                return null;
            }
        }


        public CongTy TimKiem(string tenCongTy)
        {
            try
            {
                string sqlStr = string.Format("SELECT * FROM CongTy WHERE tenCongTy LIKE N'{0}'", tenCongTy);
                DataTable dt = dbConn.LayDanhSach(sqlStr);

                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        DataRow row = dt.Rows[0];
                        return new CongTy(
                            Convert.ToInt32(row["ID_CongTy"].ToString()),
                            row["tenCongTy"].ToString(),
                            Convert.ToDateTime(row["NgayTao"].ToString())
                        );
                    }
                }

                return null;
            }
            catch
            {
                return null;
            }
        }
    }
}
