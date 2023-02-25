using System;
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
            /*String sqlStr = string.Format("INSERT INTO HocSinh(Ten , QueQuan, Cmnd, NgaySinh, email, SDT) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')", cd.HoTen, cd.QueQuan, cd.Cmnd, cd.NgaySinh, cd.Email, cd.Sdt);
            dbConn.ThucThi(sqlStr);*/
        }

        public void Xoa(CongDan cd)
        {
            /*String sqlStr = string.Format("DELETE FROM HocSinh WHERE macd = ('{0}')", cd.Id);
            dbConn.ThucThi(sqlStr);*/
        }

        public void Sua(CongDan cd)
        {
            /*String sqlStr = string.Format("UPDATE HocSinh SET Ten = '{0}', QueQuan = '{1}', email = '{3}', SDT = '{4}' WHERE macd = {2}", cd.HoTen, cd.NoiSinh, cd.Id, cd.Email, cd.Sdt);
            dbConn.ThucThi(sqlStr);*/
        }

        public DataTable LayDanhSachCongDan()
        {
            string sqlStr = string.Format("SELECT * FROM HocSinh");
            return dbConn.LayDanhSach(sqlStr);
        }

        private Boolean IsNull(CongDan cd)
        {
            if (String.IsNullOrEmpty(cd.HoTen)) return true;
            if (String.IsNullOrEmpty(cd.QueQuan)) return true;
            if (String.IsNullOrEmpty(cd.GioiTinh)) return true;
            if (String.IsNullOrEmpty(cd.Email)) return true;
            if (String.IsNullOrEmpty(cd.Sdt)) return true;
            return false;
        }

        private Boolean checkEmail_SDT(CongDan cd)
        {
            bool isValidPhoneNumber = Regex.IsMatch(cd.Sdt, @"^\d{10}$");
            bool isValidEmail = Regex.IsMatch(cd.Email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (isValidPhoneNumber && isValidEmail) return true;
            return false;
        }

        public String KiemTraDuLieu(CongDan cd)
        {
            string result = "";
            if (IsNull(cd)) result += "Vui long nhap day du thong tin ";
            if (!checkEmail_SDT(cd)) result += "SDT hoac email khong hop le";
            return result;
        }
    }
}
