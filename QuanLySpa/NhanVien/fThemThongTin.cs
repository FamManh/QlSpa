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
using QuanLySpa.BUS;

namespace QuanLySpa.NhanVien
{
    public partial class fThemThongTin : Form
    {
        public fThemThongTin()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            fThemThongTin f = new fThemThongTin();
            f.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            try
            {
                fAdmin f = new fAdmin();
                ThongKeDTO obj = new ThongKeDTO();
                obj.TenBang = f.LoadTenBangFromComboBox();
                obj.Ngay = f.GetDay();
                obj.MaNV = cmbTenNV.SelectedValue.ToString();
                obj.MaDV = cmbTenDV.Text.ToString();

                obj.TienCer = int.Parse(txbCertificat.Text.Trim());
                obj.TienMat = int.Parse(txbTienMat.Text.Trim());

                QLThemDichVuBUS _Service = new QLThemDichVuBUS();
                obj.ThoiGianDV = _Service.GetThoiGian(cmbTenDV.Text.ToString());
                _Service.ThemTua(obj);
                //f.DataKhiChonNhanVien();

            }
            catch (Exception exp)
            {
                MessageBox.Show("Thêm bị lỗi: " + exp.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void LoadDVToComboBox()
        {
            QLDichVuBUS _Services = new QLDichVuBUS();
            cmbTenDV.DataSource = _Services.GetData();
            cmbTenDV.DisplayMember = "MaDV";
            cmbTenDV.ValueMember = "GiaDV";

        }
        public void LoadNVToComboBox()
        {
            QLNhanVienBUS _Staff = new QLNhanVienBUS();
            cmbTenNV.DataSource = _Staff.GetData();
            cmbTenNV.DisplayMember = "TenNV";
            cmbTenNV.ValueMember = "MaNV";

        }
        private void fThemThongTin_Load(object sender, EventArgs e)
        {
            LoadDVToComboBox();
            LoadNVToComboBox();
        }



        private void cmbTenDV_SelectedValueChanged(object sender, EventArgs e)
        {


        }

        private void cmbTenDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataThemDL();
        }


        private void nmdGiamGia_KeyUp(object sender, KeyEventArgs e)
        {
            LoadDataThemDL();
        }
        private void rdbtnCertificat_CheckedChanged(object sender, EventArgs e)
        {
            LoadDataThemDL();
        }
        public void LoadDataThemDL()
        {
            QLDichVuBUS _Service = new QLDichVuBUS();
            QLThemDichVuBUS _DichVu = new QLThemDichVuBUS();
            string strTien = "";
            strTien = cmbTenDV.SelectedValue.ToString();
            int giamGia = int.Parse(nmdGiamGia.Value.ToString());
            int intTien = 0;

            if (_DichVu.IsNumber(strTien, ref intTien) == true)
            {
                if (giamGia != 0)
                {
                    if (rdbtnCertificat.Checked == true)
                    {
                        txbCertificat.Text = (intTien / 100 * (100 - giamGia)).ToString();
                        txbTienMat.Text = 0.ToString();

                    }
                    else
                    {
                        txbTienMat.Text = (intTien / 100 * (100 - giamGia)).ToString();
                        txbCertificat.Text = 0.ToString();
                    }
                }
                else
                {
                    if (rdbtnCertificat.Checked == true)
                    {
                        txbCertificat.Text = intTien.ToString();
                        txbTienMat.Text = 0.ToString();

                    }
                    else
                    {
                        txbTienMat.Text = intTien.ToString();
                        txbCertificat.Text = 0.ToString();
                    }
                }
            }
            else
            {
                txbTienMat.Text = 0.ToString();
                txbCertificat.Text = 0.ToString();

            }
        }

        private void txbTienMat_KeyPress(object sender, KeyPressEventArgs e)
        {

            keyPress(sender, e);
        }

        private void txbCertificat_KeyPress(object sender, KeyPressEventArgs e)
        {

            keyPress(sender, e);
        }
        public void keyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
