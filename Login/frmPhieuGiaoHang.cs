using QuanLiBanHang.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiBanHang
{
    public partial class frmPhieuGiaoHang : Form
    {
        DataTable tblPhieuGiaoHang;
        int chucNangDaChon = ChucNang.NONE;
        public string TimKiem {  get; set; }
        public frmPhieuGiaoHang()
        {
            InitializeComponent();
        }

        private void frmPhieuGiaoHang_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            btnLuu.Enabled = false;
        }

        private void LoadDataGridView()
        {
            txtMaPhieuGH.Enabled = false;
            txtDonGia.Enabled = false;
            txtSoLuong.Enabled = false;
            cboMaDC.Enabled = false;
            cboMaDDH.Enabled = false;
            dtpNgayGiao.Enabled = false;

            string sql = "SELECT PhieuGiaoHang.MaPhieuGiaoHang, PhieuGiaoHang.MaDonDatHang, PhieuGiaoHang.NgayGiaoHang, " +
                         "ChiTietPhieuGiaoHang.MaDoChoi, ChiTietPhieuGiaoHang.SoLuong, ChiTietPhieuGiaoHang.DonGia " +
                         "FROM PhieuGiaoHang " +
                         "INNER JOIN ChiTietPhieuGiaoHang " +
                         "ON PhieuGiaoHang.MaPhieuGiaoHang = ChiTietPhieuGiaoHang.MaPhieuGiaoHang";
            tblPhieuGiaoHang = Class.Functions.GetDataToTable(sql);
            dgvPhieuGH.DataSource = tblPhieuGiaoHang;

            string qr = "SELECT MaDoChoi FROM DoChoi";
            DataTable dtMaDoChoi = Class.Functions.GetDataToTable(qr);
            cboMaDC.DataSource = dtMaDoChoi;
            cboMaDC.DisplayMember = "MaDoChoi";  
            cboMaDC.ValueMember = "MaDoChoi";    

            string query = "SELECT MaDonDatHang FROM DonDatHang";
            DataTable dtMaDonDH = Class.Functions.GetDataToTable(query);
            cboMaDDH.DataSource = dtMaDonDH;
            cboMaDDH.DisplayMember = "MaDonDatHang";  
            cboMaDDH.ValueMember = "MaDonDatHang";    

            dgvPhieuGH.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvPhieuGH.AllowUserToAddRows = false;
        }
        private void SetStateControl(Boolean trangThai)
        {
            btnThem.Enabled = trangThai;
            btnSua.Enabled = trangThai;
            btnXoa.Enabled = trangThai;
            btnLuu.Enabled = !trangThai;
            btnHuy.Enabled = !trangThai;
            btnExit.Enabled = trangThai;
            btnXemDH.Enabled = trangThai;
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
                        txtMaPhieuGH.Enabled = true;
                        txtDonGia.Enabled = true;
                        txtSoLuong.Enabled = true;
                        cboMaDDH.Enabled = true;
                        cboMaDC.Enabled = true;
                        dtpNgayGiao.Enabled = true;
                        ResetValue();
                        txtMaPhieuGH.Focus();
                        break;
                    }
                case ChucNang.UPDATE:
                    {
                        SetStateControl(false);
                        txtMaPhieuGH.Enabled = false;
                        txtDonGia.Enabled = true;
                        txtSoLuong.Enabled = true;
                        cboMaDDH.Enabled = true;
                        cboMaDC.Enabled = false;
                        dtpNgayGiao.Enabled = true;
                        break;
                    }
                case ChucNang.NONE:
                    {
                        SetStateControl(true);
                        txtMaPhieuGH.Enabled = false;
                        txtSoLuong.Enabled = false;
                        txtDonGia.Enabled = false;
                        cboMaDC.Enabled = false;
                        cboMaDDH.Enabled = false;
                        dtpNgayGiao.Enabled = false;
                        break;
                    }
            }
        }

        private void ResetValue()
        {
            txtDonGia.Text = "";
            txtMaPhieuGH.Text = "";
            txtSoLuong.Text = "";
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
            string qr;
            if (tblPhieuGiaoHang.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaPhieuGH.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE FROM PhieuGiaoHang WHERE MaPhieuGiaoHang = N'" + txtMaPhieuGH.Text + "'";
                qr = "DELETE FROM ChiTietPhieuGiaoHang WHERE MaDoChoi = N'" + cboMaDC.Text + "' AND MaPhieuGiaoHang = N'" + txtMaPhieuGH.Text + "'";

                Class.Functions.RunSqlDel(qr);
                Class.Functions.RunSqlDel(sql);
                MessageBox.Show("Xóa thành công!", "Thông báo");
                LoadDataGridView();
                ResetValue();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaPhieuGH.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (chucNangDaChon == ChucNang.NONE)
                SwitchMode(ChucNang.UPDATE);
            else
                SwitchMode(ChucNang.NONE);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (chucNangDaChon == ChucNang.ADD)
            {
                string sql;
                string qr;
                if (txtMaPhieuGH.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn chưa nhập mã loại đồ chơi", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                if (txtDonGia.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn chưa nhập đơn giá", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                if (txtSoLuong.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn chưa nhập số lượng", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                if (cboMaDC.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn chưa chọn mã đồ chơi", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                if (cboMaDDH.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn chưa chọn mã đơn đặt hàng", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                sql = "SELECT PhieuGiaoHang.MaPhieuGiaoHang, ChiTietPhieuGiaoHang.MaDoChoi FROM PhieuGiaoHang " +
                      "INNER JOIN ChiTietPhieuGiaoHang ON ChiTietPhieuGiaoHang.MaPhieuGiaoHang = PhieuGiaoHang.MaPhieuGiaoHang " +
                      "WHERE PhieuGiaoHang.MaPhieuGiaoHang = N'" + txtMaPhieuGH.Text.Trim() + "' AND ChiTietPhieuGiaoHang.MaDoChoi = N'" + cboMaDC.Text + "'";

                if (Class.Functions.CheckKey(sql))
                {
                    MessageBox.Show("Mã phiếu giao hàng và mã đồ chơi đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaPhieuGH.Focus();
                    return;
                }
                string ngayGiaoFormatted = dtpNgayGiao.Value.ToString("yyyy/MM/dd"); 
                sql = "INSERT INTO PhieuGiaoHang VALUES(N'" + txtMaPhieuGH.Text.Trim() + "',N'" + cboMaDDH.Text + "', '" + ngayGiaoFormatted + "')";
                qr = "INSERT INTO ChiTietPhieuGiaoHang VALUES(N'" + txtMaPhieuGH.Text.Trim() + "',N'" + cboMaDC.Text + "'," + Int32.Parse(txtSoLuong.Text) + ", " + float.Parse(txtDonGia.Text) + ")";
                Class.Functions.RunSQL(sql);
                Class.Functions.RunSQL(qr);

                MessageBox.Show("Thêm thành công!");
                LoadDataGridView();
            }
            if (chucNangDaChon == ChucNang.UPDATE)
            {
                string sql = "update PhieuGiaoHang set MaDonDatHang = N'" + cboMaDDH.Text.ToString() +
                             "', NgayGiaoHang = N'" + dtpNgayGiao.Value.ToString("yyyy/MM/dd") +
                             "' where MaPhieuGiaoHang = N'" + txtMaPhieuGH.Text + "'";
                string qr = "update ChiTietPhieuGiaoHang set SoLuong = " + int.Parse(txtSoLuong.Text) +
                             ", DonGia = " + float.Parse(txtDonGia.Text) +
                             " where MaPhieuGiaoHang = N'" + txtMaPhieuGH.Text + "' and MaDoChoi = N'" + cboMaDC.Text + "'"; 
                Class.Functions.RunSQL(sql);
                Class.Functions.RunSQL(qr);
                SwitchMode(ChucNang.NONE);
                LoadDataGridView();
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SwitchMode(ChucNang.NONE);
            LoadDataGridView();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXemDH_Click(object sender, EventArgs e)
        {
            TimKiem = cboMaDDH.Text.ToString();
            frmDonDH frmDDH = new frmDonDH(this);
            this.Hide();
            frmDDH.ShowDialog();
            this.Show();
        }

        private void dgvHDBanHang_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                txtMaPhieuGH.Focus();
                return;
            }
            if (tblPhieuGiaoHang.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMaPhieuGH.Text = dgvPhieuGH.CurrentRow.Cells[0].Value.ToString();
            cboMaDDH.Text = dgvPhieuGH.CurrentRow.Cells[1].Value.ToString();
            dtpNgayGiao.Text = dgvPhieuGH.CurrentRow.Cells[2].Value.ToString();
            cboMaDC.Text = dgvPhieuGH.CurrentRow.Cells[3].Value.ToString();
            txtSoLuong.Text = dgvPhieuGH.CurrentRow.Cells[4].Value.ToString();
            txtDonGia.Text = dgvPhieuGH.CurrentRow.Cells[5].Value.ToString();

            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem mã phiếu giao hàng có được nhập không
            if (txtTimMaPGH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã phiếu giao hàng cần tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xây dựng câu truy vấn SQL để tìm kiếm thông tin phiếu giao hàng và chi tiết phiếu giao hàng tương ứng
            string sql = "SELECT PhieuGiaoHang.MaPhieuGiaoHang, PhieuGiaoHang.MaDonDatHang, PhieuGiaoHang.NgayGiaoHang, " +
                         "ChiTietPhieuGiaoHang.MaDoChoi, ChiTietPhieuGiaoHang.SoLuong, ChiTietPhieuGiaoHang.DonGia " +
                         "FROM PhieuGiaoHang " +
                         "INNER JOIN ChiTietPhieuGiaoHang ON " +
                         "PhieuGiaoHang.MaPhieuGiaoHang = ChiTietPhieuGiaoHang.MaPhieuGiaoHang " +
                         "WHERE PhieuGiaoHang.MaPhieuGiaoHang LIKE'%" + txtTimMaPGH.Text + "%'";
            tblPhieuGiaoHang = Class.Functions.GetDataToTable(sql);
            dgvPhieuGH.DataSource = tblPhieuGiaoHang;
        }

    }
}
