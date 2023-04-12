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


        public void ThemLichSuThue(LichSuThue lichSuThue)
        {
            string sqlStr = string.Format("INSERT INTO LichSuThue(ID_CongDan, NgayTao, TenCongTy, SoTien, TrangThai) VALUES ({0}, '{1}', N'{2}', {3}, {4})",
                                          lichSuThue.ID_CongDan, lichSuThue.NgayTao, lichSuThue.TenCongTy, lichSuThue.SoTien, 0);
            dbConn.ThucThi(sqlStr);
        }


        public DataTable LayLichSuThueTheoIDCongDan(int id_congdan)
        {
            string sqlStr = string.Format("SELECT * FROM LichSuThue WHERE ID_CongDan = '{0}' ORDER BY ID_LichSuThue DESC", id_congdan);
            return dbConn.LayDanhSach(sqlStr);
        }

        public DataTable LayLichSuThueTheoCongTY(String tenCongTy)
        {
            string sqlStr = string.Format("SELECT * FROM LichSuThue WHERE NguoiNop = N'{0}' ORDER BY ID_LichSuThue DESC", tenCongTy);
            return dbConn.LayDanhSach(sqlStr);
        }

        public bool TimKiemThue(int idNhanVien, String tenCongTY, DateTime NgayTao)
        {
            string sqlStr = string.Format("SELECT * FROM LichSuThue WHERE ID_CongDan = '{0}' and NgayTao = '{1}' and TenCongTy = N'{2}'", idNhanVien, NgayTao.ToString("dd/MM/yy"), tenCongTY);
            DataTable data = dbConn.LayDanhSach(sqlStr);
            return data.Rows.Count > 0;
        }

        public void NopThue(int idNhanVien)
        {
            string sqlStr = string.Format("Update LichSuThue SET TrangThai = 1 WHERE ID_CongDan = '{0}'", idNhanVien);
            dbConn.ThucThi(sqlStr);

        }

        public DataTable LayCongDanChuaDongThue()
        {
            string sqlStr = "SELECT ID_CongDan, COUNT(*) as Total FROM LichSuThue WHERE TrangThai = 0 GROUP BY ID_CongDan";
            return dbConn.LayDanhSach(sqlStr);
        }
    }   
        
}
