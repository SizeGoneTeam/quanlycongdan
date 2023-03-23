using QuanLyCongDan.Model;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongDan.DAO
{
    internal class CongTyDAO
    {
        DBconnection dbConn = new DBconnection();

        public void ThemCongTy(CongTy ct)
        {
            string sqlStr = string.Format("INSERT INTO CongTy(TenCongTy, NgayVao, Luong, TrangThai) VALUES ('{0}', '{1}', {2}, {3})", ct.TenCongTy, ct.NgayVao.ToString("yyyy-MM-dd"), ct.Luong, ct.TrangThai ? 1 : 0);
            dbConn.ThucThi(sqlStr);
        }

        public void NghiViec(int id)
        {
            string sqlStr = string.Format("UPDATE CongTy SET TrangThai = {0} WHERE ID_CongTy = {1}", 0 ,id);
            dbConn.ThucThi(sqlStr);
        }

        public void SuaLuong(CongTy ct)
        {
            string sqlStr = string.Format("UPDATE CongTy SET Luong = {0} WHERE ID_CongTy = {1}", ct.Luong, ct.Id_CongTy);
            dbConn.ThucThi(sqlStr);
        }
    }
}
