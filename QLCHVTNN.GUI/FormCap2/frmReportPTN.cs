using Microsoft.Reporting.WinForms;
using QLCHVTNN.BUS;
using QLCHVTNN.DAL.Model;
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
    public partial class frmReportPTN : Form
    {
        private readonly PHIEUTHUNOService pHIEUTHUNOService = new PHIEUTHUNOService();
        private readonly KHACHHANGService kHACHHANGService = new KHACHHANGService();
        public frmReportPTN()
        {
            InitializeComponent();
        }
        string maPhieu;
        public frmReportPTN(string maPH)
        {
            InitializeComponent();
            maPhieu = maPH.ToString();
        }
        private void frmPhieuThuNo_Load(object sender, EventArgs e)
        {
            PHIEUTHUNO dsct = pHIEUTHUNOService.FindByID(maPhieu);
            rvwPTN.LocalReport.ReportPath = Application.StartupPath + @"\FormCap2\ReportPhieuNo.rdlc";          
            rvwPTN.LocalReport.DataSources.Clear();
            rvwPTN.LocalReport.SetParameters(new ReportParameter("MaPhieu", dsct.MaPhieu.ToString()));
            rvwPTN.LocalReport.SetParameters(new ReportParameter("NgayThu", dsct.NgayThu.ToString()));
            rvwPTN.LocalReport.SetParameters(new ReportParameter("TenKH", dsct.KHACHHANG.TenKH.ToString()));
            rvwPTN.LocalReport.SetParameters(new ReportParameter("DiaChi", dsct.KHACHHANG.DiaChi.ToString()));
            rvwPTN.LocalReport.SetParameters(new ReportParameter("SoTien", dsct.SoTienThu.ToString("N0")));
            this.rvwPTN.RefreshReport();
        }
    }
}
