using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106
{
    public partial class Form_Score : Form
    {
        private Dictionary<string, int> scores = new Dictionary<string, int>();
        private string username;
        private string IpAddress;

        public Form_Score(string username, string ipAddress)
        {
            InitializeComponent();
            this.username = username;
            this.IpAddress = ipAddress;
        }

        private async Task GetScoreHistoryFromServer(string username)
        {
            try
            {
                using (Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP))
                {
                    client.Connect(IpAddress, 8080);

                    var requestData = new
                    {
                        type = "ScoreHistory",
                        username = username
                    };

                    string jsonData = JsonConvert.SerializeObject(requestData);
                    byte[] data = Encoding.UTF8.GetBytes(jsonData);

                    await Task.Run(() => client.Send(data));

                    byte[] buffer = new byte[4096];
                    int receivedBytes = await Task.Run(() => client.Receive(buffer));

                    if (receivedBytes > 0)
                    {
                        string responseData = Encoding.UTF8.GetString(buffer, 0, receivedBytes);
                        var responseObject = JsonConvert.DeserializeObject<JObject>(responseData);

                        if (responseObject["status"].ToString() == "success")
                        {
                            PopulateScores(responseObject["data"].ToString());
                        }
                        else
                        {
                            MessageBox.Show("Không thể lấy điểm từ server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể lấy điểm từ server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kết nối với server: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void PopulateScores(string data)
        {
            try
            {
                var dataArray = JsonConvert.DeserializeObject<JArray>(data);

                foreach (var item in dataArray)
                {
                    string quizName = item["QuizName"].ToString();
                    int highScore = item["HighScore"].ToObject<int>();

                    scores[quizName] = highScore; // Gán giá trị vào dictionary
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi xử lý JSON: " + ex.Message);
            }
        }

        private void DisplayScore()
        {
            tbScoreDL.Text = scores.ContainsKey("Dia Ly") ? scores["Dia Ly"].ToString() : "0";
            tbScoreLS.Text = scores.ContainsKey("Lich Su") ? scores["Lich Su"].ToString() : "0";
            tbScoreKH.Text = scores.ContainsKey("Khoa Hoc") ? scores["Khoa Hoc"].ToString() : "0";
        }

        private async void Form_Score_Load(object sender, EventArgs e)
        {
            await GetScoreHistoryFromServer(username);
            DisplayScore();
        }
    }
}