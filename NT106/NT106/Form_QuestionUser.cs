using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NT106
{
    public partial class Form_QuestionUser : Form
    {
        private List<QuestionModel> questions; // Change the type to QuestionModel
        private int currentQuestionIndex;
        public string answerServer;
        public string answerPlayer;

        public Form_QuestionUser(string jsonData)
        {
            InitializeComponent();
            AddData(jsonData);
            realTime.Start();
            timer.Start();
        }

        public void AddData(string jsonData)
        {
           

            try
            {
                QuestionsData data = JsonConvert.DeserializeObject<QuestionsData>(jsonData);
                if (data == null || data.questions == null || data.questions.Count == 0)
                {
                    MessageBox.Show("Không có câu hỏi được tìm thấy.");
                    return;
                }

                questions = data.questions; // Assign to questions of type List<QuestionModel>
                currentQuestionIndex = 0;
                DisplayQuestion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi deserialization dữ liệu JSON: " + ex.Message);
            }
        }

        private void DisplayQuestion()
        {
            if (currentQuestionIndex < questions.Count)
            {
                var currentQuestion = questions[currentQuestionIndex];
                textBoxElipse5.Text = currentQuestion.question;
                tbA.Text = currentQuestion.choices[0];
                tbB.Text = currentQuestion.choices[1];
                tbC.Text = currentQuestion.choices[2];
                tbD.Text = currentQuestion.choices[3];
                answerServer = currentQuestion.choices[currentQuestion.answer];
            }
            else
            {
                MessageBox.Show("Đã hết câu hỏi.");
            }
        }

        private void lbA_Click(object sender, EventArgs e)
        {
            answerPlayer = tbA.Text;
            CheckAnswer();
        }

        private void lbB_Click(object sender, EventArgs e)
        {
            answerPlayer = tbB.Text;
            CheckAnswer();
        }

        private void lbC_Click(object sender, EventArgs e)
        {
            answerPlayer = tbC.Text;
            CheckAnswer();
        }

        private void lbD_Click(object sender, EventArgs e)
        {
            answerPlayer = tbD.Text;
            CheckAnswer();
        }

        private void CheckAnswer()
        {
            bool isCorrect = answerServer.Equals(answerPlayer, StringComparison.OrdinalIgnoreCase);
            if (isCorrect)
            {
                MessageBox.Show("Câu trả lời chính xác!");
            }
            else
            {
                MessageBox.Show("Câu trả lời không chính xác!");
            }

            currentQuestionIndex++;
            DisplayQuestion();
        }


        int i = 60;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i > 0)
            {
                i--;
                tbTime.Text = "Time:" + i.ToString() + "s";
            }
            else
            {
                tbTime.Text = "TimeOver";
                timer.Stop();
            }

        }
        private void Form_QuestionUser_Load(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            tbRealTime.Text = currentTime.ToString("HH:mm:ss");
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            realTime.Stop(); // Stop the timer
            realTime.Dispose(); // Dispose of the timer resources
        }

        private void realTime_Tick(object sender, EventArgs e)
        {
            tbRealTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
