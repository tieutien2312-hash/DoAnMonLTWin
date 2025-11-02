namespace QLCHVTNN.GUI.FormCap2
{
    partial class frmReportPhNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rvwHD = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvwHD
            // 
            this.rvwHD.LocalReport.ReportEmbeddedResource = "QLCHVTNN.GUI.Form Cap 2.ReportHoaDon.rdlc";
            this.rvwHD.Location = new System.Drawing.Point(-19, 2);
            this.rvwHD.Name = "rvwHD";
            this.rvwHD.ServerReport.BearerToken = null;
            this.rvwHD.Size = new System.Drawing.Size(1025, 564);
            this.rvwHD.TabIndex = 1;
            // 
            // frmReportPhNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 569);
            this.Controls.Add(this.rvwHD);
            this.Name = "frmReportPhNhap";
            this.Text = "IN PHIẾU NHẬP";
            this.Load += new System.EventHandler(this.frmReportPhNhap_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvwHD;
    }
}