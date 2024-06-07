using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;



namespace NT106
{
    public partial class Server : Form
    {
        private string connectionString;
        private System.Windows.Forms.Timer countdownTimer;
        private int timeDown;
        private int quizID;
        public Server()
        {
            InitializeComponent();
            InitializeCountdownTimer();
            connect();
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SUCCESS\Desktop\NT106\NT106-Final\NT106-Final\NT106\NT106\Database1.mdf;Integrated Security=True";

        }
        

        IPEndPoint IP;
        Socket server;
        List<Socket> clientList;
        private void InitializeCountdownTimer()
        {
            if (countdownTimer == null)
            {
                countdownTimer = new System.Windows.Forms.Timer();
                countdownTimer.Interval = 1000;
                countdownTimer.Tick += CountdownTimer_Tick;
            }
        }


        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            int timeInSeconds = timeDown;

                if (timeInSeconds > 0)
                {
                    timeInSeconds--;
                    UpdateTimeDisplay(timeInSeconds);
                    timeDown = timeInSeconds;
                }
                else
                {
                    countdownTimer.Stop();
                    tbTime.Text = "Time's Up";

                    // Lấy lựa chọn từ ComboBox
                    string selectedOption = cb_Question.SelectedItem.ToString();

                    // Gọi hàm tương ứng dựa trên lựa chọn
                    switch (selectedOption)
                    {
                        case "1":
                        AddQuiz("Khoa Hoc");

                        SendMultipleQuestions_1();
                            break;
                        case "2":
                        AddQuiz("Dia Ly");

                        SendMultipleQuestions_2();

                        break;
                        case "3":
                        AddQuiz("Lich Su");

                        SendMultipleQuestions_3();

                        break;
                        default:
                            // Xử lý cho các lựa chọn khác nếu cần
                            break;
                    }
                }           
        }
        private void AddQuiz(string quizName)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Quiz (QuizName) OUTPUT INSERTED.QuizId VALUES (@QuizName)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@QuizName", quizName);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        quizID = Convert.ToInt32(result);
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi nếu cần
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

        }




        private void UpdateTimeDisplay(int timeInSeconds)
        {
            TimeSpan time = TimeSpan.FromSeconds(timeInSeconds);
            tbTime.Text = $"Time: {time:mm\\:ss}";
        }

        

        

        void connect()
        {
            clientList = new List<Socket>();
            IP = new IPEndPoint(IPAddress.Any, 8080);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            server.Bind(IP);
            richTextBox1.AppendText("Listening for clients...\n");

            Thread listen = new Thread(() => {
                try
                {
                    while (true)
                    {
                        server.Listen(100); //có 100 client đợi để đc nghe
                        Socket client = server.Accept();
                        clientList.Add(client);
                        // tạo thread để receive
                        Thread rec = new Thread(receive);
                        rec.IsBackground = true;
                        rec.Start(client);

                        string clientInfo = "Client connected from: " + client.RemoteEndPoint.ToString() + "\n";
                        richTextBox1.Invoke((MethodInvoker)delegate {
                            richTextBox1.AppendText(clientInfo);
                        });
                        
                    }
                }
                catch
                {
                    IP = new IPEndPoint(IPAddress.Any, 8080);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                }
            });
            listen.IsBackground = true;
            listen.Start();
        }



        public void SendMultipleQuestions_1()
        {
           string jsonFilePath = "questions_1.json"; // Đường dẫn tới tệp JSON
            List<QuestionModel> questions = LoadQuestionsFromJson(jsonFilePath);

            if (questions == null || questions.Count == 0)
            {
                MessageBox.Show("Lỗi đọc câu hỏi từ file JSON");
                return;
            }

            string jsonData = JsonConvert.SerializeObject(new { questions });

            foreach (Socket client in clientList)
            {
                client.Send(Encoding.UTF8.GetBytes(jsonData));
            }
        }

        public void SendMultipleQuestions_2()
        {
            string jsonFilePath = "questions_2.json"; // Đường dẫn tới tệp JSON
            List<QuestionModel> questions = LoadQuestionsFromJson(jsonFilePath);

            if (questions == null || questions.Count == 0)
            {
                MessageBox.Show("Lỗi đọc câu hỏi từ file JSON");
                return;
            }

            string jsonData = JsonConvert.SerializeObject(new { questions });

            foreach (Socket client in clientList)
            {
                client.Send(Encoding.UTF8.GetBytes(jsonData));
            }
        }

        public void SendMultipleQuestions_3()
        {
            string jsonFilePath = "questions_3.json"; // Đường dẫn tới tệp JSON
            List<QuestionModel> questions = LoadQuestionsFromJson(jsonFilePath);

            if (questions == null || questions.Count == 0)
            {
                MessageBox.Show("Lỗi đọc câu hỏi từ file JSON");
                return;
            }

            string jsonData = JsonConvert.SerializeObject(new { questions });

            foreach (Socket client in clientList)
            {
                client.Send(Encoding.UTF8.GetBytes(jsonData));
            }
        }


        private List<QuestionModel> LoadQuestionsFromJson(string filePath)
        {
            try
            {
                string jsonContent = File.ReadAllText(filePath);
                QuestionsData questionObj = JsonConvert.DeserializeObject<QuestionsData>(jsonContent);
                return questionObj.questions;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đọc file JSON: " + ex.Message);
                return null;
            }
        }

        void receive(object obj)
        {
            Socket client = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] buffer = new byte[409600];

                    int receivedBytes = client.Receive(buffer);
                    if (receivedBytes > 0)
                    {
                        string data = Encoding.UTF8.GetString(buffer, 0, receivedBytes);

                        // Log dữ liệu nhận được
                        Console.WriteLine("Received data: " + data);

                        dynamic request;
                        try
                        {
                            // Phân tích chuỗi JSON nhận được thành đối tượng dynamic
                            request = JsonConvert.DeserializeObject(data);
                        }
                        catch (Exception ex)
                        {
                            // Log lỗi khi phân tích chuỗi JSON
                            Console.WriteLine("JSON Deserialize Error: " + ex.Message);

                            // Gửi phản hồi lỗi về client
                            string errorResponse = JsonConvert.SerializeObject(new { status = "error", message = "Invalid request format: " + ex.Message });
                            client.Send(Encoding.UTF8.GetBytes(errorResponse));
                            continue;
                        }

                        if (request == null || request.type == null)
                        {
                            // Log lỗi khi request hoặc request type là null
                            if (request == null)
                            {
                                Console.WriteLine("Request is null");
                            }
                            else if (request.type == null)
                            {
                                Console.WriteLine("Request type is null");
                            }

                            // Gửi phản hồi lỗi về client
                            string errorResponse = JsonConvert.SerializeObject(new { status = "error", message = "Invalid request format: Request or request type is null" });
                            client.Send(Encoding.UTF8.GetBytes(errorResponse));
                            continue;
                        }

                        string response;

                        if (request.type == "login")
                        {
                            // Xử lý yêu cầu login và nhận phản hồi
                            response = HandleLogin((string)request.username, (string)request.password);
                        }
                        else if (request.type == "register")
                        {
                            // Xử lý yêu cầu register và nhận phản hồi
                            response = HandleRegister((string)request.username, (string)request.password, (string)request.email, Convert.FromBase64String((string)request.profileImage));
                        }

                        else if (request.type == "getInfo")
                        {
                            response = GetUserInfo((string)request.username);
                        }
                        else if (request.type == "resetPass")
                        {
                            response = ResetPassword((string)request.email);
                        }
                        else if (request.type == "logout")
                        {
                            response = Logout((string)request.username);
                        }

                        else if (request.type == "updateAVT")
                        {
                        
                            byte[] avatarBytes = Convert.FromBase64String((string)request.avatar);
                            response = UpdateAVT((string)request.username, avatarBytes);
                            
                            
                        }
                        else if (request.type == "score")
                        {
                            try
                            {
                                string username = (string)request.UserName;
                                int score = (int)request.Score;
                                response = FinalScore(username, quizID, score);
                            }
                            catch (Exception ex)
                            {
                                // Log lỗi khi chuyển đổi kiểu dữ liệu
                                Console.WriteLine("Error converting request parameters: " + ex.Message);
                                response = JsonConvert.SerializeObject(new { status = "error", message = "Invalid request parameters" });
                            }
                        }

                        else if (request.type == "ScoreHistory")
                        {
                            /*string jsonData = JsonConvert.SerializeObject(new { questions });

                            foreach (Socket client in clientList)
                            {
                                client.Send(Encoding.UTF8.GetBytes(jsonData));
                            }*/

                            try
                            {
                                string username = request.username;
                                response = GetScoreHistory(username);
                            }
                            catch (Exception ex)
                            {
                                // Log lỗi khi chuyển đổi kiểu dữ liệu
                                Console.WriteLine("Error converting request parameters: " + ex.Message);
                                response = JsonConvert.SerializeObject(new { status = "error", message = "Invalid request parameters" });
                            }
                        }

                        else if (request.type == "rank")
                        {
                            response = TopRanking();
                        }



                        else
                        {
                            // Yêu cầu không được nhận diện
                            response = JsonConvert.SerializeObject(new { status = "error", message = "Unknown request type" });
                        }

                        // Chuyển đổi phản hồi thành mảng byte và gửi lại cho client
                        Console.WriteLine("Send response: " + response);
                        byte[] responseData = Encoding.UTF8.GetBytes(response);
                        client.Send(responseData);
                    }
                }
            }
            catch (Exception ex)
            {
                // Log chi tiết lỗi nếu có ngoại lệ xảy ra
                Console.WriteLine("Receive Error: " + ex.Message);
                clientList.Remove(client);
                client.Close();
            }
        }

        private string UpdateAVT(string username, byte[] avatarBytes)
        {
            string response;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE TaiKhoan SET ProfileImage = @ProfileImage WHERE UserName = @UserName";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ProfileImage", avatarBytes);
                    command.Parameters.AddWithValue("@UserName", username);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        response = JsonConvert.SerializeObject(new { status = "success", message = "Thay Đổi Avartar thành công!" });
                    }
                    else
                    {
                        response = JsonConvert.SerializeObject(new { status = "error", message = "User not found or avatar update failed" });
                    }
                }
            }
            catch (Exception ex)
            {
                response = JsonConvert.SerializeObject(new { status = "error", message = "An error occurred while updating avatar: " + ex.Message });
            }
            return response;
        }



        private string TopRanking()
        {
            string query = @"
        SELECT TOP 6 tk.UserName, tk.ProfileImage, qr.Score
        FROM QuizResult qr
        JOIN TaiKhoan tk ON qr.UserId = tk.UserId
        ORDER BY qr.Score DESC";

            List<dynamic> topScores = new List<dynamic>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string userName = reader["UserName"].ToString();
                        int score = Convert.ToInt32(reader["Score"]);
                        byte[] profileImageBytes = reader["ProfileImage"] as byte[];

                        string profileImageBase64 = Convert.ToBase64String(profileImageBytes);

                        topScores.Add(new
                        {
                            UserName = userName,
                            Score = score,
                            ProfileImage = profileImageBase64
                        });
                        
                    }
                }
            }

            string response = JsonConvert.SerializeObject(new
            {
                status = "success",
                data = topScores
            });

            return response;
        }
        private string GetScoreHistory(string username)
        {

            string query = @"
            SELECT 
                q.QuizName,
                COALESCE(MAX(qr.Score), 0) AS HighScore
            FROM 
                Quiz q
            LEFT JOIN 
                QuizResult qr ON q.QuizId = qr.QuizId AND qr.UserId = (SELECT UserId FROM TaiKhoan WHERE UserName = @UserName)
            GROUP BY 
                q.QuizName
            ORDER BY 
                q.QuizName
        ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserName", username);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                List<Dictionary<string, object>> results = new List<Dictionary<string, object>>();
                while (reader.Read())
                {
                    results.Add(new Dictionary<string, object>()
            {
                { "QuizName", reader["QuizName"] },
                { "HighScore", reader["HighScore"] }
            });
                }

                string response = JsonConvert.SerializeObject(new
                {
                    status = "success",
                    data = results
                });
                return response;
            }
        }
        
        private string FinalScore(string username, int quizId, int score)
        {
           // Console.WriteLine("In func FinalScore: " + username + " " + quizId + " " + score);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                // Lấy UserId từ UserName
                string getUserIdQuery = "SELECT UserId FROM TaiKhoan WHERE UserName = @UserName";
                SqlCommand getUserIdCommand = new SqlCommand(getUserIdQuery, connection);
                getUserIdCommand.Parameters.AddWithValue("@UserName", username);
                connection.Open();

                int userId = -1;
                object result = getUserIdCommand.ExecuteScalar();
                if (result != null)
                {
                    userId = Convert.ToInt32(result);
                }
                else
                {
                    return JsonConvert.SerializeObject(new { status = "error", message = "User not found" });
                }
                connection.Close();

                // Lưu điểm vào bảng QuizResult
                string insertScoreQuery = "INSERT INTO QuizResult (UserId, QuizId, Score) VALUES (@UserId, @QuizId, @Score)";
                SqlCommand insertScoreCommand = new SqlCommand(insertScoreQuery, connection);
                insertScoreCommand.Parameters.AddWithValue("@UserId", userId);
                insertScoreCommand.Parameters.AddWithValue("@QuizId", quizId);
                insertScoreCommand.Parameters.AddWithValue("@Score", score);
                connection.Open();
                int rowsAffected = insertScoreCommand.ExecuteNonQuery();
                connection.Close();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Score saved successfully");
                    return JsonConvert.SerializeObject(new { status = "success", message = "Score saved successfully" });
                }
                else
                {
                    return JsonConvert.SerializeObject(new { status = "error", message = "Failed to save score" });
                }
            }
        }




        private string Logout(string username)
        {
            string query = "UPDATE TaiKhoan SET Status = 'Offline' WHERE UserName = @UserName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserName", username);

                connection.Open();
                command.ExecuteNonQuery();

            }
            string response = JsonConvert.SerializeObject(new { status = "success", message = "Đăng xuất thành công" });



            return response;
        }

        private string ResetPassword(string email)
        {
            string query = "SELECT PassWord From TaiKhoan WHERE Email = @Email";
            string response;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Email", email);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string passs = reader.GetString(0);
                     

                        // Tạo đối tượng JSON chứa thông tin người dùng và gửi lại cho client
                        var userPass = new { status = "success", pass = passs };
                        response = JsonConvert.SerializeObject(userPass);
                    }
                    else
                    {
                        response = JsonConvert.SerializeObject(new { status = "error", message = "Email chưa được đăng kí!" });
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                response = JsonConvert.SerializeObject(new { status = "error", message = "Error retrieving user information: " + ex.Message });
            }

            return response;

        }
        private string GetUserInfo(string username)
        {
            string query = "SELECT Email, ProfileImage FROM TaiKhoan WHERE UserName = @UserName";
            string response;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserName", username);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string email = reader.GetString(0);
                        byte[] profileImageBytes = reader["ProfileImage"] as byte[];
                        string profileImageBase64 = profileImageBytes != null ? Convert.ToBase64String(profileImageBytes) : null;

                        var userInfo = new { status = "success", email = email, profileImage = profileImageBase64 };
                        response = JsonConvert.SerializeObject(userInfo);
                    }
                    else
                    {
                        response = JsonConvert.SerializeObject(new { status = "error", message = "User not found" });
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                response = JsonConvert.SerializeObject(new { status = "error", message = "Error retrieving user information: " + ex.Message });
            }

            return response;
        }

        string HandleLogin(string username, string password)
        {
            string query = "SELECT Status FROM TaiKhoan WHERE UserName = @username AND PassWord = @password COLLATE SQL_Latin1_General_CP1_CS_AS";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    string status = reader["Status"].ToString();
                    if (status == "Online")
                    {
                        return JsonConvert.SerializeObject(new { status = "error", message = "Tài khoản đang đăng nhập ở vị trí khác!" });
                    }
                    else
                    {
                        reader.Close(); // Close the reader before executing another command

                        // Update the status to Online
                        string updateQuery = "UPDATE TaiKhoan SET Status = 'Online' WHERE UserName = @username AND PassWord = @password COLLATE SQL_Latin1_General_CP1_CS_AS";
                        SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                        updateCommand.Parameters.AddWithValue("@username", username);
                        updateCommand.Parameters.AddWithValue("@password", password);
                        updateCommand.ExecuteNonQuery();

                        return JsonConvert.SerializeObject(new { status = "success", message = "Đăng nhập thành công!" });
                    }
                }
                else
                {
                    return JsonConvert.SerializeObject(new { status = "error", message = "Tên Tài khoản hoặc Mật khẩu không chính xác!" });
                }
            }
        }

        string HandleRegister(string username, string password, string email, byte[] profileImage)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Kiểm tra email đã tồn tại chưa
                string checkEmailQuery = "SELECT * FROM TaiKhoan WHERE Email = @Email";
                SqlCommand checkEmailCommand = new SqlCommand(checkEmailQuery, connection);
                checkEmailCommand.Parameters.AddWithValue("@Email", email);

                SqlDataReader emailReader = checkEmailCommand.ExecuteReader();
                if (emailReader.HasRows)
                {
                    emailReader.Close();
                    return JsonConvert.SerializeObject(new { status = "error", message = "Email này đã được đăng ký, vui lòng sử dụng Email khác!" });
                }
                emailReader.Close();

                // Kiểm tra username đã tồn tại chưa
                string checkUsernameQuery = "SELECT * FROM TaiKhoan WHERE UserName = @UserName";
                SqlCommand checkUsernameCommand = new SqlCommand(checkUsernameQuery, connection);
                checkUsernameCommand.Parameters.AddWithValue("@UserName", username);

                SqlDataReader usernameReader = checkUsernameCommand.ExecuteReader();
                if (usernameReader.HasRows)
                {
                    usernameReader.Close();
                    return JsonConvert.SerializeObject(new { status = "error", message = "Username này đã tồn tại, vui lòng sử dụng Username khác!" });
                }
                usernameReader.Close();

                // Chuẩn bị câu truy vấn INSERT
                string query = "INSERT INTO TaiKhoan (UserName, Password, Email, ProfileImage, Status) VALUES (@UserName, @PassWord, @Email, @ProfileImage, @Status)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserName", username);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@ProfileImage", profileImage);
                command.Parameters.AddWithValue("@Status", "Offline");

                // Thực thi câu truy vấn INSERT
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    return JsonConvert.SerializeObject(new { status = "success", message = "Đăng ký thành công!" });
                }
                else
                {
                    return JsonConvert.SerializeObject(new { status = "error", message = "Đăng ký không thành công!" });
                }
            }
        }



        

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbCountDown.Text, out timeDown))
            {
                MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            if (countdownTimer.Enabled)
            {
                countdownTimer.Stop();
            }

            
            StartCountdown();
        }

        
        private void StartCountdown()
        {
            InitializeCountdownTimer();
            timeDown = int.Parse(tbCountDown.Text); // Lấy lại giá trị đếm ngược từ ô nhập liệu
            countdownTimer.Start();
            UpdateTimeDisplay(timeDown);
        }

       
    }
}
