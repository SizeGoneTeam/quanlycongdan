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
            String sqlStr = string.Format("INSERT INTO CCCD(SoCCCD, NoiCap, NgayCap) VALUES ('{0}',N'{1}','{2}')",cc.SoCC, cc.Add, cc.NgayCap);
            dbConn.ThucThi(sqlStr);
        }

        public void Xoa(CCCD cc)
        {
            String sqlStr = string.Format("DELETE FROM CCCD WHERE ID_CongDan = ('{0}')", cc.IDCD);
            dbConn.ThucThi(sqlStr);
        }

        public void Sua(CCCD cc)
        {
            String sqlStr = string.Format("UPDATE CCCD SET SoCCCD = '{0}', NoiCap = '{1}',NgayCap = '{2}' where ID_CongDan = '{3}'", cc.SoCC, cc.Add, cc.NgayCap, cc.IDCD);
            dbConn.ThucThi(sqlStr);
        }
        
        public CCCD TimKiem_ID(string id)
        {
            string sqlStr = string.Format("SELECT * FROM CCCD WHERE SoCCCD LIKE '{0}'", id);
            return dbConn.TimKiemCC(sqlStr);
        }

        public DataTable LayDanhSachCCCD()
        {
            string sqlStr = string.Format("SELECT * FROM CCCD");
            return dbConn.LayDanhSach(sqlStr);
        }
    }
}
