using QuanLyCongDan.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongDan.DAO
{
    internal class SoHoKhauThanhVienDAO
    {
        DBconnection con = new DBconnection();

        public List<SoHoKhauThanhVien> LayDanhSach(int idSoHoKhau)
        {
            string sqlStr = string.Format(
                "SELECT * FROM CongDan_SoHoKhau WHERE ID_SoHoKhau = '{0}'",
                idSoHoKhau);

            DataTable dt = con.LayDanhSach(sqlStr);

            List<SoHoKhauThanhVien> list = new List<SoHoKhauThanhVien>();

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows) 
                    {
                        int idCongDan = int.Parse(dr["ID_CongDan"].ToString());
                        string quanHe = dr["QuanHe"].ToString();
                        string ngheNghiepNoiLamViec = dr["NgheNghiep_NoiLamViec"].ToString();
                        string noiThuongTruTruoc = dr["NoiThuongTruTruoc"].ToString();
                        string canBoDangKy = dr["CanBoDangKy"].ToString();
                        DateTime ngayDangKy = Convert.ToDateTime(dr["NgayDangKy"].ToString());

                        CongDanDAO dao = new CongDanDAO();

                        list.Add(new SoHoKhauThanhVien(
                            idSoHoKhau,
                            dao.TimKiem(idCongDan.ToString()),
                            quanHe,
                            ngheNghiepNoiLamViec,
                            noiThuongTruTruoc,
                            canBoDangKy,
                            ngayDangKy));
                        
                    }
                }
            }

            return list;
        }

        public bool Them(SoHoKhauThanhVien soHoKhauThanhVien)
        {
            string sqlStr = string.Format(
                @"INSERT INTO CongDan_SoHoKhau
                (ID_SoHoKhau, ID_CongDan, QuanHe, NgheNghiep_NoiLamViec, NoiThuongTruTruoc, CanBoDangKy, NgayDangKy)
                VALUES ('{0}', '{1}', N'{2}', N'{3}', N'{4}', N'{5}', '{6}')",
                soHoKhauThanhVien.IDSoHoKhau,
                soHoKhauThanhVien.CongDan.Id,
                soHoKhauThanhVien.QuanHe,
                soHoKhauThanhVien.NgheNghiepNoiLamViec,
                soHoKhauThanhVien.NoiThuongTruTruoc,
                soHoKhauThanhVien.CanBoDangKy,
                soHoKhauThanhVien.NgayDangKy);

            return con.ThucThi(sqlStr);
        }

    }
}
