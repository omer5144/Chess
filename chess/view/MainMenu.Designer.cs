namespace chess.view
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.name = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.Play = new System.Windows.Forms.Button();
            this.background = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Black;
            this.name.Font = new System.Drawing.Font("Impact", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(71, 319);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(175, 23);
            this.name.TabIndex = 11;
            this.name.Text = "*made by Omer Asher";
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(107, 209);
            this.logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(66, 60);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 10;
            this.logo.TabStop = false;
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.DarkRed;
            this.Close.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.Location = new System.Drawing.Point(544, 78);
            this.Close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(66, 60);
            this.Close.TabIndex = 9;
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
            this.title.Location = new System.Drawing.Point(-25, 24);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(581, 149);
            this.title.TabIndex = 8;
            this.title.Text = "2p chess";
            // 
            // Play
            // 
            this.Play.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Play.BackgroundImage")));
            this.Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Play.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play.ForeColor = System.Drawing.Color.White;
            this.Play.Location = new System.Drawing.Point(300, 209);
            this.Play.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(309, 132);
            this.Play.TabIndex = 6;
            this.Play.Text = "play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.Black;
            this.background.Location = new System.Drawing.Point(-39, 10);
            this.background.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(856, 431);
            this.background.TabIndex = 7;
            this.background.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(904, 450);
            this.Controls.Add(this.name);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.title);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.PictureBox logo;
        private new System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.PictureBox background;
    }
}