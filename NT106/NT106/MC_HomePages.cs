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
    public partial class MC_HomePages : Form
    {
        private Form CurrentFormChild;
        public MC_HomePages()
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

        private void btnQuestion_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_QuestionMC());
        }

        private void btnInfor_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_Infor());
        }

        
    }
}
