using QuanLySpa.DAO;
using QuanLySpa.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySpa.BUS
{
    public class QLDichVuBUS
    {

        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            string query = "select * from DichVu";
            DataConfig config = new DataConfig();
            dt = config.GetData(query);
            return dt;
        }
        public DataTable TimKiemDV(string id)
        {
            DataTable dt = new DataTable();
            string query = "select * from DichVu where MaDV like '%" + id + "%' or TenDV like N'%" + id + "%'";
            DataConfig config = new DataConfig();
            dt = config.GetData(query);
            return dt;
        }
        public bool CheckID(string id)
        {
            DataTable dt = new DataTable();
            string query = "select * from DichVu where MaDV = '" + id + "'";
            DataConfig config = new DataConfig();
            dt = config.GetData(query);
            if (dt.Rows.Count > 0)
                return false;
            return true;
        }

        public int ThemDV(DichVuDTO obj)
        {
            int result = 0;
            string query = " INSERT into dbo.DichVu VALUES ('" + obj.MaDV + "',N'" + obj.TenDV + "','" + obj.ThoiGian + "', " + obj.GiaDV + ")";
            DataConfig config = new DataConfig();
            result = config.fExecuteNoneQuery(query);
            return result;

        }
        public int SuaDV(DichVuDTO obj)
        {
            int result = 0;
            string query = " UPDATE dbo.DichVu SET TenDV = N'" + obj.TenDV + "',ThoiGianDV = '" + obj.ThoiGian + "',GiaDV = N'" + obj.GiaDV + "'  WHERE MaDV = '" + obj.MaDV + "'";
            DataConfig config = new DataConfig();
            result = config.fExecuteNoneQuery(query);
            return result;

        }
        public int XoaDV(DichVuDTO obj)
        {
            int result = 0;
            string query = " DELETE dbo.DichVu WHERE MaDV = '" + obj.MaDV + "'";
            DataConfig config = new DataConfig();
            result = config.fExecuteNoneQuery(query);
            return result;
        }
    }
}
