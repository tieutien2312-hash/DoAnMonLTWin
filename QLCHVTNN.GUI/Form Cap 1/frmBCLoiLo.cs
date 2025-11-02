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

namespace QLCHVTNN.GUI
{
    public partial class frmBCLoiLo : Form
    {
        public frmBCLoiLo()
        {
            InitializeComponent();
        }
        private readonly MATHANGService mATHANGService=new MATHANGService();
        private readonly CHITIETHOADONBANService cHITIETHOADONBANService=new CHITIETHOADONBANService();
        private void frmBCLoiLo_Load(object sender, EventArgs e)
        {
            cmbLoaiGia.Items.Add("Ghi nợ");
            cmbLoaiGia.Items.Add("Thanh toán liền");
            cmbLoaiGia.SelectedIndex = 0;
        }
        private void LoadMH(List<BCDoanhThu> ds)
        {
            dgvBCNhap.Rows.Clear();
            dgvBCNhap.Columns.Clear();
            dgvBCNhap.Columns.Add("Col1", "Mã Mặt hàng");
            dgvBCNhap.Columns.Add("Col2", "Tên Mặt hàng");
            dgvBCNhap.Columns.Add("Col3", "Giá Nhập");
            dgvBCNhap.Columns.Add("Col4", "Giá bán");
            dgvBCNhap.Columns.Add("Col5", "Số lượng");
            dgvBCNhap.Columns.Add("Col6", "Lợi nhuận");
            decimal tongTien = 0;
            foreach (var p in ds)
            {
                var i = dgvBCNhap.Rows.Add(p);
                dgvBCNhap.Rows[i].Cells[0].Value = p.MaMH;
                dgvBCNhap.Rows[i].Cells[1].Value = p.TenMH;
                dgvBCNhap.Rows[i].Cells[2].Value = p.GiaNhap;
                dgvBCNhap.Rows[i].Cells[3].Value = p.GiaBan;
                dgvBCNhap.Rows[i].Cells[4].Value = p.SoLuong;
                dgvBCNhap.Rows[i].Cells[5].Value = p.LoiNhuan;

                tongTien += (decimal)p.LoiNhuan;
            }
            txtTongGT.Text = tongTien.ToString("N0");
        }

        private void cmbLoaiGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime from = dtpFrom.Value.Date;
            DateTime to = dtpTo.Value.Date;
            var kieu = cmbLoaiGia.SelectedItem.ToString();
            List<BCDoanhThu> data = new List<BCDoanhThu>();
            List<string> dsma = mATHANGService.DSID();
            if (kieu == "Ghi nợ")
            {                
                foreach (var i in dsma)
                {
                    data.Add(cHITIETHOADONBANService.DoanhThuNO(i, from, to));
                }                
            }
            else
            {                
                foreach (var i in dsma)
                {
                    data.Add(cHITIETHOADONBANService.DoanhThuTM(i, from, to));
                }                
            }
            data = data.OrderByDescending(m => m.LoiNhuan).ToList();
            LoadMH(data);
        }
    }
}
