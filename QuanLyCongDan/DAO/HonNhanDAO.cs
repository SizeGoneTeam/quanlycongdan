using QuanLyCongDan.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongDan
{
    internal class HonNhanDAO
    {
        DBconnection dbConn = new DBconnection();
        public void Them(HonNhan hn)
        {
            String sqlStr = string.Format("INSERT INTO HonNhan(ID_Chong,ID_Vo, NgayDangKy, NoiDangKy,TrangThai) VALUES ('{0}','{1}','{2}',N'{3}','{4}')",hn.IdChong,hn.IdVo,hn.NgayDangKy,hn.NoiDangKy,hn.TrangThai);
            dbConn.ThucThi(sqlStr);
        }

        public void LyHon(String idChong, String idVo)
        {
            String sqlStr = string.Format("UPDATE HonNhan SET TrangThai = '{0}' WHERE ID_Chong = '{1}' AND ID_Vo = '{2}'",false, idChong, idVo);
            dbConn.ThucThi(sqlStr);
        }

        public DataTable LayHonNhanMoi()
        {
            string sqlStr = string.Format("SELECT TOP 1 * FROM HonNhan ORDER BY ID_HonNhan DESC");
            return dbConn.LayDanhSach(sqlStr);
        }

        public HonNhan TimKiem_ChongVo(int idChong, int idVo)
        {
            string sqlStr = string.Format("SELECT * FROM HonNhan WHERE ID_Chong = {0} AND ID_Vo = {1}", idChong, idVo);
            DataTable dt = dbConn.LayDanhSach(sqlStr);

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    return new HonNhan(
                        int.Parse(row["ID_HonNhan"].ToString()),
                        int.Parse(row["ID_Chong"].ToString()),
                        int.Parse(row["ID_Vo"].ToString()),
                        Convert.ToDateTime(row["NgayDangKy"].ToString()),
                        row["NoiDangKy"].ToString(),
                        Convert.ToBoolean(row["TrangThai"].ToString())
                    );
                }
            }

            return null;
        }

        public HonNhan TimKiemId(int id)
        {
            string sqlStr = string.Format("SELECT * FROM HonNhan WHERE ID_HonNhan = '{0}'", id);
            DataTable dt = dbConn.LayDanhSach(sqlStr);

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    return new HonNhan(
                        int.Parse(row["ID_HonNhan"].ToString()),
                        int.Parse(row["ID_Chong"].ToString()),
                        int.Parse(row["ID_Vo"].ToString()),
                        Convert.ToDateTime(row["NgayDangKy"].ToString()),
                        row["NoiDangKy"].ToString(),
                        Convert.ToBoolean(row["TrangThai"].ToString())
                    );
                }
            }

            return null;
        }

        // True là đã kết hôn. False là chưa kết hôn
        public Boolean TinhTrangHonNhanChong(int id)
        {
            string sqlStr = string.Format("SELECT * FROM HonNhan WHERE ID_Chong = {0} AND TrangThai = 1", id);
            DataTable dt = dbConn.LayDanhSach(sqlStr);

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    return true;

                }
            }

            return false;
        }

        public Boolean TinhTrangHonNhanVo(int id)
        {
            string sqlStr = string.Format("SELECT * FROM HonNhan WHERE ID_Vo = {0} AND TrangThai = 1", id);
            DataTable dt = dbConn.LayDanhSach(sqlStr);

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    return true;

                }
            }

            return false;
        }

    }
}
