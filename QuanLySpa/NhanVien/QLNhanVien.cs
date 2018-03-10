using QuanLySpa.BUS;
using QuanLySpa.DTO;
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
    public partial class QLNhanVien : Form
    {
        public QLNhanVien()
        {
            InitializeComponent();
        }

        private void QLNhanVien_Load(object sender, EventArgs e)
        {
            LoadNV();
        }
        string query = "";
        void Execute (string query)
        {
            if (query == "add")
            {
                try
                {
                    NhanVienDTO obj = new NhanVienDTO();
                    obj.MaNV = txbMaNV.Text.Trim();
                    obj.TenNV = txbTenNV.Text.Trim();
                    QLNhanVienBUS _Staff = new QLNhanVienBUS();
                    if (_Staff.CheckID(obj.MaNV.Trim()) == true)
                    {
                        _Staff.ThemNV(obj);
                        LoadNV();
                    }
                    else
                    {
                        MessageBox.Show("Mã nhân viên này đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Thêm bị lỗi: " + exp.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            if (query == "edit")
            {
                try
                {
                    NhanVienDTO obj = new NhanVienDTO();
                    obj.MaNV = txbMaNV.Text.Trim();
                    obj.TenNV = txbTenNV.Text.Trim();
                    QLNhanVienBUS _Staff = new QLNhanVienBUS();
                    if (_Staff.CheckID(obj.MaNV.Trim()) == false)
                    {
                        _Staff.SuaNV(obj);
                        LoadNV();
                    }
                    else
                    {
                        MessageBox.Show("Mã nhân viên này chưa tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Sửa bị lỗi: " + exp.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            if (query == "delete")
            {
                try
                {
                    NhanVienDTO obj = new NhanVienDTO();
                    obj.MaNV = txbMaNV.Text.Trim();
                    obj.TenNV = txbTenNV.Text.Trim();
                    QLNhanVienBUS _Staff = new QLNhanVienBUS();
                    if (_Staff.CheckID(obj.MaNV.Trim()) == false)
                    {
                        _Staff.XoaNV(obj);
                        LoadNV();
                    }
                    else
                    {
                        MessageBox.Show("Mã nhân viên này chưa tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Xóa bị lỗi: " + exp.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }
        private void LoadNV()
        {
            QLNhanVienBUS _Staff = new QLNhanVienBUS();
            dtgvNV.DataSource = _Staff.GetData();
            ButtonControl(1);
        }
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            txbMaNV.Text = "";
            txbTenNV.Text = "";
            ButtonControl(2);
            query = "add";
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            txbMaNV.ReadOnly = true;
            ButtonControl(2);
            query = "edit";


        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            ButtonControl(2);
            query = "delete";

        }
        void ButtonControl(int type)
        {
            btnThemNV.Visible = type == 1 ? true : false;
            btnSuaNV.Visible = type == 1 ? true : false;
            btnXoaNV.Visible = type == 1 ? true : false;

            btnCancelNV.Visible = type == 2 ? true : false;
            btnOkNV.Visible = type == 2 ? true : false;
            lbDongYNV.Visible = type == 2 ? true : false;

        }

        private void btnCancelNV_Click(object sender, EventArgs e)
        {
            txbMaNV.ReadOnly = false;
            ButtonControl(1);

        }

        private void btnOkNV_Click(object sender, EventArgs e)
        {
            txbMaNV.ReadOnly = false;
            Execute(query);
        }

        private void dtgvNV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txbMaNV.Text = dtgvNV["clMaNV", index].Value.ToString();
            txbTenNV.Text = dtgvNV["clTenNV", index].Value.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            QLNhanVienBUS _Staff = new QLNhanVienBUS();
            dtgvNV.DataSource = _Staff.TimKiemNV(txbTimKiemNV.Text.Trim());
        }

        private void btnTimNV_Click(object sender, EventArgs e)
        {

        }
    }
}
