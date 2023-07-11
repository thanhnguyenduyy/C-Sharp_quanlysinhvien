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
using System.Text.RegularExpressions;

namespace quanlysinhvien
{
    public partial class Register : Form
    {
        private string connectionString = @"Data Source=VNHU1019\MAYAO;Initial Catalog=quanlysinhvien;Integrated Security=True";

        public Register()
        {
            InitializeComponent();
        }

        // validate username
        private bool ValidateUsername(string username)
        {
            return !string.IsNullOrWhiteSpace(username);
        }

        // validate password
        private bool ValidatePassword(string password)
        {
            return !string.IsNullOrWhiteSpace(password) && password.Length >= 8;
        }

        // validate confirm password
        private bool ValidateConfirmPassword(string password, string confirmPassword)
        {
            return password == confirmPassword;
        }

        //validate email
        private bool ValidateEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, emailPattern);
        }

        // Sự kiện Validating của trường Email
        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            string email = email_txt.Text;

            // Kiểm tra tính hợp lệ của địa chỉ email
            if (!IsValidEmail(email))
            {
                // Hiển thị thông báo lỗi
                errorProvider1.SetError(email_txt, "Địa chỉ email không hợp lệ.");
                e.Cancel = true; // Ngăn không cho người dùng di chuyển đến trường tiếp theo
            }
            else
            {
                // Xóa thông báo lỗi (nếu có)
                errorProvider1.SetError(email_txt, string.Empty);
            }
        }

        // Phương thức kiểm tra tính hợp lệ của địa chỉ email
        private bool IsValidEmail(string email)
        {
            // Sử dụng Regex để kiểm tra định dạng email
            // Đây chỉ là một ví dụ đơn giản, bạn có thể sử dụng một biểu thức chính quy phức tạp hơn để kiểm tra định dạng email
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(emailPattern);

            return regex.IsMatch(email);
        }


        private void btn_register(object sender, EventArgs e)
        {
            // Gọi phương thức txtEmail_Validating trực tiếp
            txtEmail_Validating(sender, new CancelEventArgs());


            string username = user_txt.Text;
            string password = password_txt.Text;
            string confirmPassword = passworConfirm_txt.Text;
            string email = email_txt.Text;

            //validate username
            if (!ValidateUsername(username))
            {
                MessageBox.Show("Tên sử dụng không hợp lệ! Vui lòng nhập tên người dùng hợp lệ.", "Lỗi đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //validate password
            if (!ValidatePassword(password))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu hợp lệ (ít nhất 8 ký tự).", "Lỗi đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //validate confirmPassword
            if (!ValidateConfirmPassword(password, confirmPassword))
            {
                MessageBox.Show("Mất khẩu không hợp lệ! Vui lòng nhập cùng một mật khẩu.", "Lỗi đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidateEmail(email))
            {
                MessageBox.Show("Email không hợp lệ! Vui lòng nhập một địa chỉ email hợp lệ.", "Lỗi đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (InsertRegistrationInfo(username, password, email))
            {
                MessageBox.Show("Đăng kí thành công!" + Environment.NewLine + "Username: " + username + Environment.NewLine + "Email: " + email, "Đăng kí thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đăng kí thất bại!", "Lỗi đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Function đăng kí thông tin
        private bool InsertRegistrationInfo(string username, string password, string email)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO USERS (USERNAME, PASSWORD, EMAIL) VALUES (@Username, @Password, @Email)";

                    // Tạo một đối tượng SqlCommand với câu truy vấn INSERT và kết nối cơ sở dữ liệu
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        // Thêm các tham số và giá trị tương ứng vào câu truy vấn
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Email", email);

                        // Thực thi câu truy vấn INSERT và lấy số hàng bị ảnh hưởng
                        int rowsAffected = command.ExecuteNonQuery();
                        // Kiểm tra số hàng bị ảnh hưởng để xác định kết quả chèn thông tin đăng ký
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi xảy ra trong quá trình chèn thông tin đăng ký
                MessageBox.Show("Đã xảy ra lỗi trong quá trình đăng ký: " + ex.Message, "Lỗi đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
