using QuanLySpa.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySpa.BUS
{
    public class QLTuaNgayBUS
    {
        public DataTable GetThangToComboBox()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM ThongKeThang";
            DataConfig config = new DataConfig();
            dt = config.GetData(query);

            return dt;
        }
        public DataTable GetData(string TenThang)
        {
            DataTable dt = new DataTable();
            string query = "select * from "+TenThang+"";
            DataConfig config = new DataConfig();
            dt = config.GetData(query);
            return dt;
        }
        public DataTable TimDichVu()
        {
            DataTable dt = new DataTable();
            string query = "select * from ThangDemo where ";
            DataConfig config = new DataConfig();
            dt = config.GetData(query);
            return dt;
        }
    }
}
