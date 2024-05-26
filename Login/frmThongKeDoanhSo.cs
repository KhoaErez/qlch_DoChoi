using QuanLiBanHang.Class;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLiBanHang
{
    public partial class frmThongKeDoanhSo : Form
    {
        DataTable dtTKeDoanhSo;
        public frmThongKeDoanhSo()
        {
            InitializeComponent();
        }

        private void frmThongKeDoanhSo_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM ChiTietHoaDon ORDER BY SoLuong DESC";
            dtTKeDoanhSo = Functions.GetDataToTable(sql);
            dgvTKDoanhSo.DataSource = dtTKeDoanhSo;

            dgvTKDoanhSo.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvTKDoanhSo.AllowUserToAddRows = false;

            // Tính tổng tiền và hiển thị lên TextBox
            decimal tongTien = TinhTongTien();
            txtTongTien.Text = tongTien.ToString("N0") + " VND";
        }

        private decimal TinhTongTien()
        {
            // Thực hiện tính toán tổng tiền từ bảng ChiTietHoaDon
            string sql = "SELECT SUM(SoLuong * Gia) AS TongTien FROM ChiTietHoaDon";
            DataTable dtTongTien = Class.Functions.GetDataToTable(sql);
            if (dtTongTien.Rows.Count > 0 && dtTongTien.Rows[0]["TongTien"] != DBNull.Value)
            {
                return Convert.ToDecimal(dtTongTien.Rows[0]["TongTien"]);
            }
            return 0;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
