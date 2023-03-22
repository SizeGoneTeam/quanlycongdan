using QuanLyCongDan;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week2
{
    internal class DBconnection
    {
        SqlConnection conn = new SqlConnection(QuanLyCongDan.Properties.Settings.Default.connStr);

        public CongDan TimKiemDB(string sqlStr)
        {
            CongDan cd = new CongDan();
            DataTable dtds = new DataTable();
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                adapter.Fill(dtds);
                if (dtds.Rows.Count > 0)
                {
                    DataRow dr = dtds.Rows[0];
                    cd.Id = dr["ID_CongDan"].ToString();
                    cd.HoTen = dr["HoTen"].ToString();
                    cd.GioiTinh = dr["GioiTinh"].ToString();
                    cd.NgaySinh = Convert.ToDateTime(dr["NgaySinh"]);
                    cd.QueQuan = dr["QueQuan"].ToString();
                    cd.DanToc = dr["DanToc"].ToString();
                    cd.TonGiao = dr["TonGiao"].ToString();
                    cd.Sdt = dr["SDT"].ToString();
                    cd.Email = dr["Email"].ToString();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return cd;
        }
        public CCCD TimKiemCC(string sqlStr)
        {
            CCCD cc = new CCCD();
            DataTable dtds = new DataTable();
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                adapter.Fill(dtds);
                if (dtds.Rows.Count > 0)
                {
                    DataRow dr = dtds.Rows[0];
                    cc.CD = dr["ID_CongDan"].ToString();
                    cc.IDCC = dr["SoCCCD"].ToString();
                    cc.Add = dr["NoiCap"].ToString();
                    cc.NgayCap = Convert.ToDateTime(dr["NgayCap"]);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return cc;
        }
        public DataTable LayDanhSach(string sqlStr)
        {
            DataTable dtds = new DataTable();
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                adapter.Fill(dtds);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return dtds;
        }
        public bool ThucThi(String sqlStr)
        {
            try
            {
                // Ket noi
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Thanh cong");
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("That bai" + ex);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
