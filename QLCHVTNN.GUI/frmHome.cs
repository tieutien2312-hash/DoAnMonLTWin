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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            frmQLKhachHang frmQLKhachHang = new frmQLKhachHang();
            frmQLKhachHang.Show();
        }

        private void btnQLNCC_Click(object sender, EventArgs e)
        {
            frmQLNhaCungCap frmQLNhaCungCap = new frmQLNhaCungCap();
            frmQLNhaCungCap.Show();
        }

        private void btnQLLoaiHang_Click(object sender, EventArgs e)
        {
            frmQLLoaiHang frmQLLoaiHang = new frmQLLoaiHang();
            frmQLLoaiHang.Show();
        }

        private void btnQLMatHang_Click(object sender, EventArgs e)
        {
            frmQLMatHang frmQLMatHang = new frmQLMatHang();
            frmQLMatHang.Show();    
        }

        private void btnPNhap_Click(object sender, EventArgs e)
        {
            frmPhNhapHang frmPhNhapHang = new frmPhNhapHang();
            frmPhNhapHang.Show();
        }

        private void btnHD_Click(object sender, EventArgs e)
        {
            frmHoaDon frmHoaDon = new frmHoaDon();
            frmHoaDon.Show();
        }

        private void btnPThuNo_Click(object sender, EventArgs e)
        {
            frmPhThuNo frm = new frmPhThuNo();
            frm.Show();
        }

        private void btnLSMua_Click(object sender, EventArgs e)
        {
            frmLSMuaHang frmLSMuaHang = new frmLSMuaHang();
            frmLSMuaHang.Show();
        }

        private void btnDSNo_Click(object sender, EventArgs e)
        {
            frmDSKhachNo frmDSKhachNo = new frmDSKhachNo();
            frmDSKhachNo.Show();
        }

        private void btnBCLoiLo_Click(object sender, EventArgs e)
        {
            frmBCLoiLo frmBCLoiLo = new frmBCLoiLo();
            frmBCLoiLo.Show();
        }

        private void btnBCNhapH_Click(object sender, EventArgs e)
        {
            frmBCNhapHang frmBCNhap=new frmBCNhapHang();
            frmBCNhap.Show();
        }
    }
}
