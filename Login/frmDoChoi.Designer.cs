namespace QuanLiBanHang
{
    partial class frmDoChoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoChoi));
            this.lblDoChoi = new System.Windows.Forms.Label();
            this.lblMaDC = new System.Windows.Forms.Label();
            this.lblTenDC = new System.Windows.Forms.Label();
            this.lblMaLoaiDC = new System.Windows.Forms.Label();
            this.txtMaDC = new System.Windows.Forms.TextBox();
            this.txtTenDC = new System.Windows.Forms.TextBox();
            this.cboMaLoaiDC = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvDoChoi = new System.Windows.Forms.DataGridView();
            this.colMaDC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaLoaiDC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoChoi)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDoChoi
            // 
            this.lblDoChoi.AutoSize = true;
            this.lblDoChoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoChoi.ForeColor = System.Drawing.Color.Blue;
            this.lblDoChoi.Location = new System.Drawing.Point(289, 21);
            this.lblDoChoi.Name = "lblDoChoi";
            this.lblDoChoi.Size = new System.Drawing.Size(263, 29);
            this.lblDoChoi.TabIndex = 4;
            this.lblDoChoi.Text = "DANH MỤC ĐỒ CHƠI";
            // 
            // lblMaDC
            // 
            this.lblMaDC.AutoSize = true;
            this.lblMaDC.Location = new System.Drawing.Point(-3, 28);
            this.lblMaDC.Name = "lblMaDC";
            this.lblMaDC.Size = new System.Drawing.Size(76, 16);
            this.lblMaDC.TabIndex = 5;
            this.lblMaDC.Text = "Mã đồ chơi:";
            // 
            // lblTenDC
            // 
            this.lblTenDC.AutoSize = true;
            this.lblTenDC.Location = new System.Drawing.Point(-3, 61);
            this.lblTenDC.Name = "lblTenDC";
            this.lblTenDC.Size = new System.Drawing.Size(81, 16);
            this.lblTenDC.TabIndex = 6;
            this.lblTenDC.Text = "Tên đồ chơi:";
            // 
            // lblMaLoaiDC
            // 
            this.lblMaLoaiDC.AutoSize = true;
            this.lblMaLoaiDC.Location = new System.Drawing.Point(406, 28);
            this.lblMaLoaiDC.Name = "lblMaLoaiDC";
            this.lblMaLoaiDC.Size = new System.Drawing.Size(101, 16);
            this.lblMaLoaiDC.TabIndex = 12;
            this.lblMaLoaiDC.Text = "Mã loại đồ chơi:";
            // 
            // txtMaDC
            // 
            this.txtMaDC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaDC.Location = new System.Drawing.Point(95, 26);
            this.txtMaDC.Name = "txtMaDC";
            this.txtMaDC.Size = new System.Drawing.Size(177, 22);
            this.txtMaDC.TabIndex = 13;
            // 
            // txtTenDC
            // 
            this.txtTenDC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenDC.Location = new System.Drawing.Point(95, 59);
            this.txtTenDC.Name = "txtTenDC";
            this.txtTenDC.Size = new System.Drawing.Size(177, 22);
            this.txtTenDC.TabIndex = 14;
            // 
            // cboMaLoaiDC
            // 
            this.cboMaLoaiDC.FormattingEnabled = true;
            this.cboMaLoaiDC.Location = new System.Drawing.Point(539, 25);
            this.cboMaLoaiDC.Name = "cboMaLoaiDC";
            this.cboMaLoaiDC.Size = new System.Drawing.Size(177, 24);
            this.cboMaLoaiDC.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLuu);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnHuy);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Location = new System.Drawing.Point(27, 381);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(717, 63);
            this.panel2.TabIndex = 23;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(374, 11);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(92, 39);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(624, 11);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 39);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Đóng";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(122, 11);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(92, 39);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(249, 11);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(92, 39);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(499, 11);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(92, 39);
            this.btnHuy.TabIndex = 12;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
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
            // dgvDoChoi
            // 
            this.dgvDoChoi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDoChoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoChoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDC,
            this.colTenDC,
            this.colMaLoaiDC});
            this.dgvDoChoi.Location = new System.Drawing.Point(27, 169);
            this.dgvDoChoi.Name = "dgvDoChoi";
            this.dgvDoChoi.RowHeadersWidth = 51;
            this.dgvDoChoi.RowTemplate.Height = 24;
            this.dgvDoChoi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoChoi.Size = new System.Drawing.Size(717, 206);
            this.dgvDoChoi.TabIndex = 24;
            this.dgvDoChoi.Click += new System.EventHandler(this.dgvDoChoi_Click);
            // 
            // colMaDC
            // 
            this.colMaDC.DataPropertyName = "MaDoChoi";
            this.colMaDC.HeaderText = "Mã đồ chơi";
            this.colMaDC.MinimumWidth = 6;
            this.colMaDC.Name = "colMaDC";
            this.colMaDC.Width = 160;
            // 
            // colTenDC
            // 
            this.colTenDC.DataPropertyName = "TenDoChoi";
            this.colTenDC.HeaderText = "Tên đồ chơi";
            this.colTenDC.MinimumWidth = 6;
            this.colTenDC.Name = "colTenDC";
            this.colTenDC.Width = 160;
            // 
            // colMaLoaiDC
            // 
            this.colMaLoaiDC.DataPropertyName = "MaLoaiDoChoi";
            this.colMaLoaiDC.HeaderText = "Mã loại đồ chơi";
            this.colMaLoaiDC.MinimumWidth = 6;
            this.colMaLoaiDC.Name = "colMaLoaiDC";
            this.colMaLoaiDC.Width = 160;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTenDC);
            this.panel1.Controls.Add(this.txtMaDC);
            this.panel1.Controls.Add(this.lblMaLoaiDC);
            this.panel1.Controls.Add(this.lblTenDC);
            this.panel1.Controls.Add(this.cboMaLoaiDC);
            this.panel1.Controls.Add(this.lblMaDC);
            this.panel1.Location = new System.Drawing.Point(27, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 98);
            this.panel1.TabIndex = 25;
            // 
            // frmDoChoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDoChoi);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblDoChoi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDoChoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục đồ chơi";
            this.Load += new System.EventHandler(this.frmDoChoi_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoChoi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDoChoi;
        private System.Windows.Forms.Label lblMaDC;
        private System.Windows.Forms.Label lblTenDC;
        private System.Windows.Forms.Label lblMaLoaiDC;
        private System.Windows.Forms.TextBox txtMaDC;
        private System.Windows.Forms.TextBox txtTenDC;
        private System.Windows.Forms.ComboBox cboMaLoaiDC;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvDoChoi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLoaiDC;
    }
}