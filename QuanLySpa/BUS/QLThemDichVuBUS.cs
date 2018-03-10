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
    public class QLThemDichVuBUS
    {
        public int ThemTua(ThongKeDTO obj)
        {
            int result = 0;
            string query = " INSERT INTO " + obj.TenBang + " VALUES ('" + obj.Ngay + "','" + obj.MaNV + "','" + obj.MaDV + "', " + obj.ThoiGianDV + "," + obj.TienCer + "," + obj.TienMat + ")";
            DataConfig config = new DataConfig();
            result = config.fExecuteNoneQuery(query);

            return result;
        }
        public DataTable LocTheoNgay(string _TenBang, string _Ngay)
        {
            DataTable result = new DataTable();
            string query = "SELECT * FROM " + _TenBang + "  WHERE Ngay = '" + _Ngay + "'";
            DataConfig config = new DataConfig();
            result = config.GetData(query);

            return result;
        }
        public int GetThoiGian(string MaDV)
        {
            int result = 0;
            string query = "SELECT ThoiGianDV FROM dbo.DichVu WHERE MaDV = '" + MaDV + "'";
            DataConfig config = new DataConfig();
            result = int.Parse(config.fExecuteScalar(query).ToString());

            return result;
        }
        public int XoaTua(string _TenBang, string id)
        {
            int result = 0;
            string query = "delete  " + _TenBang + " where STT = '" + id + "'";
            DataConfig config = new DataConfig();
            result = config.fExecuteNoneQuery(query);

            return result;
        }
        
        public bool IsNumber(string num, ref int result)
        {
            bool succes = int.TryParse(num, out result);
            return succes;
        }
    }
}
