namespace Week_4._4_Sneez_Numbers
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
            this.tbinput = new System.Windows.Forms.TextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbinput
            // 
            this.tbinput.Location = new System.Drawing.Point(5, 12);
            this.tbinput.Name = "tbinput";
            this.tbinput.Size = new System.Drawing.Size(396, 22);
            this.tbinput.TabIndex = 0;
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(41, 40);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(317, 50);
            this.btnGet.TabIndex = 1;
            this.btnGet.Text = "Get sneez number at this positin";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 101);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.tbinput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbinput;
        private System.Windows.Forms.Button btnGet;
    }
}

