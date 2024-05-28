using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NT106
{
    class User
    {
        private string userName;
        private string password;
        public string Email { get; set; } // Thêm thuộc tính Email
        public byte[] ProfileImage { get; set; }
        public User()
        {
        }

        public User(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }


        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
    }
}
