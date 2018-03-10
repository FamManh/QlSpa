using QuanLySpa.BUS;
using QuanLySpa.DTO;
using QuanLySpa.NhanVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySpa
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
        }
        #region Bien
        static string day = DateTime.Now.ToString("MM/dd/yy");
        static int rowEnterIndex;
        static string TenBang = "THANG3";
        static string MaNhanVien = "ALL";
        static int count = 0;
        static string thangTT = "";

        #endregion
        #region ham
        public void TinhTien()
        {
            lbTienCer.Text = TongTienCer().ToString();
            lbTienMat.Text = TongTienMat().ToString();
            lbTong.Text = (TongTienCer() + TongTienMat()).ToString();
        }
        public double TongTienCer()
        {
            double thanhTien = 0;
            double sc = dtgvTuaNgay.Rows.Count;
            for (int i = 0; i < sc - 1; i++)
            {
                thanhTien += double.Parse(dtgvTuaNgay.Rows[i].Cells["clTienCer"].Value.ToString());
            }


            return thanhTien;
        }
        public double TongTienMat()
        {
            double thanhTien = 0;
            double sc = dtgvTuaNgay.Rows.Count;

            for (int i = 0; i < sc - 1; i++)
            {
                thanhTien += double.Parse(dtgvTuaNgay.Rows[i].Cells["clTienMat"].Value.ToString());
            }


            return thanhTien;
        }
        public string LoadTenBangFromComboBox()
        {
            return TenBang;
        }
        public string GetDay()
        {
            return day;
        }
        public void LoadDataDay()
        {

            QLTuaNgayBUS TuaNgay = new QLTuaNgayBUS();
            dtgvTuaNgay.DataSource = TuaNgay.GetData(LoadTenBangFromComboBox());
            TinhTien();
            TinhTienTT();
        }
        public void LoadThangToComboBox()
        {
            QLTuaNgayBUS _Services = new QLTuaNgayBUS();
            cmbThang.DataSource = _Services.GetThangToComboBox();
            cmbThang.DisplayMember = "TenBang";
            cmbThang.ValueMember = "TenBang";

            cmbThongKeTT.DataSource = _Services.GetThangToComboBox();
            cmbThongKeTT.DisplayMember = "TenBang";
            cmbThongKeTT.ValueMember = "TenBang";
        }
        void LoadData()
        {
            QLThemDichVuBUS _DichVu = new QLThemDichVuBUS();
            day = dtpkNgay.Value.ToString("MM/dd/yy");
            dtgvTuaNgay.DataSource = _DichVu.LocTheoNgay(TenBang, day);
            TinhTien();
            TinhTienTT();
        }
        public void LoadNhanVienToCobobox()
        {
            SpaManagerBUS _NhanVien = new SpaManagerBUS();
            cmbNhanVien.DataSource = _NhanVien.LoadNhanVienToComboBox();
            cmbNhanVien.DisplayMember = "TenNV";
            cmbNhanVien.ValueMember = "MaNV";


           

        }

        public void DataKhiChonNhanVien()
        {
            if (cmbNhanVien.SelectedValue.ToString() == "ALL")
                MaNhanVien = "";
            else
                MaNhanVien = cmbNhanVien.SelectedValue.ToString();

            SpaManagerBUS _Service = new SpaManagerBUS();
            dtgvTuaNgay.DataSource = _Service.LocNhanVien(TenBang, day, MaNhanVien);
            TinhTien();
            TinhTienTT();
        }

        // tab2
        public void LoadDataTab2()
        {
            //if (cmbNhanVien.SelectedValue.ToString() == "ALL")
            //    MaNhanVien = "";
            //else
            //    MaNhanVien = cmbNhanVien.SelectedValue.ToString();
            try
            {
                SpaManagerBUS _Service = new SpaManagerBUS();
                dtgvTongThang.DataSource = _Service.LoadDataTongThang(thangTT);
                TinhTien();
                TinhTienTT();
            }
            catch { }
            

        }

        public void TinhTienTT()
        {
            lbTienCerTT.Text = TongTienCerTT().ToString();
            lbTienMatTT.Text = TongTienMatTT().ToString();
            lbTongTT.Text = (TongTienCerTT() + TongTienMatTT()).ToString();
        }
        public double TongTienCerTT()
        {
            double thanhTien = 0;
            int sc = dtgvTongThang.Rows.Count;
            for (int i = 0; i < sc - 1; i++)
            {
                thanhTien += double.Parse(dtgvTongThang.Rows[i].Cells["clTienCerTT"].Value.ToString());
            }


            return thanhTien;
        }
        public double TongTienMatTT()
        {
            double thanhTien = 0;
            int sc = dtgvTongThang.Rows.Count;

            for (int i = 0; i < sc - 1; i++)
            {
                thanhTien += double.Parse(dtgvTongThang.Rows[i].Cells["clTienMatTT"].Value.ToString());
            }


            return thanhTien;
        }
        #endregion
        #region event
        private void fAdmin_Load(object sender, EventArgs e)
        {
            LoadNhanVienToCobobox();
            LoadDataTab2();
            //LoadData();
            LoadThangToComboBox();
            LoadData();
            TinhTien();
            TinhTienTT();

        }
        private void tạoThángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fTaoThang f = new fTaoThang();
            f.ShowDialog();
            LoadThangToComboBox();
        }
        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLNhanVien f = new QLNhanVien();
            f.ShowDialog();
            LoadNhanVienToCobobox();

        }
        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLDichVu f = new QLDichVu();
            f.ShowDialog();
        }

        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fThemThongTin f = new fThemThongTin();
            f.ShowDialog();
            DataKhiChonNhanVien();
            LoadDataTab2();

            //LoadData();
        }

        private void dtpkNgay_ValueChanged(object sender, EventArgs e)
        {
            day = dtpkNgay.Value.ToString("MM/dd/yy");

            DataKhiChonNhanVien();

            //LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataKhiChonNhanVien();

            //LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ThongKeDTO obj = new ThongKeDTO();
            //obj.STT = rowEnterIndex;
            QLThemDichVuBUS _Service = new QLThemDichVuBUS();
            _Service.XoaTua(TenBang, rowEnterIndex.ToString());
            //LoadDataDay();
            DataKhiChonNhanVien();
            LoadDataTab2();


        }

        private void dtgvTuaNgay_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                int result = 0;
                QLThemDichVuBUS _DichVu = new QLThemDichVuBUS();
                if (_DichVu.IsNumber(dtgvTuaNgay["clSTT", rowIndex].Value.ToString(), ref result))
                    rowEnterIndex = int.Parse(dtgvTuaNgay["clSTT", rowIndex].Value.ToString());
            }catch
            { }
            
        }

        private void cmbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (count > 1)
            {
                TenBang = cmbThang.SelectedValue.ToString();
                LoadData();

            }
            count++;
        }

        private void txbTimKiem_TextChanged(object sender, EventArgs e)
        {
            string id = txbTimKiem.Text.Trim();
            SpaManagerBUS _Service = new SpaManagerBUS();
            dtgvTuaNgay.DataSource = _Service.TimKiemTua(TenBang, day, MaNhanVien, id);
        }

        private void btnTimKiemTua_Click(object sender, EventArgs e)
        {
            string id = txbTimKiem.Text.Trim();
            SpaManagerBUS _Service = new SpaManagerBUS();
            dtgvTuaNgay.DataSource = _Service.TimKiemTua(TenBang, day, MaNhanVien, id);
        }

        private void cmbNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataKhiChonNhanVien();
        }

        private void xóaThángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fXoaThang f = new fXoaThang();
            f.ShowDialog();
            TenBang = "THANG3";
            DataKhiChonNhanVien();
            LoadThangToComboBox();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                ExportExcel excel = new ExportExcel();
                DataTable dt = (DataTable)dtgvTongThang.DataSource;
                excel.Export(dt, "DanhSach", "Danh sách thang 2");
            }
            catch { }
            
        }

        private void cmbThongKeTT_SelectedIndexChanged(object sender, EventArgs e)
        {
            thangTT = cmbThongKeTT.SelectedValue.ToString();
            LoadDataTab2();
        }

        private void btnExportNgay_Click(object sender, EventArgs e)
        {
            try
            {
                ExportExcel excel = new ExportExcel();
                DataTable dt = (DataTable)dtgvTuaNgay.DataSource;
                excel.ExportNgay(dt, "DanhSach", "Danh sách thang 2");
            }
            catch { }
        }
    }
}
