using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QuanLyCongDan.DAO
{
    internal class CCCDDAO
    {
        public void Them(CCCD cc)
        {
            using (var dbConn = new QLCongDanEntities())
            {
                var newCC = new CCCD
                {
                    ID_CongDan = cc.ID_CongDan,
                    SoCCCD = cc.SoCCCD,
                    NoiCap = cc.NoiCap,
                    NgayCap = cc.NgayCap,
                };

                dbConn.CCCDs.Add(newCC);
                dbConn.SaveChanges();
            }
        }

        public void Xoa(CCCD cc)
        {
            using (var dbConn = new QLCongDanEntities())
            {
                var delCC = dbConn.CCCDs.SingleOrDefault(c => c.ID_CongDan == cc.ID_CongDan);
                if (delCC != null)
                {
                    dbConn.CCCDs.Remove(delCC);
                    dbConn.SaveChanges();
                }
            }
        }

        public void Sua(CCCD cc)
        {
            using (var dbConn = new QLCongDanEntities())
            {
                var UpCCCD = dbConn.CCCDs.FirstOrDefault(c => c.ID_CongDan == cc.ID_CongDan);
                if (UpCCCD != null)
                {
                    UpCCCD.SoCCCD = cc.SoCCCD;
                    UpCCCD.NoiCap = cc.NoiCap;
                    UpCCCD.NgayCap = cc.NgayCap;
                    dbConn.SaveChanges();
                }
            }

        }

        public CCCD TimKiem_ID(String id)
        {
            try
            {
                using (var dbConn = new QLCongDanEntities())
                {
                    var cccd = dbConn.CCCDs.FirstOrDefault(c => c.SoCCCD.Contains(id));
                    if (cccd != null)
                    {
                        return new CCCD(
                            cccd.ID_CCCD,
                            cccd.ID_CongDan,
                            cccd.SoCCCD,
                            cccd.NgayCap,
                            cccd.NoiCap
                         );
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch
            {
                return null;
            }


        }
        public CCCD TimKiem(String id)
        {
            try
            {
                using (var dbConn = new QLCongDanEntities())
                {
                    var cccd = dbConn.CCCDs.FirstOrDefault(c => c.ID_CongDan == int.Parse(id));
                    if (cccd != null)
                    {
                        return new CCCD(
                            cccd.ID_CCCD,
                            cccd.ID_CongDan,
                            cccd.SoCCCD,
                            cccd.NgayCap,
                            cccd.NoiCap
                         );
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch
            {
                return null;
            }

        }
        public DataTable LayDanhSachCCCD()
        {
            using (var dbConn = new QLCongDanEntities())
            {
                var CCCD = dbConn.CCCDs.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("ID_CCCD", typeof(int));
                dt.Columns.Add("ID_CongDan", typeof(int));
                dt.Columns.Add("SoCCCD", typeof(int));
                dt.Columns.Add("NgayCap", typeof(DateTime));
                dt.Columns.Add("NoiCap", typeof(int));

                foreach (var cc in CCCD)
                {
                    var dr = dt.NewRow();
                    dr["ID_CCCD"] = cc.ID_CCCD;
                    dr["ID_CongDan"] = cc.ID_CongDan;
                    dr["SoCCCD"] = cc.SoCCCD;
                    dr["NgayCap"] = cc.NgayCap;
                    dr["NoiCap"] = cc.NoiCap;
                    dt.Rows.Add(dr);
                }

                return dt;
            }
        }
        public int toIdCongDan(String soCCCD)
        {
            using (var dbConn = new QLCongDanEntities())
            {
                var cccd = dbConn.CCCDs.FirstOrDefault(c => c.SoCCCD == soCCCD);
                return cccd?.ID_CongDan ?? -1; // use null-coalescing operator
            }
        }
    }
}
