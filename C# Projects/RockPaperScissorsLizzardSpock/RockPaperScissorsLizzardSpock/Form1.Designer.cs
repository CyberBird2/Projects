namespace RockPaperScissorsLizzardSpock
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
            this.btnReset = new System.Windows.Forms.Button();
            this.lbResults = new System.Windows.Forms.ListBox();
            this.pbSpock = new System.Windows.Forms.PictureBox();
            this.pbPaper = new System.Windows.Forms.PictureBox();
            this.pbScissors = new System.Windows.Forms.PictureBox();
            this.pbLizzard = new System.Windows.Forms.PictureBox();
            this.pbRock = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLizzard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRock)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(16, 15);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 28);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // lbResults
            // 
            this.lbResults.FormattingEnabled = true;
            this.lbResults.ItemHeight = 16;
            this.lbResults.Location = new System.Drawing.Point(551, 15);
            this.lbResults.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(493, 484);
            this.lbResults.TabIndex = 12;
            // 
            // pbSpock
            // 
            this.pbSpock.Image = global::RockPaperScissorsLizzardSpock.Properties.Resources.FadedSpock;
            this.pbSpock.Location = new System.Drawing.Point(284, 341);
            this.pbSpock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbSpock.Name = "pbSpock";
            this.pbSpock.Size = new System.Drawing.Size(171, 158);
            this.pbSpock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSpock.TabIndex = 14;
            this.pbSpock.TabStop = false;
            // 
            // pbPaper
            // 
            this.pbPaper.Image = global::RockPaperScissorsLizzardSpock.Properties.Resources.Paper;
            this.pbPaper.Location = new System.Drawing.Point(195, 42);
            this.pbPaper.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbPaper.Name = "pbPaper";
            this.pbPaper.Size = new System.Drawing.Size(171, 158);
            this.pbPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPaper.TabIndex = 11;
            this.pbPaper.TabStop = false;
            this.pbPaper.Click += new System.EventHandler(this.pbPaper_Click);
            // 
            // pbScissors
            // 
            this.pbScissors.Image = global::RockPaperScissorsLizzardSpock.Properties.Resources.Scissors;
            this.pbScissors.Location = new System.Drawing.Point(373, 176);
            this.pbScissors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbScissors.Name = "pbScissors";
            this.pbScissors.Size = new System.Drawing.Size(171, 158);
            this.pbScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbScissors.TabIndex = 10;
            this.pbScissors.TabStop = false;
            this.pbScissors.Click += new System.EventHandler(this.pbScissors_Click);
            // 
            // pbLizzard
            // 
            this.pbLizzard.Enabled = false;
            this.pbLizzard.Image = global::RockPaperScissorsLizzardSpock.Properties.Resources.FadedLizzard;
            this.pbLizzard.Location = new System.Drawing.Point(105, 341);
            this.pbLizzard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbLizzard.Name = "pbLizzard";
            this.pbLizzard.Size = new System.Drawing.Size(171, 158);
            this.pbLizzard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLizzard.TabIndex = 9;
            this.pbLizzard.TabStop = false;
            // 
            // pbRock
            // 
            this.pbRock.Image = global::RockPaperScissorsLizzardSpock.Properties.Resources.Rock;
            this.pbRock.Location = new System.Drawing.Point(16, 176);
            this.pbRock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbRock.Name = "pbRock";
            this.pbRock.Size = new System.Drawing.Size(171, 158);
            this.pbRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRock.TabIndex = 8;
            this.pbRock.TabStop = false;
            this.pbRock.Click += new System.EventHandler(this.pbRock_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 615);
            this.Controls.Add(this.pbSpock);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lbResults);
            this.Controls.Add(this.pbPaper);
            this.Controls.Add(this.pbScissors);
            this.Controls.Add(this.pbLizzard);
            this.Controls.Add(this.pbRock);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Rock, Paper, Scissors, Lizzard?, Spock!";
            ((System.ComponentModel.ISupportInitialize)(this.pbSpock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLizzard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSpock;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ListBox lbResults;
        private System.Windows.Forms.PictureBox pbPaper;
        private System.Windows.Forms.PictureBox pbScissors;
        private System.Windows.Forms.PictureBox pbLizzard;
        private System.Windows.Forms.PictureBox pbRock;
    }
}

