using QuanLyCongDan.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongDan.DAO
{
    internal class KhaiTuDAO
    {
        DBconnection con = new DBconnection();

        public KhaiTu TimKiem(int iD)
        {
            string sqlStr = string.Format(
                "SELECT * FROM KhaiTu WHERE ID_KhaiTu = '{0}'", 
                iD);

            DataTable dt = con.LayDanhSach(sqlStr);

            if (dt != null )
            {
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    return new KhaiTu(
                        iD,
                        int.Parse(row["ID_CongDan"].ToString()),
                        int.Parse(row["ID_NguoiYeuCau"].ToString()),
                        row["QuanHe"].ToString(),
                        Convert.ToDateTime(row["ThoiGianChet"].ToString()),
                        row["NoiChet"].ToString(),
                        row["NguyenNhan"].ToString(),
                        row["NoiDangKy"].ToString(),
                        Convert.ToDateTime(row["NgayThucHien"].ToString())
                        );
                }
            }

            return null;
        }

        public bool Them(KhaiTu khaiTu)
        {
            string sqlStr = string.Format(
                @"INSERT INTO KhaiTu(
                    ID_CongDan, 
                    ID_NguoiYeuCau, 
                    QuanHe, 
                    ThoiGianChet,
                    NoiChet,
                    NguyenNhan,
                    NoiDangKy,
                    NgayThucHien) 
                VALUES ('{0}', '{1}', N'{2}', '{3}', N'{4}', N'{5}', N'{6}', '{7}')",
                khaiTu.IDCongDan,
                khaiTu.IDNguoiYeuCau,
                khaiTu.QuanHe,
                khaiTu.ThoiGianChet,
                khaiTu.NoiChet,
                khaiTu.NguyenNhan,
                khaiTu.NoiDangKy,
                khaiTu.NgayThucHien);

            return con.ThucThi(sqlStr);
        }

        public bool Sua(KhaiTu khaiTu)
        {
            string sqlStr = string.Format(
                @"UPDATE KhaiTu SET
                    ID_CongDan = '{0}', 
                    ID_NguoiYeuCau = '{1}', 
                    QuanHe = N'{2}', 
                    ThoiGianChet = '{3}',
                    NoiChet = N'{4}',
                    NguyenNhan = N'{5}',
                    NoiDangKy = N'{6}',
                    NgayThucHien = '{7}'
                WHERE ID_KhaiTu = '{8}'",
                khaiTu.IDCongDan,
                khaiTu.IDNguoiYeuCau,
                khaiTu.QuanHe,
                khaiTu.ThoiGianChet,
                khaiTu.NoiChet,
                khaiTu.NguyenNhan,
                khaiTu.NoiDangKy,
                khaiTu.NgayThucHien,
                khaiTu.ID);

            return con.ThucThi(sqlStr);
        }

        public bool Xoa(int iD)
        {
            string sqlStr = string.Format(
                "DELETE FROM KhaiTu WHERE ID_KhaiTu = '{0}'", iD);

            return con.ThucThi(sqlStr);
        }

        public int getLatestRowIndex()
        {
            string sqlStr = string.Format("SELECT MAX(ID_KhaiTu) FROM KhaiTu");
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
