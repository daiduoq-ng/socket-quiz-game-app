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

        public Form_Setting(HomePage homePage)
        {
            InitializeComponent();
            this.homePage = homePage;
        }

        private void VolumeTrackBar_ValueChanged(object sender, EventArgs e)
        {
            // Lấy giá trị hiện tại của TrackBar làm giá trị âm lượng
            int volume = trackBar1.Value;

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

        private void btnCheckGuide_Click(object sender, EventArgs e)
        {
            Form_Guides form_Guides = new Form_Guides();
            homePage.OpenChildForm(form_Guides);
        }
    }
}
