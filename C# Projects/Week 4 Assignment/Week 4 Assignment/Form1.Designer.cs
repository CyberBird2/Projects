namespace Week_4_Assignment
{
    partial class SimpleCalculator
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
            this.InfoText = new System.Windows.Forms.RichTextBox();
            this.number1textbx = new System.Windows.Forms.TextBox();
            this.number2textbx = new System.Windows.Forms.TextBox();
            this.Number1lbl = new System.Windows.Forms.Label();
            this.Number2lbl = new System.Windows.Forms.Label();
            this.Sumbtn = new System.Windows.Forms.Button();
            this.Substractingbtn = new System.Windows.Forms.Button();
            this.multibtn = new System.Windows.Forms.Button();
            this.Divisionbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InfoText
            // 
            this.InfoText.Location = new System.Drawing.Point(282, 12);
            this.InfoText.Name = "InfoText";
            this.InfoText.Size = new System.Drawing.Size(312, 238);
            this.InfoText.TabIndex = 0;
            this.InfoText.Text = "";
            this.InfoText.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // number1textbx
            // 
            this.number1textbx.Location = new System.Drawing.Point(84, 33);
            this.number1textbx.Name = "number1textbx";
            this.number1textbx.Size = new System.Drawing.Size(100, 22);
            this.number1textbx.TabIndex = 1;
            // 
            // number2textbx
            // 
            this.number2textbx.Location = new System.Drawing.Point(84, 108);
            this.number2textbx.Name = "number2textbx";
            this.number2textbx.Size = new System.Drawing.Size(100, 22);
            this.number2textbx.TabIndex = 2;
            // 
            // Number1lbl
            // 
            this.Number1lbl.AutoSize = true;
            this.Number1lbl.Location = new System.Drawing.Point(8, 33);
            this.Number1lbl.Name = "Number1lbl";
            this.Number1lbl.Size = new System.Drawing.Size(70, 17);
            this.Number1lbl.TabIndex = 3;
            this.Number1lbl.Text = "Number 1";
            // 
            // Number2lbl
            // 
            this.Number2lbl.AutoSize = true;
            this.Number2lbl.Location = new System.Drawing.Point(12, 108);
            this.Number2lbl.Name = "Number2lbl";
            this.Number2lbl.Size = new System.Drawing.Size(66, 17);
            this.Number2lbl.TabIndex = 4;
            this.Number2lbl.Text = "Number2";
            // 
            // Sumbtn
            // 
            this.Sumbtn.Location = new System.Drawing.Point(2, 164);
            this.Sumbtn.Name = "Sumbtn";
            this.Sumbtn.Size = new System.Drawing.Size(52, 45);
            this.Sumbtn.TabIndex = 5;
            this.Sumbtn.Text = "+";
            this.Sumbtn.UseVisualStyleBackColor = true;
            this.Sumbtn.Click += new System.EventHandler(this.Sumbtn_Click);
            // 
            // Substractingbtn
            // 
            this.Substractingbtn.Location = new System.Drawing.Point(60, 164);
            this.Substractingbtn.Name = "Substractingbtn";
            this.Substractingbtn.Size = new System.Drawing.Size(54, 45);
            this.Substractingbtn.TabIndex = 6;
            this.Substractingbtn.Text = "-";
            this.Substractingbtn.UseVisualStyleBackColor = true;
            this.Substractingbtn.Click += new System.EventHandler(this.Substractingbtn_Click);
            // 
            // multibtn
            // 
            this.multibtn.Location = new System.Drawing.Point(184, 164);
            this.multibtn.Name = "multibtn";
            this.multibtn.Size = new System.Drawing.Size(57, 45);
            this.multibtn.TabIndex = 7;
            this.multibtn.Text = "*";
            this.multibtn.UseVisualStyleBackColor = true;
            this.multibtn.Click += new System.EventHandler(this.multibtn_Click);
            // 
            // Divisionbtn
            // 
            this.Divisionbtn.Location = new System.Drawing.Point(120, 164);
            this.Divisionbtn.Name = "Divisionbtn";
            this.Divisionbtn.Size = new System.Drawing.Size(58, 45);
            this.Divisionbtn.TabIndex = 8;
            this.Divisionbtn.Text = "/";
            this.Divisionbtn.UseVisualStyleBackColor = true;
            this.Divisionbtn.Click += new System.EventHandler(this.Divisionbtn_Click);
            // 
            // SimpleCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 260);
            this.Controls.Add(this.Divisionbtn);
            this.Controls.Add(this.multibtn);
            this.Controls.Add(this.Substractingbtn);
            this.Controls.Add(this.Sumbtn);
            this.Controls.Add(this.Number2lbl);
            this.Controls.Add(this.Number1lbl);
            this.Controls.Add(this.number2textbx);
            this.Controls.Add(this.number1textbx);
            this.Controls.Add(this.InfoText);
            this.Name = "SimpleCalculator";
            this.Text = "SimpleCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox InfoText;
        private System.Windows.Forms.TextBox number1textbx;
        private System.Windows.Forms.TextBox number2textbx;
        private System.Windows.Forms.Label Number1lbl;
        private System.Windows.Forms.Label Number2lbl;
        private System.Windows.Forms.Button Sumbtn;
        private System.Windows.Forms.Button Substractingbtn;
        private System.Windows.Forms.Button multibtn;
        private System.Windows.Forms.Button Divisionbtn;
    }
}

