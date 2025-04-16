using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace NT106
{
    public partial class Reset_Pass : Form
    {
        private string IpAddress;
        public Reset_Pass(string IpAddress)
        {
            InitializeComponent();
            label3.Text = "";
            this.IpAddress=IpAddress;

        }
      

        private void btn_ForgotPassword_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            if (email.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập email đăng kí!");
                return;
            }

            try
            {
                var forgotPassword = new
                {
                    type = "forgotPassword",
                    email = email,
                };
                string requestData = JsonConvert.SerializeObject(forgotPassword);
                byte[] data = Encoding.UTF8.GetBytes(requestData);
                using (Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
                {
                    client.Connect(IpAddress, 8080);
                    client.Send(data);

                    byte[] buffer = new byte[1024];
                    int receivedBytes = client.Receive(buffer);
                    string response = Encoding.UTF8.GetString(buffer, 0, receivedBytes);
                    dynamic responseObject = JsonConvert.DeserializeObject(response);

                    if (responseObject.status == "success")
                    {
                        string username = responseObject.username;
                        string password = responseObject.password;

                        SendMail(email, username, password);

                        Console.WriteLine(username + password, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        label3.ForeColor = Color.Red;
                        label3.Text = "Error: " + responseObject.message.ToString();

                    }
                }
            }
            catch (Exception ex)
            {
                int a = 5;
            }
        }

        private void SendMail(string email, string username, string password)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("xuanmai032004@gmail.com", "Nhóm 12 - NT106.O21");
            mail.To.Add(email);
            mail.Subject = "Khôi phục mật khẩu";

            string htmlBody = @"
                <!DOCTYPE html>
                <html lang='en'>
                <head>
                    <meta charset='UTF-8'>
                    <meta name='viewport' content='width=device-width, initial-scale=1.0'>
                    <title>Khôi phụ mật khẩu</title>
                    <style>
                        body {
                            background-color: #f4f4f9;
                            font-family: 'Poetsen One', sans-serif;
                            color: #333;
                            margin: 0;
                            padding: 0;
                        }
                        .container {
                            width: 80%;
                            max-width: 800px;
                            margin: 0 auto;
                            background: #fff;
                            padding: 20px;
                            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
                            border-radius: 10px;
                        }
                        h1 {
                            text-align: center;
                            font-size: 24px;
                            margin-bottom: 20px;
                            color: #4CAF50;
                        }
                        .slogan {
                            text-align: center;
                            font-size: 18px;
                            margin-top: 20px;
                            color: #FF6347;
                        }
                        table {
                            width: 100%;
                            border-collapse: collapse;
                        }
                        td {
                            padding: 10px;
                            border-bottom: 1px solid #ddd;
                        }
                        .left-column {
                            width: 30%;
                            text-align: center;
                        }
                        .right-column {
                            width: 70%;
                            vertical-align: top;
                            text-align: left;
                        }
                        img {
                            max-width: 100%;
                            height: auto;
                            border-radius: 10px;
                        }
                        p {
                            font-size: 16px;
                            margin: 5px 0;
                        }
                    </style>
                    <link href='https://fonts.googleapis.com/css2?family=Poetsen+One&display=swap' rel='stylesheet'>
                </head>
                <body>
                    <div class='container'>
                        <h1>Khôi phục mật khẩu và vào game thôi nàoooo !!!</h1>
                        <table>
                            <tr>
                                <td class='left-column'>
                                     <img src='" + @"https://s.net.vn/noio'" + @"' alt='Một ví dụ về hình ảnh'>
                                </td>
                                <td class='right-column'>
                                    <p><strong>Username: </strong>" + username + @".</p>                                   
                                    <p><strong>Email: </strong>" + email + @".</p>
                                    <p><strong>Password: </strong>" + password + @".</p>
                                    
                                </td>
                            </tr>
                        </table>
                        <div class='slogan'>
                            <p>Chúc bạn có trải nghiệm vui vẻ với trò chơi của chúng tôi nhéeee !!!!</p>
                        </div>
                    </div>
                </body>
                </html>";

            mail.IsBodyHtml = true;
            mail.Body = htmlBody;

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.Credentials = new System.Net.NetworkCredential("xuanmai032004@gmail.com", "zuco tyqc rxyr pkeq"); // Thông tin đăng nhập tài khoản email 
            smtpClient.EnableSsl = true;


            smtpClient.Send(mail);
            label3.ForeColor = Color.DarkGreen;
            label3.Text = "Success";
            MessageBox.Show("Email xác nhận đã được gửi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
    }
}
