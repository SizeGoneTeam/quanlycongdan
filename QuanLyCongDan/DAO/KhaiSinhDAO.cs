using QuanLyCongDan.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongDan
{
    internal class KhaiSinhDAO
    {
        DBconnection con = new DBconnection();

        public KhaiSinh TimKiem(int id)
        {
            string sqlStr = string.Format("select * from KhaiSinh where ID_KhaiSinh={0}", id);
            DataTable dt = con.LayDanhSach(sqlStr);

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    return new KhaiSinh(
                        int.Parse(row["ID_KhaiSinh"].ToString()),
                        int.Parse(row["ID_CongDan"].ToString()),
                        int.Parse(row["ID_NguoiYeuCau"].ToString()),
                        int.Parse(row["ID_Cha"].ToString()),
                        int.Parse(row["ID_Me"].ToString()),
                        row["NoiDangKy"].ToString(),
                        Convert.ToDateTime(row["NgayThucHien"].ToString()));
                }
            }

            return null;
        }
        
        public bool Them(KhaiSinh ks)
        {
            string sqlStr = string.Format(
                "Insert into KhaiSinh(ID_CongDan, ID_NguoiYeuCau, ID_Cha, ID_Me, NoiDangKy, NgayThucHien) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                ks.IDCongDan,
                ks.IDNguoiYeuCau,
                ks.IDCha,
                ks.IDMe,
                ks.NoiDangKy,
                ks.NgayThucHien);

            return con.ThucThi(sqlStr);
        }

        public bool Sua(KhaiSinh ks)
        {
            string sqlStr = string.Format(
                "Update KhaiSinh set ID_CongDan = '{0}', ID_NguoiYeuCau = '{1}', ID_Cha = '{2}', ID_Me = '{3}', NoiDangKy = '{4}', NgayThucHien = '{5}' where ID_KhaiSinh = '{6}'",
                ks.IDCongDan,
                ks.IDNguoiYeuCau,
                ks.IDCha,
                ks.IDMe,
                ks.NoiDangKy,
                ks.NgayThucHien,
                ks.ID);

            return con.ThucThi(sqlStr);
        }

        public bool Xoa(int id)
        {
            string sqlStr = string.Format(
                "Delete from KhaiSinh where ID_KhaiSinh={0}", id);

            return con.ThucThi(sqlStr);
        }

        public int getLatestRowIndex()
        {
            string sqlStr = string.Format("SELECT MAX(ID_KhaiSinh) FROM KhaiSinh");
            DataTable dt = con.LayDanhSach(sqlStr);
            int latestIndex = -1;
            if (dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
            {
                latestIndex = Convert.ToInt32(dt.Rows[0][0]);
            }
            return latestIndex;
        }
    }
}
