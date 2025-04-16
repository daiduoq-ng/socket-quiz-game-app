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
        private string IpAddress;
        public Form_BXH(string ipAddress)
        {
            InitializeComponent();
            this.IpAddress = ipAddress;
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
                    client.Connect(IpAddress, 8080);

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
            if (dict_Rank.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu. Cuộc thi đang diễn ra!","Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int displayCount = Math.Min(3, dict_Rank.Count); 

            for (var i = 1; i <= displayCount; i++)
            {
                var dictElement = dict_Rank.ElementAt(i - 1);
                var key = dictElement.Key;
                var value = dictElement.Value;

                // Xử lý nhãn hiển thị tên và điểm số
                GetLabel("lbNameHang" + i).Text = key.ToString().Substring(0, key.Length - 2);

                if (value != null && value.Keys.Any())
                {
                    GetLabel("lbScoreHang" + i).Text = value.Keys.FirstOrDefault().ToString();
                }

                // Xử lý hình ảnh
                if (value != null && value.Values.Any())
                {
                    var imageBytes = value.Values.FirstOrDefault();
                    if (imageBytes != null)
                    {
                        SetImageWithBytesForPictureBox(imageBytes, GetPictureBox("pbHang" + i));
                    }
                }
            }
        }

        private Label GetLabel(string name)
        {
            return this.Controls.Find(name, true).FirstOrDefault() as Label;
        }



        private PictureBox GetPictureBox(string name)
        {
            return this.Controls.Find(name, true).FirstOrDefault() as PictureBox;
        }

        private void SetImageWithBytesForPictureBox(byte[] imageBytes, PictureBox pictureBox)
        {
            using (var ms = new MemoryStream(imageBytes))
            {
                pictureBox.BackgroundImage = null;
                pictureBox.Image = Image.FromStream(ms);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private async void Form_BXH_Load(object sender, EventArgs e)
        {
            await GetTopRankingFromServer();
            DisplayScore();
        }
       
    }
}
