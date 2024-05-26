namespace QuanLiBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDon));
            this.lblHoaDon = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpNgayLapHD = new System.Windows.Forms.DateTimePicker();
            this.cboMaKH = new System.Windows.Forms.ComboBox();
            this.mtbDienThoai = new System.Windows.Forms.MaskedTextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.lblNgayLapHD = new System.Windows.Forms.Label();
            this.lbLMaKH = new System.Windows.Forms.Label();
            this.lblThongTinChung = new System.Windows.Forms.Label();
            this.lblThongTinDC = new System.Windows.Forms.Label();
            this.lblMaDC = new System.Windows.Forms.Label();
            this.lblDoChoi = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.cboMaDC = new System.Windows.Forms.ComboBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTenDC = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnPhieuHen = new System.Windows.Forms.Button();
            this.btnPhieuGhiNo = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lblBangChu = new System.Windows.Forms.Label();
            this.lblBangChuTT = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.dgvHDBanHang = new System.Windows.Forms.DataGridView();
            this.colMaDC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMaHoaDon = new System.Windows.Forms.ComboBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDBanHang)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHoaDon
            // 
            this.lblHoaDon.AutoSize = true;
            this.lblHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoaDon.ForeColor = System.Drawing.Color.Blue;
            this.lblHoaDon.Location = new System.Drawing.Point(266, 20);
            this.lblHoaDon.Name = "lblHoaDon";
            this.lblHoaDon.Size = new System.Drawing.Size(269, 29);
            this.lblHoaDon.TabIndex = 5;
            this.lblHoaDon.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpNgayLapHD);
            this.panel1.Controls.Add(this.cboMaKH);
            this.panel1.Controls.Add(this.mtbDienThoai);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.txtTenKH);
            this.panel1.Controls.Add(this.lblDiaChi);
            this.panel1.Controls.Add(this.lblTenKH);
            this.panel1.Controls.Add(this.txtMaHD);
            this.panel1.Controls.Add(this.lblDienThoai);
            this.panel1.Controls.Add(this.lblMaHD);
            this.panel1.Controls.Add(this.lblNgayLapHD);
            this.panel1.Controls.Add(this.lbLMaKH);
            this.panel1.Location = new System.Drawing.Point(25, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 131);
            this.panel1.TabIndex = 21;
            // 
            // dtpNgayLapHD
            // 
            this.dtpNgayLapHD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayLapHD.Location = new System.Drawing.Point(144, 90);
            this.dtpNgayLapHD.Name = "dtpNgayLapHD";
            this.dtpNgayLapHD.Size = new System.Drawing.Size(180, 22);
            this.dtpNgayLapHD.TabIndex = 20;
            // 
            // cboMaKH
            // 
            this.cboMaKH.FormattingEnabled = true;
            this.cboMaKH.Location = new System.Drawing.Point(144, 53);
            this.cboMaKH.Name = "cboMaKH";
            this.cboMaKH.Size = new System.Drawing.Size(180, 24);
            this.cboMaKH.TabIndex = 19;
            this.cboMaKH.TextChanged += new System.EventHandler(this.cboMaKH_TextChanged);
            // 
            // mtbDienThoai
            // 
            this.mtbDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtbDienThoai.Location = new System.Drawing.Point(521, 88);
            this.mtbDienThoai.Name = "mtbDienThoai";
            this.mtbDienThoai.Size = new System.Drawing.Size(230, 22);
            this.mtbDienThoai.TabIndex = 14;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiaChi.Location = new System.Drawing.Point(521, 53);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(230, 22);
            this.txtDiaChi.TabIndex = 13;
            // 
            // txtTenKH
            // 
            this.txtTenKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenKH.Location = new System.Drawing.Point(521, 19);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(230, 22);
            this.txtTenKH.TabIndex = 12;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(408, 57);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(50, 16);
            this.lblDiaChi.TabIndex = 11;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new System.Drawing.Point(408, 21);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(106, 16);
            this.lblTenKH.TabIndex = 10;
            this.lblTenKH.Text = "Tên khách hàng:";
            // 
            // txtMaHD
            // 
            this.txtMaHD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaHD.Location = new System.Drawing.Point(144, 19);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(180, 22);
            this.txtMaHD.TabIndex = 5;
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Location = new System.Drawing.Point(408, 90);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(69, 16);
            this.lblDienThoai.TabIndex = 4;
            this.lblDienThoai.Text = "Điện thoại:";
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
            // lblNgayLapHD
            // 
            this.lblNgayLapHD.AutoSize = true;
            this.lblNgayLapHD.Location = new System.Drawing.Point(24, 90);
            this.lblNgayLapHD.Name = "lblNgayLapHD";
            this.lblNgayLapHD.Size = new System.Drawing.Size(87, 16);
            this.lblNgayLapHD.TabIndex = 2;
            this.lblNgayLapHD.Text = "Ngày lập HĐ:";
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
            // lblThongTinChung
            // 
            this.lblThongTinChung.AutoSize = true;
            this.lblThongTinChung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinChung.Location = new System.Drawing.Point(20, 55);
            this.lblThongTinChung.Name = "lblThongTinChung";
            this.lblThongTinChung.Size = new System.Drawing.Size(153, 25);
            this.lblThongTinChung.TabIndex = 17;
            this.lblThongTinChung.Text = "Thông tin chung";
            // 
            // lblThongTinDC
            // 
            this.lblThongTinDC.AutoSize = true;
            this.lblThongTinDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinDC.Location = new System.Drawing.Point(18, 235);
            this.lblThongTinDC.Name = "lblThongTinDC";
            this.lblThongTinDC.Size = new System.Drawing.Size(198, 25);
            this.lblThongTinDC.TabIndex = 22;
            this.lblThongTinDC.Text = "Thông tin các đồ chơi";
            // 
            // lblMaDC
            // 
            this.lblMaDC.AutoSize = true;
            this.lblMaDC.Location = new System.Drawing.Point(16, 15);
            this.lblMaDC.Name = "lblMaDC";
            this.lblMaDC.Size = new System.Drawing.Size(76, 16);
            this.lblMaDC.TabIndex = 23;
            this.lblMaDC.Text = "Mã đồ chơi:";
            // 
            // lblDoChoi
            // 
            this.lblDoChoi.AutoSize = true;
            this.lblDoChoi.Location = new System.Drawing.Point(245, 15);
            this.lblDoChoi.Name = "lblDoChoi";
            this.lblDoChoi.Size = new System.Drawing.Size(81, 16);
            this.lblDoChoi.TabIndex = 24;
            this.lblDoChoi.Text = "Tên đồ chơi:";
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(245, 52);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(56, 16);
            this.lblDonGia.TabIndex = 25;
            this.lblDonGia.Text = "Đơn giá:";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(16, 56);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(63, 16);
            this.lblSoLuong.TabIndex = 26;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.AutoSize = true;
            this.lblThanhTien.Location = new System.Drawing.Point(523, 15);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(72, 16);
            this.lblThanhTien.TabIndex = 28;
            this.lblThanhTien.Text = "Thành tiền:";
            // 
            // cboMaDC
            // 
            this.cboMaDC.FormattingEnabled = true;
            this.cboMaDC.Location = new System.Drawing.Point(101, 11);
            this.cboMaDC.Name = "cboMaDC";
            this.cboMaDC.Size = new System.Drawing.Size(121, 24);
            this.cboMaDC.TabIndex = 29;
            this.cboMaDC.TextChanged += new System.EventHandler(this.cboMaDC_TextChanged);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoLuong.Location = new System.Drawing.Point(101, 52);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(121, 22);
            this.txtSoLuong.TabIndex = 19;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            // 
            // txtTenDC
            // 
            this.txtTenDC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenDC.Location = new System.Drawing.Point(344, 13);
            this.txtTenDC.Name = "txtTenDC";
            this.txtTenDC.Size = new System.Drawing.Size(155, 22);
            this.txtTenDC.TabIndex = 30;
            // 
            // txtDonGia
            // 
            this.txtDonGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDonGia.Location = new System.Drawing.Point(344, 50);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(155, 22);
            this.txtDonGia.TabIndex = 32;
            this.txtDonGia.TextChanged += new System.EventHandler(this.txtDonGia_TextChanged);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThanhTien.Location = new System.Drawing.Point(600, 13);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(155, 22);
            this.txtThanhTien.TabIndex = 33;
            this.txtThanhTien.TextChanged += new System.EventHandler(this.txtThanhTien_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnPhieuHen);
            this.panel2.Controls.Add(this.btnPhieuGhiNo);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lblBangChu);
            this.panel2.Controls.Add(this.lblBangChuTT);
            this.panel2.Controls.Add(this.txtTongTien);
            this.panel2.Controls.Add(this.lblTongTien);
            this.panel2.Controls.Add(this.dgvHDBanHang);
            this.panel2.Controls.Add(this.txtThanhTien);
            this.panel2.Controls.Add(this.txtDonGia);
            this.panel2.Controls.Add(this.txtTenDC);
            this.panel2.Controls.Add(this.txtSoLuong);
            this.panel2.Controls.Add(this.cboMaDC);
            this.panel2.Controls.Add(this.lblThanhTien);
            this.panel2.Controls.Add(this.lblSoLuong);
            this.panel2.Controls.Add(this.lblDonGia);
            this.panel2.Controls.Add(this.lblDoChoi);
            this.panel2.Controls.Add(this.lblMaDC);
            this.panel2.Location = new System.Drawing.Point(23, 263);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(768, 417);
            this.panel2.TabIndex = 34;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(19, 289);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(282, 34);
            this.btnXoa.TabIndex = 45;
            this.btnXoa.Text = "Nhấp vào để xóa thông tin bạn muốn xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnPhieuHen
            // 
            this.btnPhieuHen.Location = new System.Drawing.Point(526, 324);
            this.btnPhieuHen.Name = "btnPhieuHen";
            this.btnPhieuHen.Size = new System.Drawing.Size(106, 34);
            this.btnPhieuHen.TabIndex = 44;
            this.btnPhieuHen.Text = "Phiếu hẹn";
            this.btnPhieuHen.UseVisualStyleBackColor = true;
            this.btnPhieuHen.Click += new System.EventHandler(this.btnPhieuHen_Click);
            // 
            // btnPhieuGhiNo
            // 
            this.btnPhieuGhiNo.Location = new System.Drawing.Point(639, 324);
            this.btnPhieuGhiNo.Name = "btnPhieuGhiNo";
            this.btnPhieuGhiNo.Size = new System.Drawing.Size(117, 34);
            this.btnPhieuGhiNo.TabIndex = 43;
            this.btnPhieuGhiNo.Text = "Ghi nợ";
            this.btnPhieuGhiNo.UseVisualStyleBackColor = true;
            this.btnPhieuGhiNo.Click += new System.EventHandler(this.btnPhieuGhiNo_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Controls.Add(this.btnThanhToan);
            this.panel3.Controls.Add(this.btnHuy);
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Controls.Add(this.btnIn);
            this.panel3.Controls.Add(this.btnLuu);
            this.panel3.Location = new System.Drawing.Point(20, 364);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(736, 42);
            this.panel3.TabIndex = 39;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(3, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(127, 34);
            this.btnThem.TabIndex = 44;
            this.btnThem.Text = "Thêm hóa đơn";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(382, 5);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(118, 34);
            this.btnThanhToan.TabIndex = 43;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(255, 5);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(121, 34);
            this.btnHuy.TabIndex = 40;
            this.btnHuy.Text = "Hủy hóa đơn";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(619, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(114, 34);
            this.btnExit.TabIndex = 42;
            this.btnExit.Text = "Đóng";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(506, 5);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(106, 34);
            this.btnIn.TabIndex = 41;
            this.btnIn.Text = "In hóa đơn";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(136, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(114, 34);
            this.btnLuu.TabIndex = 39;
            this.btnLuu.Text = "Lưu thông tin";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lblBangChu
            // 
            this.lblBangChu.AutoSize = true;
            this.lblBangChu.Location = new System.Drawing.Point(89, 333);
            this.lblBangChu.Name = "lblBangChu";
            this.lblBangChu.Size = new System.Drawing.Size(164, 16);
            this.lblBangChu.TabIndex = 37;
            this.lblBangChu.Text = "Năm trăm mười ngàn đồng";
            // 
            // lblBangChuTT
            // 
            this.lblBangChuTT.AutoSize = true;
            this.lblBangChuTT.Location = new System.Drawing.Point(17, 333);
            this.lblBangChuTT.Name = "lblBangChuTT";
            this.lblBangChuTT.Size = new System.Drawing.Size(66, 16);
            this.lblBangChuTT.TabIndex = 36;
            this.lblBangChuTT.Text = "Bằng chữ:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTongTien.Location = new System.Drawing.Point(563, 289);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(192, 22);
            this.txtTongTien.TabIndex = 35;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(491, 291);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(66, 16);
            this.lblTongTien.TabIndex = 19;
            this.lblTongTien.Text = "Tổng tiền:";
            // 
            // dgvHDBanHang
            // 
            this.dgvHDBanHang.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvHDBanHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDBanHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDC,
            this.colSoLuong,
            this.colDonGiaBan});
            this.dgvHDBanHang.Location = new System.Drawing.Point(19, 93);
            this.dgvHDBanHang.Name = "dgvHDBanHang";
            this.dgvHDBanHang.RowHeadersWidth = 51;
            this.dgvHDBanHang.RowTemplate.Height = 24;
            this.dgvHDBanHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHDBanHang.Size = new System.Drawing.Size(736, 189);
            this.dgvHDBanHang.TabIndex = 34;
            this.dgvHDBanHang.Click += new System.EventHandler(this.dgvHDBanHang_Click);
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
            this.colSoLuong.HeaderText = "Số lượng mua";
            this.colSoLuong.MinimumWidth = 6;
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Width = 125;
            // 
            // colDonGiaBan
            // 
            this.colDonGiaBan.DataPropertyName = "Gia";
            this.colDonGiaBan.HeaderText = "Đơn giá bán";
            this.colDonGiaBan.MinimumWidth = 6;
            this.colDonGiaBan.Name = "colDonGiaBan";
            this.colDonGiaBan.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Mã hóa đơn:";
            // 
            // cboMaHoaDon
            // 
            this.cboMaHoaDon.FormattingEnabled = true;
            this.cboMaHoaDon.Location = new System.Drawing.Point(112, 10);
            this.cboMaHoaDon.Name = "cboMaHoaDon";
            this.cboMaHoaDon.Size = new System.Drawing.Size(212, 24);
            this.cboMaHoaDon.TabIndex = 40;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(337, 4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(118, 34);
            this.btnTim.TabIndex = 43;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btnTim);
            this.panel4.Controls.Add(this.cboMaHoaDon);
            this.panel4.Location = new System.Drawing.Point(25, 686);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(458, 48);
            this.panel4.TabIndex = 44;
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 742);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblThongTinDC);
            this.Controls.Add(this.lblThongTinChung);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblHoaDon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn bán hàng";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDBanHang)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHoaDon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.Label lblNgayLapHD;
        private System.Windows.Forms.Label lbLMaKH;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.MaskedTextBox mtbDienThoai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblThongTinChung;
        private System.Windows.Forms.Label lblThongTinDC;
        private System.Windows.Forms.Label lblMaDC;
        private System.Windows.Forms.Label lblDoChoi;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.ComboBox cboMaDC;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTenDC;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvHDBanHang;
        private System.Windows.Forms.ComboBox cboMaKH;
        private System.Windows.Forms.Label lblBangChu;
        private System.Windows.Forms.Label lblBangChuTT;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMaHoaDon;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnPhieuGhiNo;
        private System.Windows.Forms.Button btnPhieuHen;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.DateTimePicker dtpNgayLapHD;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGiaBan;
    }
}