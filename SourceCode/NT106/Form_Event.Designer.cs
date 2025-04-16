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
            this.lbEvent1 = new System.Windows.Forms.Label();
            this.textBoxElipse1 = new NT106.UserControls.TextBoxElipse();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.Location = new System.Drawing.Point(261, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sự Kiện Đang Diễn Ra";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::NT106.Properties.Resources._event;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(378, 36);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 70);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lbEvent1
            // 
            this.lbEvent1.AutoSize = true;
            this.lbEvent1.BackColor = System.Drawing.Color.MintCream;
            this.lbEvent1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbEvent1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbEvent1.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold);
            this.lbEvent1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbEvent1.Location = new System.Drawing.Point(165, 256);
            this.lbEvent1.Name = "lbEvent1";
            this.lbEvent1.Size = new System.Drawing.Size(483, 37);
            this.lbEvent1.TabIndex = 9;
            this.lbEvent1.Text = "Cuộc thi đã bắt đầu- Click để tham gia";
            this.lbEvent1.Click += new System.EventHandler(this.lbEvent1_Click);
            // 
            // textBoxElipse1
            // 
            this.textBoxElipse1.BackColor = System.Drawing.Color.Transparent;
            this.textBoxElipse1.Br = System.Drawing.Color.MediumSeaGreen;
            this.textBoxElipse1.Enabled = false;
            this.textBoxElipse1.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.textBoxElipse1.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxElipse1.Location = new System.Drawing.Point(126, 218);
            this.textBoxElipse1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxElipse1.Name = "textBoxElipse1";
            this.textBoxElipse1.Size = new System.Drawing.Size(647, 110);
            this.textBoxElipse1.TabIndex = 12;
            // 
            // Form_Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.BackgroundImage = global::NT106.Properties.Resources.bg3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(847, 514);
            this.Controls.Add(this.lbEvent1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxElipse1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Event";
            this.Text = "Form_Event";
           
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UserControls.TextBoxElipse textBoxElipse1;
        private System.Windows.Forms.Label lbEvent1;
    }
}