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
    public partial class frmQLLoaiHang : Form
    {
        LOAIHANGService lhService = new LOAIHANGService();
        public frmQLLoaiHang()
        {
            InitializeComponent();
        }

        private void frmQLLoaiHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvLoaiHang.Rows.Clear();
            var loaiHangs = lhService.GetAllLOAIHANGs();
            foreach (var lh in loaiHangs)
            {
                int idx = dgvLoaiHang.Rows.Add();
                dgvLoaiHang.Rows[idx].Cells[0].Value = lh.MaLoai;
                dgvLoaiHang.Rows[idx].Cells[1].Value = lh.TenLoai;
                dgvLoaiHang.Rows[idx].Cells[2].Value = lh.TinhLaiNo == true ? "Có" : "Không";
            }
        }

        private void ClearForm()
        {
            txtMaLoai.Clear();
            txtTenLoai.Clear();
            rdoCo.Checked = false;
            rdoKhong.Checked = false;
        }

        private void dgvLoaiHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLoaiHang.Rows[e.RowIndex];
                txtMaLoai.Text = row.Cells[0].Value.ToString();
                txtTenLoai.Text = row.Cells[1].Value.ToString();
                if (row.Cells[2].Value.ToString() == "Có")
                {
                    rdoCo.Checked = true;
                }
                else
                {
                    rdoKhong.Checked = true;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMaLoai.Text) || 
                    string.IsNullOrWhiteSpace(txtTenLoai.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin loại hàng.", "Lỗi");
                    return;
                }
                if (lhService.GetLOAIHANGById(txtMaLoai.Text) != null)
                {
                    MessageBox.Show("Mã loại hàng đã tồn tại. Vui lòng sử dụng mã khác.", "Lỗi");
                    return;
                }
                LOAIHANG lh = new LOAIHANG
                {
                    MaLoai = txtMaLoai.Text,
                    TenLoai = txtTenLoai.Text,
                    TinhLaiNo = rdoCo.Checked ? true : false
                };
                lhService.AddLOAIHANG(lh);
                LoadData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm loại hàng: " + ex.Message);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (lhService.GetLOAIHANGById(txtMaLoai.Text) == null)
                {
                    MessageBox.Show("Loại hàng không tồn tại.", "Lỗi");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtMaLoai.Text))
                {
                    MessageBox.Show("Vui lòng chọn loại hàng để sửa.", "Lỗi");
                    return;
                }
                LOAIHANG lh = new LOAIHANG
                {
                    MaLoai = txtMaLoai.Text,
                    TenLoai = txtTenLoai.Text,
                    TinhLaiNo = rdoCo.Checked ? true : false
                };
                lhService.UpdateLOAIHANG(lh);
                LoadData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa loại hàng: " + ex.Message);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (lhService.GetLOAIHANGById(txtMaLoai.Text) == null)
                {
                    MessageBox.Show("Loại hàng không tồn tại.", "Lỗi");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtMaLoai.Text))
                {
                    MessageBox.Show("Vui lòng chọn loại hàng để xóa.", "Lỗi");
                    return;
                }
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa loại hàng này?", 
                                            "Xác Nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    lhService.DeleteLOAIHANG(txtMaLoai.Text);
                    LoadData();
                    ClearForm();
                    MessageBox.Show("Xóa loại hàng thành công.", "Thông Báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa loại hàng: " + ex.Message);
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
            var searchResults = lhService.SearchLOAIHANGByName(keyword);
            dgvLoaiHang.Rows.Clear();
            foreach (var lh in searchResults)
            {
                int idx = dgvLoaiHang.Rows.Add();
                dgvLoaiHang.Rows[idx].Cells[0].Value = lh.MaLoai;
                dgvLoaiHang.Rows[idx].Cells[1].Value = lh.TenLoai;
                dgvLoaiHang.Rows[idx].Cells[2].Value = lh.TinhLaiNo == true ? "Có" : "Không";
            }
        }
    }
}
