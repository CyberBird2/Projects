namespace Week_4._2_Marks_Analyzer
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
            this.tbname = new System.Windows.Forms.TextBox();
            this.tbstudentnumber = new System.Windows.Forms.TextBox();
            this.btncreatestudent = new System.Windows.Forms.Button();
            this.btnaddmark = new System.Windows.Forms.Button();
            this.btncalculateavg = new System.Windows.Forms.Button();
            this.tbnewmark = new System.Windows.Forms.TextBox();
            this.lbname = new System.Windows.Forms.Label();
            this.lbStudentnumber = new System.Windows.Forms.Label();
            this.nwmark = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbMarks = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.ListBox();
            this.lbaverageresult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(137, 22);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(100, 22);
            this.tbname.TabIndex = 0;
            // 
            // tbstudentnumber
            // 
            this.tbstudentnumber.Location = new System.Drawing.Point(137, 56);
            this.tbstudentnumber.Name = "tbstudentnumber";
            this.tbstudentnumber.Size = new System.Drawing.Size(100, 22);
            this.tbstudentnumber.TabIndex = 1;
            // 
            // btncreatestudent
            // 
            this.btncreatestudent.Location = new System.Drawing.Point(12, 87);
            this.btncreatestudent.Name = "btncreatestudent";
            this.btncreatestudent.Size = new System.Drawing.Size(246, 24);
            this.btncreatestudent.TabIndex = 2;
            this.btncreatestudent.Text = "Create Student";
            this.btncreatestudent.UseVisualStyleBackColor = true;
            this.btncreatestudent.Click += new System.EventHandler(this.btncreatestudent_Click);
            // 
            // btnaddmark
            // 
            this.btnaddmark.Location = new System.Drawing.Point(23, 159);
            this.btnaddmark.Name = "btnaddmark";
            this.btnaddmark.Size = new System.Drawing.Size(214, 23);
            this.btnaddmark.TabIndex = 3;
            this.btnaddmark.Text = "Add Mark";
            this.btnaddmark.UseVisualStyleBackColor = true;
            this.btnaddmark.Click += new System.EventHandler(this.btnaddmark_Click);
            // 
            // btncalculateavg
            // 
            this.btncalculateavg.Location = new System.Drawing.Point(55, 373);
            this.btncalculateavg.Name = "btncalculateavg";
            this.btncalculateavg.Size = new System.Drawing.Size(143, 34);
            this.btncalculateavg.TabIndex = 4;
            this.btncalculateavg.Text = "Calculate Average";
            this.btncalculateavg.UseVisualStyleBackColor = true;
            this.btncalculateavg.Click += new System.EventHandler(this.btncalculateavg_Click);
            // 
            // tbnewmark
            // 
            this.tbnewmark.Location = new System.Drawing.Point(137, 121);
            this.tbnewmark.Name = "tbnewmark";
            this.tbnewmark.Size = new System.Drawing.Size(100, 22);
            this.tbnewmark.TabIndex = 5;
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Location = new System.Drawing.Point(52, 22);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(45, 17);
            this.lbname.TabIndex = 6;
            this.lbname.Text = "Name";
            // 
            // lbStudentnumber
            // 
            this.lbStudentnumber.AutoSize = true;
            this.lbStudentnumber.Location = new System.Drawing.Point(12, 56);
            this.lbStudentnumber.Name = "lbStudentnumber";
            this.lbStudentnumber.Size = new System.Drawing.Size(111, 17);
            this.lbStudentnumber.TabIndex = 7;
            this.lbStudentnumber.Text = "Student Number";
            // 
            // nwmark
            // 
            this.nwmark.AutoSize = true;
            this.nwmark.Location = new System.Drawing.Point(27, 126);
            this.nwmark.Name = "nwmark";
            this.nwmark.Size = new System.Drawing.Size(70, 17);
            this.nwmark.TabIndex = 8;
            this.nwmark.Text = "New Mark";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Average mark is";
            // 
            // lbMarks
            // 
            this.lbMarks.AutoSize = true;
            this.lbMarks.Location = new System.Drawing.Point(36, 199);
            this.lbMarks.Name = "lbMarks";
            this.lbMarks.Size = new System.Drawing.Size(46, 17);
            this.lbMarks.TabIndex = 10;
            this.lbMarks.Text = "Marks";
            // 
            // lbResult
            // 
            this.lbResult.FormattingEnabled = true;
            this.lbResult.ItemHeight = 16;
            this.lbResult.Location = new System.Drawing.Point(30, 219);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(199, 148);
            this.lbResult.TabIndex = 11;
            // 
            // lbaverageresult
            // 
            this.lbaverageresult.AutoSize = true;
            this.lbaverageresult.Location = new System.Drawing.Point(167, 424);
            this.lbaverageresult.Name = "lbaverageresult";
            this.lbaverageresult.Size = new System.Drawing.Size(0, 17);
            this.lbaverageresult.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 450);
            this.Controls.Add(this.lbaverageresult);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lbMarks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nwmark);
            this.Controls.Add(this.lbStudentnumber);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.tbnewmark);
            this.Controls.Add(this.btncalculateavg);
            this.Controls.Add(this.btnaddmark);
            this.Controls.Add(this.btncreatestudent);
            this.Controls.Add(this.tbstudentnumber);
            this.Controls.Add(this.tbname);
            this.Name = "Form1";
            this.Text = "Marks";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.TextBox tbstudentnumber;
        private System.Windows.Forms.Button btncreatestudent;
        private System.Windows.Forms.Button btnaddmark;
        private System.Windows.Forms.Button btncalculateavg;
        private System.Windows.Forms.TextBox tbnewmark;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label lbStudentnumber;
        private System.Windows.Forms.Label nwmark;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbMarks;
        private System.Windows.Forms.ListBox lbResult;
        private System.Windows.Forms.Label lbaverageresult;
    }
}

