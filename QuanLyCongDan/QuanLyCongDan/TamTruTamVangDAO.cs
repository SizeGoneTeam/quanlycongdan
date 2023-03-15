using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2;

namespace QuanLyCongDan
{
    internal class TamTruTamVangDAO
    {
        DBconnection dbConn = new DBconnection();
        public TamTruTamVang TimKiem(int id)
        {
            string sqlStr = string.Format("select * from TamTruTamVang where ID_TamTru={0}", id);
            DataTable dt = dbConn.LayDanhSach(sqlStr);

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    return new TamTruTamVang(
                        row["ID_TamTru"].ToString(),
                        row["ID_CongDan"].ToString(),
                        Convert.ToDateTime(row["NgayDen"].ToString()),
                        row["DiaChi"].ToString(),
                        row["LiDo"].ToString());
                }
            }
            return null;
        }
        public void Them(TamTruTamVang tt)
        {
            String sqlStr = string.Format("INSERT INTO TamTruTamVang(ID_CongDan,NgayDen,DiaChi,LiDo) VALUES ('{0}','{1}','{2}','{3}')", tt.IDCD, tt.Come, tt.Add,tt.Why);
            dbConn.ThucThi(sqlStr);
        }

        public void Xoa(TamTruTamVang tt)
        {
            String sqlStr = string.Format("DELETE FROM TamTruTamVang WHERE ID_TamTru = ('{0}')", tt.IDTT);
            dbConn.ThucThi(sqlStr);
        }

        public void Sua(TamTruTamVang tt)
        {
            String sqlStr = string.Format("UPDATE TamTruTamVang SET ID_CongDan = '{0}', NgayDen = '{1}',LiDo = '{2}',DiaChi='{3}' where ID_TamTru = '{4}'", tt.IDCD, tt.Come, tt.Why, tt.Add,tt.IDTT);
            dbConn.ThucThi(sqlStr);
        }

        public DataTable LayDanhSachTamTruTamVang()
        {
            string sqlStr = string.Format("SELECT * FROM TamTruTamVang");
            return dbConn.LayDanhSach(sqlStr);
        }
    }
}
