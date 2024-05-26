using QuanLiBanHang.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiBanHang
{
    public partial class frmPhieuTraNo : Form
    {
        DataTable tblPTN;
        int chucNangDaChon = ChucNang.NONE;
        public frmPhieuTraNo()
        {
            InitializeComponent();
        }


        private void LoadDataGridView()
        {
            txtMaPhieuGN.Enabled = false;
            dtpNgayTra.Enabled = false;
            txtSoTienTra.Enabled = false;
            cboMaHD.Enabled = false;

            string sql = "SELECT * FROM PhieuTraNo";
            tblPTN = Functions.GetDataToTable(sql);
            dgvPhieuTraNo.DataSource = tblPTN;

            dgvPhieuTraNo.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvPhieuTraNo.AllowUserToAddRows = false;
        }
        private void FillComboBoxMaHD()
        {
            string sql = "SELECT MaHoaDon FROM HoaDon";
            DataTable tblHoaDon = Functions.GetDataToTable(sql);

            cboMaHD.Items.Clear();

            foreach (DataRow row in tblHoaDon.Rows)
            {
                cboMaHD.Items.Add(row["MaHoaDon"].ToString());
            }
        }

        private void frmPhieuTraNo_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            btnLuu.Enabled = false;
            FillComboBoxMaHD();
        }
        private void ResetValue()
        {
            txtMaPhieuGN.Text = "";
            txtSoTienTra.Text = "";
            cboMaHD.Text = "";
        }
        private void SetStateControl(Boolean trangThai)
        {
            btnThem.Enabled = trangThai;
            btnSua.Enabled = trangThai;
            btnXoa.Enabled = trangThai;
            btnLuu.Enabled = !trangThai;
            btnExit.Enabled = trangThai;
        }
        private void SwitchMode(int chucNang)
        {
            chucNangDaChon = chucNang;
            switch (chucNang)
            {
                case ChucNang.ADD:
                    {
                        SetStateControl(false);
                        txtMaPhieuGN.Enabled = true;
                        dtpNgayTra.Enabled = true;
                        txtSoTienTra.Enabled = true;
                        cboMaHD.Enabled = true;
                        ResetValue();
                        txtMaPhieuGN.Focus();
                        break;
                    }
                case ChucNang.UPDATE:
                    {
                        SetStateControl(false);
                        txtMaPhieuGN.Enabled = false;
                        dtpNgayTra.Enabled = true;
                        txtSoTienTra.Enabled = true;
                        cboMaHD.Enabled = true;
                        txtMaPhieuGN.Focus();
                        break;
                    }
                case ChucNang.NONE:
                    {
                        SetStateControl(true);
                        txtMaPhieuGN.Enabled = false;
                        dtpNgayTra.Enabled = false;
                        txtSoTienTra.Enabled = false;
                        cboMaHD.Enabled = false;
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaPhieuGN.Text == "")
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
            if (txtMaPhieuGN.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                string MaPhieuTraNo = txtMaPhieuGN.Text.Trim();
                string sql = $"DELETE FROM PhieuTraNo WHERE MaPhieuTraNo = '{MaPhieuTraNo}'";
                Functions.RunSQL(sql);
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataGridView();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (chucNangDaChon == ChucNang.ADD)
            {
                string MaPhieuTraNo = txtMaPhieuGN.Text.Trim();
                string NgayTraStr = dtpNgayTra.Text.Trim();
                string SoTienTraStr = txtSoTienTra.Text.Trim();

                // Kiểm tra dữ liệu đã nhập đầy đủ chưa
                if (MaPhieuTraNo == "" || NgayTraStr == "" || SoTienTraStr == "" || cboMaHD.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra và chuyển đổi chuỗi SoTienTra thành kiểu float
                float SoTienTra;
                if (!float.TryParse(SoTienTraStr, out SoTienTra))
                {
                    MessageBox.Show("Số tiền trả không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                // Thực hiện thêm mới vào CSDL
                string sql = $"INSERT INTO PhieuTraNo (MaPhieuTraNo, NgayTra, SoTienTra, MaHoaDon) VALUES ('{MaPhieuTraNo}', '{dtpNgayTra.Value.ToString("yyyy/MM/dd")}', {SoTienTra}, '{cboMaHD.Text.Trim()}')";
                Functions.RunSQL(sql);
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataGridView();
            }
            else if (chucNangDaChon == ChucNang.UPDATE)
            {
                // Tương tự cho phần cập nhật dữ liệu
            }

            // Chuyển về trạng thái mặc định
            SwitchMode(ChucNang.NONE);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPhieuTraNo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void dgvPhieuTraNo_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                txtMaPhieuGN.Focus();
                return;
            }

            if (tblPTN.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txtMaPhieuGN.Text = dgvPhieuTraNo.CurrentRow.Cells[0].Value.ToString();
            dtpNgayTra.Text = dgvPhieuTraNo.CurrentRow.Cells[1].Value.ToString();
            txtSoTienTra.Text = dgvPhieuTraNo.CurrentRow.Cells[2].Value.ToString();
            cboMaHD.Text = dgvPhieuTraNo.CurrentRow.Cells[3].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // Nhận mã phiếu ghi nợ từ người dùng
            string maPhieuTraNo = txtMaPhieuGN.Text.Trim();

            // Kiểm tra mã phiếu ghi nợ có được nhập hay không
            if (maPhieuTraNo == "")
            {
                MessageBox.Show("Vui lòng nhập mã phiếu ghi nợ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thực hiện truy vấn SQL để lấy thông tin về phiếu ghi nợ có mã tương ứng
            string sql = $"SELECT * FROM PhieuTraNo WHERE MaPhieuTraNo = '{maPhieuTraNo}'";
            DataTable tblPhieuTraNo = Functions.GetDataToTable(sql);

            // Kiểm tra xem có dữ liệu trả về hay không
            if (tblPhieuTraNo.Rows.Count > 0)
            {
                // Hiển thị thông tin về phiếu ghi nợ
                txtMaPhieuGN.Text = tblPhieuTraNo.Rows[0]["MaPhieuTraNo"].ToString();
                dtpNgayTra.Text = tblPhieuTraNo.Rows[0]["NgayTra"].ToString();
                txtSoTienTra.Text = tblPhieuTraNo.Rows[0]["SoTienTra"].ToString();
                cboMaHD.Text = tblPhieuTraNo.Rows[0]["MaHoaDon"].ToString();
                MessageBox.Show("Tìm kiếm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Xử lý trường hợp không tìm thấy phiếu ghi nợ với mã đã nhập
                MessageBox.Show("Không tìm thấy phiếu ghi nợ có mã đã nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ResetFields()
        {
            // Làm sạch các ô hiển thị thông tin
            txtMaPhieuGN.Text = "";
            dtpNgayTra.Text = "";
            txtSoTienTra.Text = "";
            cboMaHD.Text = "";
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string maPhieuTraNo = txtTimKiem.Text.Trim();

            // Kiểm tra xem mã phiếu ghi nợ có được nhập hay không
            if (maPhieuTraNo == "")
            {
                // Nếu không có mã nào được nhập, làm sạch các ô hiển thị thông tin
                ResetFields();
                return;
            }

            // Thực hiện truy vấn SQL để lấy thông tin về phiếu ghi nợ có mã tương ứng
            string sql = $"SELECT * FROM PhieuTraNo WHERE MaPhieuTraNo = '{maPhieuTraNo}'";
            DataTable tblPhieuTraNo = Functions.GetDataToTable(sql);

            // Kiểm tra xem có dữ liệu trả về hay không
            if (tblPhieuTraNo.Rows.Count > 0)
            {
                // Hiển thị thông tin về phiếu ghi nợ
                txtMaPhieuGN.Text = tblPhieuTraNo.Rows[0]["MaPhieuTraNo"].ToString();
                dtpNgayTra.Text = tblPhieuTraNo.Rows[0]["NgayTra"].ToString();
                txtSoTienTra.Text = tblPhieuTraNo.Rows[0]["SoTienTra"].ToString();
                cboMaHD.Text = tblPhieuTraNo.Rows[0]["MaHoaDon"].ToString();
            }
            else
            {
                // Nếu không tìm thấy phiếu ghi nợ với mã đã nhập, làm sạch các ô hiển thị thông tin
                ResetFields();
            }
        }

    }
}
