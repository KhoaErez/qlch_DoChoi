using QuanLiBanHang.Class;
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
    public partial class frmDoChoi : Form
    {
        DataTable tblDoChoi;
        int chucNangDaChon = ChucNang.NONE;
        public frmDoChoi()
        {
            InitializeComponent();
        }

        private void frmDoChoi_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            btnLuu.Enabled = false;
        }

        private void LoadDataGridView()
        {
            txtMaDC.Enabled = false;
            txtTenDC.Enabled = false;
            cboMaLoaiDC.Enabled = false;
            string sql = "SELECT * FROM DoChoi";
            tblDoChoi = Class.Functions.GetDataToTable(sql);
            dgvDoChoi.DataSource = tblDoChoi;
            string qr = "SELECT MaLoaiDoChoi FROM LoaiDoChoi";

            DataTable dtMaNhaCungCap = Class.Functions.GetDataToTable(qr);
            cboMaLoaiDC.DataSource = dtMaNhaCungCap;
            cboMaLoaiDC.DisplayMember = "MaLoaiDoChoi";  // Hiển thị mã nhà cung cấp
            cboMaLoaiDC.ValueMember = "MaLoaiDoChoi";    // Giá trị của mỗi mục là mã nhà cung cấp

            dgvDoChoi.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvDoChoi.AllowUserToAddRows = false;
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
                        txtMaDC.Enabled = true;
                        txtTenDC.Enabled = true;
                        cboMaLoaiDC.Enabled = true;
                        ResetValue();
                        txtMaDC.Focus();
                        break;
                    }
                case ChucNang.UPDATE:
                    {
                        SetStateControl(false);
                        txtMaDC.Enabled = false;
                        txtTenDC.Enabled = true;
                        cboMaLoaiDC.Enabled = true;
                        txtMaDC.Focus();
                        break;
                    }
                case ChucNang.NONE:
                    {
                        SetStateControl(true);
                        txtMaDC.Enabled = false;
                        txtTenDC.Enabled = false;
                        cboMaLoaiDC.Enabled = false;
                        break;
                    }
            }
        }
        private void ResetValue()
        {
            txtMaDC.Text = "";
            txtTenDC.Text = "";
            cboMaLoaiDC.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (chucNangDaChon == ChucNang.NONE)
                SwitchMode(ChucNang.ADD);
            else
                SwitchMode(ChucNang.NONE);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaDC.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (chucNangDaChon == ChucNang.NONE)
                SwitchMode(ChucNang.UPDATE);
            else
                SwitchMode(ChucNang.NONE);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblDoChoi.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaDC.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE FROM DoChoi WHERE MaDoChoi = '" + txtMaDC.Text + "'";
                Class.Functions.RunSqlDel(sql);
                MessageBox.Show("Xóa thành công!", "Thông báo");
                LoadDataGridView();
                ResetValue();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (chucNangDaChon == ChucNang.ADD)
            {
                string sql;
                if (txtMaDC.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn chưa nhập mã loại đồ chơi", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                if (txtTenDC.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn chưa nhập tên loại đồ chơi", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                if (cboMaLoaiDC.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn chưa chọn mã nhà cung cấp", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                sql = "SELECT MaDoChoi FROM DoChoi WHERE MaDoChoi = '" + txtMaDC.Text.Trim() + "'";
                if (Class.Functions.CheckKey(sql))
                {
                    MessageBox.Show("Mã nhà cung cấp này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaDC.Focus();
                    return;
                }

                sql = "INSERT INTO DoChoi VALUES('" + txtMaDC.Text.Trim() + "',N'" + txtTenDC.Text.Trim() + "', N'" + cboMaLoaiDC.Text + "')";
                Class.Functions.RunSQL(sql);
                MessageBox.Show("Thêm thành công!");
                LoadDataGridView();
            }
            if (chucNangDaChon == ChucNang.UPDATE)
            {
                string sql = "update DoChoi set TenDoChoi = N'" + txtTenDC.Text.ToString() +
                             "', MaLoaiDoChoi = N'" + cboMaLoaiDC.Text.ToString() +
                             "' where MaDoChoi = N'" + txtMaDC.Text + "'";
                Class.Functions.RunSQL(sql);
                SwitchMode(ChucNang.NONE);
                LoadDataGridView();
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SwitchMode(ChucNang.NONE);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDoChoi_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                txtMaDC.Focus();
                return;
            }
            if (tblDoChoi.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaDC.Text = dgvDoChoi.CurrentRow.Cells[0].Value.ToString();
            txtTenDC.Text = dgvDoChoi.CurrentRow.Cells[1].Value.ToString();
            cboMaLoaiDC.Text = dgvDoChoi.CurrentRow.Cells[2].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = true;
        }
    }
}
