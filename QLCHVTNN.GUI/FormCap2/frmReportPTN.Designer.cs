namespace QLCHVTNN.GUI.FormCap2
{
    partial class frmReportPTN
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
            this.rvwPTN = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvwPTN
            // 
            this.rvwPTN.Location = new System.Drawing.Point(7, 7);
            this.rvwPTN.Name = "rvwPTN";
            this.rvwPTN.ServerReport.BearerToken = null;
            this.rvwPTN.Size = new System.Drawing.Size(902, 549);
            this.rvwPTN.TabIndex = 0;
            // 
            // frmReportPTN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 558);
            this.Controls.Add(this.rvwPTN);
            this.Name = "frmReportPTN";
            this.Text = "IN PHIẾU THU NỢ";
            this.Load += new System.EventHandler(this.frmPhieuThuNo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvwPTN;
    }
}