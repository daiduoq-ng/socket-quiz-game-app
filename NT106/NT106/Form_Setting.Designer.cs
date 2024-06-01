namespace NT106
{
    partial class Form_Setting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btn_LogOut = new NT106.UserControls.ButtonElipse();
            this.btnAboutUs = new NT106.UserControls.ButtonElipse();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbMusic = new System.Windows.Forms.PictureBox();
            this.trackBarMusic = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMusic)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.linkLabel1.LinkColor = System.Drawing.Color.MediumSeaGreen;
            this.linkLabel1.Location = new System.Drawing.Point(218, 234);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(114, 23);
            this.linkLabel1.TabIndex = 31;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Privacy Policy";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.Active1 = System.Drawing.Color.DarkGreen;
            this.btn_LogOut.Active2 = System.Drawing.Color.Black;
            this.btn_LogOut.BackColor = System.Drawing.Color.Transparent;
            this.btn_LogOut.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_LogOut.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.btn_LogOut.ForeColor = System.Drawing.Color.MintCream;
            this.btn_LogOut.Inactive1 = System.Drawing.Color.MediumSeaGreen;
            this.btn_LogOut.Inactive2 = System.Drawing.Color.MediumSeaGreen;
            this.btn_LogOut.Location = new System.Drawing.Point(484, 305);
            this.btn_LogOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Radius = 10;
            this.btn_LogOut.Size = new System.Drawing.Size(88, 36);
            this.btn_LogOut.Stroke = false;
            this.btn_LogOut.StrokeColor = System.Drawing.Color.Gray;
            this.btn_LogOut.TabIndex = 30;
            this.btn_LogOut.Text = "Logout";
            this.btn_LogOut.Transparency = false;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click_1);
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.Active1 = System.Drawing.Color.DarkGreen;
            this.btnAboutUs.Active2 = System.Drawing.Color.Black;
            this.btnAboutUs.BackColor = System.Drawing.Color.Transparent;
            this.btnAboutUs.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAboutUs.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.btnAboutUs.ForeColor = System.Drawing.Color.MintCream;
            this.btnAboutUs.Inactive1 = System.Drawing.Color.MediumSeaGreen;
            this.btnAboutUs.Inactive2 = System.Drawing.Color.MediumSeaGreen;
            this.btnAboutUs.Location = new System.Drawing.Point(312, 156);
            this.btnAboutUs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Radius = 10;
            this.btnAboutUs.Size = new System.Drawing.Size(88, 36);
            this.btnAboutUs.Stroke = false;
            this.btnAboutUs.StrokeColor = System.Drawing.Color.Gray;
            this.btnAboutUs.TabIndex = 29;
            this.btnAboutUs.Text = "Check";
            this.btnAboutUs.Transparency = false;
            this.btnAboutUs.Click += new System.EventHandler(this.btnAboutUs_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MintCream;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label4.Location = new System.Drawing.Point(250, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 38);
            this.label4.TabIndex = 28;
            this.label4.Text = "SETTING";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MintCream;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label3.Location = new System.Drawing.Point(218, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "About Us";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MintCream;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.Location = new System.Drawing.Point(218, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 23);
            this.label2.TabIndex = 26;
            this.label2.Text = "Music";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MintCream;
            this.pictureBox1.BackgroundImage = global::NT106.Properties.Resources.ask;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(169, 162);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 26);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // pbMusic
            // 
            this.pbMusic.BackColor = System.Drawing.Color.MintCream;
            this.pbMusic.BackgroundImage = global::NT106.Properties.Resources.music;
            this.pbMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbMusic.Location = new System.Drawing.Point(169, 115);
            this.pbMusic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbMusic.Name = "pbMusic";
            this.pbMusic.Size = new System.Drawing.Size(28, 23);
            this.pbMusic.TabIndex = 24;
            this.pbMusic.TabStop = false;
            // 
            // trackBarMusic
            // 
            this.trackBarMusic.BackColor = System.Drawing.Color.MintCream;
            this.trackBarMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarMusic.LargeChange = 15;
            this.trackBarMusic.Location = new System.Drawing.Point(291, 115);
            this.trackBarMusic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBarMusic.Maximum = 100;
            this.trackBarMusic.Name = "trackBarMusic";
            this.trackBarMusic.Size = new System.Drawing.Size(128, 45);
            this.trackBarMusic.SmallChange = 5;
            this.trackBarMusic.TabIndex = 23;
            this.trackBarMusic.TickFrequency = 20;
            this.trackBarMusic.Value = 20;
            // 
            // Form_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(622, 379);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.btnAboutUs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbMusic);
            this.Controls.Add(this.trackBarMusic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_Setting";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMusic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private UserControls.ButtonElipse btn_LogOut;
        private UserControls.ButtonElipse btnAboutUs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbMusic;
        private System.Windows.Forms.TrackBar trackBarMusic;
    }
}