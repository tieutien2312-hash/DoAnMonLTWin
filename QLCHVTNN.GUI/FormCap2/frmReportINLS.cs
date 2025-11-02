using Microsoft.Reporting.WinForms;
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

namespace QLCHVTNN.GUI.FormCap2
{
    public partial class frmReportINLS : Form
    {
        string MaKhach;
        DateTime ngfrom;
        DateTime ngto;
        private readonly HOADONBANService hOADONBANService = new HOADONBANService();
        private readonly CHITIETHOADONBANService cHITIETHOADONBANService = new CHITIETHOADONBANService();
        private readonly KHACHHANGService kHACHHANGService = new KHACHHANGService();
        public frmReportINLS()
        {
            InitializeComponent();
        }
        public frmReportINLS(string MaKH, DateTime ngfrom, DateTime ngto)
        {
            InitializeComponent();
            MaKhach = MaKH;
            this.ngfrom = ngfrom;
            this.ngto = ngto;
        }
        private void frmReportINLS_Load(object sender, EventArgs e)
        {
            var dsHD = hOADONBANService.FindByIDKH(MaKhach);
            
            List<CHITIETHOADONBAN> dsct = cHITIETHOADONBANService.DSCTTheoNg(dsHD, ngfrom, ngto);
            List<rpINLSMua> data = new List<rpINLSMua>();
            decimal tongTien = 0;
            foreach (var i in dsct)
            {
                rpINLSMua dtemp = new rpINLSMua();
                dtemp.ThoiGian =(DateTime)i.HOADONBAN.NgayBan;                
                dtemp.TenMH = i.MATHANG.TenMH;
                dtemp.SoLuong = i.SoLuong;
                dtemp.DonGia = i.DonGia;                
                dtemp.ThanhTien = (decimal)i.ThanhTien;               
                data.Add(dtemp);
                tongTien += (decimal)i.ThanhTien;
            }
            rvwINLS.LocalReport.ReportPath = Application.StartupPath + @"\FormCap2\ReportINLS.rdlc";

            var source = new ReportDataSource("DataSetLSMua", data);
            rvwINLS.LocalReport.DataSources.Clear();
            rvwINLS.LocalReport.DataSources.Add(source);
            rvwINLS.LocalReport.SetParameters(new ReportParameter("tongTien", tongTien.ToString("N0")));
            rvwINLS.LocalReport.SetParameters(new ReportParameter("MaKH", MaKhach));
            rvwINLS.LocalReport.SetParameters(new ReportParameter("TenKH",kHACHHANGService.FindByID(MaKhach).TenKH ));
            rvwINLS.LocalReport.SetParameters(new ReportParameter("NgayFrom", ngfrom.ToString("dd/MM/yyyy")));
            rvwINLS.LocalReport.SetParameters(new ReportParameter("NgayTo", ngto.ToString("dd/MM/yyyy")));
            this.rvwINLS.RefreshReport();
        }
    }
}
