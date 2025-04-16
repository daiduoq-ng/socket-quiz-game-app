using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace NT106
{
    class Connection
    {
        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ADMIN\Downloads\NT106-Final\NT106-Final\NT106\NT106\Database1.mdf;Integrated Security=True";

        public static string GetConnectionString()
        {
            return connectionString;
        }
    }
}
