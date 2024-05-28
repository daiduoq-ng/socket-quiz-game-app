using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Runtime.Remoting.Messaging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;

namespace NT106
{
    public partial class Sign_Up : Form
    {
        public Sign_Up()
        {
            InitializeComponent();
        }

        public bool checkAccount(string account) //check mk va tk co hop le hay khong
        {
            return Regex.IsMatch(account, "^[a-zA-z0-9]{6,24}$"); //tu aA den zZ va tu 0 den 9
        }

        public bool checkEmail(string email)
        {
            return Regex.IsMatch(email, @"^[a-zA-Z0-9_.]{3,20}@gmail\.com(\.vn|)$");
        }

        Modify modify = new Modify();

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            string userName = textBox_Name.Text;
            string password = textBox_pass.Text;
            string confirmPassword = textBox_confpass.Text;
            string email = textBox_email.Text;

            if (!checkAccount(userName))
            {
                MessageBox.Show("Vui lòng nhập Tên tài khoản từ 6-24 kí tự, với các kí tự chữ và số, chữ hoa và chữ thường!");
                return;
            }

            if (!checkAccount(password))
            {
                MessageBox.Show("Vui lòng nhập Mật khẩu từ 3 đến 20 kí tự, với các kí tự chữ và số, chữ hoa và chữ thường!");
                return;
            }

            if (confirmPassword != password)
            {
                MessageBox.Show("Xác nhận mật khẩu không trùng khớp!");
                return;
            }

            if (!checkEmail(email))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng Email!");
                return;
            }

            if (modify.Users("SELECT * FROM TaiKhoan WHERE Email = '" + email + "'").Count != 0)
            {
                MessageBox.Show("Email này đã được đăng kí, vui lòng sử dụng Email khác!");
                return;
            }

            if (string.IsNullOrEmpty(selectedImagePath))
            {
                MessageBox.Show("Vui lòng chọn một tập tin hình ảnh trước khi đăng ký.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // Đọc dữ liệu hình ảnh thành mảng byte
                byte[] imageBytes = System.IO.File.ReadAllBytes(selectedImagePath);

                // Chuẩn bị câu truy vấn INSERT
                string query = "INSERT INTO TaiKhoan (UserName, Password, Email, ProfileImage) VALUES (@UserName, @Password, @Email, @ProfileImage)";

                // Kết nối đến cơ sở dữ liệu
                using (SqlConnection connection = Connection.GetSqlConnection())
                {
                    // Mở kết nối
                    connection.Open();

                    // Chuẩn bị đối tượng SqlCommand
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm tham số cho câu truy vấn INSERT
                        command.Parameters.AddWithValue("@UserName", userName);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@ProfileImage", imageBytes);

                        // Thực thi câu truy vấn INSERT
                        int rowsAffected = command.ExecuteNonQuery();

                        // Kiểm tra xem dữ liệu đã được thêm thành công hay không
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Đăng ký thành công!");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Đăng ký không thành công!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private string selectedImagePath;

        private void btnUpAVT_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Thiết lập các thuộc tính cho OpenFileDialog
            openFileDialog1.Title = "Chọn ảnh đại diện";
            openFileDialog1.Filter = "Tệp hình ảnh (*.jpg;*.jpeg;*.gif;*.png)|*.jpg;*.jpeg;*.gif;*.png";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            // Hiển thị hộp thoại chọn tập tin
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Lưu đường dẫn đến tệp hình ảnh đã chọn vào biến selectedImagePath
                selectedImagePath = openFileDialog1.FileName;

                // Hiển thị hình ảnh đã chọn (tuỳ chọn)
                pictureBoxPreview.ImageLocation = selectedImagePath; // Giả sử pictureBoxPreview là PictureBox để hiển thị hình ảnh trên giao diện người dùng

                if (!string.IsNullOrEmpty(selectedImagePath))
                {
                    try
                    {
                        // Thực hiện lưu hình ảnh vào CSDL bằng class Modify
                        Modify modify = new Modify();
                        modify.UploadImage(textBox_Name.Text, selectedImagePath); // Giả sử txtUsername là TextBox chứa tên người dùng
                        MessageBox.Show("Hình ảnh đã được tải lên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một tập tin hình ảnh trước khi lưu vào CSDL.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
