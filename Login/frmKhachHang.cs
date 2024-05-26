
using QuanLiBanHang.Class;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLiBanHang
{
    public partial class frmKhachHang : Form
    {
        DataTable tblKhachHang;
        int chucNangDaChon = ChucNang.NONE;

        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void LoadDataGridView()
        {
            txtMaKH.Enabled = false;
            txtTenKH.Enabled = false;
            txtDiaChi.Enabled = false;
            mtbDienThoai.Enabled = false;
            string sql = "SELECT * FROM KhachHang";
            tblKhachHang = Class.Functions.GetDataToTable(sql);
            dgvKhachHang.DataSource = tblKhachHang;

            dgvKhachHang.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvKhachHang.AllowUserToAddRows = false;
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            btnLuu.Enabled = false;
        }

        private void dgvKhachHang_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                txtMaKH.Focus();
                return;
            }
            if (tblKhachHang.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaKH.Text = dgvKhachHang.CurrentRow.Cells[0].Value.ToString();
            txtTenKH.Text = dgvKhachHang.CurrentRow.Cells[1].Value.ToString();
            txtDiaChi.Text = dgvKhachHang.CurrentRow.Cells[2].Value.ToString();
            mtbDienThoai.Text = dgvKhachHang.CurrentRow.Cells[3].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void ResetValue()
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtDiaChi.Text = "";
            mtbDienThoai.Text = "";
        }

        private void SetStateControl(bool trangThai)
        {
            btnThem.Enabled = trangThai;
            btnSua.Enabled = trangThai;
            btnXoa.Enabled = trangThai;
            btnLuu.Enabled = !trangThai;
            btnHuy.Enabled = !trangThai;
            btnExit.Enabled = trangThai;
        }

        private void SwitchMode(int chucNang)
        {
            chucNangDaChon = chucNang;
            switch (chucNang)
            {
                case ChucNang.ADD:
                    SetStateControl(false);
                    txtMaKH.Enabled = true;
                    txtTenKH.Enabled = true;
                    txtDiaChi.Enabled = true;
                    mtbDienThoai.Enabled = true;
                    ResetValue();
                    txtMaKH.Focus();
                    break;

                case ChucNang.UPDATE:
                    SetStateControl(false);
                    txtMaKH.Enabled = false;
                    txtTenKH.Enabled = true;
                    txtDiaChi.Enabled = true;
                    mtbDienThoai.Enabled = true;
                    txtMaKH.Focus();
                    break;

                case ChucNang.NONE:
                    SetStateControl(true);
                    txtMaKH.Enabled = false;
                    txtTenKH.Enabled = false;
                    txtDiaChi.Enabled = false;
                    mtbDienThoai.Enabled = false;
                    break;
            }
        }

        private void dgvKhachHang_Click_1(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                txtMaKH.Focus();
                return;
            }
            if (tblKhachHang.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaKH.Text = dgvKhachHang.CurrentRow.Cells[0].Value.ToString();
            txtTenKH.Text = dgvKhachHang.CurrentRow.Cells[1].Value.ToString();
            txtDiaChi.Text = dgvKhachHang.CurrentRow.Cells[2].Value.ToString();
            mtbDienThoai.Text = dgvKhachHang.CurrentRow.Cells[3].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (chucNangDaChon == ChucNang.NONE)
                SwitchMode(ChucNang.ADD);
            else
                SwitchMode(ChucNang.NONE);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblKhachHang.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaKH.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = $"DELETE FROM KhachHang WHERE MaKhachHang = '{txtMaKH.Text}'";
                Class.Functions.RunSqlDel(sql);
                MessageBox.Show("Xóa thành công!", "Thông báo");
                LoadDataGridView();
                ResetValue();
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "")
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (chucNangDaChon == ChucNang.ADD)
            {
                string sql;
                if (txtMaKH.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn chưa nhập mã khách hàng", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                if (txtTenKH.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn chưa nhập tên khách hàng", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                if (txtDiaChi.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn chưa nhập địa chỉ khách hàng", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                if (mtbDienThoai.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn chưa nhập số điện thoại khách hàng", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                sql = $"SELECT MaKhachHang FROM KhachHang WHERE MaKhachHang = '{txtMaKH.Text.Trim()}'";
                if (Class.Functions.CheckKey(sql))
                {
                    MessageBox.Show("Mã khách hàng này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaKH.Focus();
                    return;
                }

                sql = $"INSERT INTO KhachHang VALUES('{txtMaKH.Text.Trim()}',N'{txtTenKH.Text.Trim()}', N'{txtDiaChi.Text.Trim()}', '{mtbDienThoai.Text.Trim()}')";
                Class.Functions.RunSQL(sql);
                MessageBox.Show("Thêm thành công!");
                LoadDataGridView();
            }

            if (chucNangDaChon == ChucNang.UPDATE)
            {
                string sql = $"UPDATE KhachHang SET TenKhachHang = N'{txtTenKH.Text}', DiaChi = N'{txtDiaChi.Text}', SoDienThoai = '{mtbDienThoai.Text}' WHERE MaKhachHang = '{txtMaKH.Text}'";
                Class.Functions.RunSQL(sql);
                SwitchMode(ChucNang.NONE);
                LoadDataGridView();
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
