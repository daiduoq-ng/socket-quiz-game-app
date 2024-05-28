namespace NT106
{
    partial class Sign_In
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sign_In));
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.btn_SignIn = new System.Windows.Forms.Button();
            this.linkLabel_SignUp = new System.Windows.Forms.LinkLabel();
            this.linkLabel_ForgotPass = new System.Windows.Forms.LinkLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_UserName.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.textBox_UserName.ForeColor = System.Drawing.Color.DarkGreen;
            this.textBox_UserName.Location = new System.Drawing.Point(133, 239);
            this.textBox_UserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_UserName.Multiline = true;
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox_UserName.Size = new System.Drawing.Size(254, 39);
            this.textBox_UserName.TabIndex = 3;
            // 
            // textBox_Password
            // 
            this.textBox_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Password.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.textBox_Password.ForeColor = System.Drawing.Color.DarkGreen;
            this.textBox_Password.Location = new System.Drawing.Point(133, 309);
            this.textBox_Password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Password.Multiline = true;
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(254, 36);
            this.textBox_Password.TabIndex = 4;
            // 
            // btn_SignIn
            // 
            this.btn_SignIn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_SignIn.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold);
            this.btn_SignIn.ForeColor = System.Drawing.Color.Honeydew;
            this.btn_SignIn.Location = new System.Drawing.Point(182, 457);
            this.btn_SignIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_SignIn.Name = "btn_SignIn";
            this.btn_SignIn.Size = new System.Drawing.Size(147, 52);
            this.btn_SignIn.TabIndex = 8;
            this.btn_SignIn.Text = "Sign In";
            this.btn_SignIn.UseVisualStyleBackColor = false;
            this.btn_SignIn.Click += new System.EventHandler(this.btn_SignIn_Click);
            // 
            // linkLabel_SignUp
            // 
            this.linkLabel_SignUp.AutoSize = true;
            this.linkLabel_SignUp.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.linkLabel_SignUp.LinkColor = System.Drawing.Color.MediumSeaGreen;
            this.linkLabel_SignUp.Location = new System.Drawing.Point(322, 393);
            this.linkLabel_SignUp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel_SignUp.Name = "linkLabel_SignUp";
            this.linkLabel_SignUp.Size = new System.Drawing.Size(76, 25);
            this.linkLabel_SignUp.TabIndex = 10;
            this.linkLabel_SignUp.TabStop = true;
            this.linkLabel_SignUp.Text = "Sign Up";
            this.linkLabel_SignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_SignUp_LinkClicked);
            // 
            // linkLabel_ForgotPass
            // 
            this.linkLabel_ForgotPass.AutoSize = true;
            this.linkLabel_ForgotPass.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.linkLabel_ForgotPass.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.linkLabel_ForgotPass.LinkColor = System.Drawing.Color.MediumSeaGreen;
            this.linkLabel_ForgotPass.Location = new System.Drawing.Point(58, 393);
            this.linkLabel_ForgotPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel_ForgotPass.Name = "linkLabel_ForgotPass";
            this.linkLabel_ForgotPass.Size = new System.Drawing.Size(155, 25);
            this.linkLabel_ForgotPass.TabIndex = 9;
            this.linkLabel_ForgotPass.TabStop = true;
            this.linkLabel_ForgotPass.Text = "Forgot password?";
            this.linkLabel_ForgotPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::NT106.Properties.Resources.key;
            this.pictureBox3.Location = new System.Drawing.Point(63, 309);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::NT106.Properties.Resources.account1;
            this.pictureBox2.Location = new System.Drawing.Point(60, 239);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NT106.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(136, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Sign_In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(493, 538);
            this.Controls.Add(this.linkLabel_SignUp);
            this.Controls.Add(this.linkLabel_ForgotPass);
            this.Controls.Add(this.btn_SignIn);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_UserName);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Sign_In";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In";
            this.Load += new System.EventHandler(this.Sign_In_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Button btn_SignIn;
        private System.Windows.Forms.LinkLabel linkLabel_SignUp;
        private System.Windows.Forms.LinkLabel linkLabel_ForgotPass;
    }
}

