using Microsoft.Reporting.WinForms;
using QLCHVTNN.BUS;
using QLCHVTNN.BUS.Service;
using QLCHVTNN.GUI.Form_Cap_2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHVTNN.GUI.FormCap2
{
    public partial class frmReportPhNhap : Form
    {
        private readonly PHIEUNHAPService pHIEUNHAPService=new PHIEUNHAPService();
        private readonly CHITIETPHIEUNHAPService cHITIETPHIEUNHAPService=new CHITIETPHIEUNHAPService();
        public frmReportPhNhap()
        {
            InitializeComponent();
        }
        string maPhieu;
        public frmReportPhNhap(string maPH)
        {
            InitializeComponent();
            maPhieu = maPH;
        }
        private void frmReportPhNhap_Load(object sender, EventArgs e)
        {
            var dsct = cHITIETPHIEUNHAPService.FindByID(maPhieu);
            List<rpPhNhap> data = new List<rpPhNhap>();
            decimal tongTien = 0;
            foreach (var i in dsct)
            {
                rpPhNhap dtemp = new rpPhNhap();
                dtemp.MaPH = i.MaPN;
                dtemp.MaMH = i.MaMH;
                dtemp.TenMH = i.MATHANG.TenMH;
                dtemp.DonGia = i.DonGiaNhap;
                dtemp.SoLuong = i.SoLuong;
                dtemp.ThanhTien = i.ThanhTien;
                dtemp.TenNCC = i.PHIEUNHAP.NHACUNGCAP.TenNCC;
                dtemp.NgayLap = i.PHIEUNHAP.NgayNhap;
                data.Add(dtemp);
                tongTien += (decimal)i.ThanhTien;
            }
            rvwHD.LocalReport.ReportPath = Application.StartupPath + @"\FormCap2\ReportPhieuNhap.rdlc";
            
            var source = new ReportDataSource("DataSetPhNhap", data);
            rvwHD.LocalReport.DataSources.Clear();
            rvwHD.LocalReport.DataSources.Add(source);
            rvwHD.LocalReport.SetParameters(new ReportParameter("tongTien", tongTien.ToString()));
            this.rvwHD.RefreshReport();
        }
    }
}
