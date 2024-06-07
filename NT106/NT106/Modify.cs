using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace NT106
{
    class Modify
    {
        public Modify()
        {

        }
        SqlCommand SqlCommand; //Dung de truy van 
        SqlDataReader dataReader; //Dung de doc du lieu trong bang 
        public List<User> Users(string query)
        {
            List<User> users = new List<User>();
            using (SqlConnection sqlConnection =Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                SqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = SqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    users.Add(new User(dataReader.GetString(0), dataReader.GetString(1)));
                }
                sqlConnection.Close();
            }
            return users;
        }
        public void Command(string query) //dang ki tai khoan
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                SqlCommand = new SqlCommand (query, sqlConnection);
                SqlCommand.ExecuteNonQuery(); //thuc thi cau query nay

                sqlConnection.Close();
            }
        }

        public void UploadImage(string username, string imagePath)
        {
            // Đọc dữ liệu hình ảnh thành mảng byte
            byte[] imageBytes = System.IO.File.ReadAllBytes(imagePath);

            // Chuẩn bị truy vấn SQL INSERT
            string insertQuery = "UPDATE TaiKhoan SET ProfileImage = @ProfileImage WHERE UserName = @UserName";

            // Kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                // Mở kết nối
                connection.Open();

                // Chuẩn bị đối tượng SqlCommand
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    // Thêm tham số cho truy vấn SQL UPDATE
                    command.Parameters.AddWithValue("@ProfileImage", imageBytes);
                    command.Parameters.AddWithValue("@UserName", username);

                    // Thực thi truy vấn SQL UPDATE
                    int rowsAffected = command.ExecuteNonQuery();

                    // Kiểm tra xem dữ liệu đã được cập nhật thành công hay không
                   
                }
            }
        }
    }

}
