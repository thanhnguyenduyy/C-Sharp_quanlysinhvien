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
    public partial class Form2 : Form
    {
        private static SqlDataAdapter ad;
        private static DataTable dt;
        private string connectionString = @"Data Source=VNHU1019\MAYAO;Initial Catalog=quanlysinhvien;Integrated Security=True";

        public Form2()
        {
            InitializeComponent();
            hienthi(db1);
        }

        //danh sách thông tin sinh vien
        private void hienthi(DataGridView db1)
        {
           using (SqlConnection connection = new SqlConnection(connectionString))
           {
               try
               {
                   connection.Open();

                   string query = "SELECT * FROM SINHVIEN"; // Truy vấn để lấy dữ liệu từ cơ sở dữ liệu
                   SqlCommand command = new SqlCommand(query, connection);

                   SqlDataReader reader = command.ExecuteReader();

                   while (reader.Read())
                   {
                       //
                       dt = new DataTable();
                       ad.Fill(dt);
                       db1.DataSource = dt;

                       //Set tên cột cho danh sách thông tin sinh viên
                       db1.Columns[0].HeaderText = "Mã sinh viên";
                       db1.Columns[1].HeaderText = "Họ và tên";
                       db1.Columns[2].HeaderText = "Số điện thoại";
                       db1.Columns[3].HeaderText = "Địa chỉ";
                   }

                   reader.Close();
               }
               catch (Exception ex)
               {
                   // Xử lý lỗi kết nối cơ sở dữ liệu
                   MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message);
               }
           }
        }

        //insert thông tin sinh viên
        private void button_Add(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO SINHVIEN (MASV, HOTEN, SDT, DIACHI) VALUES (@maSV, @hoTEN, @phone, @diaChi)";

                    // Tạo một đối tượng SqlCommand với câu truy vấn INSERT và kết nối cơ sở dữ liệu
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        string maSV = masv_txt.Text;
                        string hoTEN = hovaten_txt.Text;
                        string phone = sdt_txt.Text;
                        string diaChi = diachi_txt.Text;

                        // Thêm các tham số và giá trị tương ứng vào câu truy vấn
                        command.Parameters.AddWithValue("@maSV", maSV);
                        command.Parameters.AddWithValue("@hoTEN", hoTEN);
                        command.Parameters.AddWithValue("@phone", phone);
                        command.Parameters.AddWithValue("@diaChi", diaChi);

                        // Thực thi câu truy vấn INSERT và lấy số hàng bị ảnh hưởng
                        int rowsAffected = command.ExecuteNonQuery();
                        // Kiểm tra số hàng bị ảnh hưởng để xác định kết quả chèn thông tin đăng ký
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm thành công !", "Thông báo");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại" + ex);
            }
        }

        //update thông tin sinh viên theo masv
        private void button_Update(object sender, EventArgs e)
        {
            //try
            //{
            //    string sqlUpdate = "UPDATE SINHVIEN SET hoten=N'" + hovaten_txt.Text + "', sdt='" + sdt_txt.Text + "', diachi='" + diachi_txt.Text + "' where masv='" + masv_txt.Text + "'";
            //    mycon = new SqlConnection(sqlconn);
            //    mycon.Open();
            //    com = new SqlCommand(sqlUpdate, mycon);
            //    com.ExecuteNonQuery();
            //    MessageBox.Show("Update thành công thông tin sinh viên có msv là: '" + masv_txt.Text + "'", "Thông báo");
            //    hienthi(db1);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Update thất bại thông tin sinh viên có msv là: '" + masv_txt.Text + "'" + ex);
            //}
        }

        //hiển thị thông tin sinh viên ra ô input
        private void db1_Click(object sender, EventArgs e)
        {
            int curow = db1.CurrentRow.Index;
            masv_txt.Text = db1.Rows[curow].Cells[0].Value.ToString();
            hovaten_txt.Text = db1.Rows[curow].Cells[1].Value.ToString();
            sdt_txt.Text = db1.Rows[curow].Cells[2].Value.ToString();
            diachi_txt.Text = db1.Rows[curow].Cells[3].Value.ToString();
        }

        // reset ô input thành rỗng
        private void button_Reset(object sender, EventArgs e)
        {
            masv_txt.ResetText();
            hovaten_txt.ResetText();
            sdt_txt.ResetText();
            diachi_txt.ResetText();
        }

        //xóa 1 thông tin sinh viên
        private void button_Delete(object sender, EventArgs e)
        {
            //try
            //{
            //    string sqlDelete = "DELETE SINHVIEN WHERE masv='" + masv_txt.Text + "'";
            //    mycon = new SqlConnection(sqlconn);
            //    mycon.Open();
            //    com = new SqlCommand(sqlDelete, mycon);
            //    com.ExecuteNonQuery();
            //    MessageBox.Show("Xóa thành công", "Thông báo");
            //    hienthi(db1);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Xóa thất bại" + ex);
            //}

        }

        //thoát chương trình
        private void button_Exit(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        //tìm kiếm thông tin sinh viên theo masv, hoten, sdt, diachi
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //string keyword = SearchKeyword_txt.Text;

            //// Xây dựng câu truy vấn động
            //string searchQuery = "SELECT * FROM SINHVIEN WHERE ";
            //string[] columns = { "masv", "hoten", "sdt", "diachi" };

            //for (int i = 0; i < columns.Length; i++)
            //{
            //    if (i > 0)
            //    {
            //        searchQuery += " OR ";
            //    }

            //    searchQuery += string.Format("{0} LIKE '%'+@Keyword+'%'", columns[i]);
            //}

            //using (SqlCommand command = new SqlCommand(searchQuery, mycon))
            //{
            //    command.Parameters.AddWithValue("@Keyword", keyword);

            //    DataTable searchResult = new DataTable();
            //    SqlDataAdapter searchAdapter = new SqlDataAdapter(command);
            //    searchAdapter.Fill(searchResult);
            //    db1.DataSource = searchResult;
            //}
        }
    }
}
