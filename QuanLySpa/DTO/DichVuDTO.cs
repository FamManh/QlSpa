using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySpa.DTO
{
    public class DichVuDTO
    {
        string _MaDV;
        string _TenDV;
        int _ThoiGian;
        int _GiaDV;

        public string MaDV { get => _MaDV; set => _MaDV = value; }
        public string TenDV { get => _TenDV; set => _TenDV = value; }
        public int GiaDV { get => _GiaDV; set => _GiaDV = value; }
        public int ThoiGian { get => _ThoiGian; set => _ThoiGian = value; }
    }
}
