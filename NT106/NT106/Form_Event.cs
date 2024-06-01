using System.Windows.Forms;
using System;

namespace NT106
{
    public partial class Form_Event : Form
    {
        private HomePage homePage;
        private string questionJson;

        public Form_Event(HomePage homePage, string jsonData)
        {
            InitializeComponent();
            this.homePage = homePage;
            this.questionJson = jsonData; // Lưu dữ liệu nhận được từ form chính

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
            // Gửi dữ liệu sang form QuestionUser khi click vào label lbEvent1
            Form_QuestionUser form_Event1 = new Form_QuestionUser(questionJson);
            homePage.OpenChildForm(form_Event1);
        }

        private void Form_Event_Load(object sender, EventArgs e)
        {
            
        }
    }
}