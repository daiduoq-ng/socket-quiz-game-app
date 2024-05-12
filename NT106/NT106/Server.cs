using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace NT106
{
    public partial class Server : Form
    {

        public Server()
        {
            InitializeComponent();
            connect();
        }
        /*
        private void Server_Load(object sender, EventArgs e)
        {
            // Khởi tạo một luồng mới để bắt đầu lắng nghe kết nối từ client
            Thread listenThread = new Thread(ListenForClients);
            listenThread.Start();
        }

        // Phương thức để bắt đầu lắng nghe kết nối từ client
        private void ListenForClients()
        {
            // Biến đếm số lượng client kết nối
            int cnt = 1;

            // Khởi tạo một đối tượng TcpListener để lắng nghe kết nối từ client
            TcpListener listener = new TcpListener(IPAddress.Any, 8080);
            listener.Start();

            richTextBox1.AppendText("Waiting player!\n");

            // Vòng lặp vô hạn để chấp nhận kết nối từ client
            while (true)
            {
                // Chấp nhận kết nối từ một client
                TcpClient client = listener.AcceptTcpClient();
                // Thêm client mới vào danh sách
                list_clients.Add(cnt, client);
                richTextBox1.AppendText("Someone is playing!\n");

                // Tạo một luồng mới để xử lý kết nối từ client
                Thread clientThread = new Thread(HandleClient);
                clientThread.Start(cnt);

                // Tăng biến đếm để đảm bảo id duy nhất cho mỗi client
                cnt++;
            }
        }

        // Phương thức xử lý kết nối từ client
        private void HandleClient(object obj)
        {
            // Ép kiểu đối tượng đầu vào thành kiểu int để lấy id của client
            int id = (int)obj;
            TcpClient client;

            // Truy cập list_clients để lấy client tương ứng với id
            client = list_clients[id];

            // Vòng lặp vô hạn để nhận và xử lý dữ liệu từ client
            while (true)
            {
                try
                {
                    // Sử dụng NetworkStream để truyền và nhận dữ liệu giữa máy chủ và client
                    NetworkStream stream = client.GetStream();

                    // Khởi tạo buffer để đọc dữ liệu từ client
                    byte[] buffer = new byte[1024];

                    // Đọc dữ liệu từ client và trả về số lượng byte đã đọc được
                    int byte_count = stream.Read(buffer, 0, buffer.Length);

                    // Nếu không có dữ liệu được gửi từ client, thoát khỏi vòng lặp
                    if (byte_count == 0)
                    {
                        break;
                    }

                    // Decode dữ liệu nhận được từ client thành chuỗi
                    string data = Encoding.Unicode.GetString(buffer, 0, byte_count);

                    // Phát sóng dữ liệu nhận được từ client đến tất cả các client khác
                    broadcast(data);

                    // In ra dữ liệu nhận được từ client lên richTextBox1
                    richTextBox1.Invoke(new Action(() => richTextBox1.AppendText(data + "\n")));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    break;
                }
            }

            // Xóa client đã ngắt kết nối khỏi danh sách và đóng kết nối
            list_clients.Remove(id);
            client.Close();
        }

        // Phương thức để phát sóng dữ liệu từ một client đến tất cả các client khác
        private void broadcast(string data)
        {
            // Encode dữ liệu thành mảng byte
            byte[] buffer = Encoding.Unicode.GetBytes(data + Environment.NewLine);
            foreach (TcpClient client in list_clients.Values)
            {
                try
                {
                    // Lấy luồng mạng từ client để gửi dữ liệu
                    NetworkStream stream = client.GetStream();

                    // Gửi dữ liệu đến client
                    stream.Write(buffer, 0, buffer.Length);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }*/

        IPEndPoint IP;
        Socket server;
        List<Socket> clientList;

        void connect()
        {
            clientList = new List<Socket>();
            IP = new IPEndPoint(IPAddress.Any, 8080);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            server.Bind(IP);

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

        void close()
        {
            server.Close();
        }

        void Send()
        {
            //question là câu hỏi lấy từ csdl
            string question="";
            foreach(Socket item in clientList)
            {
                item.Send(serialize(question));
            }    
        }

        void receive(object obj)
        {
            Socket client = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] buffer = new byte[1024];
                    client.Receive(buffer);

                    string data = (string)deserialize(buffer);

                    addData(data);
                }
            }
            catch
            {
                clientList.Remove(client);
                client.Close();
            }
            
        }

        void addData(string s)
        {
            richTextBox1.AppendText(s);
        }

        byte[] serialize(object obj)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, obj);
                return stream.ToArray();
            }
        }

        object deserialize(byte[] data)
        {
            using (MemoryStream stream = new MemoryStream(data))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                return formatter.Deserialize(stream);
            }
        }
    }
}
