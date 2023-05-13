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
        public KhaiTu TimKiem(int id)
        {
            using (var db = new QLCongDanEntities())
            {
                var khaiTu = db.KhaiTus.FirstOrDefault(x => x.ID_KhaiTu == id);

                if (khaiTu != null)
                {
                    return new KhaiTu(
                        khaiTu.ID_KhaiTu,
                        khaiTu.ID_CongDan,
                        khaiTu.ID_NguoiYeuCau,
                        khaiTu.QuanHe,
                        khaiTu.ThoiGianChet,
                        khaiTu.NoiChet,
                        khaiTu.NguyenNhan,
                        khaiTu.NoiDangKy,
                        khaiTu.NgayThucHien
                    );
                }
            }

            return null;
        }

        public bool Them(KhaiTu khaiTu)
        {
            using (var db = new QLCongDanEntities())
            {
                var khaiTuEntity = new KhaiTu()
                {
                    ID_CongDan = khaiTu.ID_CongDan,
                    ID_NguoiYeuCau = khaiTu.ID_NguoiYeuCau,
                    QuanHe = khaiTu.QuanHe,
                    ThoiGianChet = khaiTu.ThoiGianChet,
                    NoiChet = khaiTu.NoiChet,
                    NguyenNhan = khaiTu.NguyenNhan,
                    NoiDangKy = khaiTu.NoiDangKy,
                    NgayThucHien = khaiTu.NgayThucHien
                };

                db.KhaiTus.Add(khaiTuEntity);
                db.SaveChanges();

                return true;
            }
        }

        public bool Sua(KhaiTu khaiTu)
        {
            using (var db = new QLCongDanEntities())
            {
                var khaiTuDb = db.KhaiTus.FirstOrDefault(x => x.ID_KhaiTu == khaiTu.ID_KhaiTu);

                if (khaiTuDb != null)
                {
                    khaiTuDb.ID_CongDan = khaiTu.ID_CongDan;
                    khaiTuDb.ID_NguoiYeuCau = khaiTu.ID_NguoiYeuCau;
                    khaiTuDb.QuanHe = khaiTu.QuanHe;
                    khaiTuDb.ThoiGianChet = khaiTu.ThoiGianChet;
                    khaiTuDb.NoiChet = khaiTu.NoiChet;
                    khaiTuDb.NguyenNhan = khaiTu.NguyenNhan;
                    khaiTuDb.NoiDangKy = khaiTu.NoiDangKy;
                    khaiTuDb.NgayThucHien = khaiTu.NgayThucHien;

                    db.SaveChanges();

                    return true;
                }

                return false;
            }
        }

        public bool Xoa(int iD)
        {
            using (var db = new QLCongDanEntities())
            {
                var khaiTu = db.KhaiTus.FirstOrDefault(x => x.ID_KhaiTu == iD);

                if (khaiTu != null)
                {
                    db.KhaiTus.Remove(khaiTu);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public int getLatestRowIndex()
        {
            using (var dbConn = new QLCongDanEntities())
            {
                int latestIndex = dbConn.KhaiTus.Max(kt => (int?)kt.ID_KhaiTu) ?? -1;
                return latestIndex;
            }
        }
    }
}
