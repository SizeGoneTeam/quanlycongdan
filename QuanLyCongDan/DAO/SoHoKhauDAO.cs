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
        public SoHoKhau TimKiem(int id)
        {
            using (var db = new QLCongDanEntities())
            {
                var soHoKhau = db.SoHoKhaus.FirstOrDefault(s => s.ID_SoHoKhau == id);

                if (soHoKhau != null)
                {
                    return new SoHoKhau(
                        soHoKhau.ID_SoHoKhau,
                        soHoKhau.ID_HoSoHoKhau,
                        soHoKhau.ID_SoDangKyThuongTru,
                        soHoKhau.ID_SoDangKyThuongTru_ToSo,
                        soHoKhau.NoiThuongTru,
                        soHoKhau.NgayDangKy
                    );
                }

                return null;
            }
        }

        public bool Them(SoHoKhau soHoKhau)
        {
            using (var db = new QLCongDanEntities())
            {
                var entity = new SoHoKhau
                {
                    ID_HoSoHoKhau = soHoKhau.ID_HoSoHoKhau,
                    ID_SoDangKyThuongTru = soHoKhau.ID_SoDangKyThuongTru,
                    ID_SoDangKyThuongTru_ToSo = soHoKhau.ID_SoDangKyThuongTru_ToSo,
                    NoiThuongTru = soHoKhau.NoiThuongTru,
                    NgayDangKy = soHoKhau.NgayDangKy
                };

                db.SoHoKhaus.Add(entity);
                return db.SaveChanges() > 0;
            }
        }

        public bool Sua(SoHoKhau soHoKhau)
        {
            using (var context = new QLCongDanEntities())
            {
                var entity = context.SoHoKhaus.Find(soHoKhau.ID_SoHoKhau);
                if (entity != null)
                {
                    entity.ID_HoSoHoKhau = soHoKhau.ID_HoSoHoKhau;
                    entity.ID_SoDangKyThuongTru = soHoKhau.ID_SoDangKyThuongTru;
                    entity.ID_SoDangKyThuongTru_ToSo = soHoKhau.ID_SoDangKyThuongTru_ToSo;
                    entity.NoiThuongTru = soHoKhau.NoiThuongTru;
                    entity.NgayDangKy = soHoKhau.NgayDangKy;

                    context.SaveChanges();
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
            using (var db = new QLCongDanEntities())
            {
                var soHoKhau = db.SoHoKhaus.FirstOrDefault(x => x.ID_SoHoKhau == id);

                if (soHoKhau != null)
                {
                    db.SoHoKhaus.Remove(soHoKhau);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public int GetLatestRowIndex()
        {
            using (var db = new QLCongDanEntities())
            {
                var latestIndex = db.SoHoKhaus.Max(x => x.ID_SoHoKhau);
                return latestIndex;
            }
        }
    }
}
