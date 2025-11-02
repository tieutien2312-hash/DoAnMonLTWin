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
    public partial class frmQLKhachHang : Form
    {
        private readonly KHACHHANGService KHACHHANGService = new KHACHHANGService();
        public frmQLKhachHang()
        {
            InitializeComponent();
        }

        private void frmQLKhachHang_Load(object sender, EventArgs e)
        {
            LoadData(); 
        }

        private void LoadData()
        {
            var khachHangs = KHACHHANGService.GetAll();
            dgvKhachHang.Rows.Clear();
            foreach (var kh in khachHangs)
            {
                int idx = dgvKhachHang.Rows.Add();
                dgvKhachHang.Rows[idx].Cells[0].Value = kh.MaKH;
                dgvKhachHang.Rows[idx].Cells[1].Value = kh.TenKH;
                dgvKhachHang.Rows[idx].Cells[2].Value = kh.DiaChi;
                dgvKhachHang.Rows[idx].Cells[3].Value = kh.SDT;
                dgvKhachHang.Rows[idx].Cells[4].Value = kh.TongNo;

            }
        }

        private void ClearForm()
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtTimKiem.Clear();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells[0].Value?.ToString() ?? "";
                txtTenKH.Text = row.Cells[1].Value?.ToString() ?? "";
                txtDiaChi.Text = row.Cells[2].Value?.ToString() ?? "";
                txtSDT.Text = row.Cells[3].Value?.ToString() ?? "";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaKH.Text) ||
                    string.IsNullOrEmpty(txtTenKH.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ mã và tên khách hàng.", "Lỗi");
                    return;
                }

                if (KHACHHANGService.FindByID(txtMaKH.Text) != null)
                {
                    MessageBox.Show("Mã khách hàng đã tồn tại.\nVui lòng nhập mã khác để thêm mới.", "Lỗi");
                    return;
                }
                KHACHHANG newKH = new KHACHHANG
                {
                    MaKH = txtMaKH.Text,
                    TenKH = txtTenKH.Text,
                    DiaChi = txtDiaChi.Text,
                    SDT = txtSDT.Text,
                    TongNo = 0
                };

                KHACHHANGService.AddKHACHHANG(newKH);
                MessageBox.Show("Thêm khách hàng thành công.", "Thông Báo");
                LoadData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm khách hàng: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaKH.Text))
                {
                    MessageBox.Show("Vui lòng chọn khách hàng để sửa.", "Lỗi");
                    return;
                }

                if (KHACHHANGService.FindByID(txtMaKH.Text) == null)
                {
                    MessageBox.Show("Khách hàng không tồn tại.", "Lỗi");
                    return;
                }
                KHACHHANG updatedKH = new KHACHHANG
                {
                    MaKH = txtMaKH.Text,
                    TenKH = txtTenKH.Text,
                    DiaChi = txtDiaChi.Text,
                    SDT = txtSDT.Text,
                    TongNo = KHACHHANGService.FindByID(txtMaKH.Text).TongNo
                };
                KHACHHANGService.UpdateKHACHHANG(updatedKH);
                MessageBox.Show("Cập nhật khách hàng thành công.", "Thông Báo");
                LoadData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật khách hàng: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMaKH.Text))
                {
                    MessageBox.Show("Vui lòng chọn khách hàng để xóa.", "Lỗi");
                    return;
                }

                if (KHACHHANGService.FindByID(txtMaKH.Text) == null)
                {
                    MessageBox.Show("Khách hàng không tồn tại.", "Lỗi");
                    return;
                }

                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?",
                                            "Xác Nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    KHACHHANGService.DeleteKHACHHANG(txtMaKH.Text);
                    MessageBox.Show("Xóa khách hàng thành công.", "Thông Báo");
                    LoadData();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa khách hàng: " + ex.Message);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            var keyword = txtTimKiem.Text.ToLower();
            var filteredKHs = KHACHHANGService.SearchKHACHHANGs(keyword);
            dgvKhachHang.Rows.Clear();
            foreach (var kh in filteredKHs)
            {
                int idx = dgvKhachHang.Rows.Add();
                dgvKhachHang.Rows[idx].Cells[0].Value = kh.MaKH;
                dgvKhachHang.Rows[idx].Cells[1].Value = kh.TenKH;
                dgvKhachHang.Rows[idx].Cells[2].Value = kh.DiaChi;
                dgvKhachHang.Rows[idx].Cells[3].Value = kh.SDT;
                dgvKhachHang.Rows[idx].Cells[4].Value = kh.TongNo;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
