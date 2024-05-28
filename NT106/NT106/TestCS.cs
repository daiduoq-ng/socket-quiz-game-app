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
    public partial class TestCS : Form
    {
        public TestCS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Server f = new Server();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sign_In f = new Sign_In();
            f.Show();
        }
    }
}
