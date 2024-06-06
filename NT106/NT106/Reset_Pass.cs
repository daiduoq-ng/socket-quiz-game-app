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

namespace NT106
{
    public partial class Reset_Pass : Form
    {
        public Reset_Pass()
        {
            InitializeComponent();
            label3.Text = "";

        }
        Modify modify= new Modify();

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            if (email.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập email đăng kí!");
                return;
            }

            try
            {
                var resetPass = new
                {
                    type = "resetPass",
                    email = email,
                };
                string requestData = JsonConvert.SerializeObject(resetPass);
                byte[] data = Encoding.UTF8.GetBytes(requestData);
                using (Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
                {
                    client.Connect("127.0.0.1", 8080);
                    client.Send(data);

                    byte[] buffer = new byte[1024];
                    int receivedBytes = client.Receive(buffer);
                    string response = Encoding.UTF8.GetString(buffer, 0, receivedBytes);
                    dynamic responseObject = JsonConvert.DeserializeObject(response);

                    if (responseObject.status == "success")
                    {
                        // Assuming the password is in responseObject.pass
                        string password = responseObject.pass.ToString();
                        label3.ForeColor = Color.Blue;
                        label3.Text = "Password: " + password;

                        MessageBox.Show(responseObject.message.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
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

    }
}
