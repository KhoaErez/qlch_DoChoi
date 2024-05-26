using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace QuanLiBanHang.Class
{
    internal class Functions
    {
        public static SqlConnection Conn;
        public static void Connect()
        {
            string url = @"Data Source=TRANKHOA\SQLEXPRESS;Initial Catalog=QuanLiDoChoi;Integrated Security=True";
            Conn = new SqlConnection(url);
            Conn.Open();
            //if (Conn.State == ConnectionState.Open)
            //    MessageBox.Show("Kết nối thành công!", "Thông báo", MessageBoxButtons.OK);
            //else MessageBox.Show("Kết nối không thành công!", "Thông báo", MessageBoxButtons.OK);
        }

        public static DataTable GetDataToTable(string query)
        {
            SqlDataAdapter dap = new SqlDataAdapter(query, Conn);
            DataTable table = new DataTable();
            dap.Fill(table);
            return table;
        }

        //Hàm kiểm tra khoá trùng
        public static bool CheckKey(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, Conn);
            DataTable table = new DataTable();
            dap.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            return false;
        }

        //Hàm thực hiện câu lệnh SQL
        public static void RunSQL(string sql)
        {
            SqlCommand cmd; //Đối tượng thuộc lớp SqlCommand
            cmd = new SqlCommand();
            cmd.Connection = Conn; //Gán kết nối
            cmd.CommandText = sql; //Gán lệnh SQL
            try
            {
                cmd.ExecuteNonQuery(); //Thực hiện câu lệnh SQL
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();//Giải phóng bộ nhớ
            cmd = null;
        }

        public static void RunSqlDel(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Functions.Conn;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu đang được dùng, không thể xoá...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                //MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }

        //Chuyển đổi từ PM sang dạng 24h
        public static string ConvertTimeTo24(string hour)
        {
            string h = "";
            switch (hour)
            {
                case "1":
                    h = "13";
                    break;
                case "2":
                    h = "14";
                    break;
                case "3":
                    h = "15";
                    break;
                case "4":
                    h = "16";
                    break;
                case "5":
                    h = "17";
                    break;
                case "6":
                    h = "18";
                    break;
                case "7":
                    h = "19";
                    break;
                case "8":
                    h = "20";
                    break;
                case "9":
                    h = "21";
                    break;
                case "10":
                    h = "22";
                    break;
                case "11":
                    h = "23";
                    break;
                case "12":
                    h = "0";
                    break;
            }
            return h;
        }

        //Hàm tạo khóa có dạng: TientoNgaythangnam_giophutgiay
        public static string CreateKey(string tiento)
        {
            string key = tiento;
            string[] partsDay;
            partsDay = DateTime.Now.ToShortDateString().Split('/');
            //Ví dụ 07/08/2009
            string d = String.Format("{0}{1}{2}", partsDay[0], partsDay[1], partsDay[2]);
            key = key + d;
            string[] partsTime;
            partsTime = DateTime.Now.ToLongTimeString().Split(':');
            //Ví dụ 7:08:03 PM hoặc 7:08:03 AM
            if (partsTime[2].Substring(3, 2) == "PM")
                partsTime[0] = ConvertTimeTo24(partsTime[0]);
            if (partsTime[2].Substring(3, 2) == "AM")
                if (partsTime[0].Length == 1)
                    partsTime[0] = "0" + partsTime[0];
            //Xóa ký tự trắng và PM hoặc AM
            partsTime[2] = partsTime[2].Remove(2, 3);
            string t;
            t = String.Format("_{0}{1}{2}", partsTime[0], partsTime[1], partsTime[2]);
            key = key + t;
            return key;
        }

        public static string ChuyenSoSangChu(string sNumber)
        {
            int mLen, mDigit;
            string mTemp = "";
            string[] mNumText;
            //Xóa các dấu "," nếu có
            sNumber = sNumber.Replace(",", "");
            mNumText = "không;một;hai;ba;bốn;năm;sáu;bảy;tám;chín".Split(';');
            mLen = sNumber.Length - 1; // trừ 1 vì thứ tự đi từ 0
            for (int i = 0; i <= mLen; i++)
            {
                mDigit = Convert.ToInt32(sNumber.Substring(i, 1));
                mTemp = mTemp + " " + mNumText[mDigit];
                if (mLen == i) // Chữ số cuối cùng không cần xét tiếp break; 
                    switch ((mLen - i) % 9)
                    {
                        case 0:
                            mTemp = mTemp + " tỷ";
                            if (sNumber.Substring(i + 1, 3) == "000") i = i + 3;
                            if (sNumber.Substring(i + 1, 3) == "000") i = i + 3;
                            if (sNumber.Substring(i + 1, 3) == "000") i = i + 3;
                            break;
                        case 6:
                            mTemp = mTemp + " triệu";
                            if (sNumber.Substring(i + 1, 3) == "000") i = i + 3;
                            if (sNumber.Substring(i + 1, 3) == "000") i = i + 3;
                            break;
                        case 3:
                            mTemp = mTemp + " nghìn";
                            if (sNumber.Substring(i + 1, 3) == "000") i = i + 3;
                            break;
                        default:
                            switch ((mLen - i) % 3)
                            {
                                case 2:
                                    mTemp = mTemp + " trăm";
                                    break;
                                case 1:
                                    mTemp = mTemp + " mươi";
                                    break;
                            }
                            break;
                    }
            }
            //Loại bỏ trường hợp x00
            mTemp = mTemp.Replace("không mươi không ", "");
            mTemp = mTemp.Replace("không mươi không", ""); //Loại bỏ trường hợp 00x 
            mTemp = mTemp.Replace("không mươi ", "linh "); //Loại bỏ trường hợp x0, x>=2
            mTemp = mTemp.Replace("mươi không", "mươi");
            //Fix trường hợp 10
            mTemp = mTemp.Replace("một mươi", "mười");
            //Fix trường hợp x4, x>=2
            mTemp = mTemp.Replace("mươi bốn", "mươi tư");
            //Fix trường hợp x04
            mTemp = mTemp.Replace("linh bốn", "linh tư");
            //Fix trường hợp x5, x>=2
            mTemp = mTemp.Replace("mươi năm", "mươi lăm");
            //Fix trường hợp x1, x>=2
            mTemp = mTemp.Replace("mươi một", "mươi mốt");
            //Fix trường hợp x15
            mTemp = mTemp.Replace("mười năm", "mười lăm");
            //Bỏ ký tự space
            mTemp = mTemp.Trim();
            //Viết hoa ký tự đầu tiên
            mTemp = mTemp.Substring(0, 1).ToUpper() + mTemp.Substring(1) + " đồng";
            return mTemp;
        }

        public static string GetFieldValues(string sql)
        {
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, Conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
                ma = reader.GetValue(0).ToString();
            reader.Close();
            return ma;
        }

        public static void Disconnect()
        {
            if (Conn.State == ConnectionState.Open)
            {
                Conn.Close();   	//Đóng kết nối
                Conn.Dispose(); 	//Giải phóng tài nguyên
                Conn = null;
            }
        }

    }
}
