using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySpa.DTO
{
    public class ThongKeDTO
    {
        string _TenBang;
        int _STT;
        string _Ngay;
        string _MaNV;
        string _MaDV;
        int _ThoiGianDV;
        int _TienCer;
        int _TienMat;

        public int STT { get => _STT; set => _STT = value; }
        public string Ngay { get => _Ngay; set => _Ngay = value; }
        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public string MaDV { get => _MaDV; set => _MaDV = value; }
        public int ThoiGianDV { get => _ThoiGianDV; set => _ThoiGianDV = value; }
        public int TienCer { get => _TienCer; set => _TienCer = value; }
        public int TienMat { get => _TienMat; set => _TienMat = value; }
        public string TenBang { get => _TenBang; set => _TenBang = value; }
    }
}
