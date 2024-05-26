namespace QuanLiBanHang
{
    partial class frmThongKeDoanhSo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKeDoanhSo));
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTKDoanhSo = new System.Windows.Forms.DataGridView();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.colMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaDoChoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDGB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKDoanhSo)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CadetBlue;
            this.label2.Location = new System.Drawing.Point(219, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thống kê doanh số";
            // 
            // dgvTKDoanhSo
            // 
            this.dgvTKDoanhSo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTKDoanhSo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKDoanhSo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHD,
            this.colMaDoChoi,
            this.colSL,
            this.colDGB});
            this.dgvTKDoanhSo.Location = new System.Drawing.Point(32, 96);
            this.dgvTKDoanhSo.Name = "dgvTKDoanhSo";
            this.dgvTKDoanhSo.RowHeadersWidth = 51;
            this.dgvTKDoanhSo.RowTemplate.Height = 24;
            this.dgvTKDoanhSo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTKDoanhSo.Size = new System.Drawing.Size(712, 150);
            this.dgvTKDoanhSo.TabIndex = 2;
            // 
            // txtTongTien
            // 
            this.txtTongTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.ForeColor = System.Drawing.Color.Red;
            this.txtTongTien.Location = new System.Drawing.Point(149, 285);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(299, 30);
            this.txtTongTien.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CadetBlue;
            this.label1.Location = new System.Drawing.Point(27, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tổng tiền:";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnThoat.Location = new System.Drawing.Point(654, 280);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(90, 39);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // colMaHD
            // 
            this.colMaHD.DataPropertyName = "MaHoaDon";
            this.colMaHD.HeaderText = "Mã hóa đơn";
            this.colMaHD.MinimumWidth = 6;
            this.colMaHD.Name = "colMaHD";
            this.colMaHD.Width = 125;
            // 
            // colMaDoChoi
            // 
            this.colMaDoChoi.DataPropertyName = "MaDoChoi";
            this.colMaDoChoi.HeaderText = "Mã đồ chơi";
            this.colMaDoChoi.MinimumWidth = 6;
            this.colMaDoChoi.Name = "colMaDoChoi";
            this.colMaDoChoi.Width = 125;
            // 
            // colSL
            // 
            this.colSL.DataPropertyName = "SoLuong";
            this.colSL.HeaderText = "Số lượng mua";
            this.colSL.MinimumWidth = 6;
            this.colSL.Name = "colSL";
            this.colSL.Width = 125;
            // 
            // colDGB
            // 
            this.colDGB.DataPropertyName = "Gia";
            this.colDGB.HeaderText = "Đơn giá bán";
            this.colDGB.MinimumWidth = 6;
            this.colDGB.Name = "colDGB";
            this.colDGB.Width = 125;
            // 
            // frmThongKeDoanhSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(771, 348);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.dgvTKDoanhSo);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmThongKeDoanhSo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê doanh số";
            this.Load += new System.EventHandler(this.frmThongKeDoanhSo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKDoanhSo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTKDoanhSo;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDoChoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDGB;
    }
}