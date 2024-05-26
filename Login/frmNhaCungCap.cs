using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiBanHang.Class;
using System.Data.SqlClient;
using QuanLiBanHang.Class;

namespace QuanLiBanHang
{
    public partial class frmNhaCungCap : Form
    {
        DataTable tblNhaCungCap;
        int chucNangDaChon = ChucNang.NONE;
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private void LoadDataGridView()
        {
            txtMaNhaCC.Enabled = false;
            txtTenNhaCC.Enabled = false;
            txtDiaChi.Enabled = false;
            mtbDienThoai.Enabled = false;
            string sql = "SELECT * FROM NhaCungCap";
            tblNhaCungCap = Class.Functions.GetDataToTable(sql);
            dgvNhaCC.DataSource = tblNhaCungCap;

            dgvNhaCC.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvNhaCC.AllowUserToAddRows = false;
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            LoadDataGridView();

            btnLuu.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvNhaCC_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                txtMaNhaCC.Focus();
                return;
            }
            if (tblNhaCungCap.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaNhaCC.Text = dgvNhaCC.CurrentRow.Cells[0].Value.ToString();
            txtTenNhaCC.Text = dgvNhaCC.CurrentRow.Cells[1].Value.ToString();
            txtDiaChi.Text = dgvNhaCC.CurrentRow.Cells[2].Value.ToString();
            mtbDienThoai.Text = dgvNhaCC.CurrentRow.Cells[3].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void ResetValue()
        {
            txtMaNhaCC.Text = "";
            txtTenNhaCC.Text = "";
            txtDiaChi.Text = "";
            mtbDienThoai.Text = "";
        }

        private void SetStateControl(Boolean trangThai)
        {
            btnThem.Enabled = trangThai;
            btnSua.Enabled = trangThai;
            btnXoa.Enabled = trangThai;
            btnLuu.Enabled = !trangThai;
            btnHuy.Enabled = !trangThai;
            btnExit.Enabled = trangThai;
        }

        //Phương thức chọn chức năng
        void SwitchMode(int chucNang)
        {
            chucNangDaChon = chucNang;
            switch (chucNang)
            {
                case ChucNang.ADD:
                    {
                        SetStateControl(false);
                        txtMaNhaCC.Enabled = true;
                        txtTenNhaCC.Enabled = true;
                        txtDiaChi.Enabled = true;
                        mtbDienThoai.Enabled = true;
                        ResetValue();
                        txtMaNhaCC.Focus();
                        break;
                    }
                case ChucNang.UPDATE:
                    {
                        SetStateControl(false);
                        txtMaNhaCC.Enabled = false;
                        txtTenNhaCC.Enabled = true;
                        txtDiaChi.Enabled = true;
                        mtbDienThoai.Enabled= true;
                        txtMaNhaCC.Focus();
                        break;
                    }
                case ChucNang.NONE:
                    {
                        SetStateControl(true);
                        txtMaNhaCC.Enabled = false;
                        txtTenNhaCC.Enabled = false;
                        txtDiaChi.Enabled = false;
                        mtbDienThoai.Enabled = false;
                        break;
                    }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (chucNangDaChon == ChucNang.NONE)
                SwitchMode(ChucNang.ADD);
            else
                SwitchMode(ChucNang.NONE);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (chucNangDaChon == ChucNang.ADD)
            {
                string sql;
                if (txtMaNhaCC.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn chưa nhập mã nhà cung cấp", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                if (txtTenNhaCC.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn chưa nhập tên nhà cung cấp", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                if (txtDiaChi.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn chưa nhập địa chỉ nhà cung cấp", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                if (mtbDienThoai.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn chưa nhập số điện thoại nhà cung cấp", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                sql = "SELECT MaNhaCungCap FROM NhaCungCap WHERE MaNhaCungCap = '" + txtMaNhaCC.Text.Trim() + "'";
                if (Class.Functions.CheckKey(sql))
                {
                    MessageBox.Show("Mã nhà cung cấp này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaNhaCC.Focus();
                    return;
                }

                sql = "INSERT INTO NhaCungCap VALUES('" + txtMaNhaCC.Text.Trim() + "',N'" + txtTenNhaCC.Text.Trim() + "', N'" + txtDiaChi.Text.Trim() + "', '" + mtbDienThoai.Text.Trim() + "')";
                Class.Functions.RunSQL(sql);
                MessageBox.Show("Thêm thành công!");
                LoadDataGridView();
            }
            if(chucNangDaChon == ChucNang.UPDATE)
            {
               string sql = "update NhaCungCap set TenNhaCungCap = N'" + txtTenNhaCC.Text.ToString() +
                            "', DiaChi = N'" + txtDiaChi.Text.ToString() +
                            "', SoDienThoai = '" + mtbDienThoai.Text.ToString() +
                            "' where MaNhaCungCap = N'" + txtMaNhaCC.Text + "'";
                Class.Functions.RunSQL(sql);
                SwitchMode(ChucNang.NONE);
                LoadDataGridView();
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
            }    
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNhaCC.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (chucNangDaChon == ChucNang.NONE)
                SwitchMode(ChucNang.UPDATE);
            else
                SwitchMode(ChucNang.NONE);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SwitchMode(ChucNang.NONE);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNhaCungCap.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaNhaCC.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE FROM NhaCungCap WHERE MaNhaCungCap = '" + txtMaNhaCC.Text + "'";
                Class.Functions.RunSqlDel(sql);
                MessageBox.Show("Xóa thành công!","Thông báo");
                LoadDataGridView();
                ResetValue();
            }
        }

    }
}
