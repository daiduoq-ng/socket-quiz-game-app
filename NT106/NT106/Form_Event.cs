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
    public partial class Form_Event : Form
    {
        private HomePage homePage;

        public Form_Event(HomePage homePage)
        {
            InitializeComponent();
            this.homePage = homePage;
        }

        private void lbEvent1_Click(object sender, EventArgs e)
        {
            Form_QuestionUser form_Event1 = new Form_QuestionUser();
            homePage.OpenChildForm(form_Event1);
        }

       
    }
}
