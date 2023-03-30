using QuanLyCongDan.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QuanLyCongDan.DAO
{
    internal class ThueDAO
    {
        DBconnection dbConn = new DBconnection();

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
                            row["ID_Thue"].ToString(),
                            row["ID_CongDan"].ToString()
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
