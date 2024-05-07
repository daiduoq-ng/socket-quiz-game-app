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
    public partial class HomePage : Form
    {
        private Form CurrentFormChild;
        
        public HomePage()
        {
            InitializeComponent();
        }
        public void OpenChildForm(Form ChildForm)
        {
            if (CurrentFormChild != null) CurrentFormChild.Close();
            CurrentFormChild = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.Dock = DockStyle.Fill;
            panelBody.Controls.Add(ChildForm);
            panelBody.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_Account());
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            Form_Event formEvent = new Form_Event(this);
            OpenChildForm(formEvent);
        }

        private void btnBXH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_BXH());
        }

        private void btnMyScore_Click(object sender, EventArgs e)
        {

        }

        private void btnSetting_Click(object sender, EventArgs e)
        {

        }
    }
}
