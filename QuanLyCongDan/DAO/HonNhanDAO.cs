using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongDan
{
    internal class HonNhanDAO
    {
        public void Them(HonNhan hn)
        {
            using (var db = new QLCongDanEntities())
            {
                HonNhan honNhan = new HonNhan
                {
                    ID_Chong = hn.ID_Chong,
                    ID_Vo = hn.ID_Vo,
                    NgayDangKy = hn.NgayDangKy,
                    NoiDangKy = hn.NoiDangKy,
                    TrangThai = hn.TrangThai
                };

                db.HonNhans.Add(honNhan);
                db.SaveChanges();
            }
        }

        public void LyHon(string idChong, string idVo)
        {
            using (var db = new QLCongDanEntities())
            {
                var honNhan = db.HonNhans.FirstOrDefault(hn => hn.ID_Chong == int.Parse(idChong) && hn.ID_Vo == int.Parse(idVo));
                if (honNhan != null)
                {
                    honNhan.TrangThai = false;
                    db.SaveChanges();
                }
            }
        }

        public DataTable LayHonNhanMoi()
        {
            using (var db = new QLCongDanEntities())
            {
                var honNhan = db.HonNhans.OrderByDescending(hn => hn.ID_HonNhan).FirstOrDefault();
                DataTable dataTable = new DataTable();
                if (honNhan != null)
                {
                    dataTable.Rows.Add(honNhan.ID_HonNhan, honNhan.ID_Chong, honNhan.ID_Vo, honNhan.NgayDangKy, honNhan.NoiDangKy, honNhan.TrangThai);
                }
                return dataTable;
            }
        }


        public HonNhan TimKiem_ChongVo(int idChong, int idVo)
        {
            using (var db = new QLCongDanEntities())
            {
                var honNhan = db.HonNhans
                    .Where(hn => hn.ID_Chong == idChong || hn.ID_Vo == idChong || hn.ID_Chong == idVo || hn.ID_Vo == idVo)
                    .OrderByDescending(hn => hn.ID_HonNhan)
                    .FirstOrDefault();

                if (honNhan != null)
                {
                    return new HonNhan
                    {
                        ID_HonNhan = honNhan.ID_HonNhan,
                        ID_Chong = honNhan.ID_Chong,
                        ID_Vo = honNhan.ID_Vo,
                        NgayDangKy = honNhan.NgayDangKy,
                        NoiDangKy = honNhan.NoiDangKy,
                        TrangThai = honNhan.TrangThai
                    };
                }

                return null;
            }
        }


        public HonNhan TimKiemId(int id)
        {
            using (var db = new QLCongDanEntities())
            {
                var honNhan = db.HonNhans.FirstOrDefault(hn => hn.ID_HonNhan == id);

                if (honNhan != null)
                {
                    return new HonNhan
                    {
                        ID_HonNhan = honNhan.ID_HonNhan,
                        ID_Chong = honNhan.ID_Chong,
                        ID_Vo = honNhan.ID_Vo,
                        NgayDangKy = honNhan.NgayDangKy,
                        NoiDangKy = honNhan.NoiDangKy,
                        TrangThai = honNhan.TrangThai
                    };
                }

                return null;
            }
        }


        // True là đã kết hôn. False là chưa kết hôn
        public bool TinhTrangHonNhanChong(int id)
        {
            using (var db = new QLCongDanEntities())
            {
                return db.HonNhans.Any(hn => hn.ID_Chong == id && hn.TrangThai == true);
            }
        }

        public bool TinhTrangHonNhanVo(int id)
        {
            using (var db = new QLCongDanEntities())
            {
                return db.HonNhans.Any(hn => hn.ID_Vo == id && hn.TrangThai == true);
            }
        }


    }
}
