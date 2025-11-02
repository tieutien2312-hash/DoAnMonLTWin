using QLCHVTNN.BUS;
using QLCHVTNN.BUS.Service;
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
using System.Xml.Linq;

namespace QLCHVTNN.GUI
{
    public partial class frmBCNhapHang : Form
    {
        private readonly NHACUNGCAPService nHACUNGCAPService = new NHACUNGCAPService();
        private readonly MATHANGService mATHANGService = new MATHANGService();
        private readonly PHIEUNHAPService pHIEUNHAPService = new PHIEUNHAPService();
        private readonly CHITIETPHIEUNHAPService cHITIETPHIEUNHAPService= new CHITIETPHIEUNHAPService();
        public frmBCNhapHang()
        {
            InitializeComponent();
        }

        private void frmBCNhapHang_Load(object sender, EventArgs e)
        {
            cmbLoaiTK.Items.Add("Theo nhà cung cấp");
            cmbLoaiTK.Items.Add("Theo loại hàng");
            cmbLoaiTK.SelectedIndex = 0;
        }
        private void LoadNCC(List<BCNhap> ds)
        {
            dgvBCNhap.Rows.Clear();
            dgvBCNhap.Columns.Clear();
            dgvBCNhap.Columns.Add("Col1", "Mã NCC");
            dgvBCNhap.Columns.Add("Col2", "Tên Nhà Cung Cấp");
            dgvBCNhap.Columns.Add("Col3", "Tổng Tiền Nhập");
            decimal tongTien = 0;           
            foreach (var p in ds)
            {
                var i = dgvBCNhap.Rows.Add(p);
                dgvBCNhap.Rows[i].Cells[0].Value = p.Ma;
                dgvBCNhap.Rows[i].Cells[1].Value = p.Ten;
                dgvBCNhap.Rows[i].Cells[2].Value = p.TongTienNhap;
                
                tongTien += (decimal)p.TongTienNhap;
            }
            txtTongGT.Text = tongTien.ToString("N0");
        }
        private void LoadMH(List<BCNhap> ds)
        {
            dgvBCNhap.Rows.Clear();
            dgvBCNhap.Columns.Clear();
            dgvBCNhap.Columns.Add("Col1", "Mã Mặt hàng");
            dgvBCNhap.Columns.Add("Col2", "Tên Mặt hàng");
            dgvBCNhap.Columns.Add("Col3", "Tổng Tiền Nhập");
            decimal tongTien = 0;
            foreach (var p in ds)
            {
                var i = dgvBCNhap.Rows.Add(p);
                dgvBCNhap.Rows[i].Cells[0].Value = p.Ma;
                dgvBCNhap.Rows[i].Cells[1].Value = p.Ten;
                dgvBCNhap.Rows[i].Cells[2].Value = p.TongTienNhap;

                tongTien += (decimal)p.TongTienNhap;
            }
            txtTongGT.Text = tongTien.ToString("N0");
        }

        private void cmbLoaiTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime from = dtpFrom.Value.Date;
            DateTime to = dtpTo.Value.Date;
            var kieu = cmbLoaiTK.SelectedItem.ToString();            
            List<BCNhap> data=new List<BCNhap>();
            List<string> dsma=new List<string>();
            if (kieu == "Theo nhà cung cấp")
            {
                dsma = nHACUNGCAPService.DSID();
                foreach (var i in dsma)
                {
                    data.Add(pHIEUNHAPService.TongNhapNCC(i, from, to));
                }
                data=data.OrderByDescending(m=>m.TongTienNhap).ToList();
                LoadNCC(data);
            }
            else
            {
                dsma = mATHANGService.DSID();
                foreach (var i in dsma)
                {
                    data.Add(cHITIETPHIEUNHAPService.TongNhapMH(i, from, to));
                }
                data=data.OrderByDescending(m => m.TongTienNhap).ToList();
                LoadMH(data);
            }

            
        }
    }
}
