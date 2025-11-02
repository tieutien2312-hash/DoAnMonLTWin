namespace QLCHVTNN.GUI.FormCap2
{
    partial class frmReportINLS
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
            this.rvwINLS = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rvwINLS
            // 
            this.rvwINLS.Location = new System.Drawing.Point(3, 2);
            this.rvwINLS.Name = "rvwINLS";
            this.rvwINLS.ServerReport.BearerToken = null;
            this.rvwINLS.Size = new System.Drawing.Size(897, 522);
            this.rvwINLS.TabIndex = 0;
            // 
            // frmReportINLS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 527);
            this.Controls.Add(this.rvwINLS);
            this.Name = "frmReportINLS";
            this.Text = "IN LỊCH SỬ MUA";
            this.Load += new System.EventHandler(this.frmReportINLS_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvwINLS;
    }
}