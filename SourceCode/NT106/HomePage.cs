using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using WMPLib; //Thêm thư viện WindowMediaPlayer

namespace NT106
{
    public partial class HomePage : Form
    {
        private Form CurrentFormChild;
        private string userId;
        private string quizId;
        private string username;
        private string questionJson;
        private string IpAddress;

        WindowsMediaPlayer player = new WindowsMediaPlayer(); //Khai báo đối tượng player từ WindowMediaPlayer
        private Form_Setting settingForm;

        public HomePage(string username, string ipAddress)
        {
            this.IpAddress = ipAddress;
            InitializeComponent();
            connect();
            CheckForIllegalCrossThreadCalls = false;
            this.username = username;
            
            player.URL = "bgm.mp3"; //lấy âm thanh 
            settingForm = new Form_Setting(this, username,ipAddress); 
           player.controls.play(); //bật nhạc nền
        }

        public void OpenChildForm(Form ChildForm)
        {
            if (CurrentFormChild != null) CurrentFormChild.Close();
            CurrentFormChild = ChildForm;

            if (ChildForm is Form_Account)
            {
                ((Form_Account)ChildForm).SetUsername(username);
            }
            if (ChildForm is Form_QuestionUser)
            {
                ((Form_QuestionUser)ChildForm).AddData(questionJson);
            }

            ChildForm.TopLevel = false;
            ChildForm.Dock = DockStyle.Fill;
            panelBody.Controls.Add(ChildForm);
            panelBody.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            Form_Account formAccount = new Form_Account(username,IpAddress);
            OpenChildForm(formAccount);
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            
            Form_Event formEvent = new Form_Event(this,ref questionJson,username,IpAddress);
            OpenChildForm(formEvent);
        }

        private void btnBXH_Click(object sender, EventArgs e)
        {
            Form_BXH form_BXH = new Form_BXH(IpAddress);
            OpenChildForm(form_BXH);
        }

        private void btnMyScore_Click(object sender, EventArgs e)
        {
            Form_Score form_Score = new Form_Score(username,IpAddress);
            OpenChildForm(form_Score);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Form_Setting formSetting = new Form_Setting(this,username,IpAddress);
            OpenChildForm(formSetting);
        }

        public void SetVolume(int volume)
        {

            if (volume >= 0 && volume <= 100)
            {
               player.settings.volume = volume; // Đặt âm lượng theo tùy chỉnh ở setting
            }

        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            label1.Text = "Xin chào, " + username;
          //  player.URL = "bgm.mp3";
           // player.controls.play(); // Bật nhạc ở đây
        }

        private IPEndPoint IP;
        Socket client;

        void connect()
        {
            string ipAddress = IpAddress.Trim();
            IP = new IPEndPoint(IPAddress.Parse(ipAddress), 8080);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {
                client.Connect(IP);
            }
            catch
            {
                return;
            }

            Thread listen = new Thread(receive);
            listen.IsBackground = true;
            listen.Start();
        }

        void close()
        {
            client.Close();
        }

        void receive(object obj)
        {
            try
            {
                while (true)
                {
                    
                    byte[] buffer = new byte[102400];
                    int bytesRead = client.Receive(buffer);
                    if (bytesRead > 0)
                    { 
                        questionJson = string.Empty; 
                        questionJson = Encoding.UTF8.GetString(buffer, 0, bytesRead);                   
                        var jsonObject = JsonConvert.DeserializeObject<dynamic>(questionJson);
                        if (jsonObject.status == "success")
                        {
                            
                            this.Invoke(new Action(() =>
                            {
                                if (!this.IsDisposed)
                                {
                                    this.Close();
                                }
                            }));
                        }
                        else
                        {  
                            MessageBox.Show("Một cuộc thi đã bắt đầu. Hãy tham gia ngay!","Thông báo!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch
            {
                close();
            }
        }
        public void HideAllButtons()
        {
            btnAccount.Enabled = false;
            btnMyScore.Enabled = false;
            btnSetting.Enabled = false;
            btnBXH.Enabled = false;
            btnEvent.Enabled = false;

        }

        public void EnableAllButtons()
        {
            btnAccount.Enabled = true;
            btnMyScore.Enabled = true;
            btnSetting.Enabled = true;
            btnBXH.Enabled = true;
           btnEvent.Enabled = true;
            questionJson = null;
        }









        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing || e.CloseReason == CloseReason.ApplicationExitCall)
            {
                var logout = new
                {
                    type = "logout",
                    username = username
                };
                string requestData = JsonConvert.SerializeObject(logout);
                byte[] data = Encoding.UTF8.GetBytes(requestData);

                try
                {
                    // Tạo một socket mới để gửi yêu cầu đăng xuất
                    using (Socket logoutClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP))
                    {
                        logoutClient.Connect(IpAddress, 8080);
                        logoutClient.Send(data);

                        byte[] buffer = new byte[1024];
                        int receivedBytes = logoutClient.Receive(buffer);
                        string response = Encoding.UTF8.GetString(buffer, 0, receivedBytes);
                        dynamic responseObject = JsonConvert.DeserializeObject(response);

                        if (responseObject.status == "success")
                        {
                            MessageBox.Show(responseObject.message.ToString(), "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error during logout: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                player.controls.pause(); //tắt nhạc nền
            }
        }
    }
}
