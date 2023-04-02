using QuanLyCongDan.Model;
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
        DBconnection dbConn = new DBconnection();

        public void ThemThue(Thue thue)
        {
            string sqlStr = string.Format("INSERT INTO Thue(ID_CongDan) VALUES ({0})", thue.IDCongDan);
            dbConn.ThucThi(sqlStr);
        }

        public void ThemLichSuThue(LichSuThue lichSuThue)
        {
            string sqlStr = string.Format("INSERT INTO LichSuThue(ID_CongDan, ID_Thue, NgayNop, NguoiNop, SoTien) VALUES ({0}, {1}, '{2}', '{3}', {4})",
                                          lichSuThue.ID_CongDan, lichSuThue.ID_Thue, lichSuThue.NgayNop, lichSuThue.NguoiNop, lichSuThue.SoTien);
            dbConn.ThucThi(sqlStr);
        }

        public Thue TimKiem_ID(int id)
        {
            try
            {
                string sqlStr = string.Format("SELECT * FROM Thue WHERE ID_CongDan = '{0}'", id);
                DataTable dt = dbConn.LayDanhSach(sqlStr);

                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        DataRow row = dt.Rows[0];
                        return new Thue(
                            int.Parse(row["ID_Thue"].ToString()),
                            int.Parse(row["ID_CongDan"].ToString())
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

        public DataTable LayLichSuThueTheoIDCongDan(int id_congdan)
        {
            string sqlStr = string.Format("SELECT * FROM LichSuThue WHERE ID_CongDan = '{0}'", id_congdan);
            return dbConn.LayDanhSach(sqlStr);
        }
    }
}
