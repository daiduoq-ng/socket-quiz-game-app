using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace NT106
{
    public partial class Form_QuestionUser : Form
    {
        private List<QuestionModel> questions;
        private int currentQuestionIndex;
        public string answerServer;
        public string answerPlayer;
        private Timer questionTimer;
        private int TimeLimitInSeconds = 20;
        private int score = 0;

        public Form_QuestionUser(string jsonData)
        {
            InitializeComponent();
            AddData(jsonData);

           
            questionTimer = new Timer();
            questionTimer.Interval = 1000; 
            questionTimer.Tick += QuestionTimer_Tick; 
            questionTimer.Start();

            cb25.CheckedChanged += new EventHandler(CheckBox_CheckedChanged);
            cb50.CheckedChanged += new EventHandler(CheckBox_CheckedChanged);
            cb75.CheckedChanged += new EventHandler(CheckBox_CheckedChanged);
            cb2x.CheckedChanged += new EventHandler(CheckBox_CheckedChanged);

        }
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox changedCheckBox = sender as CheckBox;

            if (changedCheckBox.Checked)
            {
                // Bỏ tích các CheckBox khác
                if (changedCheckBox != cb25)
                    cb25.Checked = false;
                if (changedCheckBox != cb50)
                    cb50.Checked = false;
                if (changedCheckBox != cb75)
                    cb75.Checked = false;
                if (changedCheckBox != cb2x)
                    cb2x.Checked = false;
            }
        }


        private void QuestionTimer_Tick(object sender, EventArgs e)
        {
            TimeLimitInSeconds--; 
            if (TimeLimitInSeconds >= 0)
            {
                tbTime.Text = "Time: " + TimeLimitInSeconds.ToString() + "s";
                if (TimeLimitInSeconds == 0)
                {
                    lbNoitice.Text = "Bạn đã hết thời gian trả lời, Sang câu hỏi tiếp theo";
                }    
            }
            else
            {
                tbTime.Text = "Time Over"; 
               
            }

            if (TimeLimitInSeconds <= 0)
            {
                questionTimer.Stop();
                MoveToNextQuestion();
                TimeLimitInSeconds = 20; 
            }
        }

        private void MoveToNextQuestion()
        {
            currentQuestionIndex++;
            if (currentQuestionIndex < questions.Count)
            {
                DisplayQuestion(); 
                TimeLimitInSeconds = 20; 
                questionTimer.Start(); 
            }
            else
            {
                MessageBox.Show("Đã hoàn thành tất cả các câu hỏi. Điểm của bạn: " + score);
                
            }
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

                questions = data.questions;
                currentQuestionIndex = 0;
                DisplayQuestion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tải dữ liệu câu hỏi: " + ex.Message);
            }
        }

        private void DisplayQuestion()
        {
            // Kiểm tra điểm số và điều chỉnh các checkbox cược
            if (score <= 0)
            {
                label1.Text = "Chưa đủ điểm để cá cược!";
                label1.Visible = true;
                cb25.Visible = false;
                cb50.Visible = false;
                cb75.Visible = false;
                cb2x.Visible = false;
            }
            else
            {
                label1.Visible = false;
                cb25.Visible = true;
                cb50.Visible = true;
                cb75.Visible = true;
                cb2x.Visible = true;
            }

            // Hiển thị câu hỏi hiện tại nếu có
            if (questions != null && currentQuestionIndex < questions.Count)
            {
                var currentQuestion = questions[currentQuestionIndex];
                lbQuestion.Text = currentQuestion.question;
                tbA.Text = currentQuestion.choices[0];
                tbB.Text = currentQuestion.choices[1];
                tbC.Text = currentQuestion.choices[2];
                tbD.Text = currentQuestion.choices[3];
                answerServer = currentQuestion.choices[currentQuestion.answer];

                // Đặt trạng thái ban đầu cho các checkbox
                cb25.Checked = false;
                cb50.Checked = false;
                cb75.Checked = false;
                cb2x.Checked = false;
            }
            else
            {
                MessageBox.Show("Đã hết câu hỏi hoặc danh sách câu hỏi chưa được khởi tạo. Điểm của bạn: " + score);
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
            int points = TimeLimitInSeconds * 100;
            int bettingPoints = CalculateBettingPoints(points); // Đúng là sử dụng points ở đây thay vì score

            if (isCorrect)
            {
                score += bettingPoints;
                lbNoitice.ForeColor = System.Drawing.Color.Blue;
                lbNoitice.Text = "Câu trả lời chính xác! Bạn được cộng thêm: " + bettingPoints + " điểm";
            }
            else if(!isCorrect && cb25.Checked==false && cb2x.Checked==false && cb50.Checked==false && cb75.Checked==false)
            {
                lbNoitice.Text = "Câu trả lời không chính xác! Bạn không được điểm";
            }
            else
            {
                score -= bettingPoints;
                if (score < 0)
                {
                    lbNoitice.ForeColor = System.Drawing.Color.Red;
                }
                lbNoitice.ForeColor = System.Drawing.Color.Red;
                lbNoitice.Text = "Sai câu có cược! Bạn mất: " + bettingPoints + " điểm";
            }

            lbScore.Text = "Your Score: " + score.ToString();
            MoveToNextQuestion();
        }

        private int CalculateBettingPoints(int score)
        {
            int bettingPoints = score;

            // Áp dụng các hệ số cược
            if (cb25.Checked)
            {
                bettingPoints = (int)(bettingPoints * 0.25);
            }
            else if (cb50.Checked)
            {
                bettingPoints = (int)(bettingPoints * 0.50);
            }
            else if (cb75.Checked)
            {
                bettingPoints = (int)(bettingPoints * 0.75);
            }

            // Nhân đôi điểm nếu chọn cb2x
            if (cb2x.Checked)
            {
                bettingPoints *= 2;
            }

            return bettingPoints;
        }


        public class QuestionsData
        {
            public List<QuestionModel> questions { get; set; }
        }

        public class QuestionModel
        {
            public string question { get; set; }
            public List<string> choices { get; set; }
            public int answer { get; set; }
        }

        private void Form_QuestionUser_Load(object sender, EventArgs e)
        {
            cb25.Visible = false;
            cb50.Visible = false;
            cb75.Visible = false;
            cb2x.Visible = false;   
        }
    }
}
