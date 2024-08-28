
namespace FinalProject
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.playerVplayer = new System.Windows.Forms.Button();
            this.upload = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.howToPlay = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnBot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // playerVplayer
            // 
            this.playerVplayer.Location = new System.Drawing.Point(392, 319);
            this.playerVplayer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.playerVplayer.Name = "playerVplayer";
            this.playerVplayer.Size = new System.Drawing.Size(173, 44);
            this.playerVplayer.TabIndex = 0;
            this.playerVplayer.Text = "PLAYER vs PLAYER";
            this.playerVplayer.UseVisualStyleBackColor = true;
            this.playerVplayer.Click += new System.EventHandler(this.playerVplayer_Click);
            // 
            // upload
            // 
            this.upload.Location = new System.Drawing.Point(505, 251);
            this.upload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(173, 44);
            this.upload.TabIndex = 0;
            this.upload.Text = "UPLOAD GAME";
            this.upload.UseVisualStyleBackColor = true;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, -19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(415, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(27, 151);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(341, 273);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // howToPlay
            // 
            this.howToPlay.Location = new System.Drawing.Point(505, 27);
            this.howToPlay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.howToPlay.Name = "howToPlay";
            this.howToPlay.Size = new System.Drawing.Size(173, 44);
            this.howToPlay.TabIndex = 0;
            this.howToPlay.Text = "HOW TO PLAYT";
            this.howToPlay.UseVisualStyleBackColor = true;
            this.howToPlay.Click += new System.EventHandler(this.howToPlay_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnBot
            // 
            this.btnBot.Location = new System.Drawing.Point(618, 319);
            this.btnBot.Margin = new System.Windows.Forms.Padding(2);
            this.btnBot.Name = "btnBot";
            this.btnBot.Size = new System.Drawing.Size(173, 44);
            this.btnBot.TabIndex = 2;
            this.btnBot.Text = "VS BOT";
            this.btnBot.UseVisualStyleBackColor = true;
            this.btnBot.Click += new System.EventHandler(this.btnBot_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 432);
            this.Controls.Add(this.btnBot);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.playerVplayer);
            this.Controls.Add(this.howToPlay);
            this.Controls.Add(this.upload);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playerVplayer;
        private System.Windows.Forms.Button upload;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button howToPlay;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnBot;
    }
}