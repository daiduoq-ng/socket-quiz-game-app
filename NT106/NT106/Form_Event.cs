using System.Windows.Forms;
using System;

namespace NT106
{
    public partial class Form_Event : Form
    {
        private HomePage homePage;
        private string questionJson;
        private string username;

        public Form_Event(HomePage homePage,ref string jsonData,string username)
        {
            InitializeComponent();
            this.homePage = homePage;
            this.questionJson = jsonData; // Lưu dữ liệu nhận được từ form chính
            this.username = username;
            // Kiểm tra xem có dữ liệu nhận được hay không khi khởi tạo form
            UpdateEventLabel();
        }

        // Phương thức công khai để cập nhật trạng thái của lbEvent1
        public void UpdateEventLabel()
        {
            if (!string.IsNullOrEmpty(questionJson))
            {
                lbEvent1.Enabled = true;
                lbEvent1.Text = "Cuộc thi đang diễn ra - Click để tham gia!";
            }
            else
            {
                lbEvent1.Enabled = false;
                lbEvent1.Text = "Chưa có cuộc thi nào diễn ra!";
            }
        }

        private void lbEvent1_Click(object sender, EventArgs e)
        {
            Form_QuestionUser form_Event1 = new Form_QuestionUser(homePage,questionJson, username);
            homePage.OpenChildForm(form_Event1);

            // Hide all buttons in the HomePage form
            homePage.HideAllButtons();
        }


        private void Form_Event_Load(object sender, EventArgs e)
        {
            
        }
    }
}