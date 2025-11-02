namespace QLCHVTNN.GUI.Form_Cap_2
{
    partial class frmReportHD
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
            this.rvwHoaDon = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rvwHD = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvwHoaDon
            // 
            this.rvwHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.rvwHoaDon.Location = new System.Drawing.Point(0, 0);
            this.rvwHoaDon.Name = "rvwHoaDon";
            this.rvwHoaDon.ServerReport.BearerToken = null;
            this.rvwHoaDon.Size = new System.Drawing.Size(800, 450);
            this.rvwHoaDon.TabIndex = 0;
            // 
            // rvwHD
            // 
            this.rvwHD.LocalReport.ReportEmbeddedResource = "QLCHVTNN.GUI.Form Cap 2.ReportHoaDon.rdlc";
            this.rvwHD.Location = new System.Drawing.Point(3, 3);
            this.rvwHD.Name = "rvwHD";
            this.rvwHD.ServerReport.BearerToken = null;
            this.rvwHD.Size = new System.Drawing.Size(1025, 564);
            this.rvwHD.TabIndex = 0;
            // 
            // frmReportHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 566);
            this.Controls.Add(this.rvwHD);
            this.Name = "frmReportHD";
            this.Text = "IN HÓA ĐƠN";
            this.Load += new System.EventHandler(this.frmReportHD_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvwHoaDon;
        private Microsoft.Reporting.WinForms.ReportViewer rvwHD;
    }
}