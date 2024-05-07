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
    public partial class Form_Account : Form
    {
        public Form_Account()
        {
            InitializeComponent();
        }

        private void lbDoiAvt_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif)|*.jpg;*.jpeg;*.png;*.gif|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                if (pbAvt.BackgroundImage != null)
                {
                    pbAvt.BackgroundImage.Dispose(); 
                    pbAvt.BackgroundImage = null;    
                }

                Image newImage = Image.FromFile(imagePath);
                pbAvt.Image = newImage;
                pbAvt.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}
