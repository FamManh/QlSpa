using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLySpa.BUS;
using QuanLySpa.DTO;

namespace QuanLySpa.NhanVien
{
    public partial class QLDichVu : Form
    {
        public QLDichVu()
        {
            InitializeComponent();
        }

        string query = "";

        private void btnCancelDV_Click(object sender, EventArgs e)
        {
            txbMaDV.ReadOnly = false;
            ButtonControl(1);
        }

        private void btnOkDV_Click(object sender, EventArgs e)
        {
            txbMaDV.ReadOnly = false;
            Execute(query);
            ButtonControl(1);

        }

        private void btnXoaDV_Click(object sender, EventArgs e)
        {
            ButtonControl(2);
            query = "delete";

        }

        private void btnSuaDV_Click(object sender, EventArgs e)
        {
            txbMaDV.ReadOnly = true;
            ButtonControl(2);
            query = "edit";

        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            txbMaDV.Text = "";
            txbTenDV.Text = "";
            txbGiaDV.Text = "";
            txbThoiGianDV.Text = "";
            ButtonControl(2);
            query = "add";

        }

        private void QLDichVu_Load(object sender, EventArgs e)
        {
            LoadDV();
        }
        void Execute(string query)
        {
            fThemThongTin f = new fThemThongTin();
            if (query == "add")
            {
                try
                {
                    DichVuDTO obj = new DichVuDTO();
                    obj.MaDV = txbMaDV.Text.Trim();
                    obj.TenDV = txbTenDV.Text.Trim();
                    obj.ThoiGian = int.Parse(txbThoiGianDV.Text.Trim());
                    obj.GiaDV = int.Parse(txbGiaDV.Text.Trim());

                    QLDichVuBUS _DichVu = new QLDichVuBUS();
                    if (_DichVu.CheckID(obj.MaDV.Trim()) == true)
                    {
                        _DichVu.ThemDV(obj);
                        LoadDV();
                        f.LoadDVToComboBox();

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
                    DichVuDTO obj = new DichVuDTO();
                    obj.MaDV = txbMaDV.Text.Trim();
                    obj.TenDV = txbTenDV.Text.Trim();
                    obj.GiaDV = int.Parse(txbGiaDV.Text.Trim());

                    QLDichVuBUS _DichVu = new QLDichVuBUS();
                    if (_DichVu.CheckID(obj.MaDV.Trim()) == false)
                    {
                        _DichVu.SuaDV(obj);
                        LoadDV();
                        f.LoadDVToComboBox();

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
                    DichVuDTO obj = new DichVuDTO();
                    obj.MaDV = txbMaDV.Text.Trim();
                    QLDichVuBUS _DichVu = new QLDichVuBUS();
                    if (_DichVu.CheckID(obj.MaDV.Trim()) == false)
                    {
                        _DichVu.XoaDV(obj);
                        LoadDV();
                        f.LoadDVToComboBox();

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
        private void LoadDV()
        {
            QLDichVuBUS _DichVu = new QLDichVuBUS();
            dtgvDV.DataSource = _DichVu.GetData();
            ButtonControl(1);
        }
        void ButtonControl(int type)
        {
            btnThemDV.Visible = type == 1 ? true : false;
            btnSuaDV.Visible = type == 1 ? true : false;
            btnXoaDV.Visible = type == 1 ? true : false;

            btnCancelDV.Visible = type == 2 ? true : false;
            btnOkDV.Visible = type == 2 ? true : false;
            lbDongYDV.Visible = type == 2 ? true : false;

        }

        private void dtgvDV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txbMaDV.Text = dtgvDV["clMaDV", index].Value.ToString();
            txbTenDV.Text = dtgvDV["clTenDV", index].Value.ToString();
            txbThoiGianDV.Text = dtgvDV["clThoiGianDV", index].Value.ToString();
            txbGiaDV.Text = dtgvDV["clGiaDV", index].Value.ToString();


        }

        private void txbTimKiemDV_TextChanged(object sender, EventArgs e)
        {
            QLDichVuBUS _DichVu = new QLDichVuBUS();
            dtgvDV.DataSource = _DichVu.TimKiemDV(txbTimKiemDV.Text.Trim());
        }

        private void btnTimDV_Click(object sender, EventArgs e)
        {
            QLDichVuBUS _DichVu = new QLDichVuBUS();
            dtgvDV.DataSource = _DichVu.TimKiemDV(txbTimKiemDV.Text.Trim());
        }

        private void txbThoiGianDV_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPress(sender, e);
        }

        private void txbGiaDV_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPress(sender, e);
        }
        public void keyPress(object sender, KeyPressEventArgs e)
        {

            
            if (!Char.IsDigit(e.KeyChar)  && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbMaDV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetterOrDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }
    }
}
