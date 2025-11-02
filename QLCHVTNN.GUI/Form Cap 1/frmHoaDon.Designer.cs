namespace QLCHVTNN.GUI
{
    partial class frmHoaDon
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
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnInHD = new System.Windows.Forms.Button();
            this.btnXoaCT = new System.Windows.Forms.Button();
            this.btnThemCT = new System.Windows.Forms.Button();
            this.btnTaoHD = new System.Windows.Forms.Button();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbMatHang = new System.Windows.Forms.ComboBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gr1 = new System.Windows.Forms.GroupBox();
            this.cmbKhachHang = new System.Windows.Forms.ComboBox();
            this.dtpNgLap = new System.Windows.Forms.DateTimePicker();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkGhiNo = new System.Windows.Forms.RadioButton();
            this.chkTraLien = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gr1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(821, 670);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(251, 22);
            this.txtTongTien.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(728, 671);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Tổng tiền";
            // 
            // btnInHD
            // 
            this.btnInHD.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnInHD.Location = new System.Drawing.Point(95, 340);
            this.btnInHD.Name = "btnInHD";
            this.btnInHD.Size = new System.Drawing.Size(120, 28);
            this.btnInHD.TabIndex = 15;
            this.btnInHD.Text = "In hóa đơn";
            this.btnInHD.UseVisualStyleBackColor = false;
            this.btnInHD.Click += new System.EventHandler(this.btnInHD_Click);
            // 
            // btnXoaCT
            // 
            this.btnXoaCT.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnXoaCT.Location = new System.Drawing.Point(929, 223);
            this.btnXoaCT.Name = "btnXoaCT";
            this.btnXoaCT.Size = new System.Drawing.Size(120, 28);
            this.btnXoaCT.TabIndex = 16;
            this.btnXoaCT.Text = "Xóa chi tiết";
            this.btnXoaCT.UseVisualStyleBackColor = false;
            this.btnXoaCT.Click += new System.EventHandler(this.btnXoaCT_Click);
            // 
            // btnThemCT
            // 
            this.btnThemCT.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnThemCT.Location = new System.Drawing.Point(708, 223);
            this.btnThemCT.Name = "btnThemCT";
            this.btnThemCT.Size = new System.Drawing.Size(180, 28);
            this.btnThemCT.TabIndex = 17;
            this.btnThemCT.Text = "Thêm/ Sửa chi tiết";
            this.btnThemCT.UseVisualStyleBackColor = false;
            this.btnThemCT.Click += new System.EventHandler(this.btnThemCT_Click);
            // 
            // btnTaoHD
            // 
            this.btnTaoHD.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnTaoHD.Location = new System.Drawing.Point(430, 292);
            this.btnTaoHD.Name = "btnTaoHD";
            this.btnTaoHD.Size = new System.Drawing.Size(120, 28);
            this.btnTaoHD.TabIndex = 18;
            this.btnTaoHD.Text = "Tạo hóa đơn";
            this.btnTaoHD.UseVisualStyleBackColor = false;
            this.btnTaoHD.Click += new System.EventHandler(this.btnTaoHD_Click);
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column6,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvHoaDon.Location = new System.Drawing.Point(95, 380);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(977, 269);
            this.dgvHoaDon.TabIndex = 14;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã hóa đơn";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Mã Hàng";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Mặt Hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số lượng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Đơn Giá";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Thành Tiền";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbMatHang);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(606, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 130);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // cmbMatHang
            // 
            this.cmbMatHang.FormattingEnabled = true;
            this.cmbMatHang.Location = new System.Drawing.Point(174, 40);
            this.cmbMatHang.Name = "cmbMatHang";
            this.cmbMatHang.Size = new System.Drawing.Size(230, 24);
            this.cmbMatHang.TabIndex = 4;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(173, 84);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(231, 22);
            this.txtSoLuong.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Số lượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Mặt hàng";
            // 
            // gr1
            // 
            this.gr1.Controls.Add(this.chkTraLien);
            this.gr1.Controls.Add(this.chkGhiNo);
            this.gr1.Controls.Add(this.cmbKhachHang);
            this.gr1.Controls.Add(this.dtpNgLap);
            this.gr1.Controls.Add(this.txtMaHD);
            this.gr1.Controls.Add(this.label5);
            this.gr1.Controls.Add(this.label4);
            this.gr1.Controls.Add(this.label3);
            this.gr1.Controls.Add(this.label2);
            this.gr1.Location = new System.Drawing.Point(107, 72);
            this.gr1.Name = "gr1";
            this.gr1.Size = new System.Drawing.Size(443, 212);
            this.gr1.TabIndex = 13;
            this.gr1.TabStop = false;
            this.gr1.Text = "Thông tin phiếu";
            // 
            // cmbKhachHang
            // 
            this.cmbKhachHang.FormattingEnabled = true;
            this.cmbKhachHang.Location = new System.Drawing.Point(183, 125);
            this.cmbKhachHang.Name = "cmbKhachHang";
            this.cmbKhachHang.Size = new System.Drawing.Size(230, 24);
            this.cmbKhachHang.TabIndex = 4;
            this.cmbKhachHang.SelectedIndexChanged += new System.EventHandler(this.cmbKhachHang_SelectedIndexChanged);
            // 
            // dtpNgLap
            // 
            this.dtpNgLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgLap.Location = new System.Drawing.Point(183, 82);
            this.dtpNgLap.Name = "dtpNgLap";
            this.dtpNgLap.Size = new System.Drawing.Size(230, 22);
            this.dtpNgLap.TabIndex = 3;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(183, 40);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(231, 22);
            this.txtMaHD.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Loại thanh toán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày lập HD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã hóa đơn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(483, 344);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 24);
            this.label8.TabIndex = 9;
            this.label8.Text = "CHI TIẾT HÓA ĐƠN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(465, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 35);
            this.label1.TabIndex = 10;
            this.label1.Text = "TẠO HÓA ĐƠN";
            // 
            // chkGhiNo
            // 
            this.chkGhiNo.AutoSize = true;
            this.chkGhiNo.Location = new System.Drawing.Point(183, 167);
            this.chkGhiNo.Name = "chkGhiNo";
            this.chkGhiNo.Size = new System.Drawing.Size(69, 20);
            this.chkGhiNo.TabIndex = 5;
            this.chkGhiNo.TabStop = true;
            this.chkGhiNo.Text = "Ghi Nợ";
            this.chkGhiNo.UseVisualStyleBackColor = true;
            // 
            // chkTraLien
            // 
            this.chkTraLien.AutoSize = true;
            this.chkTraLien.Location = new System.Drawing.Point(311, 166);
            this.chkTraLien.Name = "chkTraLien";
            this.chkTraLien.Size = new System.Drawing.Size(77, 20);
            this.chkTraLien.TabIndex = 5;
            this.chkTraLien.TabStop = true;
            this.chkTraLien.Text = "Trả Liền";
            this.chkTraLien.UseVisualStyleBackColor = true;
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 715);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnInHD);
            this.Controls.Add(this.btnXoaCT);
            this.Controls.Add(this.btnThemCT);
            this.Controls.Add(this.btnTaoHD);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gr1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Name = "frmHoaDon";
            this.Text = "Tạo hóa đơn";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gr1.ResumeLayout(false);
            this.gr1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnInHD;
        private System.Windows.Forms.Button btnXoaCT;
        private System.Windows.Forms.Button btnThemCT;
        private System.Windows.Forms.Button btnTaoHD;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbMatHang;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gr1;
        private System.Windows.Forms.ComboBox cmbKhachHang;
        private System.Windows.Forms.DateTimePicker dtpNgLap;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton chkTraLien;
        private System.Windows.Forms.RadioButton chkGhiNo;
    }
}