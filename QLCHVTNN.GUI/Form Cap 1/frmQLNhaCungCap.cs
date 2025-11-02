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
    public partial class frmQLNhaCungCap : Form
    {
        private readonly NHACUNGCAPService nHACUNGCAPService = new NHACUNGCAPService();
        public frmQLNhaCungCap()
        {
            InitializeComponent();
        }

        private void frmQLNhaCungCap_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var nccList = nHACUNGCAPService.GetAll();
            dgvNCC.Rows.Clear();
            foreach (var ncc in nccList)
            {
                dgvNCC.Rows.Add(ncc.MaNCC, ncc.TenNCC, ncc.DiaChi, ncc.SDT);
            }
        }

        private void ClearForm()
        {
            txtTenNCC.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaNCC.Text) ||
                    string.IsNullOrWhiteSpace(txtTenNCC.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ mã và tên nhà cung cấp.");
                    return;
                }

                if (nHACUNGCAPService.FindByID(txtMaNCC.Text) != null)
                {
                    MessageBox.Show("Mã nhà cung cấp đã tồn tại.\nVui lòng sử dụng mã khác.");
                    return;
                }

                var newNCC = new NHACUNGCAP
                {
                    MaNCC = txtMaNCC.Text,
                    TenNCC = txtTenNCC.Text,
                    DiaChi = txtDiaChi.Text,
                    SDT = txtSDT.Text
                };
                nHACUNGCAPService.AddNCC(newNCC);
                LoadData();
                ClearForm();
                MessageBox.Show("Thêm nhà cung cấp thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm nhà cung cấp: " + ex.Message);

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (nHACUNGCAPService.FindByID(txtMaNCC.Text) == null)
                {
                    MessageBox.Show("Nhà cung cấp không tồn tại.");
                    return;
                }

                if (string.IsNullOrEmpty(txtMaNCC.Text))
                {
                    MessageBox.Show("Vui lòng chọn nhà cung cấp để sửa.", "Lỗi");
                    return;
                }

                var updateNCC = new NHACUNGCAP
                {
                    MaNCC = txtMaNCC.Text,
                    TenNCC = txtTenNCC.Text,
                    DiaChi = txtDiaChi.Text,
                    SDT = txtSDT.Text
                };

                nHACUNGCAPService.UpdateNCC(updateNCC);
                LoadData();
                ClearForm();
                MessageBox.Show("Cập nhật nhà cung cấp thành công!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật nhà cung cấp: " + ex.Message);
            }

        }

        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dgvNCC.Rows[e.RowIndex];
                txtMaNCC.Text = selectedRow.Cells[0].Value?.ToString() ?? "";
                txtTenNCC.Text = selectedRow.Cells[1].Value?.ToString() ?? "";
                txtDiaChi.Text = selectedRow.Cells[2].Value?.ToString() ?? "";
                txtSDT.Text = selectedRow.Cells[3].Value?.ToString() ?? "";
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaNCC.Text))
                {
                    MessageBox.Show("Vui lòng chọn nhà cung cấp để xóa.", "Lỗi");
                    return;
                }
                if (nHACUNGCAPService.FindByID(txtMaNCC.Text) == null)
                {
                    MessageBox.Show("Nhà cung cấp không tồn tại.", "Lỗi");
                    return;
                }
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp này?",
                                            "Xác Nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    nHACUNGCAPService.DeleteNCC(txtMaNCC.Text);
                    LoadData();
                    ClearForm();
                    MessageBox.Show("Xóa nhà cung cấp thành công!", "Thông Báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa nhà cung cấp: " + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim().ToLower();
            var filteredNCCs = nHACUNGCAPService.SearchNCCs(keyword);
            dgvNCC.Rows.Clear();
            foreach (var ncc in filteredNCCs)
            {
                dgvNCC.Rows.Add(ncc.MaNCC, ncc.TenNCC, ncc.DiaChi, ncc.SDT);
            }
        }
    }
}
