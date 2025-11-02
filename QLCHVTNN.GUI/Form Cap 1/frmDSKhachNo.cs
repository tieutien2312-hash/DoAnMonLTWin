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
    public partial class frmDSKhachNo : Form
    {
        public frmDSKhachNo()
        {
            InitializeComponent();
        }
        private readonly KHACHHANGService kHACHHANGService = new KHACHHANGService();
        private void frmDSKhachNo_Load(object sender, EventArgs e)
        {
            LoadData(kHACHHANGService.DSKhachNo());
        }
        private void LoadData(List<KHACHHANG> dsData)
        {
            dgvPhieuNhap.Rows.Clear();
            foreach (var p in dsData)
            {
                var i = dgvPhieuNhap.Rows.Add(p);
                dgvPhieuNhap.Rows[i].Cells[0].Value = p.MaKH;
                dgvPhieuNhap.Rows[i].Cells[1].Value = p.TenKH;
                dgvPhieuNhap.Rows[i].Cells[2].Value = p.DiaChi;
                dgvPhieuNhap.Rows[i].Cells[3].Value = p.SDT;
                dgvPhieuNhap.Rows[i].Cells[4].Value = p.TongNo;
                              
            }
            
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            var keyword = txtTimKiem.Text.ToLower();
            var dstk = kHACHHANGService.TimKiemKHNo(keyword);
            LoadData(dstk);
        }
    }
}
