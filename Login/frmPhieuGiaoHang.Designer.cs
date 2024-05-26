namespace QuanLiBanHang
{
    partial class frmPhieuGiaoHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuGiaoHang));
            this.lblHoaDon = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpNgayGiao = new System.Windows.Forms.DateTimePicker();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.cboMaDC = new System.Windows.Forms.ComboBox();
            this.cboMaDDH = new System.Windows.Forms.ComboBox();
            this.lblMaDC = new System.Windows.Forms.Label();
            this.txtMaPhieuGH = new System.Windows.Forms.TextBox();
            this.lblMaPhieuGH = new System.Windows.Forms.Label();
            this.lblNgayGiao = new System.Windows.Forms.Label();
            this.lblMaDDH = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTimMaPGH = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.dgvPhieuGH = new System.Windows.Forms.DataGridView();
            this.colMaPhieuGH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaDonDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayGH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaDC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXemDH = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuGH)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHoaDon
            // 
            this.lblHoaDon.AutoSize = true;
            this.lblHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoaDon.ForeColor = System.Drawing.Color.Blue;
            this.lblHoaDon.Location = new System.Drawing.Point(289, 26);
            this.lblHoaDon.Name = "lblHoaDon";
            this.lblHoaDon.Size = new System.Drawing.Size(238, 29);
            this.lblHoaDon.TabIndex = 6;
            this.lblHoaDon.Text = "PHIẾU GIAO HÀNG";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpNgayGiao);
            this.panel1.Controls.Add(this.txtSoLuong);
            this.panel1.Controls.Add(this.txtDonGia);
            this.panel1.Controls.Add(this.lblSoLuong);
            this.panel1.Controls.Add(this.lblDonGia);
            this.panel1.Controls.Add(this.cboMaDC);
            this.panel1.Controls.Add(this.cboMaDDH);
            this.panel1.Controls.Add(this.lblMaDC);
            this.panel1.Controls.Add(this.txtMaPhieuGH);
            this.panel1.Controls.Add(this.lblMaPhieuGH);
            this.panel1.Controls.Add(this.lblNgayGiao);
            this.panel1.Controls.Add(this.lblMaDDH);
            this.panel1.Location = new System.Drawing.Point(22, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 129);
            this.panel1.TabIndex = 27;
            // 
            // dtpNgayGiao
            // 
            this.dtpNgayGiao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayGiao.Location = new System.Drawing.Point(597, 55);
            this.dtpNgayGiao.Name = "dtpNgayGiao";
            this.dtpNgayGiao.Size = new System.Drawing.Size(167, 22);
            this.dtpNgayGiao.TabIndex = 16;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoLuong.Location = new System.Drawing.Point(598, 88);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(166, 22);
            this.txtSoLuong.TabIndex = 15;
            // 
            // txtDonGia
            // 
            this.txtDonGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDonGia.Location = new System.Drawing.Point(175, 90);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(166, 22);
            this.txtDonGia.TabIndex = 14;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(465, 90);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(63, 16);
            this.lblSoLuong.TabIndex = 13;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(24, 94);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(86, 16);
            this.lblDonGia.TabIndex = 12;
            this.lblDonGia.Text = "Đơn giá giao:";
            // 
            // cboMaDC
            // 
            this.cboMaDC.FormattingEnabled = true;
            this.cboMaDC.Location = new System.Drawing.Point(175, 56);
            this.cboMaDC.Name = "cboMaDC";
            this.cboMaDC.Size = new System.Drawing.Size(166, 24);
            this.cboMaDC.TabIndex = 11;
            // 
            // cboMaDDH
            // 
            this.cboMaDDH.FormattingEnabled = true;
            this.cboMaDDH.Location = new System.Drawing.Point(598, 18);
            this.cboMaDDH.Name = "cboMaDDH";
            this.cboMaDDH.Size = new System.Drawing.Size(166, 24);
            this.cboMaDDH.TabIndex = 10;
            // 
            // lblMaDC
            // 
            this.lblMaDC.AutoSize = true;
            this.lblMaDC.Location = new System.Drawing.Point(24, 61);
            this.lblMaDC.Name = "lblMaDC";
            this.lblMaDC.Size = new System.Drawing.Size(76, 16);
            this.lblMaDC.TabIndex = 4;
            this.lblMaDC.Text = "Mã đồ chơi:";
            // 
            // txtMaPhieuGH
            // 
            this.txtMaPhieuGH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaPhieuGH.Location = new System.Drawing.Point(175, 18);
            this.txtMaPhieuGH.Name = "txtMaPhieuGH";
            this.txtMaPhieuGH.Size = new System.Drawing.Size(166, 22);
            this.txtMaPhieuGH.TabIndex = 5;
            // 
            // lblMaPhieuGH
            // 
            this.lblMaPhieuGH.AutoSize = true;
            this.lblMaPhieuGH.Location = new System.Drawing.Point(24, 22);
            this.lblMaPhieuGH.Name = "lblMaPhieuGH";
            this.lblMaPhieuGH.Size = new System.Drawing.Size(128, 16);
            this.lblMaPhieuGH.TabIndex = 3;
            this.lblMaPhieuGH.Text = "Mã phiếu giao hàng:";
            // 
            // lblNgayGiao
            // 
            this.lblNgayGiao.AutoSize = true;
            this.lblNgayGiao.Location = new System.Drawing.Point(465, 60);
            this.lblNgayGiao.Name = "lblNgayGiao";
            this.lblNgayGiao.Size = new System.Drawing.Size(73, 16);
            this.lblNgayGiao.TabIndex = 2;
            this.lblNgayGiao.Text = "Ngày giao:";
            // 
            // lblMaDDH
            // 
            this.lblMaDDH.AutoSize = true;
            this.lblMaDDH.Location = new System.Drawing.Point(465, 22);
            this.lblMaDDH.Name = "lblMaDDH";
            this.lblMaDDH.Size = new System.Drawing.Size(110, 16);
            this.lblMaDDH.TabIndex = 1;
            this.lblMaDDH.Text = "Mã đơn đặt hàng:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtTimMaPGH);
            this.panel3.Controls.Add(this.btnTimKiem);
            this.panel3.Controls.Add(this.lblTimKiem);
            this.panel3.Location = new System.Drawing.Point(22, 193);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(459, 47);
            this.panel3.TabIndex = 30;
            // 
            // txtTimMaPGH
            // 
            this.txtTimMaPGH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimMaPGH.Location = new System.Drawing.Point(186, 14);
            this.txtTimMaPGH.Name = "txtTimMaPGH";
            this.txtTimMaPGH.Size = new System.Drawing.Size(155, 22);
            this.txtTimMaPGH.TabIndex = 28;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(353, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(92, 40);
            this.btnTimKiem.TabIndex = 17;
            this.btnTimKiem.Text = "Search";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(3, 16);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(177, 16);
            this.lblTimKiem.TabIndex = 11;
            this.lblTimKiem.Text = "Tìm thông tin bằng mã phiếu:";
            // 
            // dgvPhieuGH
            // 
            this.dgvPhieuGH.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPhieuGH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuGH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaPhieuGH,
            this.colMaDonDH,
            this.colNgayGH,
            this.colMaDC,
            this.colSoLuong,
            this.colDonGia});
            this.dgvPhieuGH.Location = new System.Drawing.Point(22, 243);
            this.dgvPhieuGH.Name = "dgvPhieuGH";
            this.dgvPhieuGH.RowHeadersWidth = 51;
            this.dgvPhieuGH.RowTemplate.Height = 24;
            this.dgvPhieuGH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuGH.Size = new System.Drawing.Size(784, 189);
            this.dgvPhieuGH.TabIndex = 35;
            this.dgvPhieuGH.Click += new System.EventHandler(this.dgvHDBanHang_Click);
            // 
            // colMaPhieuGH
            // 
            this.colMaPhieuGH.DataPropertyName = "MaPhieuGiaoHang";
            this.colMaPhieuGH.HeaderText = "Mã phiếu giao hàng";
            this.colMaPhieuGH.MinimumWidth = 6;
            this.colMaPhieuGH.Name = "colMaPhieuGH";
            this.colMaPhieuGH.Width = 125;
            // 
            // colMaDonDH
            // 
            this.colMaDonDH.DataPropertyName = "MaDonDatHang";
            this.colMaDonDH.HeaderText = "Mã đơn đặt hàng";
            this.colMaDonDH.MinimumWidth = 6;
            this.colMaDonDH.Name = "colMaDonDH";
            this.colMaDonDH.Width = 125;
            // 
            // colNgayGH
            // 
            this.colNgayGH.DataPropertyName = "NgayGiaoHang";
            this.colNgayGH.HeaderText = "Ngày giao hàng";
            this.colNgayGH.MinimumWidth = 6;
            this.colNgayGH.Name = "colNgayGH";
            this.colNgayGH.Width = 125;
            // 
            // colMaDC
            // 
            this.colMaDC.DataPropertyName = "MaDoChoi";
            this.colMaDC.HeaderText = "Mã đồ chơi";
            this.colMaDC.MinimumWidth = 6;
            this.colMaDC.Name = "colMaDC";
            this.colMaDC.Width = 125;
            // 
            // colSoLuong
            // 
            this.colSoLuong.DataPropertyName = "SoLuong";
            this.colSoLuong.HeaderText = "Số lượng";
            this.colSoLuong.MinimumWidth = 6;
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Width = 125;
            // 
            // colDonGia
            // 
            this.colDonGia.DataPropertyName = "DonGia";
            this.colDonGia.HeaderText = "Đơn giá";
            this.colDonGia.MinimumWidth = 6;
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.Width = 125;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnHuy);
            this.panel2.Controls.Add(this.btnXemDH);
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Location = new System.Drawing.Point(22, 457);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 63);
            this.panel2.TabIndex = 36;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(392, 11);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(92, 39);
            this.btnHuy.TabIndex = 18;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXemDH
            // 
            this.btnXemDH.Location = new System.Drawing.Point(490, 11);
            this.btnXemDH.Name = "btnXemDH";
            this.btnXemDH.Size = new System.Drawing.Size(170, 39);
            this.btnXemDH.TabIndex = 17;
            this.btnXemDH.Text = "Xem đơn đặt hàng";
            this.btnXemDH.UseVisualStyleBackColor = true;
            this.btnXemDH.Click += new System.EventHandler(this.btnXemDH_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(294, 11);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(92, 39);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(666, 11);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(118, 39);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Đóng";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(196, 11);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(92, 39);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(98, 11);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(92, 39);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(0, 11);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(92, 39);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmPhieuGiaoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 541);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvPhieuGH);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblHoaDon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPhieuGiaoHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu giao hàng";
            this.Load += new System.EventHandler(this.frmPhieuGiaoHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuGH)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHoaDon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboMaDDH;
        private System.Windows.Forms.Label lblMaDC;
        private System.Windows.Forms.TextBox txtMaPhieuGH;
        private System.Windows.Forms.Label lblMaPhieuGH;
        private System.Windows.Forms.Label lblNgayGiao;
        private System.Windows.Forms.Label lblMaDDH;
        private System.Windows.Forms.ComboBox cboMaDC;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTimMaPGH;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.DataGridView dgvPhieuGH;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXemDH;
        private System.Windows.Forms.DateTimePicker dtpNgayGiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhieuGH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDonDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayGH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.Button btnHuy;
    }
}