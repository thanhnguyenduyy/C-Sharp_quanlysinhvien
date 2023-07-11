using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace quanlysinhvien
{
    public partial class Login : Form
    {
        private static SqlConnection mycon;
        public static string sqlconn = @"Data Source=VNHU1019\MAYAO;Initial Catalog=quanlysinhvien;Integrated Security=True";

        public Login()
        {
            InitializeComponent();
            mycon = new SqlConnection(sqlconn);
        }

        private void btn_login(object sender, EventArgs e)
        {
            string user = user_txt.Text;
            string password = password_txt.Text;

            //check validate
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập tên người dùng và mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsLoginValid(user, password))
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo");
                // Đóng form hiện tại
                this.Close();

                // Thực hiện các thao tác sau khi đăng nhập thành công
                Form2 form2 = new Form2();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Tên người dùng hoặc mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool IsLoginValid(string username, string password)
        {
            bool isValid = false;

            // Kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(sqlconn))
            {
                try
                {
                    connection.Open();

                    // Tạo truy vấn kiểm tra thông tin đăng nhập
                    string query = "SELECT COUNT(*) FROM USERS WHERE USERNAME = @Username AND PASSWORD = @Password";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    int result = (int)command.ExecuteScalar();

                    if (result > 0)
                    {
                        isValid = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return isValid;
        }

        private void checkbox_showpass(object sender, EventArgs e)
        {
            if (show_password.Checked)
            {
                // Hiển thị text bình thường
                password_txt.PasswordChar = '\0'; 
            }
            else
            {
                // Ẩn mật khẩu bằng ký tự *
                password_txt.PasswordChar = '*'; 
            }
        }
    }
}
