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
            this.lbID = new System.Windows.Forms.Label();
            this.lbRank = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.lbDoiAvt.Location = new System.Drawing.Point(219, 159);
            this.lbDoiAvt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDoiAvt.Name = "lbDoiAvt";
            this.lbDoiAvt.Size = new System.Drawing.Size(146, 17);
            this.lbDoiAvt.TabIndex = 1;
            this.lbDoiAvt.Text = "Thay đổi ảnh đại diện";
            this.lbDoiAvt.Click += new System.EventHandler(this.lbDoiAvt_Click);
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold);
            this.lbHoTen.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbHoTen.Location = new System.Drawing.Point(230, 215);
            this.lbHoTen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(143, 27);
            this.lbHoTen.TabIndex = 2;
            this.lbHoTen.Text = "Nguyen Van A";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbID.Location = new System.Drawing.Point(179, 242);
            this.lbID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(0, 19);
            this.lbID.TabIndex = 3;
            // 
            // lbRank
            // 
            this.lbRank.AutoSize = true;
            this.lbRank.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRank.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbRank.Location = new System.Drawing.Point(295, 242);
            this.lbRank.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRank.Name = "lbRank";
            this.lbRank.Size = new System.Drawing.Size(0, 19);
            this.lbRank.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label5.Location = new System.Drawing.Point(276, 242);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 19);
            this.label5.TabIndex = 5;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbEmail.Location = new System.Drawing.Point(218, 267);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(169, 19);
            this.lbEmail.TabIndex = 8;
            this.lbEmail.Text = "nguyenvana@gmail.com";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::NT106.Properties.Resources.mail;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(164, 263);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 26);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pbAvt
            // 
            this.pbAvt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbAvt.Location = new System.Drawing.Point(235, 40);
            this.pbAvt.Margin = new System.Windows.Forms.Padding(2);
            this.pbAvt.Name = "pbAvt";
            this.pbAvt.Size = new System.Drawing.Size(121, 108);
            this.pbAvt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvt.TabIndex = 0;
            this.pbAvt.TabStop = false;
            // 
            // Form_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(622, 379);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbRank);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.lbHoTen);
            this.Controls.Add(this.lbDoiAvt);
            this.Controls.Add(this.pbAvt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Account";
            this.Text = "Form_Account";
            this.Load += new System.EventHandler(this.Form_Account_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbDoiAvt;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbRank;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.PictureBox pbAvt;
    }
}