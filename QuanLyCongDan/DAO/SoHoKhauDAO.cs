using QuanLyCongDan.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace QuanLyCongDan.DAO
{
    internal class SoHoKhauDAO
    {
        DBconnection con = new DBconnection();

        public SoHoKhau TimKiem(int id)
        {
            string sqlStr = string.Format("select * from SoHoKhau where ID_SoHoKhau={0}", id);
            DataTable dt = con.LayDanhSach(sqlStr);

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    int idSoHoKhau = string.IsNullOrEmpty(row["ID_SoHoKhau"].ToString()) ? 0 : int.Parse(row["ID_SoHoKhau"].ToString());
                    int idHoSoHoKhau = string.IsNullOrEmpty(row["ID_HoSoHoKhau"].ToString()) ? 0 : int.Parse(row["ID_HoSoHoKhau"].ToString());
                    string idSoDangKyThuongTru = row["ID_SoDangKyThuongTru"].ToString();
                    string idToSo = row["ID_SoDangKyThuongTru_ToSo"].ToString();
                    string noiThuongTru = row["NoiThuongTru"].ToString();
                    DateTime ngayDangKy = Convert.ToDateTime(row["NgayDangKy"].ToString());

                    return new SoHoKhau(idSoHoKhau, idHoSoHoKhau, idSoDangKyThuongTru, idToSo, noiThuongTru, ngayDangKy);
                }
            }

            return null;
        }

        public bool Them(SoHoKhau soHoKhau)
        {
            string sqlStr = string.Format(
                "INSERT INTO SoHoKhau(ID_HoSoHoKhau, ID_SoDangKyThuongTru, ID_SoDangKyThuongTru_ToSo, NoiThuongTru, NgayDangKy) VALUES('{0}', '{1}', '{2}', N'{3}', '{4}')",
                soHoKhau.IDHoSoHoKhau,
                soHoKhau.IDSoDangKyThuongTru,
                soHoKhau.IDToSo,
                soHoKhau.NoiThuongTru,
                soHoKhau.NgayDangKy);

            return con.ThucThi(sqlStr);
        }

        public bool Sua(SoHoKhau soHoKhau)
        {
            string sqlStr = string.Format(
                "UPDATE SoHoKhau SET ID_HoSoHoKhau = '{0}', ID_SoDangKyThuongTru = '{1}', ID_SoDangKyThuongTru_ToSo = '{2}', NoiThuongTru = N'{3}', NgayDangKy = '{4}' WHERE ID_SoHoKhau = '{5}'",
                soHoKhau.IDHoSoHoKhau,
                soHoKhau.IDSoDangKyThuongTru,
                soHoKhau.IDToSo,
                soHoKhau.NoiThuongTru,
                soHoKhau.NgayDangKy,
                soHoKhau.ID);
;
            return con.ThucThi(sqlStr);
        }

        public bool Xoa(int id)
        {
            string sqlStr = string.Format(
                "DELETE FROM SoHoKhau WHERE ID_SoHoKhau = '{0}'",
                id);

            return con.ThucThi(sqlStr);
        }

    }
}
