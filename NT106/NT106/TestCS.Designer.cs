namespace NT106
{
    partial class TestCS
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
            this.btnServer = new NT106.UserControls.ButtonElipse();
            this.btnClient = new NT106.UserControls.ButtonElipse();
            this.SuspendLayout();
            // 
            // btnServer
            // 
            this.btnServer.Active1 = System.Drawing.Color.DarkGreen;
            this.btnServer.Active2 = System.Drawing.Color.Black;
            this.btnServer.BackColor = System.Drawing.Color.Transparent;
            this.btnServer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnServer.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.btnServer.ForeColor = System.Drawing.Color.MintCream;
            this.btnServer.Inactive1 = System.Drawing.Color.MediumSeaGreen;
            this.btnServer.Inactive2 = System.Drawing.Color.MediumSeaGreen;
            this.btnServer.Location = new System.Drawing.Point(59, 62);
            this.btnServer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnServer.Name = "btnServer";
            this.btnServer.Radius = 10;
            this.btnServer.Size = new System.Drawing.Size(117, 44);
            this.btnServer.Stroke = false;
            this.btnServer.StrokeColor = System.Drawing.Color.Gray;
            this.btnServer.TabIndex = 30;
            this.btnServer.Text = "Server";
            this.btnServer.Transparency = false;
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // btnClient
            // 
            this.btnClient.Active1 = System.Drawing.Color.DarkGreen;
            this.btnClient.Active2 = System.Drawing.Color.Black;
            this.btnClient.BackColor = System.Drawing.Color.Transparent;
            this.btnClient.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnClient.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.btnClient.ForeColor = System.Drawing.Color.MintCream;
            this.btnClient.Inactive1 = System.Drawing.Color.MediumSeaGreen;
            this.btnClient.Inactive2 = System.Drawing.Color.MediumSeaGreen;
            this.btnClient.Location = new System.Drawing.Point(242, 62);
            this.btnClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClient.Name = "btnClient";
            this.btnClient.Radius = 10;
            this.btnClient.Size = new System.Drawing.Size(117, 44);
            this.btnClient.Stroke = false;
            this.btnClient.StrokeColor = System.Drawing.Color.Gray;
            this.btnClient.TabIndex = 31;
            this.btnClient.Text = "Client";
            this.btnClient.Transparency = false;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // TestCS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.BackgroundImage = global::NT106.Properties.Resources.Picture5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(416, 176);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.btnServer);
            this.DoubleBuffered = true;
            this.Name = "TestCS";
            this.Text = "TestCS";
            this.ResumeLayout(false);

        }

        #endregion
        private UserControls.ButtonElipse btnServer;
        private UserControls.ButtonElipse btnClient;
    }
}