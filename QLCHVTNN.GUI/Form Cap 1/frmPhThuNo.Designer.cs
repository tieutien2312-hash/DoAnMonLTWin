namespace QLCHVTNN.GUI
{
    partial class frmPhThuNo
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
            this.btnTaoPH = new System.Windows.Forms.Button();
            this.gr1 = new System.Windows.Forms.GroupBox();
            this.rtxtGhiChu = new System.Windows.Forms.RichTextBox();
            this.cmbKhachHang = new System.Windows.Forms.ComboBox();
            this.dtpNgLap = new System.Windows.Forms.DateTimePicker();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.txtMaPH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoaPH = new System.Windows.Forms.Button();
            this.dgvPhThuNo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIN = new System.Windows.Forms.Button();
            this.gr1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhThuNo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTaoPH
            // 
            this.btnTaoPH.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnTaoPH.Location = new System.Drawing.Point(40, 415);
            this.btnTaoPH.Name = "btnTaoPH";
            this.btnTaoPH.Size = new System.Drawing.Size(138, 28);
            this.btnTaoPH.TabIndex = 20;
            this.btnTaoPH.Text = "Tạo/Sửa phiếu";
            this.btnTaoPH.UseVisualStyleBackColor = false;
            this.btnTaoPH.Click += new System.EventHandler(this.btnTaoPH_Click);
            // 
            // gr1
            // 
            this.gr1.Controls.Add(this.rtxtGhiChu);
            this.gr1.Controls.Add(this.cmbKhachHang);
            this.gr1.Controls.Add(this.dtpNgLap);
            this.gr1.Controls.Add(this.txtSoTien);
            this.gr1.Controls.Add(this.txtMaPH);
            this.gr1.Controls.Add(this.label5);
            this.gr1.Controls.Add(this.label4);
            this.gr1.Controls.Add(this.label6);
            this.gr1.Controls.Add(this.label3);
            this.gr1.Controls.Add(this.label2);
            this.gr1.Location = new System.Drawing.Point(39, 75);
            this.gr1.Name = "gr1";
            this.gr1.Size = new System.Drawing.Size(423, 322);
            this.gr1.TabIndex = 19;
            this.gr1.TabStop = false;
            this.gr1.Text = "Thông tin phiếu";
            // 
            // rtxtGhiChu
            // 
            this.rtxtGhiChu.Location = new System.Drawing.Point(163, 208);
            this.rtxtGhiChu.Name = "rtxtGhiChu";
            this.rtxtGhiChu.Size = new System.Drawing.Size(230, 81);
            this.rtxtGhiChu.TabIndex = 22;
            this.rtxtGhiChu.Text = "";
            // 
            // cmbKhachHang
            // 
            this.cmbKhachHang.FormattingEnabled = true;
            this.cmbKhachHang.Location = new System.Drawing.Point(162, 115);
            this.cmbKhachHang.Name = "cmbKhachHang";
            this.cmbKhachHang.Size = new System.Drawing.Size(230, 24);
            this.cmbKhachHang.TabIndex = 4;
            // 
            // dtpNgLap
            // 
            this.dtpNgLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgLap.Location = new System.Drawing.Point(162, 72);
            this.dtpNgLap.Name = "dtpNgLap";
            this.dtpNgLap.Size = new System.Drawing.Size(230, 22);
            this.dtpNgLap.TabIndex = 3;
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(163, 160);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(231, 22);
            this.txtSoTien.TabIndex = 2;
            // 
            // txtMaPH
            // 
            this.txtMaPH.Location = new System.Drawing.Point(162, 30);
            this.txtMaPH.Name = "txtMaPH";
            this.txtMaPH.Size = new System.Drawing.Size(231, 22);
            this.txtMaPH.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ghi chú";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Khách hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Số tiền thu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày thu nợ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã phiếu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(481, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 35);
            this.label1.TabIndex = 21;
            this.label1.Text = "TẠO PHIẾU THU NỢ";
            // 
            // btnXoaPH
            // 
            this.btnXoaPH.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnXoaPH.Location = new System.Drawing.Point(219, 415);
            this.btnXoaPH.Name = "btnXoaPH";
            this.btnXoaPH.Size = new System.Drawing.Size(101, 28);
            this.btnXoaPH.TabIndex = 20;
            this.btnXoaPH.Text = "Xóa phiếu";
            this.btnXoaPH.UseVisualStyleBackColor = false;
            this.btnXoaPH.Click += new System.EventHandler(this.btnXoaPH_Click);
            // 
            // dgvPhThuNo
            // 
            this.dgvPhThuNo.AllowUserToAddRows = false;
            this.dgvPhThuNo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhThuNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhThuNo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column6,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvPhThuNo.Location = new System.Drawing.Point(501, 82);
            this.dgvPhThuNo.Name = "dgvPhThuNo";
            this.dgvPhThuNo.RowHeadersWidth = 51;
            this.dgvPhThuNo.RowTemplate.Height = 24;
            this.dgvPhThuNo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhThuNo.Size = new System.Drawing.Size(651, 315);
            this.dgvPhThuNo.TabIndex = 22;
            this.dgvPhThuNo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã phiếu";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Ngày thu nợ";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Khách hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số tiền thu";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ghi chú";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // btnIN
            // 
            this.btnIN.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnIN.Location = new System.Drawing.Point(361, 415);
            this.btnIN.Name = "btnIN";
            this.btnIN.Size = new System.Drawing.Size(101, 28);
            this.btnIN.TabIndex = 20;
            this.btnIN.Text = "IN phiếu";
            this.btnIN.UseVisualStyleBackColor = false;
            this.btnIN.Click += new System.EventHandler(this.btnIN_Click);
            // 
            // frmPhThuNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 470);
            this.Controls.Add(this.dgvPhThuNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIN);
            this.Controls.Add(this.btnXoaPH);
            this.Controls.Add(this.btnTaoPH);
            this.Controls.Add(this.gr1);
            this.Name = "frmPhThuNo";
            this.Text = "Phiếu thu nợ";
            this.Load += new System.EventHandler(this.frmPhThuNo_Load);
            this.gr1.ResumeLayout(false);
            this.gr1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhThuNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTaoPH;
        private System.Windows.Forms.GroupBox gr1;
        private System.Windows.Forms.ComboBox cmbKhachHang;
        private System.Windows.Forms.DateTimePicker dtpNgLap;
        private System.Windows.Forms.TextBox txtMaPH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoaPH;
        private System.Windows.Forms.RichTextBox rtxtGhiChu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvPhThuNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnIN;
    }
}