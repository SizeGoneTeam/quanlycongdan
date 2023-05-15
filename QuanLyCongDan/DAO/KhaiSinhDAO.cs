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
        public KhaiSinh TimKiem(int id)
        {
            using (var db = new QLCongDanEntities())
            {
                var khaiSinh = db.KhaiSinhs.FirstOrDefault(x => x.ID_KhaiSinh == id);

                if (khaiSinh != null)
                {
                    return new KhaiSinh(
                        khaiSinh.ID_KhaiSinh,
                        khaiSinh.ID_CongDan,
                        khaiSinh.ID_NguoiYeuCau,
                        khaiSinh.ID_Cha,
                        khaiSinh.ID_Me,
                        khaiSinh.NoiDangKy,
                        khaiSinh.NgayThucHien);
                }
            }

            return null;
        }

        public bool Them(KhaiSinh khaiSinh)
        {
            using (var dbConn = new QLCongDanEntities())
            {
                var newKhaiSinh = new KhaiSinh
                {
                    ID_CongDan = khaiSinh.ID_CongDan,
                    ID_NguoiYeuCau = khaiSinh.ID_NguoiYeuCau,
                    ID_Cha = khaiSinh.ID_Cha,
                    ID_Me = khaiSinh.ID_Me,
                    NoiDangKy = khaiSinh.NoiDangKy,
                    NgayThucHien = khaiSinh.NgayThucHien
                };

                dbConn.KhaiSinhs.Add(newKhaiSinh);
                dbConn.SaveChanges();

                return true;
            }
        }

        public bool Sua(KhaiSinh khaiSinh)
        {
            using (var dbConn = new QLCongDanEntities())
            {
                var ks = dbConn.KhaiSinhs.FirstOrDefault(x => x.ID_KhaiSinh == khaiSinh.ID_KhaiSinh);

                if (ks != null)
                {
                    ks.ID_CongDan = khaiSinh.ID_CongDan;
                    ks.ID_NguoiYeuCau = khaiSinh.ID_NguoiYeuCau;
                    ks.ID_Cha = khaiSinh.ID_Cha;
                    ks.ID_Me = khaiSinh.ID_Me;
                    ks.NoiDangKy = khaiSinh.NoiDangKy;
                    ks.NgayThucHien = khaiSinh.NgayThucHien;

                    dbConn.SaveChanges();

                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool Xoa(int id)
        {
            using (var dbConn = new QLCongDanEntities())
            {
                var khaiSinh = dbConn.KhaiSinhs.FirstOrDefault(ks => ks.ID_KhaiSinh == id);

                if (khaiSinh != null)
                {
                    dbConn.KhaiSinhs.Remove(khaiSinh);
                    dbConn.SaveChanges();

                    return true;
                }

                return false;
            }
        }

        public int GetLatestRowIndex()
        {
            using (var dbConn = new QLCongDanEntities())
            {
                int latestIndex = dbConn.KhaiSinhs.Max(ks => (int?)ks.ID_KhaiSinh) ?? -1;
                return latestIndex;
            }
        }
    }
}
