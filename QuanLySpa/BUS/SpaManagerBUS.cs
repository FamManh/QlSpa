using QuanLySpa.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLySpa.DTO;
using System.Data;

namespace QuanLySpa.BUS
{
    public class SpaManagerBUS
    {
        public int TaoThangMoi(TaoThangDTO obj)
        {
            int result = 0;
            int result1 = 0;
            string query = "CREATE TABLE " + obj.TenBang + " ( STT INT PRIMARY KEY IDENTITY(1,1), Ngay DATETIME DEFAULT(GETDATE()), MaNV VARCHAR(20) FOREIGN KEY REFERENCES dbo.NhanVien(MaNV), MaDV VARCHAR(20) FOREIGN KEY REFERENCES dbo.DichVu(MaDV), ThoiGianDV INT DEFAULT(0), TienCer INT DEFAULT (0), TienMat INT DEFAULT(0), )";
            string query1 = "INSERT INTO dbo.ThongKeThang VALUES ('" + obj.TenBang + "')";
            DataConfig config = new DataConfig();
            result = config.fExecuteNoneQuery(query);
            result1 = config.fExecuteNoneQuery(query1);
            return result;
        }
        public int XoaThang(string id)
        {
            int result = 0;
            int result1 = 0;
            string query = "DROP TABLE " + id + "";
            string query1 = "DELETE dbo.ThongKeThang WHERE TenBang = '" + id + "'";
            DataConfig config = new DataConfig();
            result = config.fExecuteNoneQuery(query);
            result1 = config.fExecuteNoneQuery(query1);
            return result;
        }
        public bool CheckThang(string id)
        {
            DataTable dt = new DataTable();
            string query = "select * from ThongKeThang where TenBang = '" + id + "'";
            DataConfig config = new DataConfig();
            dt = config.GetData(query);
            if (dt.Rows.Count > 0)
                return false;
            return true;

        }
        public DataTable TimKiemTua(string _TenBang, string _Ngay, string _TenNhanVien, string id)
        {
            //Ngay = '" + _Ngay + "' and
            DataTable dt = new DataTable();
            string query = "SELECT * FROM " + _TenBang + " WHERE Ngay = '" + _Ngay + "' and  MaDV LIKE '%" + id + "%' and MaNV LIKE '%" + _TenNhanVien + "%'";
            DataConfig config = new DataConfig();
            dt = config.GetData(query);

            return dt;
        }

        public DataTable LocNhanVien(string _TenBang, string _Ngay, string _TenNhanVien)
        {
            //Ngay = '" + _Ngay + "' and
            DataTable dt = new DataTable();
            string query = "SELECT * FROM " + _TenBang + " WHERE Ngay = '" + _Ngay + "' and  MaNV LIKE '%" + _TenNhanVien + "%'";
            DataConfig config = new DataConfig();
            dt = config.GetData(query);

            return dt;
        }
        public DataTable LoadNhanVienToComboBox()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM dbo.NhanVien";
            DataConfig config = new DataConfig();
            dt = config.GetData(query);

            return dt;
        }
        // tab 2
        public DataTable LoadDataTongThang(string _Thang)
        {
            DataTable dt = new DataTable();
            string query = "SELECT nv.MaNV,count (*) AS Tua,SUM(thang.ThoiGianDV) AS ThoiGian, SUM(thang.TienCer) AS TienCer, SUM(thang.TienMat) AS TienMat,SUM(thang.TienCer) + SUM(thang.TienMat) AS TongTien FROM " + _Thang + " AS thang, dbo.NhanVien AS nv WHERE thang.MaNV = nv.MaNV GROUP BY nv.MaNV";
            string query1 = "SELECT nv.MaNV,count (*) AS Tua,SUM(thang.ThoiGianDV) AS ThoiGian, SUM(thang.TienCer) AS TienCer, SUM(thang.TienMat) AS TienMat,SUM(thang.TienCer) + SUM(thang.TienMat) AS TongTien FROM " + _Thang + "  AS thang, dbo.NhanVien AS nv WHERE thang.MaNV = nv.MaNV GROUP BY nv.MaNV";
            DataConfig config = new DataConfig();
            dt = config.GetData(query);

            return dt;
        }
    }
}
