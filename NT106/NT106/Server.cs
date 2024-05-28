using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace NT106
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
            connect();
           
        }

        IPEndPoint IP;
        Socket server;
        List<Socket> clientList;

        void connect()
        {
            clientList = new List<Socket>();
            IP = new IPEndPoint(IPAddress.Any, 8080);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            server.Bind(IP);
            richTextBox1.AppendText("Listening for clients...\n");

            Thread listen = new Thread(() => {
                try
                {
                    while (true)
                    {
                        server.Listen(100); //có 100 client đợi để đc nghe
                        Socket client = server.Accept();
                        clientList.Add(client);
                        // tạo thread để receive
                        Thread rec = new Thread(receive);
                        rec.IsBackground = true;
                        rec.Start(client);

                        string clientInfo = "Client connected from: " + client.RemoteEndPoint.ToString() + "\n";
                        richTextBox1.Invoke((MethodInvoker)delegate {
                            richTextBox1.AppendText(clientInfo);
                        });
                        
                    }
                }
                catch
                {
                    IP = new IPEndPoint(IPAddress.Any, 8080);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }
            });
            listen.IsBackground = true;
            listen.Start();
        }



        public void SendMultipleQuestions()
        {
            string jsonFilePath = "questions.json"; // Đường dẫn tới tệp JSON
            List<QuestionModel> questions = LoadQuestionsFromJson(jsonFilePath);

            if (questions == null || questions.Count == 0)
            {
                MessageBox.Show("Lỗi đọc câu hỏi từ file JSON");
                return;
            }

            string jsonData = JsonConvert.SerializeObject(new { questions });

            foreach (Socket client in clientList)
            {
                client.Send(Encoding.UTF8.GetBytes(jsonData));
            }
        }


        private List<QuestionModel> LoadQuestionsFromJson(string filePath)
        {
            try
            {
                string jsonContent = File.ReadAllText(filePath);
                QuestionsData questionObj = JsonConvert.DeserializeObject<QuestionsData>(jsonContent);
                return questionObj.questions;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đọc file JSON: " + ex.Message);
                return null;
            }
        }

        void receive(object obj)
        {
            Socket client = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] buffer = new byte[1024];
                    client.Receive(buffer);

                    string data = (string)deserialize(buffer);

                    addData(data);
                }
            }
            catch
            {
                clientList.Remove(client);
                client.Close();
            }
        }

     
        void addData(string s)
        {
            richTextBox1.Invoke((MethodInvoker)delegate {
                richTextBox1.AppendText(s);
            });
        }

       

        object deserialize(byte[] data)
        {
            using (MemoryStream stream = new MemoryStream(data))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                return formatter.Deserialize(stream);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendMultipleQuestions();
        }
    }
}
