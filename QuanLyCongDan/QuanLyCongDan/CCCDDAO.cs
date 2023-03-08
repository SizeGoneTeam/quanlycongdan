using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Week2;

namespace QuanLyCongDan
{
    internal class CCCDDAO
    {
        DBconnection dbConn = new DBconnection();
        public void Them(CCCD cc)
        {
            String sqlStr = string.Format("INSERT INTO CCCD(ID_CCCD, ID_CongDan, SoCCCD, NoiCap, NgayCap) VALUES ('{0}','{1}','{2}','{3}','{4}')", cc.ID,cc.CD, cc.IDCC, cc.Add, cc.NgayCap);
            dbConn.ThucThi(sqlStr);
        }

        public void Xoa(CCCD cd)
        {
            String sqlStr = string.Format("DELETE FROM CCCD WHERE ID_CCCD = ('{0}')", cd.ID);
            dbConn.ThucThi(sqlStr);
        }

        public void Sua(CCCD cd)
        {
            String sqlStr = string.Format("UPDATE CCCD SET ID_CCCD = '{0}', ID_CongDan = '{1}', SoCCCD = '{2}', NoiCap = '{3}',NgayCap = '{4}'", cd.ID, cd.CD, cd.IDCC, cd.Add, cd.NgayCap);
            dbConn.ThucThi(sqlStr);
        }

        public DataTable LayDanhSachCCCD()
        {
            string sqlStr = string.Format("SELECT * FROM CCCD");
            return dbConn.LayDanhSach(sqlStr);
        }
    }
}
