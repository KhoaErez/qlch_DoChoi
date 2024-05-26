namespace QuanLiBanHang
{
    partial class frmTKDoChoiBanChay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTKDoChoiBanChay));
            this.dgvTKDoanhSo = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.colMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaDoChoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDGB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKDoanhSo)).BeginInit();
            this.SuspendLayout();
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
            this.dgvTKDoanhSo.Location = new System.Drawing.Point(41, 104);
            this.dgvTKDoanhSo.Name = "dgvTKDoanhSo";
            this.dgvTKDoanhSo.RowHeadersWidth = 51;
            this.dgvTKDoanhSo.RowTemplate.Height = 24;
            this.dgvTKDoanhSo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTKDoanhSo.Size = new System.Drawing.Size(712, 188);
            this.dgvTKDoanhSo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CadetBlue;
            this.label2.Location = new System.Drawing.Point(170, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(469, 42);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thống kê đồ chơi bán chạy";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.CadetBlue;
            this.button2.Location = new System.Drawing.Point(506, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 39);
            this.button2.TabIndex = 7;
            this.button2.Text = "Xuất fille excel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.CadetBlue;
            this.button1.Location = new System.Drawing.Point(663, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // frmTKDoChoiBanChay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(791, 379);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvTKDoanhSo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTKDoChoiBanChay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê đồ chơi bán chạy";
            this.Load += new System.EventHandler(this.frmTKDoChoiBanChay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKDoanhSo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTKDoanhSo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDoChoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDGB;
    }
}