using QLCHVTNN.BUS;
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
    public partial class frmPhThuNo : Form
    {
        public frmPhThuNo()
        {
            InitializeComponent();
        }
        private readonly KHACHHANGService kHACHHANGService = new KHACHHANGService();
        private readonly PHIEUTHUNOService pHIEUTHUNOService = new PHIEUTHUNOService();
        private void frmPhThuNo_Load(object sender, EventArgs e)
        {
            LoadKH(kHACHHANGService.GetAll());
            LoadData(pHIEUTHUNOService.GetAll());
        }
        private void LoadKH(List<KHACHHANG> dsKH)
        {
            cmbKhachHang.SelectedIndex = -1;
            cmbKhachHang.DataSource = dsKH;
            cmbKhachHang.ValueMember = "MaKH";
            cmbKhachHang.DisplayMember = "TenKH";
        }
        private void LoadData(List<PHIEUTHUNO> dsData)
        {
            dgvPhThuNo.Rows.Clear();
            foreach (var p in dsData)
            {
                var i = dgvPhThuNo.Rows.Add(p);
                dgvPhThuNo.Rows[i].Cells[0].Value = p.MaPhieu;
                dgvPhThuNo.Rows[i].Cells[1].Value = p.NgayThu;
                dgvPhThuNo.Rows[i].Cells[2].Value = p.MaKH;
                dgvPhThuNo.Rows[i].Cells[3].Value = p.SoTienThu;
                dgvPhThuNo.Rows[i].Cells[4].Value = p.GhiChu;               
            }            
        }

        private void btnTaoPH_Click(object sender, EventArgs e)
        {
            string maPH = txtMaPH.Text.Trim();
            var ngNh = dtpNgLap.Value;
            string khach = cmbKhachHang.SelectedValue.ToString();
            decimal sotien=decimal.Parse(txtSoTien.Text.Trim());
            string ghichu=rtxtGhiChu.Text.Trim();
            if (string.IsNullOrWhiteSpace(maPH))
            {
                MessageBox.Show("Vui lòng nhập mã phiếu.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSoTien.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập số tiền.");
                return;
            }
            if (pHIEUTHUNOService.FindByID(maPH) != null)
            {
                MessageBox.Show("Mã Phiếu đã tồn tại!");
                return;
            }
            PHIEUTHUNO pn = new PHIEUTHUNO
            {
                MaPhieu = maPH,
                NgayThu=ngNh,
                MaKH=khach,
                SoTienThu=sotien,
                GhiChu=ghichu
            };
            pHIEUTHUNOService.Them(pn);
            MessageBox.Show("Tạo phiếu thành công.", "Thông báo");
            LoadData(pHIEUTHUNOService.GetAll());
            ResetForm();
        }

        private void btnXoaPH_Click(object sender, EventArgs e)
        {
            string maPH = txtMaPH.Text;
            string kh = cmbKhachHang.SelectedValue.ToString();
            if (string.IsNullOrWhiteSpace(maPH))
            {
                MessageBox.Show("Bạn chưa chọn phiếu muốn xóa", "Thông báo");
                return;
            }
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa phiếu này?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                pHIEUTHUNOService.Xoa(maPH);
                MessageBox.Show("Xóa phiếu thành công");
                LoadData(pHIEUTHUNOService.GetAll());
                ResetForm();
            }
            else return;
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow slRow = dgvPhThuNo.CurrentRow;
            if (slRow != null)
            {
                string maPH= slRow.Cells[0].Value.ToString();
                var ptn=pHIEUTHUNOService.FindByID(maPH);
                txtMaPH.Text = maPH;
                dtpNgLap.Value = ptn.NgayThu.Value;
                cmbKhachHang.SelectedValue = ptn.MaKH;
                txtSoTien.Text = ptn.SoTienThu.ToString();
                rtxtGhiChu.Text=ptn.GhiChu.ToString();
            }
            else return;
        }
        private void ResetForm()
        {
            txtMaPH.Clear();
            txtSoTien.Clear();
            rtxtGhiChu.Clear();
            cmbKhachHang.SelectedIndex = 0;
        }
        private void btnIN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPH.Text))
            {
                MessageBox.Show("Vui lòng chọn Phiếu Trước khi IN", "Thông Báo");
                return;
            }
            frmReportPTN frm=new frmReportPTN(txtMaPH.Text);
            frm.Show();
        }

        
    }
}
