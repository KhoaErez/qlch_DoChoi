using QuanLiBanHang.Class;
using System;
using System.Collections;
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
    public partial class frmLoaiDoChoi : Form
    {
        DataTable tblLoaiDoChoi;
        int chucNangDaChon = ChucNang.NONE;
        public frmLoaiDoChoi()
        {
            InitializeComponent();
        }
        private void frmLoaiDoChoi_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            btnLuu.Enabled = false;
        }

        private void LoadDataGridView()
        {
            txtMaLoaiDC.Enabled = false;
            txtTenLoaiDC.Enabled = false;
            cboMaNhaCC.Enabled = false;
            string sql = "SELECT * FROM LoaiDoChoi";
            tblLoaiDoChoi = Class.Functions.GetDataToTable(sql);
            dgvLoaiDC.DataSource = tblLoaiDoChoi;
            string qr = "SELECT MaNhaCungCap FROM NhaCungCap";
            DataTable dtMaNhaCungCap = Class.Functions.GetDataToTable(qr);

            cboMaNhaCC.DataSource = dtMaNhaCungCap;
            cboMaNhaCC.DisplayMember = "MaNhaCungCap";  // Hiển thị mã nhà cung cấp
            cboMaNhaCC.ValueMember = "MaNhaCungCap";    // Giá trị của mỗi mục là mã nhà cung cấp

            dgvLoaiDC.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvLoaiDC.AllowUserToAddRows = false;
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
                        txtMaLoaiDC.Enabled = true;
                        txtTenLoaiDC.Enabled = true;
                        cboMaNhaCC.Enabled = true;
                        ResetValue();
                        txtMaLoaiDC.Focus();
                        break;
                    }
                case ChucNang.UPDATE:
                    {
                        SetStateControl(false);
                        txtMaLoaiDC.Enabled = false;
                        txtTenLoaiDC.Enabled = true;
                        cboMaNhaCC.Enabled = true;
                        txtMaLoaiDC.Focus();
                        break;
                    }
                case ChucNang.NONE:
                    {
                        SetStateControl(true);
                        txtMaLoaiDC.Enabled = false;
                        txtTenLoaiDC.Enabled = false;
                        cboMaNhaCC.Enabled = false;
                        break;
                    }
            }
        }

        private void ResetValue()
        {
            txtMaLoaiDC.Text = "";
            txtTenLoaiDC.Text = "";
            cboMaNhaCC.Text = "";
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
            if (txtMaLoaiDC.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (chucNangDaChon == ChucNang.NONE)
                SwitchMode(ChucNang.UPDATE);
            else
                SwitchMode(ChucNang.NONE);
        }

        private void dgvLoaiDC_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                txtMaLoaiDC.Focus();
                return;
            }
            if (tblLoaiDoChoi.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaLoaiDC.Text = dgvLoaiDC.CurrentRow.Cells[0].Value.ToString();
            txtTenLoaiDC.Text = dgvLoaiDC.CurrentRow.Cells[1].Value.ToString();
            cboMaNhaCC.Text = dgvLoaiDC.CurrentRow.Cells[2].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SwitchMode(ChucNang.NONE);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblLoaiDoChoi.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaLoaiDC.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE FROM LoaiDoChoi WHERE MaLoaiDoChoi = N'" + txtMaLoaiDC.Text + "'";
                Class.Functions.RunSqlDel(sql);
                MessageBox.Show("Xóa thành công!", "Thông báo");
                LoadDataGridView();
                ResetValue();
            }
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
                if (txtMaLoaiDC.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn chưa nhập mã loại đồ chơi", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                if (txtTenLoaiDC.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn chưa nhập tên loại đồ chơi", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                if (cboMaNhaCC.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn chưa chọn mã nhà cung cấp", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                sql = "SELECT MaLoaiDoChoi FROM LoaiDoChoi WHERE MaLoaiDoChoi = '" + txtMaLoaiDC.Text.Trim() + "'";
                if (Class.Functions.CheckKey(sql))
                {
                    MessageBox.Show("Mã nhà cung cấp này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaLoaiDC.Focus();
                    return;
                }

                sql = "INSERT INTO LoaiDoChoi VALUES('" + txtMaLoaiDC.Text.Trim() + "',N'" + txtTenLoaiDC.Text.Trim() + "', N'" + cboMaNhaCC.Text + "')";
                Class.Functions.RunSQL(sql);
                MessageBox.Show("Thêm thành công!");
                LoadDataGridView();
            }
            if (chucNangDaChon == ChucNang.UPDATE)
            {
                string sql = "update LoaiDoChoi set TenLoaiDoChoi = N'" + txtTenLoaiDC.Text.ToString() +
                             "', MaNhaCungCap = N'" + cboMaNhaCC.Text.ToString() +
                             "' where MaLoaiDoChoi = N'" + txtMaLoaiDC.Text + "'";
                Class.Functions.RunSQL(sql);
                SwitchMode(ChucNang.NONE);
                LoadDataGridView();
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
