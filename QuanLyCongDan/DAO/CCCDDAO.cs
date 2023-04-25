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
    internal class CCCDDAO
    {
        DBconnection dbConn = new DBconnection();
        public void Them(CCCD cc)
        {
            String sqlStr = string.Format("INSERT INTO CCCD(ID_CongDan,SoCCCD, NoiCap, NgayCap) VALUES ('{0}','{1}',N'{2}','{3}')",cc.IDCD,cc.SoCC, cc.Add, cc.NgayCap);
            dbConn.ThucThi(sqlStr);
        }

        public void Xoa(CCCD cc)
        {
            String sqlStr = string.Format("DELETE FROM CCCD WHERE ID_CongDan = ('{0}')", cc.IDCD);
            dbConn.ThucThi(sqlStr);
        }

        public void Sua(CCCD cc)
        {
            String sqlStr = string.Format("UPDATE CCCD SET SoCCCD = '{0}', NoiCap = N'{1}',NgayCap = '{2}' where ID_CongDan = '{3}'", cc.SoCC, cc.Add, cc.NgayCap, cc.IDCD);
            dbConn.ThucThi(sqlStr);
        }
        
        public CCCD TimKiem_ID(String id)
        {
            try
            {
                string sqlStr = string.Format("SELECT * FROM CCCD WHERE SoCCCD LIKE '{0}'", id);
                DataTable dt = dbConn.LayDanhSach(sqlStr);

                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        DataRow row = dt.Rows[0];
                        return new CCCD(
                            row["ID_CCCD"].ToString(),
                            row["ID_CongDan"].ToString(),
                            row["NoiCap"].ToString(),
                            row["SoCCCD"].ToString(),
                            Convert.ToDateTime(row["NgayCap"].ToString())
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

        public DataTable LayDanhSachCCCD()
        {
            string sqlStr = string.Format("SELECT * FROM CCCD");
            return dbConn.LayDanhSach(sqlStr);
        }

        public int toIdCongDan(String soCCCD)
        {
            string sqlStr = string.Format("SELECT * FROM CCCD WHERE SoCCCD LIKE '{0}'", soCCCD);
            DataTable dt = dbConn.LayDanhSach(sqlStr);

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    return int.Parse(row["ID_CongDan"].ToString());
                }
            }

            return -1;
        }
    }
}
