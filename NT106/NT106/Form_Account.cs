using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data.SqlClient;

namespace NT106
{
    public partial class Form_Account : Form
    {

        private string username;
        public Form_Account(string username)
        {
            InitializeComponent();
            this.username = username;
            


        }

        public void SetUsername(string username)
        {
            this.username = username;
            // Update any controls or properties that display the username
            // For example:
            lbHoTen.Text = username;
        }


        private void lbDoiAvt_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif)|*.jpg;*.jpeg;*.png;*.gif|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                if (pbAvt.BackgroundImage != null)
                {
                    pbAvt.BackgroundImage.Dispose(); 
                    pbAvt.BackgroundImage = null;    
                }

                Image newImage = Image.FromFile(imagePath);
                pbAvt.Image = newImage;
                pbAvt.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
        Modify modify = new Modify();

        private void Form_Account_Load(object sender, EventArgs e)
        {
            
            string query1 = "SELECT Email, ProfileImage FROM TaiKhoan WHERE UserName = @UserName";

            // Tạo kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                // Mở kết nối
                connection.Open();

                // Chuẩn bị đối tượng SqlCommand
                using (SqlCommand command = new SqlCommand(query1, connection))
                {
                    // Thêm tham số cho câu truy vấn SELECT
                    command.Parameters.AddWithValue("@UserName", username);

                    // Thực thi câu truy vấn SELECT và đọc dữ liệu
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Kiểm tra xem có dữ liệu trả về hay không
                        if (reader.Read())
                        {
                            // Lấy giá trị của cột Email từ kết quả truy vấn
                            string userEmail = reader.GetString(0);

                            // Hiển thị email trên giao diện người dùng
                            lbEmail.Text = userEmail;

                            // Kiểm tra xem cột ProfileImage có dữ liệu không
                            if (!reader.IsDBNull(1))
                            {
                                // Nếu có, lấy dữ liệu ảnh từ cột ProfileImage
                                byte[] profileImageBytes = (byte[])reader["ProfileImage"];

                                // Chuyển đổi dữ liệu ảnh thành hình ảnh và hiển thị trên PictureBox
                                using (var ms = new System.IO.MemoryStream(profileImageBytes))
                                {
                                    pbAvt.Image = Image.FromStream(ms);
                                }
                            }
                            else
                            {
                                // Nếu không có dữ liệu ảnh, có thể hiển thị một hình mặc định hoặc ẩn điều khiển hình ảnh
                                // Ví dụ: pbAvt.Image = Properties.Resources.DefaultImage;
                            }
                        }
                        else
                        {
                            // Không tìm thấy người dùng có tên như vậy trong cơ sở dữ liệu
                            MessageBox.Show("Không tìm thấy người dùng có tên như vậy trong cơ sở dữ liệu.");
                        }
                    }
                }
            }
        }
    }
}
