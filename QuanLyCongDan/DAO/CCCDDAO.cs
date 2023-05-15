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
            /*String sqlStr = string.Format("INSERT INTO CCCD(ID_CongDan,SoCCCD, NoiCap, NgayCap) VALUES ('{0}','{1}',N'{2}','{3}')", cc.IDCD, cc.SoCC, cc.ADD, cc.NgayCap.Date);
            dbConn.ThucThi(sqlStr);*/

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
            /*String sqlStr = string.Format("UPDATE CCCD SET SoCCCD = '', NoiCap = '', NgayCap = '' where ID_CongDan = '{0}'", cc.IDCD);
            dbConn.ThucThi(sqlStr);*/
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
            /*String sqlStr = string.Format("UPDATE CCCD SET SoCCCD = '{0}', NoiCap = N'{1}',NgayCap = '{2}' where ID_CongDan = '{3}'", cc.SoCC, cc.ADD, cc.NgayCap.Date, cc.IDCD);
            dbConn.ThucThi(sqlStr);*/
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
            /*try
            {
                string sqlStr = string.Format("SELECT * FROM CCCD WHERE SoCCCD LIKE '{0}'", id);
                DataTable dt = dbConn.LayDanhSach(sqlStr);

                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        DataRow row = dt.Rows[0];
                        return new CCCD(
                            row["ID_CCCD"].ToString(),
                            row["ID_CongDan"].ToString(),
                            row["SoCCCD"].ToString(),
                            Convert.ToDateTime(row["NgayCap"].ToString()),
                            row["NoiCap"].ToString()
                        );
                    }
                }

                return null;
            }
            catch
            {
                return null;
            }*/

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
            /*try
            {
                string sqlStr = string.Format("SELECT * FROM CCCD WHERE ID_CongDan LIKE '{0}'", id);
                DataTable dt = dbConn.LayDanhSach(sqlStr);

                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        DataRow row = dt.Rows[0];
                        return new CCCD(
                            row["ID_CCCD"].ToString(),
                            row["ID_CongDan"].ToString(),
                            row["SoCCCD"].ToString(),
                            Convert.ToDateTime(row["NgayCap"].ToString()),
                            row["NoiCap"].ToString()
                        );
                    }
                }

                return null;
            }
            catch
            {
                return null;
            }*/

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
            /*string sqlStr = string.Format("SELECT * FROM CCCD");
            return dbConn.LayDanhSach(sqlStr);*/
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
            /*string sqlStr = string.Format("SELECT * FROM CCCD WHERE SoCCCD LIKE '{0}'", soCCCD);
            DataTable dt = dbConn.LayDanhSach(sqlStr);

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    return int.Parse(row["ID_CongDan"].ToString());
                }
            }

            return -1;*/
            using (var dbConn = new QLCongDanEntities())
            {
                var cccd = dbConn.CCCDs.FirstOrDefault(c => c.SoCCCD == soCCCD);
                return cccd?.ID_CongDan ?? -1; // use null-coalescing operator
            }
        }
    }
}
