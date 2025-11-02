using Microsoft.Reporting.WinForms;
using QLCHVTNN.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHVTNN.GUI.Form_Cap_2
{
    public partial class frmReportHD : Form
    {
        private string maHoaDon;
        public frmReportHD()
        {
            InitializeComponent();
        }
        public frmReportHD(string maHD)
        {
            InitializeComponent();
            this.maHoaDon = maHD;
        }
        private readonly CHITIETHOADONBANService cHITIETHOADONBANService = new CHITIETHOADONBANService();
        private readonly HOADONBANService hOADONBANService = new HOADONBANService();
        private void frmReportHD_Load(object sender, EventArgs e)
        {
            var dsct = cHITIETHOADONBANService.FindByID(maHoaDon);
            List<rpHoaDon> data = new List<rpHoaDon>();
            decimal tongTien = 0;
            foreach (var i in dsct)
            {
                rpHoaDon dtemp = new rpHoaDon();
                dtemp.MaHD = i.MaHD;
                dtemp.MaMH = i.MaMH;
                dtemp.TenMH = i.MATHANG.TenMH;
                dtemp.DonGia = i.DonGia;
                dtemp.SoLuong = i.SoLuong;
                dtemp.ThanhTien = i.ThanhTien;
                dtemp.TenKH = i.HOADONBAN.KHACHHANG.TenKH;
                dtemp.NgayBan = i.HOADONBAN.NgayBan;
                data.Add(dtemp);
                tongTien += (decimal)i.ThanhTien;
            }
            rvwHD.LocalReport.ReportPath = Application.StartupPath + @"\FormCap2\ReportHoaDon.rdlc";
            ;
            var source = new ReportDataSource("DataSetHD", data);
            rvwHD.LocalReport.DataSources.Clear();
            rvwHD.LocalReport.DataSources.Add(source);
            rvwHD.LocalReport.SetParameters(new ReportParameter("tongTien", tongTien.ToString()));
            this.rvwHD.RefreshReport();
        }
    }
}
