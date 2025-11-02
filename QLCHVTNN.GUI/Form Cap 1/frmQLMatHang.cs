using QLCHVTNN.BUS;
using QLCHVTNN.DAL.Model;
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
    public partial class frmQLMatHang : Form
    {
        private readonly MATHANGService mhService = new MATHANGService();
        private readonly LOAIHANGService lhService = new LOAIHANGService();
        private readonly NHACUNGCAPService nccService = new NHACUNGCAPService();

        public frmQLMatHang()
        {
            InitializeComponent();
        }

        private void frmQLMatHang_Load(object sender, EventArgs e)
        {
            LoadData();
            FillLHCmb();
            FillNCCCmb();
        }

        private void LoadData()
        {
            dgvMatHang.Rows.Clear();
            var matHangs = mhService.GetAll();
            foreach (var mh in matHangs)
            {
                int idx = dgvMatHang.Rows.Add();
                dgvMatHang.Rows[idx].Cells[0].Value = mh.MaMH;
                dgvMatHang.Rows[idx].Cells[1].Value = mh.TenMH;
                dgvMatHang.Rows[idx].Cells[2].Value = mh.LOAIHANG?.TenLoai ?? "-";
                dgvMatHang.Rows[idx].Cells[3].Value = mh.NHACUNGCAP?.TenNCC ?? "-";
                dgvMatHang.Rows[idx].Cells[4].Value = mh.DonViTinh;
                dgvMatHang.Rows[idx].Cells[5].Value = mh.GiaBanTienMat;
                dgvMatHang.Rows[idx].Cells[6].Value = mh.GiaBanGhiNo;
                dgvMatHang.Rows[idx].Cells[7].Value = mh.SoLuongTon;
            }
        }

        private void FillLHCmb()
        {
            var loaiHangs = lhService.GetAllLOAIHANGs();
            cmbLoaiHang.DataSource = loaiHangs;
            cmbLoaiHang.DisplayMember = "TenLoai";
            cmbLoaiHang.ValueMember = "MaLoai";
            if (cmbLoaiHang.Items.Count > 0)
                cmbLoaiHang.SelectedIndex = 0;
        }
        private void FillNCCCmb()
        {
            var nccs = nccService.GetAll();
            cmbNCC.DataSource = nccs;
            cmbNCC.DisplayMember = "TenNCC";
            cmbNCC.ValueMember = "MaNCC";
            if (cmbNCC.Items.Count > 0)
                cmbNCC.SelectedIndex = 0;
        }

        private void dgvMatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMatHang.Rows[e.RowIndex];
                txtMaMH.Text = row.Cells[0].Value.ToString();
                txtTenMH.Text = row.Cells[1].Value.ToString();
                cmbLoaiHang.Text = row.Cells[2].Value.ToString();
                cmbNCC.Text = row.Cells[3].Value.ToString();
                txtDVTinh.Text = row.Cells[4].Value?.ToString() ?? "";
                txtGiaTienMat.Text = row.Cells[5].Value.ToString();
                txtGiaGhiNo.Text = row.Cells[6].Value.ToString();
                txtSLTon.Text = row.Cells[7].Value.ToString();
            }
        }

        private void ClearForm()
        {
            txtMaMH.Clear();
            txtTenMH.Clear();
            if (cmbLoaiHang.Items.Count > 0)
                cmbLoaiHang.SelectedIndex = 0;
            if (cmbNCC.Items.Count > 0)
                cmbNCC.SelectedIndex = 0;
            txtDVTinh.Clear();
            txtGiaTienMat.Clear();
            txtGiaGhiNo.Clear();
            txtSLTon.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaMH.Text) ||
                    string.IsNullOrWhiteSpace(txtTenMH.Text) ||
                    string.IsNullOrWhiteSpace(txtGiaGhiNo.Text) ||
                    string.IsNullOrWhiteSpace(txtGiaTienMat.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ tên và giá của mặt hàng.", "Lỗi");
                    return;
                }
                if (mhService.FindByID(txtMaMH.Text) != null)
                {
                    MessageBox.Show("Mã mặt hàng đã tồn tại. Vui lòng sử dụng mã khác.", "Lỗi");
                    return;
                }
                if (!decimal.TryParse(txtGiaTienMat.Text, out decimal giaTienMat) ||
                    !decimal.TryParse(txtGiaGhiNo.Text, out decimal giaGhiNo))
                {
                    MessageBox.Show("Giá bán phải là số hợp lệ.", "Lỗi");
                    return;
                }
                if (!string.IsNullOrWhiteSpace(txtSLTon.Text) && !int.TryParse(txtSLTon.Text, out int soLuongTon))
                {
                    MessageBox.Show("Số lượng tồn phải là số nguyên.", "Lỗi");
                    return;
                }
                MATHANG mathang = new MATHANG
                {
                    MaMH = txtMaMH.Text,
                    TenMH = txtTenMH.Text,
                    MaLoai = cmbLoaiHang.SelectedValue.ToString(),
                    MaNCC = cmbNCC.SelectedValue.ToString(),
                    DonViTinh = txtDVTinh.Text ?? "-",
                    GiaBanTienMat = decimal.Parse(txtGiaTienMat.Text),
                    GiaBanGhiNo = decimal.Parse(txtGiaGhiNo.Text),
                    SoLuongTon = string.IsNullOrWhiteSpace(txtSLTon.Text) ? 0 : int.Parse(txtSLTon.Text)
                };
                mhService.AddMATHANG(mathang);
                LoadData();
                ClearForm();
                MessageBox.Show("Thêm mặt hàng thành công!", "Thông Báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm mặt hàng: " + ex.Message, "Lỗi");

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaMH.Text))
                {
                    MessageBox.Show("Vui lòng chọn mặt hàng cần sửa.", "Lỗi");
                    return;
                }
                if (mhService.FindByID(txtMaMH.Text) == null)
                {
                    MessageBox.Show("Mặt hàng không tồn tại.", "Lỗi");
                    return;
                }
                if (!decimal.TryParse(txtGiaTienMat.Text, out decimal giaTienMat) ||
                    !decimal.TryParse(txtGiaGhiNo.Text, out decimal giaGhiNo))
                {
                    MessageBox.Show("Giá bán phải là số hợp lệ.", "Lỗi");
                    return;
                }
                if (!string.IsNullOrWhiteSpace(txtSLTon.Text) && !int.TryParse(txtSLTon.Text, out int soLuongTon))
                {
                    MessageBox.Show("Số lượng tồn phải là số nguyên.", "Lỗi");
                    return;
                }
                MATHANG mathang = new MATHANG
                {
                    MaMH = txtMaMH.Text,
                    TenMH = txtTenMH.Text,
                    MaLoai = cmbLoaiHang.SelectedValue.ToString(),
                    MaNCC = cmbNCC.SelectedValue.ToString(),
                    DonViTinh = txtDVTinh.Text ?? "",
                    GiaBanTienMat = giaTienMat,
                    GiaBanGhiNo = giaGhiNo,
                    SoLuongTon = string.IsNullOrWhiteSpace(txtSLTon.Text) ? 0 : int.Parse(txtSLTon.Text)
                };
                mhService.UpdateMATHANG(mathang);
                LoadData();
                ClearForm();
                MessageBox.Show("Cập nhật mặt hàng thành công!", "Thông Báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật mặt hàng: " + ex.Message, "Lỗi");
            }
        }

        
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaMH.Text))
            {
                MessageBox.Show("Vui lòng chọn mặt hàng cần xóa.", "Lỗi");
                return;
            }
            if (mhService.FindByID(txtMaMH.Text) == null)
            {
                MessageBox.Show("Mặt hàng không tồn tại.", "Lỗi");
                return;
            }
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa mặt hàng này?", 
                                                "Xác Nhận Xóa", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    mhService.DeleteMATHANG(txtMaMH.Text);
                    LoadData();
                    ClearForm();
                    MessageBox.Show("Xóa mặt hàng thành công!", "Thông Báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa mặt hàng: " + ex.Message, "Lỗi");
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(keyword))
            {
                LoadData();
                return;
            }
            var filteredMHs = mhService.SearchMATHANGByName(keyword);
            dgvMatHang.Rows.Clear();
            foreach (var mh in filteredMHs)
            {
                int idx = dgvMatHang.Rows.Add();
                dgvMatHang.Rows[idx].Cells[0].Value = mh.MaMH;
                dgvMatHang.Rows[idx].Cells[1].Value = mh.TenMH;
                dgvMatHang.Rows[idx].Cells[2].Value = mh.LOAIHANG.TenLoai;
                dgvMatHang.Rows[idx].Cells[3].Value = mh.NHACUNGCAP.TenNCC;
                dgvMatHang.Rows[idx].Cells[4].Value = mh.DonViTinh;
                dgvMatHang.Rows[idx].Cells[5].Value = mh.GiaBanTienMat;
                dgvMatHang.Rows[idx].Cells[6].Value = mh.GiaBanGhiNo;
                dgvMatHang.Rows[idx].Cells[7].Value = mh.SoLuongTon;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
