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
using Newtonsoft.Json;
using System.Net.Sockets;

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

            if (string.IsNullOrEmpty(selectedImagePath))
            {
                MessageBox.Show("Vui lòng chọn một tập tin hình ảnh trước khi đăng ký.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // Đọc dữ liệu hình ảnh thành mảng byte
                byte[] imageBytes = System.IO.File.ReadAllBytes(selectedImagePath);

                // Tạo đối tượng đăng ký
                var registerRequest = new
                {
                    type = "register",
                    username = userName,
                    password = password,
                    email = email,
                    profileImage = Convert.ToBase64String(imageBytes)
                };
                string requestData = JsonConvert.SerializeObject(registerRequest);
                byte[] data = Encoding.UTF8.GetBytes(requestData);

                // In ra requestData để kiểm tra
                Console.WriteLine("Request data: " + requestData);

                // Gửi yêu cầu đăng ký đến server
                using (Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP))
                {
                    client.Connect("127.0.0.1", 8080);
                    client.Send(data);

                    byte[] buffer = new byte[1024];
                    int receivedBytes = client.Receive(buffer);
                    string response = Encoding.UTF8.GetString(buffer, 0, receivedBytes);
                    dynamic responseObject = JsonConvert.DeserializeObject(response);

                    if (responseObject.status == "success")
                    {
                        MessageBox.Show(responseObject.message.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show(responseObject.message.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        
                        Modify modify = new Modify();
                        modify.UploadImage(textBox_Name.Text, selectedImagePath); 
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
                MessageBox.Show("Vui lòng chọn một tập tin hình ảnh để làm Avatar!.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
