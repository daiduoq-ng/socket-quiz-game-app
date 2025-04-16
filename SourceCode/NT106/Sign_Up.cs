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
using System.Net;
using System.IO;
using System.Drawing.Imaging;

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
            //biểu thức chính quy để kiểm tra định dạng email
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        public static void ResizeImage(string inputImagePath, string outputImagePath, int maxWidth, int maxHeight)
        {
            using (Image originalImage = Image.FromFile(inputImagePath))
            {
                int newWidth, newHeight;

                if (originalImage.Width > originalImage.Height)
                {
                    newWidth = maxWidth;
                    newHeight = (int)(originalImage.Height * ((float)maxWidth / originalImage.Width));
                }
                else
                {
                    newHeight = maxHeight;
                    newWidth = (int)(originalImage.Width * ((float)maxHeight / originalImage.Height));
                }

                using (Bitmap resizedImage = new Bitmap(newWidth, newHeight))
                {
                    using (Graphics g = Graphics.FromImage(resizedImage))
                    {
                        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                        g.DrawImage(originalImage, 0, 0, newWidth, newHeight);
                    }
                    resizedImage.Save(outputImagePath, ImageFormat.Jpeg);
                }
            }
        }

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
            if (string.IsNullOrEmpty(tbIP.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ IP của Server!.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                byte[] imageBytes = File.ReadAllBytes(selectedImagePath);
                int imageSize = imageBytes.Length;

              
                int maxSize = 1024 * 1024; // 1MB is maximum of avarta
                if (imageSize > maxSize)
                {
                    MessageBox.Show("Kích thước của hình ảnh quá lớn. Vui lòng chọn một hình ảnh nhỏ hơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
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

                //gửi yêu cầu đăng ký đến server
                using (Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
                {
                    string IpAddress = tbIP.Text;
                    client.Connect(IpAddress, 8080);
                    client.Send(data);

                    byte[] buffer = new byte[4096000];
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
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Title = "Chọn ảnh đại diện",
                Filter = "Tệp hình ảnh (*.jpg;*.jpeg;*.gif;*.png)|*.jpg;*.jpeg;*.gif;*.png",
                FilterIndex = 1,
                RestoreDirectory = true
            })
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = openFileDialog1.FileName;

                    if (!string.IsNullOrEmpty(selectedImagePath))
                    {
                        try
                        {
                            using (FileStream fs = new FileStream(selectedImagePath, FileMode.Open, FileAccess.Read))
                            {
                                byte[] imageBytes = new byte[fs.Length];
                                fs.Read(imageBytes, 0, (int)fs.Length);

                                // Kiểm tra kích thước của hình ảnh
                                int maxSize = 1024 * 1024; // 1MB
                                if (fs.Length > maxSize)
                                {
                                    MessageBox.Show("Kích thước của hình ảnh quá lớn. Vui lòng chọn một hình ảnh nhỏ hơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;
                                }

                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    pictureBoxPreview.Image = Image.FromStream(ms);
                                }

                                MessageBox.Show("Hình ảnh đã được chọn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
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





        private void chbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPass.Checked)
            {
                textBox_pass.PasswordChar = '\0';
                textBox_confpass.PasswordChar = '\0';
            }
            else
            {

                textBox_confpass.PasswordChar = '●';
                textBox_pass.PasswordChar = '●';
            }
        }
    }
}
