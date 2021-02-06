namespace chess.view
{
    partial class Error
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Error));
            this.Close = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.background = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.DarkRed;
            this.Close.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.Location = new System.Drawing.Point(495, 22);
            this.Close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(66, 60);
            this.Close.TabIndex = 12;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Black;
            this.title.Font = new System.Drawing.Font("Showcard Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(25, 31);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(464, 149);
            this.title.TabIndex = 11;
            this.title.Text = "ERROR";
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.Black;
            this.background.Location = new System.Drawing.Point(12, 11);
            this.background.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(560, 193);
            this.background.TabIndex = 10;
            this.background.TabStop = false;
            // 
            // Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(584, 218);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.title);
            this.Controls.Add(this.background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Error";
            this.Text = "Error";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Error_FormClosed);
            this.Load += new System.EventHandler(this.Error_Load);
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox background;
    }
}