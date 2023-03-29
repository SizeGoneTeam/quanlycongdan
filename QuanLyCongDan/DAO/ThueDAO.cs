using QuanLyCongDan.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongDan
{
    internal class ThueDAO
    {
        DBconnection dbConn = new DBconnection();
        public void Them(Thue thue)
        {
            String sqlStr = string.Format("INSERT INTO Thue(ID_CongDan,MaSoThue,NgayCapNhat) VALUES ('{0}','{1}','{2}')",thue.ID, thue.Mso, thue.NgayUp);
            dbConn.ThucThi(sqlStr);
        }

        public void Xoa(Thue thue)
        {
            String sqlStr = string.Format("DELETE FROM Thue WHERE ID_Thue = ('{0}')", thue.IDThue);
            dbConn.ThucThi(sqlStr);
        }

        public void Sua(Thue thue)
        {
            String sqlStr = string.Format("UPDATE Thue SET ID_CongDan = '{0}',MaSoThue = '{1}',NgayCapNhat = '{2}' where ID_Thue = '{3}'", thue.ID,thue.Mso, thue.NgayUp, thue.IDThue);
            dbConn.ThucThi(sqlStr);
        }

        public DataTable LayDanhSachThue()
        {
            string sqlStr = string.Format("SELECT * FROM Thue");
            return dbConn.LayDanhSach(sqlStr);
        }
    }
}
