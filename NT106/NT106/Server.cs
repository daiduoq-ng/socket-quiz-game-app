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
     
        public Server()
        {
            InitializeComponent();
            InitializeCountdownTimer();
            connect();
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";


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
            int timeInSeconds;
            if (int.TryParse(tbCountDown.Text, out timeInSeconds))
            {
                if (timeInSeconds > 0)
                {
                    timeInSeconds--;
                    UpdateTimeDisplay(timeInSeconds);
                    tbCountDown.Text = timeInSeconds.ToString();
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
                            SendMultipleQuestions_1();
                            break;
                        case "2":
                            SendMultipleQuestions_2();
                            break;
                        case "3":
                            SendMultipleQuestions_3();
                            break;
                        default:
                            // Xử lý cho các lựa chọn khác nếu cần
                            break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid input in the countdown timer.");
                countdownTimer.Stop();
            }
        }

        private void UpdateTimeDisplay(int timeInSeconds)
        {
            TimeSpan time = TimeSpan.FromSeconds(timeInSeconds);
            tbTime.Text = $"Time: {time:mm\\:ss}";
        }

        private void StartCountdown()
        {
            InitializeCountdownTimer();
            countdownTimer.Start();
            UpdateTimeDisplay(int.Parse(tbCountDown.Text));
        }

        private void StopCountdown()
        {
            countdownTimer.Stop();
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

                        else if(request.type== "getInfo")
                        {
                            response = GetUserInfo((string)request.username);
                        }
                        else if(request.type== "resetPass")
                        {
                            response= ResetPassword((string)request.email);
                        }    
                        
                        
                        else
                        {
                            // Yêu cầu không được nhận diện
                            response = JsonConvert.SerializeObject(new { status = "error", message = "Unknown request type" });
                        }

                        // Chuyển đổi phản hồi thành mảng byte và gửi lại cho client
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
           
            string query = "SELECT * FROM TaiKhoan WHERE UserName = @username AND PassWord = @password";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    return JsonConvert.SerializeObject(new { status = "success", message = "Đăng nhập thành công!" });
                }
                else
                {
                    return JsonConvert.SerializeObject(new { status = "error", message = "Tên Tài khoản hoặc Mật khẩu không chính xác!" });
                }
            }
        }

        string HandleRegister(string username, string password, string email, byte[] profileImage)
        {
            // Kiểm tra email đã tồn tại chưa
            string checkQuery = "SELECT * FROM TaiKhoan WHERE Email = @Email";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                checkCommand.Parameters.AddWithValue("@Email", email);

                connection.Open();
                SqlDataReader reader = checkCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    return JsonConvert.SerializeObject(new { status = "error", message = "Email này đã được đăng ký, vui lòng sử dụng Email khác!" });
                }
                reader.Close();

                // Chuẩn bị câu truy vấn INSERT
                string query = "INSERT INTO TaiKhoan (UserName, Password, Email, ProfileImage) VALUES (@UserName, @PassWord, @Email, @ProfileImage)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserName", username);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@ProfileImage", profileImage);

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


    private void button1_Click(object sender, EventArgs e)
        {
            SendMultipleQuestions_1();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StartCountdown();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
