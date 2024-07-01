
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
            this.vsBot = new System.Windows.Forms.Button();
            this.howToPlay = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.checkBoxHard = new System.Windows.Forms.CheckBox();
            this.checkBoxEasy = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // playerVplayer
            // 
            this.playerVplayer.Location = new System.Drawing.Point(588, 491);
            this.playerVplayer.Name = "playerVplayer";
            this.playerVplayer.Size = new System.Drawing.Size(260, 67);
            this.playerVplayer.TabIndex = 0;
            this.playerVplayer.Text = "1v1";
            this.playerVplayer.UseVisualStyleBackColor = true;
            this.playerVplayer.Click += new System.EventHandler(this.playerVplayer_Click);
            // 
            // upload
            // 
            this.upload.Location = new System.Drawing.Point(588, 383);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(260, 67);
            this.upload.TabIndex = 0;
            this.upload.Text = "upload game";
            this.upload.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, -29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(622, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(41, 232);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(511, 420);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // vsBot
            // 
            this.vsBot.Location = new System.Drawing.Point(957, 420);
            this.vsBot.Name = "vsBot";
            this.vsBot.Size = new System.Drawing.Size(260, 67);
            this.vsBot.TabIndex = 0;
            this.vsBot.Text = "vs Bot";
            this.vsBot.UseVisualStyleBackColor = true;
            this.vsBot.Click += new System.EventHandler(this.playerVbot_Click);
            // 
            // howToPlay
            // 
            this.howToPlay.Location = new System.Drawing.Point(758, 42);
            this.howToPlay.Name = "howToPlay";
            this.howToPlay.Size = new System.Drawing.Size(260, 67);
            this.howToPlay.TabIndex = 0;
            this.howToPlay.Text = "how to play";
            this.howToPlay.UseVisualStyleBackColor = true;
            this.howToPlay.Click += new System.EventHandler(this.howToPlay_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // checkBoxHard
            // 
            this.checkBoxHard.AutoSize = true;
            this.checkBoxHard.Location = new System.Drawing.Point(962, 526);
            this.checkBoxHard.Name = "checkBoxHard";
            this.checkBoxHard.Size = new System.Drawing.Size(70, 24);
            this.checkBoxHard.TabIndex = 3;
            this.checkBoxHard.Text = "Hard\r\n";
            this.checkBoxHard.UseVisualStyleBackColor = true;
            this.checkBoxHard.Click += new System.EventHandler(this.hardClick);
            // 
            // checkBoxEasy
            // 
            this.checkBoxEasy.AutoSize = true;
            this.checkBoxEasy.Location = new System.Drawing.Point(1132, 526);
            this.checkBoxEasy.Name = "checkBoxEasy";
            this.checkBoxEasy.Size = new System.Drawing.Size(70, 24);
            this.checkBoxEasy.TabIndex = 3;
            this.checkBoxEasy.Text = "Easy";
            this.checkBoxEasy.UseVisualStyleBackColor = true;
            this.checkBoxEasy.Click += new System.EventHandler(this.easyClick);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 664);
            this.Controls.Add(this.checkBoxEasy);
            this.Controls.Add(this.checkBoxHard);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.vsBot);
            this.Controls.Add(this.playerVplayer);
            this.Controls.Add(this.howToPlay);
            this.Controls.Add(this.upload);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playerVplayer;
        private System.Windows.Forms.Button upload;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button vsBot;
        private System.Windows.Forms.Button howToPlay;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.CheckBox checkBoxHard;
        private System.Windows.Forms.CheckBox checkBoxEasy;
    }
}