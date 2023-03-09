﻿using System;
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
            String sqlStr = string.Format("INSERT INTO CCCD(ID_CongDan,SoCCCD, NoiCap, NgayCap) VALUES ('{0}','{1}','{2}','{3}')",cc.CD, cc.IDCC, cc.Add, cc.NgayCap);
            dbConn.ThucThi(sqlStr);
        }

        public void Xoa(CCCD cc)
        {
            String sqlStr = string.Format("DELETE FROM CCCD WHERE ID_CongDan = ('{0}')", cc.CD);
            dbConn.ThucThi(sqlStr);
        }

        public void Sua(CCCD cc)
        {
            String sqlStr = string.Format("UPDATE CCCD SET SoCCCD = '{0}', NoiCap = '{1}',NgayCap = '{2}' where ID_CongDan = '{3}'", cc.IDCC, cc.Add, cc.NgayCap, cc.CD);
            dbConn.ThucThi(sqlStr);
        }

        public DataTable LayDanhSachCCCD()
        {
            string sqlStr = string.Format("SELECT * FROM CCCD");
            return dbConn.LayDanhSach(sqlStr);
        }
    }
}
