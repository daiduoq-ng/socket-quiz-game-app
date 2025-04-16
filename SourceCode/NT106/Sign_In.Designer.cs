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
            this.linkLabel_SignUp = new System.Windows.Forms.LinkLabel();
            this.linkLabel_ForgotPass = new System.Windows.Forms.LinkLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_SignIn = new NT106.UserControls.ButtonElipse();
            this.chbShowPass = new System.Windows.Forms.CheckBox();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.tbIPServer = new System.Windows.Forms.TextBox();
            this.lbIPServer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel_SignUp
            // 
            this.linkLabel_SignUp.AutoSize = true;
            this.linkLabel_SignUp.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.linkLabel_SignUp.LinkColor = System.Drawing.Color.MediumSeaGreen;
            this.linkLabel_SignUp.Location = new System.Drawing.Point(242, 319);
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
            this.linkLabel_ForgotPass.Location = new System.Drawing.Point(44, 319);
            this.linkLabel_ForgotPass.Name = "linkLabel_ForgotPass";
            this.linkLabel_ForgotPass.Size = new System.Drawing.Size(155, 25);
            this.linkLabel_ForgotPass.TabIndex = 9;
            this.linkLabel_ForgotPass.TabStop = true;
            this.linkLabel_ForgotPass.Text = "Forgot password?";
            this.linkLabel_ForgotPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_ForgotPass_LinkClicked);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::NT106.Properties.Resources.key;
            this.pictureBox3.Location = new System.Drawing.Point(47, 251);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::NT106.Properties.Resources.account1;
            this.pictureBox2.Location = new System.Drawing.Point(45, 194);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NT106.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(102, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_SignIn
            // 
            this.btn_SignIn.Active1 = System.Drawing.Color.DarkGreen;
            this.btn_SignIn.Active2 = System.Drawing.Color.Black;
            this.btn_SignIn.BackColor = System.Drawing.Color.Transparent;
            this.btn_SignIn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_SignIn.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.btn_SignIn.ForeColor = System.Drawing.Color.MintCream;
            this.btn_SignIn.Inactive1 = System.Drawing.Color.MediumSeaGreen;
            this.btn_SignIn.Inactive2 = System.Drawing.Color.MediumSeaGreen;
            this.btn_SignIn.Location = new System.Drawing.Point(132, 432);
            this.btn_SignIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_SignIn.Name = "btn_SignIn";
            this.btn_SignIn.Radius = 10;
            this.btn_SignIn.Size = new System.Drawing.Size(110, 42);
            this.btn_SignIn.Stroke = false;
            this.btn_SignIn.StrokeColor = System.Drawing.Color.Gray;
            this.btn_SignIn.TabIndex = 31;
            this.btn_SignIn.Text = "Sign In";
            this.btn_SignIn.Transparency = false;
            this.btn_SignIn.Click += new System.EventHandler(this.btn_SignIn_Click);
            // 
            // chbShowPass
            // 
            this.chbShowPass.AutoSize = true;
            this.chbShowPass.Checked = true;
            this.chbShowPass.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbShowPass.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbShowPass.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.chbShowPass.Location = new System.Drawing.Point(184, 283);
            this.chbShowPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chbShowPass.Name = "chbShowPass";
            this.chbShowPass.Size = new System.Drawing.Size(140, 25);
            this.chbShowPass.TabIndex = 35;
            this.chbShowPass.Text = "Show Password";
            this.chbShowPass.UseVisualStyleBackColor = true;
            this.chbShowPass.CheckedChanged += new System.EventHandler(this.chbShowPass_CheckedChanged);
            // 
            // txbUserName
            // 
            this.txbUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbUserName.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUserName.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txbUserName.Location = new System.Drawing.Point(102, 199);
            this.txbUserName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(188, 33);
            this.txbUserName.TabIndex = 36;
            // 
            // txbPassword
            // 
            this.txbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPassword.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassword.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txbPassword.Location = new System.Drawing.Point(102, 251);
            this.txbPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(188, 33);
            this.txbPassword.TabIndex = 37;
            // 
            // tbIPServer
            // 
            this.tbIPServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbIPServer.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIPServer.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.tbIPServer.Location = new System.Drawing.Point(142, 377);
            this.tbIPServer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbIPServer.Name = "tbIPServer";
            this.tbIPServer.Size = new System.Drawing.Size(148, 30);
            this.tbIPServer.TabIndex = 38;
            this.tbIPServer.Text = "127.0.0.1";
            // 
            // lbIPServer
            // 
            this.lbIPServer.AutoSize = true;
            this.lbIPServer.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbIPServer.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbIPServer.Location = new System.Drawing.Point(44, 382);
            this.lbIPServer.Name = "lbIPServer";
            this.lbIPServer.Size = new System.Drawing.Size(93, 25);
            this.lbIPServer.TabIndex = 39;
            this.lbIPServer.Text = "IP Server";
            // 
            // Sign_In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(370, 496);
            this.Controls.Add(this.lbIPServer);
            this.Controls.Add(this.tbIPServer);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbUserName);
            this.Controls.Add(this.chbShowPass);
            this.Controls.Add(this.btn_SignIn);
            this.Controls.Add(this.linkLabel_SignUp);
            this.Controls.Add(this.linkLabel_ForgotPass);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sign_In";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In";
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
        private System.Windows.Forms.LinkLabel linkLabel_SignUp;
        private System.Windows.Forms.LinkLabel linkLabel_ForgotPass;
        private UserControls.ButtonElipse btn_SignIn;
        private System.Windows.Forms.CheckBox chbShowPass;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.TextBox tbIPServer;
        private System.Windows.Forms.Label lbIPServer;
    }
}

