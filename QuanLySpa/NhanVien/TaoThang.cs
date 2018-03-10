using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySpa.DTO;
using QuanLySpa.BUS;

namespace QuanLySpa.NhanVien
{
    public partial class fTaoThang : Form
    {
        public fTaoThang()
        {
            InitializeComponent();
        }
        static string TenBang = "";
        public string GetTenBang()
        {
            return TenBang;
        }
        private void btnTaoThang_Click(object sender, EventArgs e)
        {
            try
            {
                TaoThangDTO obj = new TaoThangDTO();
                obj.TenBang = txbTenBang.Text.Trim();
                if (obj.TenBang == null)
                {
                    MessageBox.Show("Các trường phải điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    
                    SpaManagerBUS _Thang = new SpaManagerBUS();
                    if (_Thang.CheckThang(obj.TenBang) == true)
                    {
                        _Thang.TaoThangMoi(obj);
                        TenBang = obj.TenBang;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Tên này đã tồn tại, xin chọn tên khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }


                }
            }
            catch(Exception exp)
            {
                MessageBox.Show("Thêm bị lỗi: "+ exp.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void btnHuyThang_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
