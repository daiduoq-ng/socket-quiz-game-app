using System;
using System.Windows.Forms;

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
        }

        private void lbEvent1_Click(object sender, EventArgs e)
        {
            // Gửi dữ liệu sang form QuestionUser khi click vào label lbEvent1
            Form_QuestionUser form_Event1 = new Form_QuestionUser(questionJson);
            homePage.OpenChildForm(form_Event1);
        }
    }
}
