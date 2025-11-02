using QLCHVTNN.BUS;
using QLCHVTNN.BUS.Service;
using QLCHVTNN.DAL.Model;
using QLCHVTNN.GUI;
using QLCHVTNN.GUI.Form_Cap_2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHVTNN.GUI
{
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }
        private readonly KHACHHANGService kHACHHANGService=new KHACHHANGService();
        private readonly MATHANGService mATHANGService=new MATHANGService();
        private readonly HOADONBANService hOADONBANService=new HOADONBANService();
        private readonly CHITIETHOADONBANService cHITIETHOADONBANService=new CHITIETHOADONBANService();

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            LoadKH(kHACHHANGService.GetAll());
            LoadMH(mATHANGService.GetAll());

        }
        private void LoadKH(List<KHACHHANG> dsKH)
        {
            cmbKhachHang.SelectedIndex = -1;
            cmbKhachHang.DataSource = dsKH;
            cmbKhachHang.ValueMember = "MaKH";
            cmbKhachHang.DisplayMember = "TenKH";
        }
        private void LoadMH(List<MATHANG> dsMH)
        {
            cmbMatHang.SelectedIndex = -1;
            cmbMatHang.DataSource = dsMH;
            cmbMatHang.ValueMember = "MaMH";
            cmbMatHang.DisplayMember = "TenMH";
        }
        private void LoadData(List<CHITIETHOADONBAN> dsData)
        {
            decimal tongTien = 0;
            dgvHoaDon.Rows.Clear();
            foreach (var p in dsData)
            {
                var i = dgvHoaDon.Rows.Add(p);
                dgvHoaDon.Rows[i].Cells[0].Value = p.MaHD;
                dgvHoaDon.Rows[i].Cells[1].Value = p.MaMH;
                dgvHoaDon.Rows[i].Cells[2].Value = p.MATHANG.TenMH;
                dgvHoaDon.Rows[i].Cells[3].Value = p.SoLuong;
                dgvHoaDon.Rows[i].Cells[4].Value = p.DonGia;
                dgvHoaDon.Rows[i].Cells[5].Value = p.ThanhTien;
                tongTien += (decimal)p.ThanhTien;
            }
            txtTongTien.Text = tongTien.ToString("N0");
        }

        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            string maHD = txtMaHD.Text.Trim();
            var ngNh = dtpNgLap.Value;
            string khach = cmbKhachHang.SelectedValue.ToString();            
            string ltt;
            if (chkGhiNo.Checked)
                ltt = "Ghi nợ";
            else ltt = "Trả liền";
            if (string.IsNullOrWhiteSpace(maHD))
            {
                MessageBox.Show("Vui lòng nhập mã phiếu.");
                return;
            }
            if (hOADONBANService.FindByID(maHD) != null)
            {
                MessageBox.Show("Mã Phiếu đã tồn tại!");
                return;
            }
            HOADONBAN pn = new HOADONBAN
            {
                MaHD = maHD,
                NgayBan = ngNh,
                MaKH = khach,
                LoaiThanhToan=ltt,
                TongTien = 0,
                DaThanhToan=null,
                GhiChu=null
            };
            hOADONBANService.Them(pn);
            MessageBox.Show("Tạo phiếu thành công, mời bạn thêm chi tiết", "Thông báo");
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            string maHD = txtMaHD.Text;
            string mh = cmbMatHang.SelectedValue.ToString();
            var hh=mATHANGService.FindByID(mh);
            int sl = int.Parse(txtSoLuong.Text.Trim());
            decimal dg;
            if (chkGhiNo.Checked)
                dg = hh.GiaBanGhiNo;
            else dg = hh.GiaBanTienMat;
            if (string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin chi tiết!");
                return;
            }
            if (hOADONBANService.FindByID(maHD) == null)
            {
                MessageBox.Show("Hóa đơn chưa tồn tại, vui lòng tạo hóa đơn trước khi thêm chi tiết!");
                return;
            }
            CHITIETHOADONBAN hd = new CHITIETHOADONBAN
            {
                MaHD = maHD,
                MaMH = mh,
                SoLuong = sl,
                DonGia = dg,
                ThanhTien = sl * dg
            };
            cHITIETHOADONBANService.ThemSua(hd);
            MessageBox.Show("Thêm/Sửa thông tin thành công");
            LoadData(cHITIETHOADONBANService.FindByID(maHD));
            ResetForm();
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            string maHD = txtMaHD.Text;
            string mh = cmbMatHang.SelectedValue.ToString();
            if (string.IsNullOrWhiteSpace(maHD) || string.IsNullOrWhiteSpace(mh))
            {
                MessageBox.Show("Bạn chưa chọn chi tiết muốn xóa", "Thông báo");
                return;
            }
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa chi tiết này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                cHITIETHOADONBANService.Xoa(maHD, mh);
                MessageBox.Show("Xóa chi tiết thành công");
                LoadData(cHITIETHOADONBANService.FindByID(maHD));
                ResetForm();
            }
            else return;
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow slRow = dgvHoaDon.CurrentRow;
            if (slRow != null)
            {
                txtMaHD.Text = slRow.Cells[0].Value.ToString();
                cmbMatHang.SelectedValue = slRow.Cells[1].Value;
                txtSoLuong.Text = slRow.Cells[3].Value.ToString();
                
            }
            else return;
        }
        private void ResetForm()
        {
            txtSoLuong.Clear();
            cmbMatHang.SelectedIndex = 0;
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            frmReportHD frm = new frmReportHD(txtMaHD.Text);
            frm.Show();
        }

        private void cmbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string khach = cmbKhachHang.SelectedValue.ToString(); 
            if (khach=="VL001")
                this.chkGhiNo.Enabled = false;
            else this.chkGhiNo.Enabled = true;
        }
    }
}
