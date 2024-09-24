
namespace FinalProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnX = new System.Windows.Forms.Button();
            this.labelP1Name = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.score_label1 = new System.Windows.Forms.Label();
            this.labelP2Name = new System.Windows.Forms.Label();
            this.score_label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.Red;
            this.btnX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnX.Location = new System.Drawing.Point(1220, 15);
            this.btnX.Margin = new System.Windows.Forms.Padding(6);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(55, 55);
            this.btnX.TabIndex = 0;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // labelP1Name
            // 
            this.labelP1Name.AutoEllipsis = true;
            this.labelP1Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelP1Name.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelP1Name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelP1Name.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP1Name.ForeColor = System.Drawing.Color.Black;
            this.labelP1Name.Location = new System.Drawing.Point(60, 87);
            this.labelP1Name.Name = "labelP1Name";
            this.labelP1Name.Size = new System.Drawing.Size(150, 150);
            this.labelP1Name.TabIndex = 1;
            this.labelP1Name.Text = "Player 1\'s turn";
            this.labelP1Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(15, 589);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 92);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_saveBoard);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Gray;
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnLoad.Location = new System.Drawing.Point(156, 589);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(6);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(90, 92);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // score_label1
            // 
            this.score_label1.AutoEllipsis = true;
            this.score_label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.score_label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.score_label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.score_label1.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_label1.ForeColor = System.Drawing.Color.Black;
            this.score_label1.Location = new System.Drawing.Point(60, 265);
            this.score_label1.Name = "score_label1";
            this.score_label1.Size = new System.Drawing.Size(150, 150);
            this.score_label1.TabIndex = 1;
            this.score_label1.Text = "score:";
            this.score_label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelP2Name
            // 
            this.labelP2Name.AutoEllipsis = true;
            this.labelP2Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelP2Name.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelP2Name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelP2Name.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP2Name.ForeColor = System.Drawing.Color.Black;
            this.labelP2Name.Location = new System.Drawing.Point(1008, 87);
            this.labelP2Name.Name = "labelP2Name";
            this.labelP2Name.Size = new System.Drawing.Size(150, 150);
            this.labelP2Name.TabIndex = 4;
            this.labelP2Name.Text = "Player 2\'s turn";
            this.labelP2Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // score_label2
            // 
            this.score_label2.AutoEllipsis = true;
            this.score_label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.score_label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.score_label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.score_label2.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_label2.ForeColor = System.Drawing.Color.Black;
            this.score_label2.Location = new System.Drawing.Point(1008, 265);
            this.score_label2.Name = "score_label2";
            this.score_label2.Size = new System.Drawing.Size(150, 150);
            this.score_label2.TabIndex = 5;
            this.score_label2.Text = "score:";
            this.score_label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1326, 863);
            this.ControlBox = false;
            this.Controls.Add(this.score_label2);
            this.Controls.Add(this.labelP2Name);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.score_label1);
            this.Controls.Add(this.labelP1Name);
            this.Controls.Add(this.btnX);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reversi";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Label labelP1Name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label score_label1;
        private System.Windows.Forms.Label labelP2Name;
        private System.Windows.Forms.Label score_label2;
    }
}

