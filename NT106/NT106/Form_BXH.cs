using Newtonsoft.Json.Linq;
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
using System.IO;
using NT106.UserControls;

namespace NT106
{
    public partial class Form_BXH : Form
    {
        private Dictionary<string,Dictionary<int, byte[]>> dict_Rank = new Dictionary<string,Dictionary <int, byte[]>>();
        public Form_BXH()
        {
            InitializeComponent();
        }
        static int temp_i = 0;
        private async Task GetTopRankingFromServer()
        {
            if (temp_i != 0)
                temp_i = 0;
            try
            {
                using (Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP))
                {
                    client.Connect("127.0.0.1", 8080);

                    var requestData = new
                    {
                        type = "rank"
                    };

                    string jsonData = JsonConvert.SerializeObject(requestData);
                    byte[] data = Encoding.UTF8.GetBytes(jsonData);

                    await Task.Run(() => client.Send(data));

                    byte[] buffer = new byte[409600];
                    int receivedBytes = await Task.Run(() => client.Receive(buffer));

                    if (receivedBytes > 0)
                    {
                        string responseData = Encoding.UTF8.GetString(buffer, 0, receivedBytes);
                        var responseObject = JsonConvert.DeserializeObject<JObject>(responseData);

                        if (responseObject["status"].ToString() == "success")
                        {
                            // Xóa dữ liệu cũ trong scores
                            dict_Rank.Clear();
                            Console.WriteLine("Not Error");
                            // Lưu dữ liệu mới vào scores
                            JArray rankingData = responseObject["data"].ToObject<JArray>();
                            foreach (var item in rankingData)
                            {
                                string userName = item["UserName"].ToString()+"_"+temp_i;
                                if (temp_i<6)
                                temp_i++;
                                int score = Convert.ToInt32(item["Score"]);
                                byte[] profileImageBytes = Convert.FromBase64String(item["ProfileImage"].ToString());
                                if (!dict_Rank.ContainsKey(userName))
                                    dict_Rank.Add(userName, new Dictionary<int, byte[]>());

                                dict_Rank[userName].Add(score, profileImageBytes);
                            }
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

        private void DisplayScore()
        {
            if (dict_Rank.Count < 6)
            {
                MessageBox.Show("Dictionary does not contain enough elements.");
                return;
            }

            for (var i = 1; i < 7; i++)
            {
                if (i <= dict_Rank.Count)
                {
                    var dictElement = dict_Rank.ElementAt(i - 1);
                    var key = dictElement.Key;
                    var value = dictElement.Value;
                    if (i < 4)
                    {
                        GetLabel("lbNameHang" + i).Text = key.ToString().Substring(0, key.Length - 2);

                        if (value != null && value.Keys.Any())
                        {
                            GetLabel("lbScoreHang" + i).Text = value.Keys.FirstOrDefault().ToString();
                        }
                    }
                    else
                    {
                        GetTextBox("tbNameHang" + i).Text = key.ToString().Substring(0, key.Length - 2);

                        if (value != null && value.Keys.Any())
                        {
                            GetTextBox("tbScoreHang" + i).Text = value.Keys.FirstOrDefault().ToString();
                        }
                    }
                    if (new List<int> { 1, 2, 3 }.Contains(i) && value.Values.Any())
                    {
                        var imageBytes = value.Values.FirstOrDefault();
                        if (imageBytes != null)
                        {
                            SetImageWithBytesForPictureBox(imageBytes, GetPictureBox("pbHang" + i));
                        }
                    }
                }
                else
                {
                    MessageBox.Show($"No element found at index {i - 1} in the dictionary.");
                }
            }
        }
        private PictureBox GetPictureBox(string pictureBoxName)
        {
            var control = this.Controls.Find(pictureBoxName, true).FirstOrDefault() as PictureBox;
            
            
            return control;
        }

        private Label GetLabel(string label)
        {
            var control = this.Controls.Find(label, true).FirstOrDefault() as Label;
           
            
            return control;
        }
        private TextBoxElipse GetTextBox(string textbox)
        {
            var control = this.Controls.Find(textbox, true).FirstOrDefault() as TextBoxElipse;

           
            return control;
        }
        private void SetImageWithBytesForPictureBox(byte[] imageData, PictureBox pictureBox)
        {
            if (imageData != null && imageData.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    try
                    {
                        Image image = Image.FromStream(ms);
                        pictureBox.BackgroundImage = image;
                    }
                    catch (Exception ex)
                    {
                        // Handle potential exceptions during image loading
                        MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Handle the case where imageData is null or empty
                MessageBox.Show("Invalid image data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void Form_BXH_Load(object sender, EventArgs e)
        {
            await GetTopRankingFromServer();
            DisplayScore();
        }
        private void ShowDictRank()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var outerPair in dict_Rank)
            {
                sb.AppendLine($"Key: {outerPair.Key}");

                foreach (var innerPair in outerPair.Value)
                {
                    sb.AppendLine($"\tInner Key: {innerPair.Key}, Value: {BitConverter.ToString(innerPair.Value)}");
                }
            }

            MessageBox.Show(sb.ToString(), "Dictionary Contents");
        }
    }
}
