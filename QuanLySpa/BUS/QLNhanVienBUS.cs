using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLySpa.DTO;
using QuanLySpa.DAO;

namespace QuanLySpa.BUS
{
    public class QLNhanVienBUS
    {
        public DataTable GetData()
        {
            DataTable dt = new DataTable();
            string query = "select * from NhanVien";
            DataConfig config = new DataConfig();
            dt = config.GetData(query);
            return dt;
        }
        public DataTable TimKiemNV(string id)
        {
            DataTable dt = new DataTable();
            string query = "select * from NhanVien where MaNV like '%" + id + "%' or TenNV = N'%" + id + "%'";
            DataConfig config = new DataConfig();
            dt = config.GetData(query);
            return dt;
        }
        public bool CheckID(string id)
        {
            DataTable dt = new DataTable();
            string query = "select * from NhanVien where MaNV = '" + id + "'";
            DataConfig config = new DataConfig();
            dt = config.GetData(query);
            if (dt.Rows.Count > 0)
                return false;
            return true;
        }

        public int ThemNV(NhanVienDTO obj)
        {
            int result = 0;
            string query = " INSERT dbo.NhanVien VALUES ('" + obj.MaNV + "',N'" + obj.TenNV + "')";
            DataConfig config = new DataConfig();
            result = config.fExecuteNoneQuery(query);
            return result;

        }
        public int SuaNV(NhanVienDTO obj)
        {
            int result = 0;
            string query = " UPDATE dbo.NhanVien SET TenNV = N'" + obj.TenNV + "' WHERE MaNV = '" + obj.MaNV + "'";
            DataConfig config = new DataConfig();
            result = config.fExecuteNoneQuery(query);
            return result;

        }
        public int XoaNV(NhanVienDTO obj)
        {
            int result = 0;
            string query = " DELETE dbo.NhanVien WHERE MaNV = '" + obj.MaNV + "'";
            DataConfig config = new DataConfig();
            result = config.fExecuteNoneQuery(query);
            return result;
        }
    }
}
