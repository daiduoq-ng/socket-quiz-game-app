using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
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
        private string IpAddress;

        public Sign_In()
        {
            InitializeComponent();
           
            IpAddress = tbIPServer.Text;
        }

        
        private void OpenHomePage(string username, string ipAddress)
        {
            HomePage homePage = new HomePage(username, ipAddress);
            homePage.Show();
        }

        private void linkLabel_ForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (CheckIp())
            {
                Reset_Pass resetpass = new Reset_Pass(IpAddress);
                resetpass.ShowDialog();
            }
        }

        private void linkLabel_SignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
                Sign_Up signup = new Sign_Up();
                signup.ShowDialog();
            
        }

       

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            if (CheckIp())
            {
                string user_name = txbUserName.Text;
                string password = txbPassword.Text;
                string ipAddress = tbIPServer.Text.Trim();

                if (user_name.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập Tên tài khoản!","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else if (password.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu!","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                
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
                        client.Connect(ipAddress, 8080);
                        client.Send(data);

                        byte[] buffer = new byte[1024];
                        int receivedBytes = client.Receive(buffer);
                        string response = Encoding.UTF8.GetString(buffer, 0, receivedBytes);
                        dynamic responseObject = JsonConvert.DeserializeObject(response);
                        Console.WriteLine("Response: " + response); // hoặc Debug.WriteLine(...)

                        if (responseObject != null && responseObject.status == "success")
                        {
                            MessageBox.Show(responseObject.message.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            OpenHomePage(user_name, ipAddress);
                            this.Close();
                        }

                        
                        else
                        {
                            MessageBox.Show(responseObject.message.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private bool CheckIp()
        {
            string ipAddress = tbIPServer.Text;

            if (string.IsNullOrWhiteSpace(ipAddress))
            {
                MessageBox.Show("Vui lòng nhập IP của Server", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IPAddress.TryParse(ipAddress, out IPAddress address))
            {
                MessageBox.Show("Địa chỉ IP không hợp lệ", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!PingHost(ipAddress))
            {
                MessageBox.Show("Không thể kết nối đến IP của Server", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool PingHost(string nameOrAddress)
        {
            bool pingable = false;
            Ping pinger = null;

            try
            {
                pinger = new Ping();
                PingReply reply = pinger.Send(nameOrAddress);
                pingable = reply.Status == IPStatus.Success;
            }
            catch (PingException)
            {

            }
            finally
            {
                pinger?.Dispose();
            }

            return pingable;
        }

        private void chbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPass.Checked)
            {
                txbPassword.PasswordChar = '\0';
            }
            else
            {
                
                txbPassword.PasswordChar = '●';
            }
        }
    }

}

