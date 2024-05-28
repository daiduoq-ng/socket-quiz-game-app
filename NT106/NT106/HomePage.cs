using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace NT106
{
    public partial class HomePage : Form
    {
        private Form CurrentFormChild;
        private string username;
        private string questionJson;

        public HomePage(string username)
        {
            InitializeComponent();
            connect();
            CheckForIllegalCrossThreadCalls = false;
            this.username = username;
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
            Form_Account formAccount = new Form_Account(username);
            OpenChildForm(formAccount);
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            
            Form_Event formEvent = new Form_Event(this, questionJson);
            OpenChildForm(formEvent);
        }

        private void btnBXH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_BXH());
        }

        private void btnMyScore_Click(object sender, EventArgs e)
        {
            Form_Score form_Score = new Form_Score();
            OpenChildForm(form_Score);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Form_Setting formSetting = new Form_Setting(this);
            OpenChildForm(formSetting);
        }

        public void SetVolume(int volume)
        {

            if (volume >= 0 && volume <= 100)
            {
                //  player.settings.volume = volume; // Đặt âm lượng theo tùy chỉnh ở setting
            }
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            label1.Text = "Xin chào, " + username;
        }

        IPEndPoint IP;
        Socket client;

        void connect()
        {
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
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
                    byte[] buffer = new byte[1024];
                    int bytesRead = client.Receive(buffer);
                    questionJson = Encoding.UTF8.GetString(buffer, 0, bytesRead); // Chuyển đổi dữ liệu từ byte array sang chuỗi
                    MessageBox.Show("Đã nhận được câu hỏi từ server.");

                  
                    Form_Event formEvent = new Form_Event(this, questionJson);
                    
                }
            }
            catch
            {
                close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_QuestionUser forma = new Form_QuestionUser(questionJson);
            forma.Show();
        }
    }
}
