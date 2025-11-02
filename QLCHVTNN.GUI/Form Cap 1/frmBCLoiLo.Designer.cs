namespace QLCHVTNN.GUI
{
    partial class frmBCLoiLo
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
            this.txtTongGT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvBCNhap = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLoaiGia = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBCNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTongGT
            // 
            this.txtTongGT.Location = new System.Drawing.Point(721, 538);
            this.txtTongGT.Name = "txtTongGT";
            this.txtTongGT.Size = new System.Drawing.Size(251, 22);
            this.txtTongGT.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(570, 538);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "Tổng doanh thu";
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(318, 99);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(125, 22);
            this.dtpTo.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Đến";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(110, 99);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(125, 22);
            this.dtpFrom.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Ngày";
            // 
            // dgvBCNhap
            // 
            this.dgvBCNhap.AllowUserToAddRows = false;
            this.dgvBCNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBCNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBCNhap.Location = new System.Drawing.Point(44, 145);
            this.dgvBCNhap.Name = "dgvBCNhap";
            this.dgvBCNhap.RowHeadersWidth = 51;
            this.dgvBCNhap.RowTemplate.Height = 24;
            this.dgvBCNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBCNhap.Size = new System.Drawing.Size(928, 378);
            this.dgvBCNhap.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 35);
            this.label1.TabIndex = 25;
            this.label1.Text = "THỐNG KÊ DOANH THU";
            // 
            // cmbLoaiGia
            // 
            this.cmbLoaiGia.FormattingEnabled = true;
            this.cmbLoaiGia.Location = new System.Drawing.Point(742, 97);
            this.cmbLoaiGia.Name = "cmbLoaiGia";
            this.cmbLoaiGia.Size = new System.Drawing.Size(230, 24);
            this.cmbLoaiGia.TabIndex = 34;
            this.cmbLoaiGia.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiGia_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(655, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Loại giá";
            // 
            // frmBCLoiLo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 583);
            this.Controls.Add(this.cmbLoaiGia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTongGT);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvBCNhap);
            this.Controls.Add(this.label1);
            this.Name = "frmBCLoiLo";
            this.Text = "frmBCLoiLo";
            this.Load += new System.EventHandler(this.frmBCLoiLo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBCNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTongGT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvBCNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLoaiGia;
        private System.Windows.Forms.Label label4;
    }
}