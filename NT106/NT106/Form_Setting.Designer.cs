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
            this.linkLabel1.Location = new System.Drawing.Point(290, 288);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(145, 29);
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
            this.btn_LogOut.Location = new System.Drawing.Point(645, 375);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Radius = 10;
            this.btn_LogOut.Size = new System.Drawing.Size(118, 44);
            this.btn_LogOut.Stroke = false;
            this.btn_LogOut.StrokeColor = System.Drawing.Color.Gray;
            this.btn_LogOut.TabIndex = 30;
            this.btn_LogOut.Text = "Logout";
            this.btn_LogOut.Transparency = false;
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
            this.btnAboutUs.Location = new System.Drawing.Point(416, 192);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Radius = 10;
            this.btnAboutUs.Size = new System.Drawing.Size(118, 44);
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
            this.label4.Location = new System.Drawing.Point(334, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 48);
            this.label4.TabIndex = 28;
            this.label4.Text = "SETTING";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MintCream;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label3.Location = new System.Drawing.Point(290, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 29);
            this.label3.TabIndex = 27;
            this.label3.Text = "About Us";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MintCream;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.Location = new System.Drawing.Point(290, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 29);
            this.label2.TabIndex = 26;
            this.label2.Text = "Music";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MintCream;
            this.pictureBox1.BackgroundImage = global::NT106.Properties.Resources.ask;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(225, 200);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 32);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // pbMusic
            // 
            this.pbMusic.BackColor = System.Drawing.Color.MintCream;
            this.pbMusic.BackgroundImage = global::NT106.Properties.Resources.music;
            this.pbMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbMusic.Location = new System.Drawing.Point(225, 142);
            this.pbMusic.Name = "pbMusic";
            this.pbMusic.Size = new System.Drawing.Size(37, 28);
            this.pbMusic.TabIndex = 24;
            this.pbMusic.TabStop = false;
            // 
            // trackBarMusic
            // 
            this.trackBarMusic.BackColor = System.Drawing.Color.MintCream;
            this.trackBarMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarMusic.LargeChange = 15;
            this.trackBarMusic.Location = new System.Drawing.Point(388, 142);
            this.trackBarMusic.Maximum = 100;
            this.trackBarMusic.Name = "trackBarMusic";
            this.trackBarMusic.Size = new System.Drawing.Size(171, 56);
            this.trackBarMusic.SmallChange = 5;
            this.trackBarMusic.TabIndex = 23;
            this.trackBarMusic.TickFrequency = 20;
            this.trackBarMusic.Value = 20;
            // 
            // Form_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(829, 467);
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