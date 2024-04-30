using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Runtime.Remoting.Messaging;

namespace NT106
{
    public partial class Sign_Up : Form
    {
        public Sign_Up()
        {
            InitializeComponent();
        }

        public bool checkAccount(string account) //check mk va tk co hop le hay khong
        {
            return Regex.IsMatch(account, "^[a-zA-z0-9]{6,24}$"); //tu aA den zZ va tu 0 den 9
        }

        public bool checkEmail(string email)
        {
            return Regex.IsMatch(email, @"^[a-zA-Z0-9_.]{3,20}@gmail\.com(\.vn|)$");
        }

        Modify modify = new Modify();

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            string usersname=textBox_Name.Text;
            string password = textBox_pass.Text;
            string confirmpass = textBox_confpass.Text;
            string email=textBox_email.Text;

            if(!checkAccount(usersname))
            {
                MessageBox.Show("Vui lòng nhập Tên tài khoản từ 6-24 kí tự, với các kí tự chữ và số, chữ hoa và chữ thường!");
                return;
            }

            if (!checkAccount(password))
            {
                MessageBox.Show("Vui lòng nhập Mật khẩu từ 3 đến 20 kí tự, với các kí tự chữ và số, chữ hoa và chữ thường!");
                return;
            }

            if (confirmpass != password)
            {
                MessageBox.Show("Xác nhận mật khẩu không trùng khớp!");
                return;
            }

            if(!checkEmail(email))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng Email!");
                return;
            }

            if (modify.Users("Select *  from TaiKhoan where Email = '" + email + "'").Count != 0)
            {
                MessageBox.Show("Email này đã được đăng kí, vui lòng sử dụng Email khác!");
                return;
            }
            try
            {
                string query = "Insert into TaiKhoan values ('" + usersname+"','"+password + "','"+email+"')";
                modify.Command(query);
                MessageBox.Show("Đăng ký thành công!");
                Close();
            }
            catch
            {
                MessageBox.Show("Tên tài khản đã được đăng kí, Vui lòng nhập tên tài khoản khác!");
            }

        }
    }
}
