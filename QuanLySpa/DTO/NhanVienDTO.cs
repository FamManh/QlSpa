using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySpa.DTO
{
    public class NhanVienDTO
    {
        string _MaNV;
        string _TenNV;

            

        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public string TenNV { get => _TenNV; set => _TenNV = value; }
    }
}
