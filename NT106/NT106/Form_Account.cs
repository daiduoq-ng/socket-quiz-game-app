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
            var loginRequest = new
            {
                type = "getInfo",
                username = username
            };
            string requestData = JsonConvert.SerializeObject(loginRequest);
            byte[] data = Encoding.UTF8.GetBytes(requestData);

            using (Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP))
            {
                client.Connect("127.0.0.1", 8080);
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


    
