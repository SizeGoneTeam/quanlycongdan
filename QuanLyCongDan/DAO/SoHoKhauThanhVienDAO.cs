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
        public List<CongDan_SoHoKhau> LayDanhSach(int idSoHoKhau)
        {
            using (var db = new QLCongDanEntities())
            {
                var query = from cs in db.CongDan_SoHoKhau
                            join cd in db.CongDans on cs.ID_CongDan equals cd.ID_CongDan
                            where cs.ID_SoHoKhau == idSoHoKhau
                            select new CongDan_SoHoKhau
                            {
                                ID_SoHoKhau = cs.ID_SoHoKhau,
                                ID_CongDan = cs.ID_CongDan,
                                QuanHe = cs.QuanHe,
                                NgheNghiep_NoiLamViec = cs.NgheNghiep_NoiLamViec,
                                NoiThuongTruTruoc = cs.NoiThuongTruTruoc,
                                CanBoDangKy = cs.CanBoDangKy,
                                NgayDangKy = cs.NgayDangKy,
                                CongDan = cd
                            };

                return query.ToList();
            }
        }

        public bool Them(CongDan_SoHoKhau soHoKhauThanhVien)
        {
            using (var db = new QLCongDanEntities())
            {
                var newCongDan_SoHoKhau = new CongDan_SoHoKhau
                {
                    ID_SoHoKhau = soHoKhauThanhVien.ID_SoHoKhau,
                    ID_CongDan = soHoKhauThanhVien.CongDan.ID_CongDan,
                    QuanHe = soHoKhauThanhVien.QuanHe,
                    NgheNghiep_NoiLamViec = soHoKhauThanhVien.NgheNghiep_NoiLamViec,
                    NoiThuongTruTruoc = soHoKhauThanhVien.NoiThuongTruTruoc,
                    CanBoDangKy = soHoKhauThanhVien.CanBoDangKy,
                    NgayDangKy = soHoKhauThanhVien.NgayDangKy
                };

                db.CongDan_SoHoKhau.Add(newCongDan_SoHoKhau);
                db.SaveChanges();
            }

            return true;
        }

        public bool Them(int idSoHoKhau, CongDan_SoHoKhau soHoKhauThanhVien)
        {
            using (var db = new QLCongDanEntities())
            {
                var entity = new CongDan_SoHoKhau
                {
                    ID_SoHoKhau = idSoHoKhau,
                    ID_CongDan = soHoKhauThanhVien.CongDan.ID_CongDan,
                    QuanHe = soHoKhauThanhVien.QuanHe,
                    NgheNghiep_NoiLamViec = soHoKhauThanhVien.NgheNghiep_NoiLamViec,
                    NoiThuongTruTruoc = soHoKhauThanhVien.NoiThuongTruTruoc,
                    CanBoDangKy = soHoKhauThanhVien.CanBoDangKy,
                    NgayDangKy = soHoKhauThanhVien.NgayDangKy
                };

                db.CongDan_SoHoKhau.Add(entity);
                db.SaveChanges();

                return true;
            }
        }

        public bool Xoa(int id)
        {
            using (var db = new QLCongDanEntities())
            {
                var entity = db.CongDan_SoHoKhau.FirstOrDefault(x => x.ID_SoHoKhau == id);
                if (entity == null)
                    return false;
                db.CongDan_SoHoKhau.Remove(entity);
                db.SaveChanges();
                return true;
            }
        }
    }
}
