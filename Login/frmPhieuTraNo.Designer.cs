namespace QuanLiBanHang
{
    partial class frmPhieuTraNo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuTraNo));
            this.lblPhieuGhiNo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.dgvPhieuTraNo = new System.Windows.Forms.DataGridView();
            this.maPhieuTraNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTienTraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayTraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHoaDonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phieuTraNoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLiDoChoiDataSet1 = new QuanLiBanHang.QuanLiDoChoiDataSet1();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.cboMaHD = new System.Windows.Forms.ComboBox();
            this.txtSoTienTra = new System.Windows.Forms.TextBox();
            this.txtMaPhieuGN = new System.Windows.Forms.TextBox();
            this.lblSoTienTra = new System.Windows.Forms.Label();
            this.lblMaPhieuGN = new System.Windows.Forms.Label();
            this.lblNgayTra = new System.Windows.Forms.Label();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.phieuTraNoTableAdapter = new QuanLiBanHang.QuanLiDoChoiDataSet1TableAdapters.PhieuTraNoTableAdapter();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuTraNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuTraNoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiDoChoiDataSet1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPhieuGhiNo
            // 
            this.lblPhieuGhiNo.AutoSize = true;
            this.lblPhieuGhiNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhieuGhiNo.ForeColor = System.Drawing.Color.Blue;
            this.lblPhieuGhiNo.Location = new System.Drawing.Point(253, 24);
            this.lblPhieuGhiNo.Name = "lblPhieuGhiNo";
            this.lblPhieuGhiNo.Size = new System.Drawing.Size(194, 29);
            this.lblPhieuGhiNo.TabIndex = 25;
            this.lblPhieuGhiNo.Text = "PHIẾU TRẢ NỢ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtTimKiem);
            this.panel3.Controls.Add(this.btnTimKiem);
            this.panel3.Controls.Add(this.lblTimKiem);
            this.panel3.Location = new System.Drawing.Point(29, 167);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(459, 47);
            this.panel3.TabIndex = 33;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimKiem.Location = new System.Drawing.Point(186, 14);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(155, 22);
            this.txtTimKiem.TabIndex = 28;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
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
            // dgvPhieuTraNo
            // 
            this.dgvPhieuTraNo.AutoGenerateColumns = false;
            this.dgvPhieuTraNo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPhieuTraNo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuTraNo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhieuTraNoDataGridViewTextBoxColumn,
            this.soTienTraDataGridViewTextBoxColumn,
            this.ngayTraDataGridViewTextBoxColumn,
            this.maHoaDonDataGridViewTextBoxColumn});
            this.dgvPhieuTraNo.DataSource = this.phieuTraNoBindingSource;
            this.dgvPhieuTraNo.Location = new System.Drawing.Point(29, 220);
            this.dgvPhieuTraNo.Name = "dgvPhieuTraNo";
            this.dgvPhieuTraNo.RowHeadersWidth = 51;
            this.dgvPhieuTraNo.RowTemplate.Height = 24;
            this.dgvPhieuTraNo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuTraNo.Size = new System.Drawing.Size(656, 172);
            this.dgvPhieuTraNo.TabIndex = 30;
            this.dgvPhieuTraNo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuTraNo_CellContentClick);
            // 
            // maPhieuTraNoDataGridViewTextBoxColumn
            // 
            this.maPhieuTraNoDataGridViewTextBoxColumn.DataPropertyName = "MaPhieuTraNo";
            this.maPhieuTraNoDataGridViewTextBoxColumn.HeaderText = "Mã phiếu trả nợ";
            this.maPhieuTraNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maPhieuTraNoDataGridViewTextBoxColumn.Name = "maPhieuTraNoDataGridViewTextBoxColumn";
            this.maPhieuTraNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // soTienTraDataGridViewTextBoxColumn
            // 
            this.soTienTraDataGridViewTextBoxColumn.DataPropertyName = "SoTienTra";
            this.soTienTraDataGridViewTextBoxColumn.HeaderText = "Số tiền trả";
            this.soTienTraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soTienTraDataGridViewTextBoxColumn.Name = "soTienTraDataGridViewTextBoxColumn";
            this.soTienTraDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayTraDataGridViewTextBoxColumn
            // 
            this.ngayTraDataGridViewTextBoxColumn.DataPropertyName = "NgayTra";
            this.ngayTraDataGridViewTextBoxColumn.HeaderText = "Ngày trả";
            this.ngayTraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayTraDataGridViewTextBoxColumn.Name = "ngayTraDataGridViewTextBoxColumn";
            this.ngayTraDataGridViewTextBoxColumn.Width = 125;
            // 
            // maHoaDonDataGridViewTextBoxColumn
            // 
            this.maHoaDonDataGridViewTextBoxColumn.DataPropertyName = "MaHoaDon";
            this.maHoaDonDataGridViewTextBoxColumn.HeaderText = "Mã hóa đơn";
            this.maHoaDonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maHoaDonDataGridViewTextBoxColumn.Name = "maHoaDonDataGridViewTextBoxColumn";
            this.maHoaDonDataGridViewTextBoxColumn.Width = 125;
            // 
            // phieuTraNoBindingSource
            // 
            this.phieuTraNoBindingSource.DataMember = "PhieuTraNo";
            this.phieuTraNoBindingSource.DataSource = this.quanLiDoChoiDataSet1;
            // 
            // quanLiDoChoiDataSet1
            // 
            this.quanLiDoChoiDataSet1.DataSetName = "QuanLiDoChoiDataSet1";
            this.quanLiDoChoiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Location = new System.Drawing.Point(29, 398);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(656, 63);
            this.panel2.TabIndex = 32;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(407, 11);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(92, 40);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(533, 11);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 40);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Đóng";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(280, 11);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(92, 40);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(150, 11);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(92, 40);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(27, 11);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(92, 40);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpNgayTra);
            this.panel1.Controls.Add(this.cboMaHD);
            this.panel1.Controls.Add(this.txtSoTienTra);
            this.panel1.Controls.Add(this.txtMaPhieuGN);
            this.panel1.Controls.Add(this.lblSoTienTra);
            this.panel1.Controls.Add(this.lblMaPhieuGN);
            this.panel1.Controls.Add(this.lblNgayTra);
            this.panel1.Controls.Add(this.lblMaHD);
            this.panel1.Location = new System.Drawing.Point(29, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 95);
            this.panel1.TabIndex = 31;
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTra.Location = new System.Drawing.Point(138, 55);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(153, 22);
            this.dtpNgayTra.TabIndex = 11;
            // 
            // cboMaHD
            // 
            this.cboMaHD.FormattingEnabled = true;
            this.cboMaHD.Location = new System.Drawing.Point(460, 18);
            this.cboMaHD.Name = "cboMaHD";
            this.cboMaHD.Size = new System.Drawing.Size(166, 24);
            this.cboMaHD.TabIndex = 10;
            // 
            // txtSoTienTra
            // 
            this.txtSoTienTra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoTienTra.Location = new System.Drawing.Point(460, 55);
            this.txtSoTienTra.Name = "txtSoTienTra";
            this.txtSoTienTra.Size = new System.Drawing.Size(166, 22);
            this.txtSoTienTra.TabIndex = 9;
            // 
            // txtMaPhieuGN
            // 
            this.txtMaPhieuGN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaPhieuGN.Location = new System.Drawing.Point(138, 19);
            this.txtMaPhieuGN.Name = "txtMaPhieuGN";
            this.txtMaPhieuGN.Size = new System.Drawing.Size(155, 22);
            this.txtMaPhieuGN.TabIndex = 5;
            // 
            // lblSoTienTra
            // 
            this.lblSoTienTra.AutoSize = true;
            this.lblSoTienTra.Location = new System.Drawing.Point(371, 61);
            this.lblSoTienTra.Name = "lblSoTienTra";
            this.lblSoTienTra.Size = new System.Drawing.Size(69, 16);
            this.lblSoTienTra.TabIndex = 4;
            this.lblSoTienTra.Text = "Số tiền trả:";
            // 
            // lblMaPhieuGN
            // 
            this.lblMaPhieuGN.AutoSize = true;
            this.lblMaPhieuGN.Location = new System.Drawing.Point(24, 21);
            this.lblMaPhieuGN.Name = "lblMaPhieuGN";
            this.lblMaPhieuGN.Size = new System.Drawing.Size(104, 16);
            this.lblMaPhieuGN.TabIndex = 3;
            this.lblMaPhieuGN.Text = "Mã phiếu ghi nợ:";
            // 
            // lblNgayTra
            // 
            this.lblNgayTra.AutoSize = true;
            this.lblNgayTra.Location = new System.Drawing.Point(24, 60);
            this.lblNgayTra.Name = "lblNgayTra";
            this.lblNgayTra.Size = new System.Drawing.Size(61, 16);
            this.lblNgayTra.TabIndex = 2;
            this.lblNgayTra.Text = "Ngày trả:";
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Location = new System.Drawing.Point(371, 21);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(81, 16);
            this.lblMaHD.TabIndex = 1;
            this.lblMaHD.Text = "Mã hóa đơn:";
            // 
            // phieuTraNoTableAdapter
            // 
            this.phieuTraNoTableAdapter.ClearBeforeFill = true;
            // 
            // frmPhieuTraNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 483);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvPhieuTraNo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPhieuGhiNo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPhieuTraNo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu trả nợ";
            this.Load += new System.EventHandler(this.frmPhieuTraNo_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuTraNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuTraNoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiDoChoiDataSet1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPhieuGhiNo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.DataGridView dgvPhieuTraNo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboMaHD;
        private System.Windows.Forms.TextBox txtSoTienTra;
        private System.Windows.Forms.TextBox txtMaPhieuGN;
        private System.Windows.Forms.Label lblSoTienTra;
        private System.Windows.Forms.Label lblMaPhieuGN;
        private System.Windows.Forms.Label lblNgayTra;
        private System.Windows.Forms.Label lblMaHD;
        private QuanLiDoChoiDataSet1 quanLiDoChoiDataSet1;
        private System.Windows.Forms.BindingSource phieuTraNoBindingSource;
        private QuanLiDoChoiDataSet1TableAdapters.PhieuTraNoTableAdapter phieuTraNoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhieuTraNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTienTraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayTraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHoaDonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
    }
}