namespace NT106
{
    partial class Server
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Question = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCountDown = new NT106.UserControls.TextBoxElipse();
            this.btnSend = new NT106.UserControls.ButtonElipse();
            this.tbTime = new NT106.UserControls.TextBoxElipse();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.MintCream;
            this.richTextBox1.Location = new System.Drawing.Point(19, 27);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(466, 167);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
           
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.tabControl1.Location = new System.Drawing.Point(22, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(509, 245);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.MintCream;
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(501, 213);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Status";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbCountDown);
            this.tabPage2.Controls.Add(this.btnSend);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.cb_Question);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.tbTime);
            this.tabPage2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(501, 213);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Config";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.Location = new System.Drawing.Point(32, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 19);
            this.label2.TabIndex = 52;
            this.label2.Text = "Ngân hàng câu hỏi";
            // 
            // cb_Question
            // 
            this.cb_Question.FormattingEnabled = true;
            this.cb_Question.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cb_Question.Location = new System.Drawing.Point(192, 113);
            this.cb_Question.Name = "cb_Question";
            this.cb_Question.Size = new System.Drawing.Size(121, 27);
            this.cb_Question.TabIndex = 51;
         
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Location = new System.Drawing.Point(32, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 19);
            this.label1.TabIndex = 50;
            this.label1.Text = "Thời gian đếm ngược";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "IP Server: ";
            // 
            // tbCountDown
            // 
            this.tbCountDown.BackColor = System.Drawing.Color.Transparent;
            this.tbCountDown.Br = System.Drawing.Color.White;
            this.tbCountDown.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.tbCountDown.ForeColor = System.Drawing.Color.DarkGreen;
            this.tbCountDown.Location = new System.Drawing.Point(192, 70);
            this.tbCountDown.Margin = new System.Windows.Forms.Padding(2);
            this.tbCountDown.Name = "tbCountDown";
            this.tbCountDown.Size = new System.Drawing.Size(120, 27);
            this.tbCountDown.TabIndex = 54;
            // 
            // btnSend
            // 
            this.btnSend.Active1 = System.Drawing.Color.DarkGreen;
            this.btnSend.Active2 = System.Drawing.Color.Black;
            this.btnSend.BackColor = System.Drawing.Color.Transparent;
            this.btnSend.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSend.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.btnSend.ForeColor = System.Drawing.Color.MintCream;
            this.btnSend.Inactive1 = System.Drawing.Color.MediumSeaGreen;
            this.btnSend.Inactive2 = System.Drawing.Color.MediumSeaGreen;
            this.btnSend.Location = new System.Drawing.Point(363, 70);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Radius = 10;
            this.btnSend.Size = new System.Drawing.Size(68, 25);
            this.btnSend.Stroke = false;
            this.btnSend.StrokeColor = System.Drawing.Color.Gray;
            this.btnSend.TabIndex = 53;
            this.btnSend.Text = "Send";
            this.btnSend.Transparency = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbTime
            // 
            this.tbTime.BackColor = System.Drawing.Color.Transparent;
            this.tbTime.Br = System.Drawing.Color.White;
            this.tbTime.Enabled = false;
            this.tbTime.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.tbTime.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.tbTime.Location = new System.Drawing.Point(363, 107);
            this.tbTime.Margin = new System.Windows.Forms.Padding(2);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(104, 32);
            this.tbTime.TabIndex = 48;
            this.tbTime.Text = "Time:30s";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(554, 323);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Server";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Server_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private UserControls.TextBoxElipse tbTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Question;
        private UserControls.ButtonElipse btnSend;
        private UserControls.TextBoxElipse tbCountDown;
        private System.Windows.Forms.Label label3;
    }
}