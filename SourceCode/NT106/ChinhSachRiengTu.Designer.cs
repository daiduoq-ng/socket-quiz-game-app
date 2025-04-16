namespace NT106
{
    partial class ChinhSachRiengTu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChinhSachRiengTu));
            this.btn_Exit = new NT106.UserControls.ButtonElipse();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.Active1 = System.Drawing.Color.DarkGreen;
            this.btn_Exit.Active2 = System.Drawing.Color.Black;
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Exit.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Exit.ForeColor = System.Drawing.Color.MintCream;
            this.btn_Exit.Inactive1 = System.Drawing.Color.MediumSeaGreen;
            this.btn_Exit.Inactive2 = System.Drawing.Color.MediumSeaGreen;
            this.btn_Exit.Location = new System.Drawing.Point(674, 479);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Radius = 10;
            this.btn_Exit.Size = new System.Drawing.Size(69, 24);
            this.btn_Exit.Stroke = false;
            this.btn_Exit.StrokeColor = System.Drawing.Color.Gray;
            this.btn_Exit.TabIndex = 53;
            this.btn_Exit.Text = "Đồng ý";
            this.btn_Exit.Transparency = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.MintCream;
            this.richTextBox1.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.richTextBox1.Location = new System.Drawing.Point(12, 64);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(777, 399);
            this.richTextBox1.TabIndex = 52;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Location = new System.Drawing.Point(278, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 27);
            this.label1.TabIndex = 51;
            this.label1.Text = "Chính Sách Riêng Tư";
            // 
            // ChinhSachRiengTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Name = "ChinhSachRiengTu";
            this.Text = "ChinhSachRiengTu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.ButtonElipse btn_Exit;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
    }
}