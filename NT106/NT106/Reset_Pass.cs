using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106
{
    public partial class Reset_Pass : Form
    {
        public Reset_Pass()
        {
            InitializeComponent();
            label3.Text = "";

        }
        Modify modify= new Modify();    

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            if(email.Trim()=="")
            {
                MessageBox.Show("Vui lòng nhập email đăng kí!");
            }
            else
            {
                string query = "Select * from TaiKhoan where Email = '" + email + "'";
                if(modify.Users(query).Count() != 0 ) 
                {
                    label3.ForeColor = Color.Blue;
                    label3.Text = "Password: " + modify.Users(query)[0].Password;
                }
                else
                {
                    label3.ForeColor = Color.Red;
                    label3.Text = "Email này chưa được đăng kí!";
                } 
                    
            }
        }
    }
}
