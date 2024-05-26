using QuanLiBanHang.Class;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLiBanHang
{
    public partial class frmTimKiemHD : Form
    {
        private frmHoaDon frmHoaDonInstance; // Instance của frmHoaDon

        // Constructor nhận instance của frmHoaDon
        public frmTimKiemHD(frmHoaDon frmHoaDonInstance)
        {
            InitializeComponent();
            this.frmHoaDonInstance = frmHoaDonInstance;
        }

        private void frmTimKiemHD_Load(object sender, EventArgs e)
        {
            if (frmHoaDonInstance != null && !string.IsNullOrEmpty(frmHoaDonInstance.TimKiem))
            {
                // Thực hiện truy vấn dữ liệu với mã hóa đơn từ frmHoaDon
                string maHoaDon = frmHoaDonInstance.TimKiem;
                string sql = $"SELECT * FROM HoaDon WHERE MaHoaDon = N'{maHoaDon}'";
                DataTable dt = Functions.GetDataToTable(sql);

                // Hiển thị dữ liệu trong DataGridView
                dgvHoaDon.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để hiển thị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
