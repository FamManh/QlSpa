using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySpa.DTO
{
    public class TaoThangDTO
    {
        string _TenThang;
        string _MaThang;
        string _TenBang;
        public string TenThang { get => _TenThang; set => _TenThang = value; }
        public string MaThang { get => _MaThang; set => _MaThang = value; }
        public string TenBang { get => _TenBang; set => _TenBang = value; }
    }
}
