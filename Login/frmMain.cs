using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiBanHang
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
        }

        private void mnuNhaCC_Click(object sender, EventArgs e)
        {
            frmNhaCungCap frmNhaCungCap = new frmNhaCungCap();
            this.Hide();
            frmNhaCungCap.ShowDialog();
            this.Show();
        }

        private void mnuLoaiDC_Click(object sender, EventArgs e)
        {
            frmLoaiDoChoi frmLoaiDoChoi = new frmLoaiDoChoi();
            this.Hide();
            frmLoaiDoChoi.ShowDialog();
            this.Show();
        }

        private void mnuDoChoi_Click(object sender, EventArgs e)
        {
            frmDoChoi frmDoChoi =  new frmDoChoi();
            this.Hide();
            frmDoChoi.ShowDialog();
            this.Show();
        }

        private void mnuDonDH_Click(object sender, EventArgs e)
        {
            frmDonDH frmDonDH = new frmDonDH(); 
            this.Hide();
            frmDonDH.ShowDialog();
            this.Show();
        }

        private void mnuPhieuGH_Click(object sender, EventArgs e)
        {
            frmPhieuGiaoHang frmPhieuGiaoHang = new frmPhieuGiaoHang();
            this.Hide();
            frmPhieuGiaoHang.ShowDialog();
            this.Show();
        }

        private void mnuHoaDon_Click(object sender, EventArgs e)
        {
            frmHoaDon frmHoaDon = new frmHoaDon();
            this.Hide();
            frmHoaDon.ShowDialog();
            this.Show();
        }

        private void mnuPhieuHen_Click(object sender, EventArgs e)
        {
            frmPhieuHen frmPH = new frmPhieuHen();
            this.Hide();
            frmPH.ShowDialog();
            this.Show();
        }

        private void mnuPhieuNo_Click(object sender, EventArgs e)
        {
            frmPhieuTraNo frmPTN = new frmPhieuTraNo();
            this.Hide();
            frmPTN.ShowDialog();
            this.Show();
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang frmKH = new frmKhachHang();
            this.Hide();
            frmKH.ShowDialog();
            this.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Class.Functions.Disconnect();
        }

        private void mnuDoanhSo_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmThongKeDoanhSo frm = new frmThongKeDoanhSo();
            frm.ShowDialog();
            this.Show();
        }

        private void mnuBanChay_Click(object sender, EventArgs e)
        {
            this.Hide();
            using(frmTKDoChoiBanChay frm = new frmTKDoChoiBanChay())
            {
                frm.ShowDialog();
            }
            this.Show();
        }
    }
}
