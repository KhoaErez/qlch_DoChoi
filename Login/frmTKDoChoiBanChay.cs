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
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLiBanHang
{
    public partial class frmTKDoChoiBanChay : Form
    {
        DataTable dtTkeBanChay;
        public frmTKDoChoiBanChay()
        {
            InitializeComponent();
        }

        private void frmTKDoChoiBanChay_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            string sql = "SELECT * FROM ChiTietHoaDon ORDER BY SoLuong DESC";
            dtTkeBanChay = Functions.GetDataToTable(sql);
            dgvTKDoanhSo.DataSource = dtTkeBanChay;

            dgvTKDoanhSo.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvTKDoanhSo.AllowUserToAddRows = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Tạo SaveFileDialog để lưu tệp Excel
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel files (*.xlsx)|*.xlsx",
                FileName = "ThongKeBanChay.xlsx"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Khởi tạo Excel Application
                    Excel.Application excelApp = new Excel.Application();
                    if (excelApp == null)
                    {
                        MessageBox.Show("Excel is not properly installed!");
                        return;
                    }

                    // Tạo Workbook và Worksheet mới
                    Excel.Workbook excelWorkbook = excelApp.Workbooks.Add();
                    Excel.Worksheet excelWorksheet = (Excel.Worksheet)excelWorkbook.Sheets[1];

                    // Thêm tiêu đề cột vào worksheet
                    for (int i = 1; i <= dtTkeBanChay.Columns.Count; i++)
                    {
                        excelWorksheet.Cells[1, i] = dtTkeBanChay.Columns[i - 1].ColumnName;
                    }

                    // Thêm dữ liệu từ DataTable vào worksheet
                    for (int i = 0; i < dtTkeBanChay.Rows.Count; i++)
                    {
                        for (int j = 0; j < dtTkeBanChay.Columns.Count; j++)
                        {
                            excelWorksheet.Cells[i + 2, j + 1] = dtTkeBanChay.Rows[i][j].ToString();
                        }
                    }

                    // Định dạng trang
                    excelWorksheet.Columns.AutoFit();

                    // Lưu workbook vào tệp đã chọn
                    excelWorkbook.SaveAs(saveFileDialog.FileName);
                    excelWorkbook.Close();
                    excelApp.Quit();

                    // Giải phóng tài nguyên
                    releaseObject(excelWorksheet);
                    releaseObject(excelWorkbook);
                    releaseObject(excelApp);

                    MessageBox.Show("Xuất dữ liệu ra Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi xuất dữ liệu ra Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the object " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
