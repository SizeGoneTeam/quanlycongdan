﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2;

namespace QuanLyCongDan
{
    internal class TamTruTamVangDAO
    {
        DBconnection dbConn = new DBconnection();
        public void Them(TamTruTamVang tt)
        {
            String sqlStr = string.Format("INSERT INTO TamTruTamVang(ID_CongDan,NgayDen,NgayDi,DiaChi) VALUES ('{0}','{1}','{2}','{3}')", tt.IDCD, tt.Come, tt.Leave, tt.Add);
            dbConn.ThucThi(sqlStr);
        }

        public void Xoa(TamTruTamVang tt)
        {
            String sqlStr = string.Format("DELETE FROM TamTruTamVang WHERE ID_TamTru = ('{0}')", tt.IDTT);
            dbConn.ThucThi(sqlStr);
        }

        public void Sua(TamTruTamVang tt)
        {
            String sqlStr = string.Format("UPDATE TamTruTamVang SET ID_CongDan = '{0}', NgayDen = '{1}',NgayDi = '{2}',DiaChi='{3}' where ID_TamTru = '{4}'", tt.IDCD, tt.Come, tt.Leave, tt.Add,tt.IDTT);
            dbConn.ThucThi(sqlStr);
        }

        public DataTable LayDanhSachTamTruTamVang()
        {
            string sqlStr = string.Format("SELECT * FROM TamTruTamVang");
            return dbConn.LayDanhSach(sqlStr);
        }
    }
}