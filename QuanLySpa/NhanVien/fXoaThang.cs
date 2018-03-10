using QuanLySpa.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySpa.NhanVien
{
    public partial class fXoaThang : Form
    {
        public fXoaThang()
        {
            InitializeComponent();
        }

        private void btnHuyThang_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoaThang_Click(object sender, EventArgs e)
        {
            try
            {
                SpaManagerBUS _Spa = new SpaManagerBUS();
                if (_Spa.CheckThang(txbTenBang.Text.Trim()) == false)
                {
                    _Spa.XoaThang(txbTenBang.Text.Trim());
                    this.Close();
                }
                else
                    MessageBox.Show("Tháng này không tồn tại sao mà xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception exp)
            {
                MessageBox.Show("Xóa tháng bị lỗi: " + exp.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
