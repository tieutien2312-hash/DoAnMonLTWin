using QLCHVTNN.BUS;
using QLCHVTNN.BUS.Service;
using QLCHVTNN.DAL.Model;
using QLCHVTNN.GUI.FormCap2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHVTNN.GUI
{
    public partial class frmPhNhapHang : Form
    {
         
        public frmPhNhapHang()
        {
            InitializeComponent();
        }
        private readonly NHACUNGCAPService nHACUNGCAPService = new NHACUNGCAPService();
        private readonly MATHANGService mATHANGService = new MATHANGService();
        private readonly PHIEUNHAPService pHIEUNHAPService = new PHIEUNHAPService();
        private readonly CHITIETPHIEUNHAPService cHITIETPHIEUNHAPService= new CHITIETPHIEUNHAPService();
        
        //Load data
        private void frmPhNhapHang_Load(object sender, EventArgs e)
        {
            LoadNCC(nHACUNGCAPService.GetAll());
            dgvPhieuNhap.Rows.Clear();
        }
        private void LoadNCC(List<NHACUNGCAP> dsNCC)
        {         
            cmbDSNCC.SelectedIndex = -1;
            cmbDSNCC.DataSource = dsNCC;
            cmbDSNCC.ValueMember = "MaNCC";
            cmbDSNCC.DisplayMember = "TenNCC";
        }
        private void LoadMH(List<MATHANG> dsMH)
        {            
            cmbMatHang.SelectedIndex = -1;
            cmbMatHang.DataSource = dsMH;
            cmbMatHang.ValueMember = "MaMH";
            cmbMatHang.DisplayMember = "TenMH";
        }
        private void LoadData(List<CHITIETPHIEUNHAP> dsData)
        {
            decimal tongTien = 0;
            dgvPhieuNhap.Rows.Clear();
            foreach (var p in dsData) 
            {
                var i=dgvPhieuNhap.Rows.Add(p);
                dgvPhieuNhap.Rows[i].Cells[0].Value=p.MaPN;
                dgvPhieuNhap.Rows[i].Cells[1].Value = p.MaMH;
                dgvPhieuNhap.Rows[i].Cells[2].Value = p.MATHANG.TenMH;
                dgvPhieuNhap.Rows[i].Cells[3].Value = p.SoLuong;
                dgvPhieuNhap.Rows[i].Cells[4].Value = p.DonGiaNhap;
                dgvPhieuNhap.Rows[i].Cells[5].Value = p.ThanhTien;
                tongTien += (decimal)p.ThanhTien;
            }
            txtTongTien.Text= tongTien.ToString("N0");
        }
        private void cmbDSNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nCC = cmbDSNCC.SelectedValue.ToString();
            if (string.IsNullOrEmpty(nCC))
            {
                return;
            }
            LoadMH(mATHANGService.DSByID(nCC));
        }

        // Tạo phiếu nhập
        private void btnTaoPhieu_Click(object sender, EventArgs e)
        {
            string maPN=txtMaPH.Text.Trim();
            var ngNh= dtpNgNhap.Value;
            string nCC=cmbDSNCC.SelectedValue.ToString();
            if (string.IsNullOrWhiteSpace(maPN))
            {
                MessageBox.Show("Vui lòng nhập mã phiếu.");
                return;
            }
            if (pHIEUNHAPService.FindByID(maPN)!=null)
            {
                MessageBox.Show("Mã Phiếu đã tồn tại!");
                return;
            }
            PHIEUNHAP pn=new PHIEUNHAP
            {
                MaPN=maPN,
                NgayNhap=ngNh,
                MaNCC=nCC,
                TongTienNhap=0
            };
            pHIEUNHAPService.Them(pn);
            MessageBox.Show("Tạo phiếu thành công, mời bạn thêm chi tiết", "Thông báo");

        }
        //Thêm Sửa
        private void btnThemCT_Click(object sender, EventArgs e)
        {
            string maPh=txtMaPH.Text;
            string mh=cmbMatHang.SelectedValue.ToString();
            int sl=int.Parse(txtSoLuong.Text.Trim());
            decimal gn= decimal.Parse(txtGiaNhap.Text.Trim());
            
            if (string.IsNullOrWhiteSpace(txtSoLuong.Text) || string.IsNullOrWhiteSpace(txtGiaNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin chi tiết!");
                return;
            }
            
            CHITIETPHIEUNHAP pn = new CHITIETPHIEUNHAP
            {
                MaPN = maPh,
                MaMH = mh,
                SoLuong = sl,
                DonGiaNhap = gn,
                ThanhTien= sl*gn
            };
            cHITIETPHIEUNHAPService.ThemSua(pn);
            MessageBox.Show("Thêm/Sửa thông tin thành công");
            LoadData(cHITIETPHIEUNHAPService.FindByID(maPh));
            ResetForm();
        }
        private void ResetForm()
        {
            txtGiaNhap.Clear();
            txtSoLuong.Clear();
            cmbMatHang.SelectedIndex = 0;
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            string maPh = txtMaPH.Text;
            string mh = cmbMatHang.SelectedValue.ToString();
            if (string.IsNullOrWhiteSpace(maPh) || string.IsNullOrWhiteSpace(mh))
            {
                MessageBox.Show("Bạn chưa chọn chi tiết muốn xóa","Thông báo");
                return;
            }
            DialogResult dr=MessageBox.Show("Bạn chắc chắn muốn xóa chi tiết này?","Xác nhận xóa",MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                cHITIETPHIEUNHAPService.Xoa(maPh, mh);
                MessageBox.Show("Xóa chi tiết thành công");
                LoadData(cHITIETPHIEUNHAPService.FindByID(maPh));
                ResetForm();
            }
            else return;
        }
        private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow slRow=dgvPhieuNhap.CurrentRow;
            if (slRow != null)
            {
                txtMaPH.Text = slRow.Cells[0].Value.ToString();
                cmbMatHang.SelectedValue=slRow.Cells[1].Value;
                txtSoLuong.Text=slRow.Cells[3].Value.ToString();
                txtGiaNhap.Text=slRow.Cells[4].Value.ToString();
            }
            else return;
        }

        private void btnInPhieu_Click(object sender, EventArgs e)
        {
            frmReportPhNhap frmINPhieuNhap = new frmReportPhNhap(txtMaPH.Text);
            frmINPhieuNhap.Show();
        }
    }
}
