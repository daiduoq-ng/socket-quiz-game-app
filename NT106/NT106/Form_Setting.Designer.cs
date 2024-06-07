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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbMusic = new System.Windows.Forms.PictureBox();
            this.trackBarMusic = new System.Windows.Forms.TrackBar();
            this.btn_LogOut = new NT106.UserControls.ButtonElipse();
            this.btnAboutUs = new NT106.UserControls.ButtonElipse();
            this.btnChangePass = new NT106.UserControls.ButtonElipse();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnChange = new NT106.UserControls.ButtonElipse();
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
            this.linkLabel1.Location = new System.Drawing.Point(238, 250);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(114, 23);
            this.linkLabel1.TabIndex = 31;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Privacy Policy";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MintCream;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label4.Location = new System.Drawing.Point(269, 83);
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
            this.label3.Location = new System.Drawing.Point(238, 202);
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
            this.label2.Location = new System.Drawing.Point(238, 152);
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
            this.pictureBox1.Location = new System.Drawing.Point(188, 196);
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
            this.pbMusic.Location = new System.Drawing.Point(188, 150);
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
            this.trackBarMusic.Location = new System.Drawing.Point(310, 150);
            this.trackBarMusic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBarMusic.Maximum = 100;
            this.trackBarMusic.Name = "trackBarMusic";
            this.trackBarMusic.Size = new System.Drawing.Size(128, 45);
            this.trackBarMusic.SmallChange = 5;
            this.trackBarMusic.TabIndex = 23;
            this.trackBarMusic.TickFrequency = 20;
            this.trackBarMusic.Value = 20;
            this.trackBarMusic.Scroll += new System.EventHandler(this.trackBarMusic_Scroll);
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
            this.btn_LogOut.Location = new System.Drawing.Point(527, 353);
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
            this.btnAboutUs.Location = new System.Drawing.Point(332, 190);
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
            // btnChangePass
            // 
            this.btnChangePass.Active1 = System.Drawing.Color.DarkGreen;
            this.btnChangePass.Active2 = System.Drawing.Color.Black;
            this.btnChangePass.BackColor = System.Drawing.Color.Transparent;
            this.btnChangePass.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnChangePass.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.btnChangePass.ForeColor = System.Drawing.Color.MintCream;
            this.btnChangePass.Inactive1 = System.Drawing.Color.MediumSeaGreen;
            this.btnChangePass.Inactive2 = System.Drawing.Color.MediumSeaGreen;
            this.btnChangePass.Location = new System.Drawing.Point(32, 353);
            this.btnChangePass.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Radius = 10;
            this.btnChangePass.Size = new System.Drawing.Size(126, 36);
            this.btnChangePass.Stroke = false;
            this.btnChangePass.StrokeColor = System.Drawing.Color.Gray;
            this.btnChangePass.TabIndex = 32;
            this.btnChangePass.Text = "Change Password";
            this.btnChangePass.Transparency = false;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MintCream;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Location = new System.Drawing.Point(60, 331);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 19);
            this.label1.TabIndex = 33;
            this.label1.Text = "New Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.MintCream;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label5.Location = new System.Drawing.Point(50, 375);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 19);
            this.label5.TabIndex = 34;
            this.label5.Text = "Reenter Password";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.textBox1.Location = new System.Drawing.Point(182, 329);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '●';
            this.textBox1.Size = new System.Drawing.Size(139, 26);
            this.textBox1.TabIndex = 35;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.textBox2.Location = new System.Drawing.Point(182, 366);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '●';
            this.textBox2.Size = new System.Drawing.Size(139, 26);
            this.textBox2.TabIndex = 36;
            // 
            // btnChange
            // 
            this.btnChange.Active1 = System.Drawing.Color.DarkGreen;
            this.btnChange.Active2 = System.Drawing.Color.Black;
            this.btnChange.BackColor = System.Drawing.Color.Transparent;
            this.btnChange.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnChange.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.btnChange.ForeColor = System.Drawing.Color.MintCream;
            this.btnChange.Inactive1 = System.Drawing.Color.MediumSeaGreen;
            this.btnChange.Inactive2 = System.Drawing.Color.MediumSeaGreen;
            this.btnChange.Location = new System.Drawing.Point(350, 343);
            this.btnChange.Margin = new System.Windows.Forms.Padding(2);
            this.btnChange.Name = "btnChange";
            this.btnChange.Radius = 10;
            this.btnChange.Size = new System.Drawing.Size(88, 36);
            this.btnChange.Stroke = false;
            this.btnChange.StrokeColor = System.Drawing.Color.Gray;
            this.btnChange.TabIndex = 37;
            this.btnChange.Text = "Change";
            this.btnChange.Transparency = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // Form_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.BackgroundImage = global::NT106.Properties.Resources.Picture5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(635, 418);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.btnAboutUs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbMusic);
            this.Controls.Add(this.trackBarMusic);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_Setting";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form_Setting_Load);
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
        private UserControls.ButtonElipse btnChangePass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private UserControls.ButtonElipse btnChange;
    }
}