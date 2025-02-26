using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace DA1_QLQuanNET.DAO
{
    internal class Functions
    {
        private static Functions instance;

        public static Functions Instance
        {
            get
            {
                if (instance == null)
                    Functions.instance = new Functions();
                return Functions.instance;
            }
            private set
            {
                Functions.instance = value;
            }
        }

        private static string chuoiKetNoi = @"Data Source=DESKTOP-BEP8RP9\SQLEXPRESS;Initial Catalog=QuanLyQuanNET;Integrated Security=True";

        private static SqlConnection ketNoi;

        public static void Connect()
        {
            ketNoi = new SqlConnection(chuoiKetNoi);

            try
            {
                ketNoi.Open();                  //Mở kết nối
                MessageBox.Show("Đăng nhập thành công", "Thông Báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối với dữ liệu: " + ex.Message);
            }
        }

        public static void Disconnect()
        {
            if (ketNoi != null && ketNoi.State == ConnectionState.Open)
            {
                ketNoi.Close();    //Đóng kết nối
                ketNoi.Dispose();  //Giải phóng tài nguyên
                ketNoi = null;
            }
        }

        // lấy dữ liệu vào bảng
        public static DataTable GetDataToTable(string chuoiLenh)
        {
            SqlDataAdapter boDocGhi = new SqlDataAdapter(chuoiLenh, ketNoi); // đối tượng thuộc lớp DataAdapter

            DataTable table = new DataTable();
            boDocGhi.Fill(table); // đưa kết quả câu lệnh sql vào bảng
            return table;
        }

        public DataTable RunQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(chuoiKetNoi))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        //Kiểm tra quy định số điện thoại
        public static bool CheckSDT(string s)
        {
            if (s.Length != 10) //nêu độ dài sdt khác 10 thì false
                return false;

            for (int i = 0; i < s.Length; i++)
            {
                if (!char.IsDigit(s[i])) // Kiểm tra xem ký tự có phải là một chữ số không
                    return false;
            }
            return true;
        }

        //lấy dữ liệu tìm file ảnh thông qua sql
        public static string GetFieldValues(string chuoiLenh)
        {
            string ma = "";
            SqlCommand cmd = new SqlCommand(chuoiLenh, ketNoi);
            SqlDataReader boDocGhi;
            boDocGhi = cmd.ExecuteReader();
            while (boDocGhi.Read())
                ma = boDocGhi.GetValue(0).ToString();
            boDocGhi.Close();
            return ma;
        }

        public string getDinhDanhHangNghin(int i)
        {
            return String.Format("{0:###,###,##0}", i);
        }
    }
}