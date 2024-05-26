namespace QuanLiBanHang
{
    partial class frmTimKiemHD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimKiemHD));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.lbLMaKH = new System.Windows.Forms.Label();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.maHoaDonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayHoaDonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKhachHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLiDoChoiDataSet2 = new QuanLiBanHang.QuanLiDoChoiDataSet2();
            this.btnDong = new System.Windows.Forms.Button();
            this.quanLiDoChoiDataSet1 = new QuanLiBanHang.QuanLiDoChoiDataSet();
            this.hoaDonTableAdapter = new QuanLiBanHang.QuanLiDoChoiDataSet2TableAdapters.HoaDonTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiDoChoiDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiDoChoiDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.txtTongTien);
            this.panel1.Controls.Add(this.txtMaKH);
            this.panel1.Controls.Add(this.txtMaHD);
            this.panel1.Controls.Add(this.lblTongTien);
            this.panel1.Controls.Add(this.lblMaHD);
            this.panel1.Controls.Add(this.lbLMaKH);
            this.panel1.Location = new System.Drawing.Point(12, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 91);
            this.panel1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ngày in hóa đơn:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(478, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // txtTongTien
            // 
            this.txtTongTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTongTien.Location = new System.Drawing.Point(463, 55);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(215, 22);
            this.txtTongTien.TabIndex = 16;
            // 
            // txtMaKH
            // 
            this.txtMaKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaKH.Location = new System.Drawing.Point(151, 55);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(155, 22);
            this.txtMaKH.TabIndex = 15;
            // 
            // txtMaHD
            // 
            this.txtMaHD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaHD.Location = new System.Drawing.Point(151, 15);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(155, 22);
            this.txtMaHD.TabIndex = 5;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(391, 57);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(66, 16);
            this.lblTongTien.TabIndex = 4;
            this.lblTongTien.Text = "Tổng tiền:";
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.Location = new System.Drawing.Point(24, 21);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(81, 16);
            this.lblMaHD.TabIndex = 3;
            this.lblMaHD.Text = "Mã hóa đơn:";
            // 
            // lbLMaKH
            // 
            this.lbLMaKH.AutoSize = true;
            this.lbLMaKH.Location = new System.Drawing.Point(24, 57);
            this.lbLMaKH.Name = "lbLMaKH";
            this.lbLMaKH.Size = new System.Drawing.Size(101, 16);
            this.lbLMaKH.TabIndex = 1;
            this.lbLMaKH.Text = "Mã khách hàng:";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AutoGenerateColumns = false;
            this.dgvHoaDon.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHoaDonDataGridViewTextBoxColumn,
            this.ngayHoaDonDataGridViewTextBoxColumn,
            this.maKhachHangDataGridViewTextBoxColumn});
            this.dgvHoaDon.DataSource = this.hoaDonBindingSource;
            this.dgvHoaDon.Location = new System.Drawing.Point(12, 120);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.Size = new System.Drawing.Size(700, 192);
            this.dgvHoaDon.TabIndex = 23;
            // 
            // maHoaDonDataGridViewTextBoxColumn
            // 
            this.maHoaDonDataGridViewTextBoxColumn.DataPropertyName = "MaHoaDon";
            this.maHoaDonDataGridViewTextBoxColumn.HeaderText = "Mã hóa đơn";
            this.maHoaDonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maHoaDonDataGridViewTextBoxColumn.Name = "maHoaDonDataGridViewTextBoxColumn";
            this.maHoaDonDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngayHoaDonDataGridViewTextBoxColumn
            // 
            this.ngayHoaDonDataGridViewTextBoxColumn.DataPropertyName = "NgayHoaDon";
            this.ngayHoaDonDataGridViewTextBoxColumn.HeaderText = "Ngày in hóa đơn";
            this.ngayHoaDonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayHoaDonDataGridViewTextBoxColumn.Name = "ngayHoaDonDataGridViewTextBoxColumn";
            this.ngayHoaDonDataGridViewTextBoxColumn.Width = 125;
            // 
            // maKhachHangDataGridViewTextBoxColumn
            // 
            this.maKhachHangDataGridViewTextBoxColumn.DataPropertyName = "MaKhachHang";
            this.maKhachHangDataGridViewTextBoxColumn.HeaderText = "Mã khách hàng";
            this.maKhachHangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maKhachHangDataGridViewTextBoxColumn.Name = "maKhachHangDataGridViewTextBoxColumn";
            this.maKhachHangDataGridViewTextBoxColumn.Width = 125;
            // 
            // hoaDonBindingSource
            // 
            this.hoaDonBindingSource.DataMember = "HoaDon";
            this.hoaDonBindingSource.DataSource = this.quanLiDoChoiDataSet2;
            // 
            // quanLiDoChoiDataSet2
            // 
            this.quanLiDoChoiDataSet2.DataSetName = "QuanLiDoChoiDataSet2";
            this.quanLiDoChoiDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(620, 318);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(92, 39);
            this.btnDong.TabIndex = 24;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // quanLiDoChoiDataSet1
            // 
            this.quanLiDoChoiDataSet1.DataSetName = "QuanLiDoChoiDataSet";
            this.quanLiDoChoiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hoaDonTableAdapter
            // 
            this.hoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // frmTimKiemHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 365);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTimKiemHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm hóa đơn";
            this.Load += new System.EventHandler(this.frmTimKiemHD_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiDoChoiDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiDoChoiDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.Label lbLMaKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.TextBox txtTongTien;
        private QuanLiDoChoiDataSet quanLiDoChoiDataSet1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private QuanLiDoChoiDataSet2 quanLiDoChoiDataSet2;
        private System.Windows.Forms.BindingSource hoaDonBindingSource;
        private QuanLiDoChoiDataSet2TableAdapters.HoaDonTableAdapter hoaDonTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHoaDonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayHoaDonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhachHangDataGridViewTextBoxColumn;
    }
}