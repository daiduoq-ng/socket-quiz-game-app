using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib; 

namespace NT106
{
    public partial class Form_Setting : Form
    {
        private HomePage homePage;
        public UserControl ChinhSach;
        private string username;
        private string IpAddress;

        public Form_Setting(HomePage homePage, string username, string ipAddress)
        {
            InitializeComponent();
            this.homePage = homePage;
            this.username = username;
            this.IpAddress = ipAddress;
            // Đặt giá trị của TrackBar từ Application Settings khi Form Setting được khởi tạo
            trackBarMusic.Value = Properties.Settings.Default.VolumeLevel;

        }

  
        private void AdjustVolume(int volume)
        {
            Console.WriteLine($"Đã điều chỉnh âm lượng: {volume}");
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            Form_Infor form_Infor = new Form_Infor();
            homePage.OpenChildForm(form_Infor);
        }

       

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChinhSachRiengTu f = new ChinhSachRiengTu();
            f.Show();
        }

        private void btn_LogOut_Click_1(object sender, EventArgs e)
        {
            this.ResetForm();
        }

        private void ResetForm()
        {
            // Đóng form HomePage nếu nó đang mở
            foreach (Form form in Application.OpenForms)
            {
                if (form is HomePage)
                {
                    form.Close();
                    break; // Kết thúc vòng lặp sau khi đã tìm thấy và đóng form HomePage
                }
            }

            // Mở lại form đăng nhập
            Sign_In loginForm = new Sign_In();
            loginForm.Show();
        }

        private void trackBarMusic_Scroll(object sender, EventArgs e)
        {
            homePage.SetVolume(trackBarMusic.Value); //set volume cho nhạc nền ở homepage
            Properties.Settings.Default.VolumeLevel = trackBarMusic.Value;
            Properties.Settings.Default.Save();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            btnChangePass.Visible = false;
            label1.Visible = true;
            label5.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            btnChange.Visible = true;
        }

        private void Form_Setting_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label5.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            btnChange.Visible = false;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!=textBox2.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu không trùng khớp!","ERROR!",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string password = textBox1.Text;
            if (password.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới!","ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!checkAccount(password))
            {
                MessageBox.Show("Vui lòng nhập Mật khẩu từ 3 đến 20 kí tự, với các kí tự chữ và số, chữ hoa và chữ thường!","ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var resetPass = new
                {
                    type = "ChangePassword",
                    username = username,
                    password = password,
                };
                string requestData = JsonConvert.SerializeObject(resetPass);
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

                        MessageBox.Show(responseObject.message.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        label1.Visible = false;
                        label5.Visible = false;
                        textBox1.Visible = false;
                        textBox2.Visible = false;
                        btnChange.Visible = false;
                        btnChangePass.Visible = true;

                    }
                    else
                    {
                        MessageBox.Show(responseObject.message.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            catch (Exception ex)
            {
                int a = 5;
            }
        }

        public bool checkAccount(string account) //check mk va tk co hop le hay khong
        {
            return Regex.IsMatch(account, "^[a-zA-z0-9]{6,24}$"); //tu aA den zZ va tu 0 den 9
        }


    }
    
}
