using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106
{
    public partial class Sign_In : Form
    {
        public delegate void LoginSuccessHandler(string username);
        public event LoginSuccessHandler OnLoginSuccess;

        public Sign_In()
        {
            InitializeComponent();
            this.Load += Sign_In_Load;
        }

        
        private void linkLabel_ForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Reset_Pass resetpass = new Reset_Pass();
            resetpass.ShowDialog();
        }
        private void linkLabel_SignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sign_Up signup = new Sign_Up();
            signup.ShowDialog();
        }

        Modify modify = new Modify();

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            string user_name = txbUserName.Text;
            string password = txbPassword.Text;
           // string user_id = 
            if (user_name.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Tên tài khoản!");
            }
            else if (password.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
            }
            else
            {
                // Gửi yêu cầu đăng nhập đến server
                var loginRequest = new
                {
                    type = "login",
                    username = user_name,
                    password = password
                };
                string requestData = JsonConvert.SerializeObject(loginRequest);
                byte[] data = Encoding.UTF8.GetBytes(requestData);

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
                        OnLoginSuccess?.Invoke(user_name);

                        HomePage home = new HomePage(user_name);
                        home.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(responseObject.message.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Sign_In_Load(object sender, EventArgs e)
        {
            // Tạo một đối tượng của Sign_In và gán sự kiện OnLoginSuccess
            Sign_In signInForm = new Sign_In();
            signInForm.OnLoginSuccess += OpenHomePage;
        }

        private void OpenHomePage(string username)
        {
            // Mở form HomePage và truyền thông tin người dùng
            HomePage homePage = new HomePage(username);
            homePage.Show();
        }

        private void chbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            // Kiểm tra trạng thái của checkbox `chbShowPass`
            if (chbShowPass.Checked)
            {
                // Nếu checkbox được đánh dấu, hiển thị văn bản trong ô txbPassWord
                txbPassword.PasswordChar = '\0';
            }
            else
            {
                // Nếu checkbox không được đánh dấu, ẩn văn bản trong ô txbPassWord dưới dạng *
                txbPassword.PasswordChar = '●';
            }
        }

        
    }
}

