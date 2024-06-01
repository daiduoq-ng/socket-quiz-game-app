namespace NT106
{
    partial class Form_Event
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
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbEvent3 = new System.Windows.Forms.Label();
            this.lbEvent2 = new System.Windows.Forms.Label();
            this.lbEvent1 = new System.Windows.Forms.Label();
            this.textBoxElipse1 = new NT106.UserControls.TextBoxElipse();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.Location = new System.Drawing.Point(156, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sự Kiện Đang Diễn Ra";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::NT106.Properties.Resources._event;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(45, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 57);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lbEvent3
            // 
            this.lbEvent3.AutoSize = true;
            this.lbEvent3.BackColor = System.Drawing.Color.MintCream;
            this.lbEvent3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbEvent3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbEvent3.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold);
            this.lbEvent3.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbEvent3.Location = new System.Drawing.Point(123, 266);
            this.lbEvent3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEvent3.Name = "lbEvent3";
            this.lbEvent3.Size = new System.Drawing.Size(2, 29);
            this.lbEvent3.TabIndex = 11;
            this.lbEvent3.Click += new System.EventHandler(this.lbEvent1_Click);
            // 
            // lbEvent2
            // 
            this.lbEvent2.AutoSize = true;
            this.lbEvent2.BackColor = System.Drawing.Color.MintCream;
            this.lbEvent2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbEvent2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbEvent2.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold);
            this.lbEvent2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbEvent2.Location = new System.Drawing.Point(123, 184);
            this.lbEvent2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEvent2.Name = "lbEvent2";
            this.lbEvent2.Size = new System.Drawing.Size(2, 29);
            this.lbEvent2.TabIndex = 10;
            this.lbEvent2.Click += new System.EventHandler(this.lbEvent1_Click);
            // 
            // lbEvent1
            // 
            this.lbEvent1.AutoSize = true;
            this.lbEvent1.BackColor = System.Drawing.Color.MintCream;
            this.lbEvent1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbEvent1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbEvent1.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold);
            this.lbEvent1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbEvent1.Location = new System.Drawing.Point(123, 222);
            this.lbEvent1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEvent1.Name = "lbEvent1";
            this.lbEvent1.Size = new System.Drawing.Size(381, 29);
            this.lbEvent1.TabIndex = 9;
            this.lbEvent1.Text = "Cuộc thi đã bắt đầu- Click để tham gia";
            this.lbEvent1.Click += new System.EventHandler(this.lbEvent1_Click);
            // 
            // textBoxElipse1
            // 
            this.textBoxElipse1.BackColor = System.Drawing.Color.Transparent;
            this.textBoxElipse1.Br = System.Drawing.Color.MediumSeaGreen;
            this.textBoxElipse1.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.textBoxElipse1.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxElipse1.Location = new System.Drawing.Point(80, 120);
            this.textBoxElipse1.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxElipse1.Name = "textBoxElipse1";
            this.textBoxElipse1.Size = new System.Drawing.Size(485, 207);
            this.textBoxElipse1.TabIndex = 12;
            // 
            // Form_Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(622, 379);
            this.Controls.Add(this.lbEvent3);
            this.Controls.Add(this.lbEvent2);
            this.Controls.Add(this.lbEvent1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxElipse1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Event";
            this.Text = "Form_Event";
            this.Load += new System.EventHandler(this.Form_Event_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbEvent3;
        private System.Windows.Forms.Label lbEvent2;
        private UserControls.TextBoxElipse textBoxElipse1;
        private System.Windows.Forms.Label lbEvent1;
    }
}