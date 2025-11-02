using QLCHVTNN.BUS;
using QLCHVTNN.DAL.Model;
using QLCHVTNN.GUI.FormCap2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QLCHVTNN.GUI
{
    public partial class frmLSMuaHang : Form
    {
        public frmLSMuaHang()
        {
            InitializeComponent();
        }
        private readonly KHACHHANGService kHACHHANGService = new KHACHHANGService();
        private readonly CHITIETHOADONBANService cHITIETHOADONBANService = new CHITIETHOADONBANService();
        private readonly HOADONBANService hOADONBANService= new HOADONBANService();
        private void frmLSMuaHang_Load(object sender, EventArgs e)
        {
            LoadKH(kHACHHANGService.GetAll());
        }
        private void LoadKH(List<KHACHHANG> dsKH)
        {
            cmbKhachHang.SelectedIndex = -1;
            cmbKhachHang.DataSource = dsKH;
            cmbKhachHang.ValueMember = "MaKH";
            cmbKhachHang.DisplayMember = "TenKH";
        }
        private void LoadData(List<CHITIETHOADONBAN> dsHD)
        {
            decimal tongNo = 0;
            dgvLSMua.Rows.Clear();
            foreach (var p in dsHD)
            {
                var i = dgvLSMua.Rows.Add(p);
                dgvLSMua.Rows[i].Cells[0].Value = p.HOADONBAN.NgayBan;
                dgvLSMua.Rows[i].Cells[1].Value = p.MaMH;
                dgvLSMua.Rows[i].Cells[2].Value = p.MATHANG.TenMH;
                dgvLSMua.Rows[i].Cells[3].Value = p.SoLuong;
                dgvLSMua.Rows[i].Cells[4].Value = p.DonGia;
                dgvLSMua.Rows[i].Cells[5].Value = p.ThanhTien;
                dgvLSMua.Rows[i].Cells[6].Value = p.HOADONBAN.LoaiThanhToan;
                if(p.HOADONBAN.LoaiThanhToan.ToLower()=="Ghi nợ".ToLower())
                {
                    tongNo += (decimal)p.ThanhTien;
                }
            }
            txtTongNo.Text = tongNo.ToString();
        }

        private void cmbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhachHang.SelectedValue == null) return;

            string maKH = cmbKhachHang.SelectedValue.ToString();
            var dsHD = hOADONBANService.FindByIDKH(maKH);

            if (dsHD == null || dsHD.Count == 0)
            {
                dgvLSMua.Rows.Clear();
                txtTongNo.Text = "0";
                return;
            }
            var ngF=dtpFrom.Value;
            var ngT=dtpTo.Value;

            List<CHITIETHOADONBAN> dsct = cHITIETHOADONBANService.DSCTTheoNg(dsHD,ngF,ngT);
            LoadData(dsct);
        }

        private void btnIN_Click(object sender, EventArgs e)
        {
            var ngF = dtpFrom.Value;
            var ngT = dtpTo.Value;
            string maKH = cmbKhachHang.SelectedValue.ToString();
            frmReportINLS frm=new frmReportINLS(maKH,ngF,ngT);
            frm.Show();
        }
    }
}
