namespace QLCHVTNN.GUI
{
    partial class frmPhNhapHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaPH = new System.Windows.Forms.TextBox();
            this.dtpNgNhap = new System.Windows.Forms.DateTimePicker();
            this.cmbDSNCC = new System.Windows.Forms.ComboBox();
            this.gr1 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbMatHang = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTaoPhieu = new System.Windows.Forms.Button();
            this.btnThemCT = new System.Windows.Forms.Button();
            this.btnXoaCT = new System.Windows.Forms.Button();
            this.btnInPhieu = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gr1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(463, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "TẠO PHIẾU NHẬP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã phiếu nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nhà cung cấp";
            // 
            // txtMaPH
            // 
            this.txtMaPH.Location = new System.Drawing.Point(183, 40);
            this.txtMaPH.Name = "txtMaPH";
            this.txtMaPH.Size = new System.Drawing.Size(231, 22);
            this.txtMaPH.TabIndex = 2;
            // 
            // dtpNgNhap
            // 
            this.dtpNgNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgNhap.Location = new System.Drawing.Point(183, 82);
            this.dtpNgNhap.Name = "dtpNgNhap";
            this.dtpNgNhap.Size = new System.Drawing.Size(230, 22);
            this.dtpNgNhap.TabIndex = 3;
            // 
            // cmbDSNCC
            // 
            this.cmbDSNCC.FormattingEnabled = true;
            this.cmbDSNCC.Location = new System.Drawing.Point(183, 125);
            this.cmbDSNCC.Name = "cmbDSNCC";
            this.cmbDSNCC.Size = new System.Drawing.Size(230, 24);
            this.cmbDSNCC.TabIndex = 4;
            this.cmbDSNCC.SelectedIndexChanged += new System.EventHandler(this.cmbDSNCC_SelectedIndexChanged);
            // 
            // gr1
            // 
            this.gr1.Controls.Add(this.cmbDSNCC);
            this.gr1.Controls.Add(this.dtpNgNhap);
            this.gr1.Controls.Add(this.txtMaPH);
            this.gr1.Controls.Add(this.label4);
            this.gr1.Controls.Add(this.label3);
            this.gr1.Controls.Add(this.label2);
            this.gr1.Location = new System.Drawing.Point(113, 63);
            this.gr1.Name = "gr1";
            this.gr1.Size = new System.Drawing.Size(443, 190);
            this.gr1.TabIndex = 5;
            this.gr1.TabStop = false;
            this.gr1.Text = "Thông tin phiếu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbMatHang);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtGiaNhap);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(612, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 190);
            this.groupBox1.TabIndex = 5;
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Giá nhập";
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(173, 126);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(231, 22);
            this.txtGiaNhap.TabIndex = 2;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(482, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "CHI TIẾT PHIẾU NHẬP";
            // 
            // dgvPhieuNhap
            // 
            this.dgvPhieuNhap.AllowUserToAddRows = false;
            this.dgvPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column6,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvPhieuNhap.Location = new System.Drawing.Point(100, 356);
            this.dgvPhieuNhap.Name = "dgvPhieuNhap";
            this.dgvPhieuNhap.RowHeadersWidth = 51;
            this.dgvPhieuNhap.RowTemplate.Height = 24;
            this.dgvPhieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuNhap.Size = new System.Drawing.Size(977, 269);
            this.dgvPhieuNhap.TabIndex = 6;
            this.dgvPhieuNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuNhap_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Phiếu Nhập";
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
            this.Column4.HeaderText = "Giá Nhập";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Thành Tiền";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // btnTaoPhieu
            // 
            this.btnTaoPhieu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnTaoPhieu.Location = new System.Drawing.Point(436, 267);
            this.btnTaoPhieu.Name = "btnTaoPhieu";
            this.btnTaoPhieu.Size = new System.Drawing.Size(120, 28);
            this.btnTaoPhieu.TabIndex = 7;
            this.btnTaoPhieu.Text = "Tạo phiếu";
            this.btnTaoPhieu.UseVisualStyleBackColor = false;
            this.btnTaoPhieu.Click += new System.EventHandler(this.btnTaoPhieu_Click);
            // 
            // btnThemCT
            // 
            this.btnThemCT.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnThemCT.Location = new System.Drawing.Point(714, 267);
            this.btnThemCT.Name = "btnThemCT";
            this.btnThemCT.Size = new System.Drawing.Size(180, 28);
            this.btnThemCT.TabIndex = 7;
            this.btnThemCT.Text = "Thêm/ Sửa chi tiết";
            this.btnThemCT.UseVisualStyleBackColor = false;
            this.btnThemCT.Click += new System.EventHandler(this.btnThemCT_Click);
            // 
            // btnXoaCT
            // 
            this.btnXoaCT.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnXoaCT.Location = new System.Drawing.Point(935, 267);
            this.btnXoaCT.Name = "btnXoaCT";
            this.btnXoaCT.Size = new System.Drawing.Size(120, 28);
            this.btnXoaCT.TabIndex = 7;
            this.btnXoaCT.Text = "Xóa chi tiết";
            this.btnXoaCT.UseVisualStyleBackColor = false;
            this.btnXoaCT.Click += new System.EventHandler(this.btnXoaCT_Click);
            // 
            // btnInPhieu
            // 
            this.btnInPhieu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnInPhieu.Location = new System.Drawing.Point(100, 316);
            this.btnInPhieu.Name = "btnInPhieu";
            this.btnInPhieu.Size = new System.Drawing.Size(120, 28);
            this.btnInPhieu.TabIndex = 7;
            this.btnInPhieu.Text = "In Phiếu";
            this.btnInPhieu.UseVisualStyleBackColor = false;
            this.btnInPhieu.Click += new System.EventHandler(this.btnInPhieu_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(826, 646);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(251, 22);
            this.txtTongTien.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(733, 647);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Tổng tiền";
            // 
            // frmPhNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 699);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnInPhieu);
            this.Controls.Add(this.btnXoaCT);
            this.Controls.Add(this.btnThemCT);
            this.Controls.Add(this.btnTaoPhieu);
            this.Controls.Add(this.dgvPhieuNhap);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gr1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Name = "frmPhNhapHang";
            this.Text = "Tạo phiếu nhập";
            this.Load += new System.EventHandler(this.frmPhNhapHang_Load);
            this.gr1.ResumeLayout(false);
            this.gr1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaPH;
        private System.Windows.Forms.DateTimePicker dtpNgNhap;
        private System.Windows.Forms.ComboBox cmbDSNCC;
        private System.Windows.Forms.GroupBox gr1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbMatHang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvPhieuNhap;
        private System.Windows.Forms.Button btnTaoPhieu;
        private System.Windows.Forms.Button btnThemCT;
        private System.Windows.Forms.Button btnXoaCT;
        private System.Windows.Forms.Button btnInPhieu;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}