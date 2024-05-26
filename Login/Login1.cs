using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiBanHang
{
    public partial class Login1 : Form
    {
        public Login1()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=TRANKHOA\SQLEXPRESS;Initial Catalog=QuanLiDoChoi;Integrated Security=True";
            string taiKhoan = txtTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM [users] WHERE tenDN = @TaiKhoan AND matKhau = @Pass";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@TaiKhoan", taiKhoan);
                    cmd.Parameters.AddWithValue("@Pass", matKhau);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count > 0)
                    {
                        frmMain frmMain = new frmMain();
                        this.Hide();
                        frmMain.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi khi kết nối cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login1_Load(object sender, EventArgs e)
        {
            btnDangNhap.Text = "&Đăng nhập";
        }

        private void Login1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn thoát không", "Thông báo");
            if(rs == DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel=true;
            }
        }
    }
}
