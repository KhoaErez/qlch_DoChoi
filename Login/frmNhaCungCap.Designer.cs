namespace QuanLiBanHang
{
    partial class frmNhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhaCungCap));
            this.lblNhaCungCap = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mtbDienThoai = new System.Windows.Forms.MaskedTextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenNhaCC = new System.Windows.Forms.TextBox();
            this.txtMaNhaCC = new System.Windows.Forms.TextBox();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.lblMaNCC = new System.Windows.Forms.Label();
            this.lblTenNhaCC = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.dgvNhaCC = new System.Windows.Forms.DataGridView();
            this.colMaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNameNhaCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaCC)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNhaCungCap
            // 
            this.lblNhaCungCap.AutoSize = true;
            this.lblNhaCungCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhaCungCap.ForeColor = System.Drawing.Color.Blue;
            this.lblNhaCungCap.Location = new System.Drawing.Point(223, 20);
            this.lblNhaCungCap.Name = "lblNhaCungCap";
            this.lblNhaCungCap.Size = new System.Drawing.Size(347, 29);
            this.lblNhaCungCap.TabIndex = 2;
            this.lblNhaCungCap.Text = "DANH MỤC NHÀ CUNG CẤP";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnHuy);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Location = new System.Drawing.Point(33, 375);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(745, 63);
            this.panel2.TabIndex = 19;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(392, 11);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(92, 39);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(641, 11);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 39);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Đóng";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(132, 11);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(92, 39);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(265, 11);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(92, 39);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(515, 11);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(92, 39);
            this.btnHuy.TabIndex = 12;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(7, 11);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(92, 39);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mtbDienThoai);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.txtTenNhaCC);
            this.panel1.Controls.Add(this.txtMaNhaCC);
            this.panel1.Controls.Add(this.lblDienThoai);
            this.panel1.Controls.Add(this.lblMaNCC);
            this.panel1.Controls.Add(this.lblTenNhaCC);
            this.panel1.Controls.Add(this.lblDiaChi);
            this.panel1.Location = new System.Drawing.Point(33, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 108);
            this.panel1.TabIndex = 20;
            // 
            // mtbDienThoai
            // 
            this.mtbDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbDienThoai.Location = new System.Drawing.Point(495, 59);
            this.mtbDienThoai.Name = "mtbDienThoai";
            this.mtbDienThoai.Size = new System.Drawing.Size(223, 22);
            this.mtbDienThoai.TabIndex = 9;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiaChi.Location = new System.Drawing.Point(495, 15);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(223, 22);
            this.txtDiaChi.TabIndex = 8;
            // 
            // txtTenNhaCC
            // 
            this.txtTenNhaCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenNhaCC.Location = new System.Drawing.Point(151, 59);
            this.txtTenNhaCC.Name = "txtTenNhaCC";
            this.txtTenNhaCC.Size = new System.Drawing.Size(226, 22);
            this.txtTenNhaCC.TabIndex = 7;
            // 
            // txtMaNhaCC
            // 
            this.txtMaNhaCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaNhaCC.Location = new System.Drawing.Point(151, 19);
            this.txtMaNhaCC.Name = "txtMaNhaCC";
            this.txtMaNhaCC.Size = new System.Drawing.Size(155, 22);
            this.txtMaNhaCC.TabIndex = 5;
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Location = new System.Drawing.Point(415, 61);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(69, 16);
            this.lblDienThoai.TabIndex = 4;
            this.lblDienThoai.Text = "Điện thoại:";
            // 
            // lblMaNCC
            // 
            this.lblMaNCC.AutoSize = true;
            this.lblMaNCC.Location = new System.Drawing.Point(24, 21);
            this.lblMaNCC.Name = "lblMaNCC";
            this.lblMaNCC.Size = new System.Drawing.Size(112, 16);
            this.lblMaNCC.TabIndex = 3;
            this.lblMaNCC.Text = "Mã nhà cung cấp:";
            // 
            // lblTenNhaCC
            // 
            this.lblTenNhaCC.AutoSize = true;
            this.lblTenNhaCC.Location = new System.Drawing.Point(24, 61);
            this.lblTenNhaCC.Name = "lblTenNhaCC";
            this.lblTenNhaCC.Size = new System.Drawing.Size(117, 16);
            this.lblTenNhaCC.TabIndex = 2;
            this.lblTenNhaCC.Text = "Tên nhà cung cấp:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(415, 21);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(50, 16);
            this.lblDiaChi.TabIndex = 1;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // dgvNhaCC
            // 
            this.dgvNhaCC.AllowUserToAddRows = false;
            this.dgvNhaCC.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvNhaCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhaCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNCC,
            this.colNameNhaCC,
            this.colAddress,
            this.colDienThoai});
            this.dgvNhaCC.Location = new System.Drawing.Point(33, 183);
            this.dgvNhaCC.Name = "dgvNhaCC";
            this.dgvNhaCC.ReadOnly = true;
            this.dgvNhaCC.RowHeadersWidth = 51;
            this.dgvNhaCC.RowTemplate.Height = 24;
            this.dgvNhaCC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhaCC.Size = new System.Drawing.Size(745, 176);
            this.dgvNhaCC.TabIndex = 21;
            this.dgvNhaCC.Click += new System.EventHandler(this.dgvNhaCC_Click);
            // 
            // colMaNCC
            // 
            this.colMaNCC.DataPropertyName = "MaNhaCungCap";
            this.colMaNCC.HeaderText = "Mã nhà cung cấp";
            this.colMaNCC.MinimumWidth = 6;
            this.colMaNCC.Name = "colMaNCC";
            this.colMaNCC.ReadOnly = true;
            this.colMaNCC.Width = 150;
            // 
            // colNameNhaCC
            // 
            this.colNameNhaCC.DataPropertyName = "TenNhaCungCap";
            this.colNameNhaCC.HeaderText = "Tên nhà cung cấp";
            this.colNameNhaCC.MinimumWidth = 6;
            this.colNameNhaCC.Name = "colNameNhaCC";
            this.colNameNhaCC.ReadOnly = true;
            this.colNameNhaCC.Width = 170;
            // 
            // colAddress
            // 
            this.colAddress.DataPropertyName = "DiaChi";
            this.colAddress.HeaderText = "Địa chỉ nhà cung cấp";
            this.colAddress.MinimumWidth = 6;
            this.colAddress.Name = "colAddress";
            this.colAddress.ReadOnly = true;
            this.colAddress.Width = 220;
            // 
            // colDienThoai
            // 
            this.colDienThoai.DataPropertyName = "SoDienThoai";
            this.colDienThoai.HeaderText = "Số điện thoại";
            this.colDienThoai.MinimumWidth = 6;
            this.colDienThoai.Name = "colDienThoai";
            this.colDienThoai.ReadOnly = true;
            this.colDienThoai.Width = 150;
            // 
            // frmNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.dgvNhaCC);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblNhaCungCap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNhaCungCap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục nhà cung cấp";
            this.Load += new System.EventHandler(this.frmNhaCungCap_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNhaCungCap;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox mtbDienThoai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenNhaCC;
        private System.Windows.Forms.TextBox txtMaNhaCC;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.Label lblMaNCC;
        private System.Windows.Forms.Label lblTenNhaCC;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.DataGridView dgvNhaCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNameNhaCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDienThoai;
    }
}