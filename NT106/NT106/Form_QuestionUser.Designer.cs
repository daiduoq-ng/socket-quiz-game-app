namespace NT106
{
    partial class Form_QuestionUser
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
            this.components = new System.ComponentModel.Container();
            this.realTime = new System.Windows.Forms.Timer(this.components);
            this.cb0 = new System.Windows.Forms.CheckBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.cb2x = new System.Windows.Forms.CheckBox();
            this.cb75 = new System.Windows.Forms.CheckBox();
            this.cb50 = new System.Windows.Forms.CheckBox();
            this.cb25 = new System.Windows.Forms.CheckBox();
            this.lbD = new System.Windows.Forms.Label();
            this.lbB = new System.Windows.Forms.Label();
            this.lbC = new System.Windows.Forms.Label();
            this.lbA = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRealTime = new NT106.UserControls.TextBoxElipse();
            this.tbTime = new NT106.UserControls.TextBoxElipse();
            this.textBoxElipse5 = new NT106.UserControls.TextBoxElipse();
            this.tbD = new NT106.UserControls.TextBoxElipse();
            this.tbC = new NT106.UserControls.TextBoxElipse();
            this.tbA = new NT106.UserControls.TextBoxElipse();
            this.tbB = new NT106.UserControls.TextBoxElipse();
            this.SuspendLayout();
            // 
            // realTime
            // 
            this.realTime.Interval = 1000;
            // 
            // cb0
            // 
            this.cb0.AutoSize = true;
            this.cb0.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.cb0.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.cb0.Location = new System.Drawing.Point(135, 265);
            this.cb0.Name = "cb0";
            this.cb0.Size = new System.Drawing.Size(59, 29);
            this.cb0.TabIndex = 53;
            this.cb0.Text = "0%";
            this.cb0.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cb2x
            // 
            this.cb2x.AutoSize = true;
            this.cb2x.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.cb2x.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.cb2x.Location = new System.Drawing.Point(525, 265);
            this.cb2x.Name = "cb2x";
            this.cb2x.Size = new System.Drawing.Size(54, 29);
            this.cb2x.TabIndex = 51;
            this.cb2x.Text = "2x";
            this.cb2x.UseVisualStyleBackColor = true;
            // 
            // cb75
            // 
            this.cb75.AutoSize = true;
            this.cb75.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.cb75.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.cb75.Location = new System.Drawing.Point(425, 265);
            this.cb75.Name = "cb75";
            this.cb75.Size = new System.Drawing.Size(69, 29);
            this.cb75.TabIndex = 50;
            this.cb75.Text = "75%";
            this.cb75.UseVisualStyleBackColor = true;
            // 
            // cb50
            // 
            this.cb50.AutoSize = true;
            this.cb50.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.cb50.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.cb50.Location = new System.Drawing.Point(325, 265);
            this.cb50.Name = "cb50";
            this.cb50.Size = new System.Drawing.Size(69, 29);
            this.cb50.TabIndex = 49;
            this.cb50.Text = "50%";
            this.cb50.UseVisualStyleBackColor = true;
            // 
            // cb25
            // 
            this.cb25.AutoSize = true;
            this.cb25.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.cb25.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.cb25.Location = new System.Drawing.Point(225, 265);
            this.cb25.Name = "cb25";
            this.cb25.Size = new System.Drawing.Size(69, 29);
            this.cb25.TabIndex = 48;
            this.cb25.Text = "25%";
            this.cb25.UseVisualStyleBackColor = true;
            // 
            // lbD
            // 
            this.lbD.AutoSize = true;
            this.lbD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbD.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold);
            this.lbD.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbD.Location = new System.Drawing.Point(410, 428);
            this.lbD.Name = "lbD";
            this.lbD.Size = new System.Drawing.Size(30, 31);
            this.lbD.TabIndex = 45;
            this.lbD.Text = "D";
            this.lbD.Click += new System.EventHandler(this.lbD_Click);
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbB.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold);
            this.lbB.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbB.Location = new System.Drawing.Point(410, 343);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(28, 31);
            this.lbB.TabIndex = 44;
            this.lbB.Text = "B";
            this.lbB.Click += new System.EventHandler(this.lbB_Click);
            // 
            // lbC
            // 
            this.lbC.AutoSize = true;
            this.lbC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbC.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold);
            this.lbC.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbC.Location = new System.Drawing.Point(57, 428);
            this.lbC.Name = "lbC";
            this.lbC.Size = new System.Drawing.Size(28, 31);
            this.lbC.TabIndex = 43;
            this.lbC.Text = "C";
            this.lbC.Click += new System.EventHandler(this.lbC_Click);
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbA.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold);
            this.lbA.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbA.Location = new System.Drawing.Point(57, 343);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(30, 31);
            this.lbA.TabIndex = 42;
            this.lbA.Text = "A";
            this.lbA.Click += new System.EventHandler(this.lbA_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.Location = new System.Drawing.Point(331, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 35);
            this.label2.TabIndex = 37;
            this.label2.Text = "ABCXYZ";
            // 
            // tbRealTime
            // 
            this.tbRealTime.BackColor = System.Drawing.Color.Transparent;
            this.tbRealTime.Br = System.Drawing.Color.White;
            this.tbRealTime.Enabled = false;
            this.tbRealTime.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.tbRealTime.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.tbRealTime.Location = new System.Drawing.Point(672, 72);
            this.tbRealTime.Name = "tbRealTime";
            this.tbRealTime.Size = new System.Drawing.Size(117, 35);
            this.tbRealTime.TabIndex = 52;
            this.tbRealTime.Text = "00:00:00";
            // 
            // tbTime
            // 
            this.tbTime.BackColor = System.Drawing.Color.Transparent;
            this.tbTime.Br = System.Drawing.Color.White;
            this.tbTime.Enabled = false;
            this.tbTime.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.tbTime.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.tbTime.Location = new System.Drawing.Point(601, 259);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(109, 35);
            this.tbTime.TabIndex = 47;
            this.tbTime.Text = "Time:30s";
            // 
            // textBoxElipse5
            // 
            this.textBoxElipse5.BackColor = System.Drawing.Color.Transparent;
            this.textBoxElipse5.Br = System.Drawing.Color.MediumSeaGreen;
            this.textBoxElipse5.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold);
            this.textBoxElipse5.ForeColor = System.Drawing.Color.MintCream;
            this.textBoxElipse5.Location = new System.Drawing.Point(135, 107);
            this.textBoxElipse5.Name = "textBoxElipse5";
            this.textBoxElipse5.Size = new System.Drawing.Size(520, 146);
            this.textBoxElipse5.TabIndex = 46;
            this.textBoxElipse5.Text = "Cái này là câu hỏi nè!";
            // 
            // tbD
            // 
            this.tbD.BackColor = System.Drawing.Color.Transparent;
            this.tbD.Br = System.Drawing.Color.White;
            this.tbD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbD.Enabled = false;
            this.tbD.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold);
            this.tbD.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.tbD.Location = new System.Drawing.Point(456, 412);
            this.tbD.Name = "tbD";
            this.tbD.Size = new System.Drawing.Size(250, 64);
            this.tbD.TabIndex = 41;
            this.tbD.Text = "textBoxElipse4";
            // 
            // tbC
            // 
            this.tbC.BackColor = System.Drawing.Color.Transparent;
            this.tbC.Br = System.Drawing.Color.White;
            this.tbC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbC.Enabled = false;
            this.tbC.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold);
            this.tbC.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.tbC.Location = new System.Drawing.Point(103, 412);
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(250, 64);
            this.tbC.TabIndex = 40;
            this.tbC.Text = "textBoxElipse3";
            // 
            // tbA
            // 
            this.tbA.BackColor = System.Drawing.Color.Transparent;
            this.tbA.Br = System.Drawing.Color.White;
            this.tbA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbA.Enabled = false;
            this.tbA.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold);
            this.tbA.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.tbA.Location = new System.Drawing.Point(103, 331);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(250, 64);
            this.tbA.TabIndex = 38;
            this.tbA.Text = "textBoxElipse1";
            // 
            // tbB
            // 
            this.tbB.BackColor = System.Drawing.Color.Transparent;
            this.tbB.Br = System.Drawing.Color.White;
            this.tbB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbB.Enabled = false;
            this.tbB.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Bold);
            this.tbB.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.tbB.Location = new System.Drawing.Point(456, 331);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(250, 64);
            this.tbB.TabIndex = 39;
            this.tbB.Text = "textBoxElipse2";
            // 
            // Form_QuestionUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(847, 522);
            this.Controls.Add(this.tbRealTime);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.textBoxElipse5);
            this.Controls.Add(this.tbD);
            this.Controls.Add(this.tbC);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.cb0);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.cb2x);
            this.Controls.Add(this.cb75);
            this.Controls.Add(this.cb50);
            this.Controls.Add(this.cb25);
            this.Controls.Add(this.lbD);
            this.Controls.Add(this.lbB);
            this.Controls.Add(this.lbC);
            this.Controls.Add(this.lbA);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_QuestionUser";
            this.Text = "Form_Event1";
            this.Load += new System.EventHandler(this.Form_QuestionUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.TextBoxElipse tbRealTime;
        private UserControls.TextBoxElipse tbTime;
        private UserControls.TextBoxElipse textBoxElipse5;
        private UserControls.TextBoxElipse tbD;
        private UserControls.TextBoxElipse tbC;
        private UserControls.TextBoxElipse tbA;
        private System.Windows.Forms.Timer realTime;
        private System.Windows.Forms.CheckBox cb0;
        private UserControls.TextBoxElipse tbB;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.CheckBox cb2x;
        private System.Windows.Forms.CheckBox cb75;
        private System.Windows.Forms.CheckBox cb50;
        private System.Windows.Forms.CheckBox cb25;
        private System.Windows.Forms.Label lbD;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.Label lbC;
        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.Label label2;
    }
}