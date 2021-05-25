namespace Week_3_Assignment_3._2._2_Crazy_Round
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
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbWhole = new System.Windows.Forms.RadioButton();
            this.rbTenth = new System.Windows.Forms.RadioButton();
            this.rbHundereth = new System.Windows.Forms.RadioButton();
            this.btnRound = new System.Windows.Forms.Button();
            this.lbShow = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(102, 26);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(100, 22);
            this.tbNumber.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number";
            // 
            // rbWhole
            // 
            this.rbWhole.AutoSize = true;
            this.rbWhole.Location = new System.Drawing.Point(102, 73);
            this.rbWhole.Name = "rbWhole";
            this.rbWhole.Size = new System.Drawing.Size(90, 21);
            this.rbWhole.TabIndex = 2;
            this.rbWhole.TabStop = true;
            this.rbWhole.Text = "To Whole";
            this.rbWhole.UseVisualStyleBackColor = true;
            // 
            // rbTenth
            // 
            this.rbTenth.AutoSize = true;
            this.rbTenth.Location = new System.Drawing.Point(102, 100);
            this.rbTenth.Name = "rbTenth";
            this.rbTenth.Size = new System.Drawing.Size(87, 21);
            this.rbTenth.TabIndex = 3;
            this.rbTenth.TabStop = true;
            this.rbTenth.Text = "To Tenth";
            this.rbTenth.UseVisualStyleBackColor = true;
            // 
            // rbHundereth
            // 
            this.rbHundereth.AutoSize = true;
            this.rbHundereth.Location = new System.Drawing.Point(102, 127);
            this.rbHundereth.Name = "rbHundereth";
            this.rbHundereth.Size = new System.Drawing.Size(122, 21);
            this.rbHundereth.TabIndex = 4;
            this.rbHundereth.TabStop = true;
            this.rbHundereth.Text = "To Hundererth";
            this.rbHundereth.UseVisualStyleBackColor = true;
            // 
            // btnRound
            // 
            this.btnRound.Location = new System.Drawing.Point(260, 20);
            this.btnRound.Name = "btnRound";
            this.btnRound.Size = new System.Drawing.Size(184, 128);
            this.btnRound.TabIndex = 5;
            this.btnRound.Text = "Round 10x";
            this.btnRound.UseVisualStyleBackColor = true;
            this.btnRound.Click += new System.EventHandler(this.btnRound_Click);
            // 
            // lbShow
            // 
            this.lbShow.FormattingEnabled = true;
            this.lbShow.ItemHeight = 16;
            this.lbShow.Location = new System.Drawing.Point(12, 178);
            this.lbShow.Name = "lbShow";
            this.lbShow.Size = new System.Drawing.Size(431, 260);
            this.lbShow.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 450);
            this.Controls.Add(this.lbShow);
            this.Controls.Add(this.btnRound);
            this.Controls.Add(this.rbHundereth);
            this.Controls.Add(this.rbTenth);
            this.Controls.Add(this.rbWhole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNumber);
            this.Name = "Form1";
            this.Text = "Crazy Rounder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbWhole;
        private System.Windows.Forms.RadioButton rbTenth;
        private System.Windows.Forms.RadioButton rbHundereth;
        private System.Windows.Forms.Button btnRound;
        private System.Windows.Forms.ListBox lbShow;
    }
}

