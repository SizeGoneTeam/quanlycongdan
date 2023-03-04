﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week2
{
    internal class CongDanDAO
    {
        DBconnection dbConn = new DBconnection();
        public void Them(CongDan cd)
        {
            String sqlStr = string.Format("INSERT INTO CongDan (HoTen, GioiTinh, NgaySinh, QueQuan, DanToc, TonGiao, SDT, Email) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}');", cd.HoTen, cd.GioiTinh, cd.NgaySinh, cd.QueQuan, cd.DanToc, cd.TonGiao, cd.Sdt, cd.Email);
            dbConn.ThucThi(sqlStr);
        }

        public void Xoa(CongDan cd)
        {
            String sqlStr = string.Format("DELETE FROM CongDan WHERE ID_CongDan = {0};", cd.Id);
            dbConn.ThucThi(sqlStr);
        }

        public void Sua(CongDan cd)
        {
            String sqlStr = string.Format("UPDATE CongDan SET HoTen = '{0}', GioiTinh = '{1}', NgaySinh = '{2}', QueQuan = '{3}', DanToc = '{4}', TonGiao = '{5}', SDT = '{6}', Email = '{7}' WHERE ID_CongDan = {8};", cd.HoTen, cd.GioiTinh, cd.NgaySinh, cd.QueQuan, cd.DanToc, cd.TonGiao, cd.Sdt, cd.Email, cd.Id);
            dbConn.ThucThi(sqlStr);
        }   

        public CongDan TimKiem(String id)
        {
            String sqlStr = string.Format("select * from CongDan where ID_CongDan = '{0}'", id);
            return dbConn.TimKiemDB(sqlStr);
        }

        public DataTable LayDanhSachCongDan()
        {
            string sqlStr = string.Format("SELECT * FROM CongDan");
            return dbConn.LayDanhSach(sqlStr);
        }

        private Boolean checkEmail_SDT(CongDan cd)
        {
            bool isValidPhoneNumber = Regex.IsMatch(cd.Sdt, @"^\d{10}$");
            bool isValidEmail = Regex.IsMatch(cd.Email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (isValidPhoneNumber && isValidEmail) return true;
            return false;
        }
    }
}
