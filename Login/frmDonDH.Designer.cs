namespace QuanLiBanHang
{
    partial class frmDonDH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDonDH));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpNgayDH = new System.Windows.Forms.DateTimePicker();
            this.cboMaNCC = new System.Windows.Forms.ComboBox();
            this.lblMaNCC = new System.Windows.Forms.Label();
            this.txtMaDDH = new System.Windows.Forms.TextBox();
            this.lblMaDonDH = new System.Windows.Forms.Label();
            this.lblNgayDH = new System.Windows.Forms.Label();
            this.lblThongTinChung = new System.Windows.Forms.Label();
            this.lblDonDH = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.cboMaDC = new System.Windows.Forms.ComboBox();
            this.lblMaDC = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDonDH = new System.Windows.Forms.DataGridView();
            this.colMaDonDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaDC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayDatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNhaCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnGuiDon = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonDH)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpNgayDH);
            this.panel1.Controls.Add(this.cboMaNCC);
            this.panel1.Controls.Add(this.lblMaNCC);
            this.panel1.Controls.Add(this.txtMaDDH);
            this.panel1.Controls.Add(this.lblMaDonDH);
            this.panel1.Controls.Add(this.lblNgayDH);
            this.panel1.Location = new System.Drawing.Point(22, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 128);
            this.panel1.TabIndex = 22;
            // 
            // dtpNgayDH
            // 
            this.dtpNgayDH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDH.Location = new System.Drawing.Point(152, 57);
            this.dtpNgayDH.Name = "dtpNgayDH";
            this.dtpNgayDH.Size = new System.Drawing.Size(154, 22);
            this.dtpNgayDH.TabIndex = 21;
            // 
            // cboMaNCC
            // 
            this.cboMaNCC.FormattingEnabled = true;
            this.cboMaNCC.Location = new System.Drawing.Point(151, 86);
            this.cboMaNCC.Name = "cboMaNCC";
            this.cboMaNCC.Size = new System.Drawing.Size(155, 24);
            this.cboMaNCC.TabIndex = 20;
            // 
            // lblMaNCC
            // 
            this.lblMaNCC.AutoSize = true;
            this.lblMaNCC.Location = new System.Drawing.Point(24, 90);
            this.lblMaNCC.Name = "lblMaNCC";
            this.lblMaNCC.Size = new System.Drawing.Size(112, 16);
            this.lblMaNCC.TabIndex = 10;
            this.lblMaNCC.Text = "Mã nhà cung cấp:";
            // 
            // txtMaDDH
            // 
            this.txtMaDDH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaDDH.Location = new System.Drawing.Point(151, 19);
            this.txtMaDDH.Name = "txtMaDDH";
            this.txtMaDDH.Size = new System.Drawing.Size(155, 22);
            this.txtMaDDH.TabIndex = 5;
            // 
            // lblMaDonDH
            // 
            this.lblMaDonDH.AutoSize = true;
            this.lblMaDonDH.Location = new System.Drawing.Point(24, 21);
            this.lblMaDonDH.Name = "lblMaDonDH";
            this.lblMaDonDH.Size = new System.Drawing.Size(110, 16);
            this.lblMaDonDH.TabIndex = 3;
            this.lblMaDonDH.Text = "Mã đơn đặt hàng:";
            // 
            // lblNgayDH
            // 
            this.lblNgayDH.AutoSize = true;
            this.lblNgayDH.Location = new System.Drawing.Point(24, 57);
            this.lblNgayDH.Name = "lblNgayDH";
            this.lblNgayDH.Size = new System.Drawing.Size(98, 16);
            this.lblNgayDH.TabIndex = 1;
            this.lblNgayDH.Text = "Ngày đặt hàng:";
            // 
            // lblThongTinChung
            // 
            this.lblThongTinChung.AutoSize = true;
            this.lblThongTinChung.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinChung.Location = new System.Drawing.Point(17, 58);
            this.lblThongTinChung.Name = "lblThongTinChung";
            this.lblThongTinChung.Size = new System.Drawing.Size(185, 29);
            this.lblThongTinChung.TabIndex = 23;
            this.lblThongTinChung.Text = "Thông tin chung";
            // 
            // lblDonDH
            // 
            this.lblDonDH.AutoSize = true;
            this.lblDonDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonDH.ForeColor = System.Drawing.Color.Blue;
            this.lblDonDH.Location = new System.Drawing.Point(222, 29);
            this.lblDonDH.Name = "lblDonDH";
            this.lblDonDH.Size = new System.Drawing.Size(207, 29);
            this.lblDonDH.TabIndex = 24;
            this.lblDonDH.Text = "ĐƠN ĐẶT HÀNG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 29);
            this.label1.TabIndex = 25;
            this.label1.Text = "Thông tin các đồ chơi";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtSoLuong);
            this.panel2.Controls.Add(this.cboMaDC);
            this.panel2.Controls.Add(this.lblMaDC);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(22, 253);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 51);
            this.panel2.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 24;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoLuong.Location = new System.Drawing.Point(438, 12);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(155, 22);
            this.txtSoLuong.TabIndex = 21;
            // 
            // cboMaDC
            // 
            this.cboMaDC.FormattingEnabled = true;
            this.cboMaDC.Location = new System.Drawing.Point(85, 12);
            this.cboMaDC.Name = "cboMaDC";
            this.cboMaDC.Size = new System.Drawing.Size(155, 24);
            this.cboMaDC.TabIndex = 20;
            // 
            // lblMaDC
            // 
            this.lblMaDC.AutoSize = true;
            this.lblMaDC.Location = new System.Drawing.Point(3, 15);
            this.lblMaDC.Name = "lblMaDC";
            this.lblMaDC.Size = new System.Drawing.Size(76, 16);
            this.lblMaDC.TabIndex = 3;
            this.lblMaDC.Text = "Mã đồ chơi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số lượng đặt:";
            // 
            // dgvDonDH
            // 
            this.dgvDonDH.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDonDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonDH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDonDH,
            this.colMaDC,
            this.colSoLuong,
            this.colNgayDatHang,
            this.colMaNhaCC});
            this.dgvDonDH.Location = new System.Drawing.Point(19, 307);
            this.dgvDonDH.Name = "dgvDonDH";
            this.dgvDonDH.RowHeadersWidth = 51;
            this.dgvDonDH.RowTemplate.Height = 24;
            this.dgvDonDH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDonDH.Size = new System.Drawing.Size(599, 205);
            this.dgvDonDH.TabIndex = 26;
            this.dgvDonDH.Click += new System.EventHandler(this.dgvDonDH_Click);
            // 
            // colMaDonDH
            // 
            this.colMaDonDH.DataPropertyName = "MaDonDatHang";
            this.colMaDonDH.HeaderText = "Mã đơn đặt hàng";
            this.colMaDonDH.MinimumWidth = 6;
            this.colMaDonDH.Name = "colMaDonDH";
            this.colMaDonDH.Width = 125;
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
            // colNgayDatHang
            // 
            this.colNgayDatHang.DataPropertyName = "NgayDatHang";
            this.colNgayDatHang.HeaderText = "Ngày đặt hàng";
            this.colNgayDatHang.MinimumWidth = 6;
            this.colNgayDatHang.Name = "colNgayDatHang";
            this.colNgayDatHang.Width = 125;
            // 
            // colMaNhaCC
            // 
            this.colMaNhaCC.DataPropertyName = "MaNhaCungCap";
            this.colMaNhaCC.HeaderText = "Mã nhà cung cấp";
            this.colMaNhaCC.MinimumWidth = 6;
            this.colMaNhaCC.Name = "colMaNhaCC";
            this.colMaNhaCC.Width = 125;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnHuy);
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Controls.Add(this.btnGuiDon);
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.btnLuu);
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Location = new System.Drawing.Point(19, 518);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(599, 42);
            this.panel3.TabIndex = 40;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(329, 3);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(78, 34);
            this.btnHuy.TabIndex = 44;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(500, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 34);
            this.btnExit.TabIndex = 42;
            this.btnExit.Text = "Đóng";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(81, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(78, 34);
            this.btnSua.TabIndex = 43;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnGuiDon
            // 
            this.btnGuiDon.Location = new System.Drawing.Point(413, 3);
            this.btnGuiDon.Name = "btnGuiDon";
            this.btnGuiDon.Size = new System.Drawing.Size(81, 34);
            this.btnGuiDon.TabIndex = 41;
            this.btnGuiDon.Text = "Gửi đơn";
            this.btnGuiDon.UseVisualStyleBackColor = true;
            this.btnGuiDon.Click += new System.EventHandler(this.btnGuiDon_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(165, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(78, 34);
            this.btnXoa.TabIndex = 40;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(249, 3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(78, 34);
            this.btnLuu.TabIndex = 39;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(0, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 34);
            this.btnThem.TabIndex = 38;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmDonDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 572);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvDonDH);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDonDH);
            this.Controls.Add(this.lblThongTinChung);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDonDH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đơn đặt hàng";
            this.Load += new System.EventHandler(this.frmDonDH_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonDH)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMaNCC;
        private System.Windows.Forms.TextBox txtMaDDH;
        private System.Windows.Forms.Label lblMaDonDH;
        private System.Windows.Forms.Label lblNgayDH;
        private System.Windows.Forms.ComboBox cboMaNCC;
        private System.Windows.Forms.Label lblThongTinChung;
        private System.Windows.Forms.Label lblDonDH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.ComboBox cboMaDC;
        private System.Windows.Forms.Label lblMaDC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDonDH;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnGuiDon;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DateTimePicker dtpNgayDH;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDonDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayDatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNhaCC;
    }
}