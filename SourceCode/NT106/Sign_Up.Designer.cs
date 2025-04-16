namespace NT106
{
    partial class Sign_Up
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sign_Up));
            this.btnUpAVT = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.chbShowPass = new System.Windows.Forms.CheckBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.textBox_confpass = new System.Windows.Forms.TextBox();
            this.btn_SignUp = new NT106.UserControls.ButtonElipse();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpAVT
            // 
            this.btnUpAVT.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold);
            this.btnUpAVT.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnUpAVT.Location = new System.Drawing.Point(55, 349);
            this.btnUpAVT.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpAVT.Name = "btnUpAVT";
            this.btnUpAVT.Size = new System.Drawing.Size(109, 29);
            this.btnUpAVT.TabIndex = 22;
            this.btnUpAVT.Text = "Upload Avatar";
            this.btnUpAVT.UseVisualStyleBackColor = true;
            this.btnUpAVT.Click += new System.EventHandler(this.btnUpAVT_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label4.Location = new System.Drawing.Point(50, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label3.Location = new System.Drawing.Point(50, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Confirm Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.Location = new System.Drawing.Point(50, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Location = new System.Drawing.Point(50, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "User Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label5.Location = new System.Drawing.Point(115, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 41);
            this.label5.TabIndex = 25;
            this.label5.Text = "Sign Up";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NT106.Properties.Resources.verify;
            this.pictureBox1.Location = new System.Drawing.Point(227, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.Location = new System.Drawing.Point(285, 349);
            this.pictureBoxPreview.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(83, 88);
            this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPreview.TabIndex = 23;
            this.pictureBoxPreview.TabStop = false;
            // 
            // chbShowPass
            // 
            this.chbShowPass.AutoSize = true;
            this.chbShowPass.Checked = true;
            this.chbShowPass.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbShowPass.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbShowPass.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.chbShowPass.Location = new System.Drawing.Point(263, 313);
            this.chbShowPass.Margin = new System.Windows.Forms.Padding(2);
            this.chbShowPass.Name = "chbShowPass";
            this.chbShowPass.Size = new System.Drawing.Size(140, 25);
            this.chbShowPass.TabIndex = 36;
            this.chbShowPass.Text = "Show Password";
            this.chbShowPass.UseVisualStyleBackColor = true;
            this.chbShowPass.CheckedChanged += new System.EventHandler(this.chbShowPass_CheckedChanged);
            // 
            // textBox_Name
            // 
            this.textBox_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Name.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.textBox_Name.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.textBox_Name.Location = new System.Drawing.Point(188, 144);
            this.textBox_Name.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(180, 33);
            this.textBox_Name.TabIndex = 37;
            // 
            // textBox_email
            // 
            this.textBox_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_email.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.textBox_email.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.textBox_email.Location = new System.Drawing.Point(188, 188);
            this.textBox_email.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(180, 33);
            this.textBox_email.TabIndex = 38;
            // 
            // textBox_pass
            // 
            this.textBox_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_pass.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.textBox_pass.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.textBox_pass.Location = new System.Drawing.Point(188, 231);
            this.textBox_pass.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.Size = new System.Drawing.Size(180, 33);
            this.textBox_pass.TabIndex = 39;
            // 
            // textBox_confpass
            // 
            this.textBox_confpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_confpass.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.textBox_confpass.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.textBox_confpass.Location = new System.Drawing.Point(188, 274);
            this.textBox_confpass.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_confpass.Name = "textBox_confpass";
            this.textBox_confpass.Size = new System.Drawing.Size(180, 33);
            this.textBox_confpass.TabIndex = 40;
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.Active1 = System.Drawing.Color.DarkGreen;
            this.btn_SignUp.Active2 = System.Drawing.Color.Black;
            this.btn_SignUp.BackColor = System.Drawing.Color.Transparent;
            this.btn_SignUp.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_SignUp.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold);
            this.btn_SignUp.ForeColor = System.Drawing.Color.MintCream;
            this.btn_SignUp.Inactive1 = System.Drawing.Color.MediumSeaGreen;
            this.btn_SignUp.Inactive2 = System.Drawing.Color.MediumSeaGreen;
            this.btn_SignUp.Location = new System.Drawing.Point(163, 498);
            this.btn_SignUp.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Radius = 10;
            this.btn_SignUp.Size = new System.Drawing.Size(110, 41);
            this.btn_SignUp.Stroke = false;
            this.btn_SignUp.StrokeColor = System.Drawing.Color.Gray;
            this.btn_SignUp.TabIndex = 31;
            this.btn_SignUp.Text = "Sign Up";
            this.btn_SignUp.Transparency = false;
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click);
            // 
            // tbIP
            // 
            this.tbIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbIP.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIP.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.tbIP.Location = new System.Drawing.Point(211, 455);
            this.tbIP.Margin = new System.Windows.Forms.Padding(2);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(141, 28);
            this.tbIP.TabIndex = 42;
            this.tbIP.Text = "127.0.0.1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label6.Location = new System.Drawing.Point(103, 458);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 25);
            this.label6.TabIndex = 41;
            this.label6.Text = "IP Address";
            // 
            // Sign_Up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(413, 561);
            this.Controls.Add(this.tbIP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_confpass);
            this.Controls.Add(this.textBox_pass);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.chbShowPass);
            this.Controls.Add(this.btn_SignUp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxPreview);
            this.Controls.Add(this.btnUpAVT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sign_Up";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.Button btnUpAVT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private UserControls.ButtonElipse btn_SignUp;
        private System.Windows.Forms.CheckBox chbShowPass;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.TextBox textBox_confpass;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Label label6;
    }
}