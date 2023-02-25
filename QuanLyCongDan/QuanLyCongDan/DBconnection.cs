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
        public void ThucThi(String sqlStr)
        {
            try
            {
                // Ket noi
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Thanh cong");

            }
            catch (Exception ex)
            {
                MessageBox.Show("That bai" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
