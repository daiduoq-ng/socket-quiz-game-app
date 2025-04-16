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
using Newtonsoft.Json;
using System.Net.Sockets;
using System.IO;

namespace NT106
{
    public partial class Form_Account : Form
    {

        private string username;
        private string IpAddress;
        public Form_Account(string username, string ipAddress)
        {
            InitializeComponent();
            this.username = username;
            this.IpAddress = ipAddress;

        }

        public void SetUsername(string username)
        {
            this.username = username;
            lbHoTen.Text = username;
        }


        private void lbDoiAvt_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif)|*.jpg;*.jpeg;*.png;*.gif|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;

                try
                {
                  
                    byte[] imageBytes = File.ReadAllBytes(imagePath);

                   
                    var updateAvtRequest = new
                    {
                        type = "updateAVT",
                        username = username, 
                        avatar = Convert.ToBase64String(imageBytes)
                    };
                    string requestData = JsonConvert.SerializeObject(updateAvtRequest);
                    byte[] data = Encoding.UTF8.GetBytes(requestData);

                    //connect máy chủ và gửi yêu cầu
                    using (Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP))
                    {
                        client.Connect(IpAddress, 8080);
                        client.Send(data);

                        //đọc phản hồi từ máy chủ và hiển thị thông báo
                        byte[] buffer = new byte[10240];
                        int receivedBytes = client.Receive(buffer);
                        string response = Encoding.UTF8.GetString(buffer, 0, receivedBytes);
                        dynamic responseObject = JsonConvert.DeserializeObject(response);

                        if (responseObject.status == "success")
                        {
                            MessageBox.Show(responseObject.message.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                        }
                        else
                        {
                            MessageBox.Show(responseObject.message.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
       

        private void Form_Account_Load(object sender, EventArgs e)
        {
            var loginRequest = new
            {
                type = "getInfo",
                username = username
            };

            string requestData = JsonConvert.SerializeObject(loginRequest);
            byte[] data = Encoding.UTF8.GetBytes(requestData);

            using (Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP))
            {
                client.Connect(IpAddress, 8080);
                client.Send(data);

                using (var ms = new System.IO.MemoryStream())
                {
                    byte[] buffer = new byte[409600];
                    int bytesRead;
                    while ((bytesRead = client.Receive(buffer, buffer.Length, SocketFlags.None)) > 0)
                    {
                        ms.Write(buffer, 0, bytesRead);
                        if (bytesRead < buffer.Length)
                            break;
                    }

                    string response = Encoding.UTF8.GetString(ms.ToArray());
                    dynamic responseObject = JsonConvert.DeserializeObject(response);

                    if (responseObject.status == "success")
                    {
                        lbEmail.Text = responseObject.email;

                        if (responseObject.profileImage != null)
                        {
                            try
                            {
                                byte[] profileImageBytes = Convert.FromBase64String((string)responseObject.profileImage);
                                using (var imageStream = new System.IO.MemoryStream(profileImageBytes))
                                {
                                    pbAvt.SizeMode = PictureBoxSizeMode.Zoom;
                                    pbAvt.Image = Image.FromStream(imageStream);
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error converting profile image: " + ex.Message);
                            }
                        }
                        else
                        {
                            pbAvt.Image = null;
                        }
                    }
                    else
                    {
                        MessageBox.Show(responseObject.message.ToString());
                    }
                }
            }
        }

       
    }
}


    
