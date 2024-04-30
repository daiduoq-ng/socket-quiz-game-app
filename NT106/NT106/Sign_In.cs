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
        public Sign_In()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Reset_Pass  resetpass = new Reset_Pass();
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
            if(user_name.Trim()=="")
            {
                MessageBox.Show("Vui lòng nhập Tên tài khoản!");
            }
            else if(password.Trim()=="")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
            }
            else
            {
                string query = "Select * from TaiKhoan where UserName = '" +user_name+"' and PassWord = '"+password+"'";
                if(modify.Users(query).Count!=0)
                {
                    MessageBox.Show("Đăng nhập thành công!","Succes",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Hide();

                    //Chỗ này là mở form sau khi đăng nhập thành công nè
                    //ở đây mở cái form tên là Form_Game để test\
                    Form_Game  Game = new Form_Game(); 
                    Game.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Tên Tài khoản hoặc Mật khẩu không chính xác!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
