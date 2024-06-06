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
    public partial class Form_Setting : Form
    {
        private HomePage homePage;
        public UserControl ChinhSach;

        public Form_Setting(HomePage homePage)
        {
            InitializeComponent();
            this.homePage = homePage;

            // Đặt giá trị của TrackBar từ Application Settings khi Form Setting được khởi tạo
            trackBarMusic.Value = Properties.Settings.Default.VolumeLevel;

        }

        private void VolumeTrackBar_ValueChanged(object sender, EventArgs e)
        {
            // Lấy giá trị hiện tại của TrackBar làm giá trị âm lượng
            int volume = trackBarMusic.Value;

            // Gọi phương thức hoặc sử dụng giá trị âm lượng tại đây
            // Ví dụ: điều chỉnh âm lượng của âm thanh dựa trên giá trị volume
            AdjustVolume(volume);
        }
        private void AdjustVolume(int volume)
        {
            // Thực hiện điều chỉnh âm lượng tại đây dựa trên giá trị volume
            // Ví dụ: điều chỉnh âm lượng của hệ thống hoặc thiết bị âm thanh
            // System.Media.SystemSounds.Asterisk.Play(); // Ví dụ đơn giản
            Console.WriteLine($"Đã điều chỉnh âm lượng: {volume}");
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            Form_Infor form_Infor = new Form_Infor();
            homePage.OpenChildForm(form_Infor);
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            // Đóng form hiện tại
            this.Close();

            // Khởi động lại ứng dụng
            Application.Restart();
        }

        private void btnCheckGuide_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            homePage.SetVolume(trackBarMusic.Value); //set volume cho nhạc nền ở homepage
            Properties.Settings.Default.VolumeLevel = trackBarMusic.Value;
            Properties.Settings.Default.Save();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChinhSachRiengTu f = new ChinhSachRiengTu();
            f.Show();
        }

        private void btn_LogOut_Click_1(object sender, EventArgs e)
        {
            this.ResetForm();
        }

        private void ResetForm()
        {
            // Đóng form HomePage nếu nó đang mở
            foreach (Form form in Application.OpenForms)
            {
                if (form is HomePage)
                {
                    form.Close();
                    break; // Kết thúc vòng lặp sau khi đã tìm thấy và đóng form HomePage
                }
            }

            // Mở lại form đăng nhập
            Sign_In loginForm = new Sign_In();
            loginForm.Show();
        }

    }
}
