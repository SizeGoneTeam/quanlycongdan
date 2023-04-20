using QuanLyCongDan.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongDan.DAO
{
    internal class TamTruTamVangDAO
    {
        DBconnection dbConn = new DBconnection();
        public void Them(TamTruTamVang tt)
        {
            String sqlStr = string.Format("INSERT INTO TamTruTamVang(ID_CongDan,NgayDen,NgayDi,DiaChi,LiDo) VALUES ('{0}','{1}','{2}',N'{3}',N'{4}') ",tt.IDCD,tt.Come.Date,tt.Leave.Date, tt.Add,tt.Why);
            dbConn.ThucThi(sqlStr);
        }

        public void Xoa(TamTruTamVang tt)
        {
            String sqlStr = string.Format("UPDATE TamTruTamVang SET NgayDen = '',NgayDi = '', LiDo ='', DiaChi='' WHERE ID_CongDan = '{0}' and NgayDen='{1}'", tt.IDCD, tt.Come.Date);
            dbConn.ThucThi(sqlStr);
        }

        public void Sua(TamTruTamVang tt)
        {
            String sqlStr = string.Format("UPDATE TamTruTamVang SET NgayDen = '{0}',NgayDi = '{1}',LiDo = N'{2}',DiaChi=N'{3}' where ID_CongDan = '{4}' and NgayDen ='{5}'", tt.Come,tt.Leave, tt.Why, tt.Add,tt.IDCD,tt.Come.Date);
            dbConn.ThucThi(sqlStr);
        }

        public DataTable LayDanhSachTamTruTamVang()
        {
            string sqlStr = string.Format("SELECT * FROM TamTruTamVang");
            return dbConn.LayDanhSach(sqlStr);
        }
        public TamTruTamVang TimKiemTT(string id)
        {
            string sqlStr = string.Format("select ID_CongDan, NgayDen, NgayDi, DiaChi, Lido from TamTruTamVang where ID_CongDan = '{0}'", id);
            DataTable dt = dbConn.LayDanhSach(sqlStr);

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    return new TamTruTamVang(
                        row["ID_CongDan"].ToString(),
                        Convert.ToDateTime(row["NgayDen"]),
                        Convert.ToDateTime(row["NgayDi"]),
                        row["DiaChi"].ToString(),
                        row["Lido"].ToString());
                }
            }

            return null;
        }
        public DataTable LayDanhSachLichsu(string id)
        {
            string sqlStr = string.Format("SELECT NgayDen as TuNgay, NgayDi as DenNgay, DiaChi, LiDo FROM TamTruTamVang where ID_CongDan = '{0}'",id);
            return dbConn.LayDanhSach(sqlStr);
        }

        public DataTable LayDanhSachQuaHan()
        {
            string sqlStr = string.Format(
                @"SELECT *
                FROM TamTruTamVang
                WHERE DATEDIFF(DAY, NgayDi, GETDATE()) > 1"
            );
            return dbConn.LayDanhSach(sqlStr);
        }
    }
}
