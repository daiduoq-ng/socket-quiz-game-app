namespace NT106
{
    partial class Form_Account
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
            this.lbDoiAvt = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbAvt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvt)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDoiAvt
            // 
            this.lbDoiAvt.AutoSize = true;
            this.lbDoiAvt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbDoiAvt.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDoiAvt.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbDoiAvt.Location = new System.Drawing.Point(341, 258);
            this.lbDoiAvt.Name = "lbDoiAvt";
            this.lbDoiAvt.Size = new System.Drawing.Size(172, 20);
            this.lbDoiAvt.TabIndex = 1;
            this.lbDoiAvt.Text = "Thay đổi ảnh đại diện";
            this.lbDoiAvt.Click += new System.EventHandler(this.lbDoiAvt_Click);
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold);
            this.lbHoTen.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbHoTen.Location = new System.Drawing.Point(338, 305);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(179, 35);
            this.lbHoTen.TabIndex = 2;
            this.lbHoTen.Text = "Nguyen Van A";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbEmail.Location = new System.Drawing.Point(323, 340);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(209, 22);
            this.lbEmail.TabIndex = 8;
            this.lbEmail.Text = "nguyenvana@gmail.com";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::NT106.Properties.Resources.mail;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(284, 342);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 20);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pbAvt
            // 
            this.pbAvt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbAvt.Location = new System.Drawing.Point(347, 112);
            this.pbAvt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbAvt.Name = "pbAvt";
            this.pbAvt.Size = new System.Drawing.Size(161, 133);
            this.pbAvt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvt.TabIndex = 0;
            this.pbAvt.TabStop = false;
            // 
            // Form_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.BackgroundImage = global::NT106.Properties.Resources.bg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(847, 514);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbHoTen);
            this.Controls.Add(this.lbDoiAvt);
            this.Controls.Add(this.pbAvt);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Account";
            this.Text = "A";
            this.Load += new System.EventHandler(this.Form_Account_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbDoiAvt;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.PictureBox pbAvt;
    }
}