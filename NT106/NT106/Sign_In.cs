using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106
{
    public partial class Sign_In : Form
    {
        public delegate void LoginSuccessHandler(string username);
        public event LoginSuccessHandler OnLoginSuccess;

        public Sign_In()
        {
            InitializeComponent();
            this.Load += Sign_In_Load;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Reset_Pass resetpass = new Reset_Pass();
            resetpass.ShowDialog();
        }

        private void linkLabel_SignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sign_Up signup = new Sign_Up();
            signup.ShowDialog();
        }

        Modify modify = new Modify();

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            string user_name = textBox_UserName.Text;
            string password = textBox_Password.Text;
            if (user_name.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Tên tài khoản!");
            }
            else if (password.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
            }
            else
            {
                string query = "Select * from TaiKhoan where UserName = '" + user_name + "' and PassWord = '" + password + "'";
                if (modify.Users(query).Count != 0)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // this.Hide();
                    OnLoginSuccess?.Invoke(user_name);

                    HomePage home = new HomePage(user_name);
                    home.Show();
                    

                }
                else
                {
                    MessageBox.Show("Tên Tài khoản hoặc Mật khẩu không chính xác!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Sign_In_Load(object sender, EventArgs e)
        {
            // Tạo một đối tượng của Sign_In và gán sự kiện OnLoginSuccess
            Sign_In signInForm = new Sign_In();
            signInForm.OnLoginSuccess += OpenHomePage;
        }

        private void OpenHomePage(string username)
        {
            // Mở form HomePage và truyền thông tin người dùng
            HomePage homePage = new HomePage(username);
            homePage.Show();
        }
    }
}

