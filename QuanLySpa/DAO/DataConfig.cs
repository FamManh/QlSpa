using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySpa.DAO
{
    public class DataConfig
    {
        SqlConnection con;
        public DataConfig()
        {
            Connect();
        }
        public void Connect()
        {
            try
            {
                string ConStr = @"Data Source=DESKTOP-RRVICEQ;Initial Catalog=QLSpa;Integrated Security=True";
                con = new SqlConnection(ConStr);
                con.Open();
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Kết nối bị lỗi: " + exp.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        public DataTable GetData(string query)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(dt);

            return dt;
        }

        public int fExecuteNoneQuery(string query)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            int result = 0;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            result = cmd.ExecuteNonQuery();

            return result;
        }

        public object fExecuteScalar(string query)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            object result = 0;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            result = cmd.ExecuteScalar();

            return result;
        }
    }
}
