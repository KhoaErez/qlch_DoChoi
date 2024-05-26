namespace QuanLiBanHang
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhaCC = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoaiDC = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoChoi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDonDH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPhieuGH = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPhieuHen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPhieuNo = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBanChay = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoanhSo = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDanhMuc,
            this.hóaĐơnToolStripMenuItem,
            this.kháchHàngToolStripMenuItem,
            this.thốngKêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuDanhMuc
            // 
            this.mnuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNhaCC,
            this.mnuLoaiDC,
            this.mnuDoChoi,
            this.mnuDonDH,
            this.mnuPhieuGH});
            this.mnuDanhMuc.Name = "mnuDanhMuc";
            this.mnuDanhMuc.Size = new System.Drawing.Size(90, 24);
            this.mnuDanhMuc.Text = "Danh mục";
            // 
            // mnuNhaCC
            // 
            this.mnuNhaCC.Name = "mnuNhaCC";
            this.mnuNhaCC.Size = new System.Drawing.Size(199, 26);
            this.mnuNhaCC.Text = "Nhà cung cấp";
            this.mnuNhaCC.Click += new System.EventHandler(this.mnuNhaCC_Click);
            // 
            // mnuLoaiDC
            // 
            this.mnuLoaiDC.Name = "mnuLoaiDC";
            this.mnuLoaiDC.Size = new System.Drawing.Size(199, 26);
            this.mnuLoaiDC.Text = "Loại đồ chơi";
            this.mnuLoaiDC.Click += new System.EventHandler(this.mnuLoaiDC_Click);
            // 
            // mnuDoChoi
            // 
            this.mnuDoChoi.Name = "mnuDoChoi";
            this.mnuDoChoi.Size = new System.Drawing.Size(199, 26);
            this.mnuDoChoi.Text = "Đồ chơi";
            this.mnuDoChoi.Click += new System.EventHandler(this.mnuDoChoi_Click);
            // 
            // mnuDonDH
            // 
            this.mnuDonDH.Name = "mnuDonDH";
            this.mnuDonDH.Size = new System.Drawing.Size(199, 26);
            this.mnuDonDH.Text = "Đơn đặt hàng";
            this.mnuDonDH.Click += new System.EventHandler(this.mnuDonDH_Click);
            // 
            // mnuPhieuGH
            // 
            this.mnuPhieuGH.Name = "mnuPhieuGH";
            this.mnuPhieuGH.Size = new System.Drawing.Size(199, 26);
            this.mnuPhieuGH.Text = "Phiếu giao hàng";
            this.mnuPhieuGH.Click += new System.EventHandler(this.mnuPhieuGH_Click);
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHoaDon,
            this.mnuPhieuHen,
            this.mnuPhieuNo});
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.hóaĐơnToolStripMenuItem.Text = "Quản lý bán hàng";
            // 
            // mnuHoaDon
            // 
            this.mnuHoaDon.Name = "mnuHoaDon";
            this.mnuHoaDon.Size = new System.Drawing.Size(156, 26);
            this.mnuHoaDon.Text = "Hóa đơn";
            this.mnuHoaDon.Click += new System.EventHandler(this.mnuHoaDon_Click);
            // 
            // mnuPhieuHen
            // 
            this.mnuPhieuHen.Name = "mnuPhieuHen";
            this.mnuPhieuHen.Size = new System.Drawing.Size(156, 26);
            this.mnuPhieuHen.Text = "Phiếu hẹn";
            this.mnuPhieuHen.Click += new System.EventHandler(this.mnuPhieuHen_Click);
            // 
            // mnuPhieuNo
            // 
            this.mnuPhieuNo.Name = "mnuPhieuNo";
            this.mnuPhieuNo.Size = new System.Drawing.Size(156, 26);
            this.mnuPhieuNo.Text = "Phiếu nợ";
            this.mnuPhieuNo.Click += new System.EventHandler(this.mnuPhieuNo_Click);
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuKhachHang});
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.kháchHàngToolStripMenuItem.Text = "Khách hàng";
            // 
            // mnuKhachHang
            // 
            this.mnuKhachHang.Name = "mnuKhachHang";
            this.mnuKhachHang.Size = new System.Drawing.Size(234, 26);
            this.mnuKhachHang.Text = "Thông tin khách hàng";
            this.mnuKhachHang.Click += new System.EventHandler(this.mnuKhachHang_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBanChay,
            this.mnuDoanhSo});
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // mnuBanChay
            // 
            this.mnuBanChay.Name = "mnuBanChay";
            this.mnuBanChay.Size = new System.Drawing.Size(283, 26);
            this.mnuBanChay.Text = "Thống kê mặt hàng bán chạy";
            this.mnuBanChay.Click += new System.EventHandler(this.mnuBanChay_Click);
            // 
            // mnuDoanhSo
            // 
            this.mnuDoanhSo.Name = "mnuDoanhSo";
            this.mnuDoanhSo.Size = new System.Drawing.Size(283, 26);
            this.mnuDoanhSo.Text = "Thống kê doanh số";
            this.mnuDoanhSo.Click += new System.EventHandler(this.mnuDoanhSo_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::QuanLiBanHang.Properties.Resources.bh;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý cửa hàng đồ chơi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuNhaCC;
        private System.Windows.Forms.ToolStripMenuItem mnuLoaiDC;
        private System.Windows.Forms.ToolStripMenuItem mnuDoChoi;
        private System.Windows.Forms.ToolStripMenuItem mnuDonDH;
        private System.Windows.Forms.ToolStripMenuItem mnuPhieuGH;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnuPhieuHen;
        private System.Windows.Forms.ToolStripMenuItem mnuPhieuNo;
        private System.Windows.Forms.ToolStripMenuItem mnuKhachHang;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuBanChay;
        private System.Windows.Forms.ToolStripMenuItem mnuDoanhSo;
    }
}