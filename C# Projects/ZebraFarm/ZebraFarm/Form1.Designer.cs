namespace ZebraFarm
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
												this.lbxZebras = new System.Windows.Forms.ListBox();
												this.btnShowZebras = new System.Windows.Forms.Button();
												this.btnShowZebra = new System.Windows.Forms.Button();
												this.btnAttemptBreeding = new System.Windows.Forms.Button();
												this.tbxMotherId = new System.Windows.Forms.TextBox();
												this.tbxFatherId = new System.Windows.Forms.TextBox();
												this.groupBox1 = new System.Windows.Forms.GroupBox();
												this.label2 = new System.Windows.Forms.Label();
												this.label1 = new System.Windows.Forms.Label();
												this.cbxZebraFilter = new System.Windows.Forms.ComboBox();
												this.tbxSearchZebra = new System.Windows.Forms.TextBox();
												this.groupBox1.SuspendLayout();
												this.SuspendLayout();
												// 
												// lbxZebras
												// 
												this.lbxZebras.FormattingEnabled = true;
												this.lbxZebras.Location = new System.Drawing.Point(220, 12);
												this.lbxZebras.Name = "lbxZebras";
												this.lbxZebras.Size = new System.Drawing.Size(398, 160);
												this.lbxZebras.TabIndex = 0;
												// 
												// btnShowZebras
												// 
												this.btnShowZebras.Location = new System.Drawing.Point(127, 12);
												this.btnShowZebras.Name = "btnShowZebras";
												this.btnShowZebras.Size = new System.Drawing.Size(85, 23);
												this.btnShowZebras.TabIndex = 1;
												this.btnShowZebras.Text = "Show zebras";
												this.btnShowZebras.UseVisualStyleBackColor = true;
												this.btnShowZebras.Click += new System.EventHandler(this.btnFilterZebras_Click);
												// 
												// btnShowZebra
												// 
												this.btnShowZebra.Location = new System.Drawing.Point(78, 149);
												this.btnShowZebra.Name = "btnShowZebra";
												this.btnShowZebra.Size = new System.Drawing.Size(134, 23);
												this.btnShowZebra.TabIndex = 2;
												this.btnShowZebra.Text = "Show zebra";
												this.btnShowZebra.UseVisualStyleBackColor = true;
												this.btnShowZebra.Click += new System.EventHandler(this.btnShowZebra_Click);
												// 
												// btnAttemptBreeding
												// 
												this.btnAttemptBreeding.Location = new System.Drawing.Point(9, 71);
												this.btnAttemptBreeding.Name = "btnAttemptBreeding";
												this.btnAttemptBreeding.Size = new System.Drawing.Size(179, 23);
												this.btnAttemptBreeding.TabIndex = 8;
												this.btnAttemptBreeding.Text = "Attempt to breed";
												this.btnAttemptBreeding.UseVisualStyleBackColor = true;
												this.btnAttemptBreeding.Click += new System.EventHandler(this.btnAttemptBreeding_Click);
												// 
												// tbxMotherId
												// 
												this.tbxMotherId.Location = new System.Drawing.Point(66, 19);
												this.tbxMotherId.Name = "tbxMotherId";
												this.tbxMotherId.Size = new System.Drawing.Size(122, 20);
												this.tbxMotherId.TabIndex = 9;
												// 
												// tbxFatherId
												// 
												this.tbxFatherId.Location = new System.Drawing.Point(66, 45);
												this.tbxFatherId.Name = "tbxFatherId";
												this.tbxFatherId.Size = new System.Drawing.Size(122, 20);
												this.tbxFatherId.TabIndex = 10;
												// 
												// groupBox1
												// 
												this.groupBox1.Controls.Add(this.label2);
												this.groupBox1.Controls.Add(this.btnAttemptBreeding);
												this.groupBox1.Controls.Add(this.label1);
												this.groupBox1.Controls.Add(this.tbxMotherId);
												this.groupBox1.Controls.Add(this.tbxFatherId);
												this.groupBox1.Location = new System.Drawing.Point(12, 41);
												this.groupBox1.Name = "groupBox1";
												this.groupBox1.Size = new System.Drawing.Size(200, 100);
												this.groupBox1.TabIndex = 11;
												this.groupBox1.TabStop = false;
												this.groupBox1.Text = "Breed zebra";
												// 
												// label2
												// 
												this.label2.AutoSize = true;
												this.label2.Location = new System.Drawing.Point(9, 48);
												this.label2.Name = "label2";
												this.label2.Size = new System.Drawing.Size(51, 13);
												this.label2.TabIndex = 12;
												this.label2.Text = "Father id:";
												// 
												// label1
												// 
												this.label1.AutoSize = true;
												this.label1.Location = new System.Drawing.Point(6, 22);
												this.label1.Name = "label1";
												this.label1.Size = new System.Drawing.Size(54, 13);
												this.label1.TabIndex = 11;
												this.label1.Text = "Mother id:";
												// 
												// cbxZebraFilter
												// 
												this.cbxZebraFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
												this.cbxZebraFilter.FormattingEnabled = true;
												this.cbxZebraFilter.Items.AddRange(new object[] {
            "All",
            "Only mares",
            "Only stallions",
            "Only unknown"});
												this.cbxZebraFilter.Location = new System.Drawing.Point(12, 12);
												this.cbxZebraFilter.Name = "cbxZebraFilter";
												this.cbxZebraFilter.Size = new System.Drawing.Size(109, 21);
												this.cbxZebraFilter.TabIndex = 12;
												this.cbxZebraFilter.SelectedIndexChanged += new System.EventHandler(this.btnFilterZebras_Click);
												// 
												// tbxSearchZebra
												// 
												this.tbxSearchZebra.Location = new System.Drawing.Point(12, 151);
												this.tbxSearchZebra.Name = "tbxSearchZebra";
												this.tbxSearchZebra.Size = new System.Drawing.Size(60, 20);
												this.tbxSearchZebra.TabIndex = 3;
												// 
												// Form1
												// 
												this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
												this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
												this.ClientSize = new System.Drawing.Size(632, 181);
												this.Controls.Add(this.cbxZebraFilter);
												this.Controls.Add(this.groupBox1);
												this.Controls.Add(this.tbxSearchZebra);
												this.Controls.Add(this.btnShowZebra);
												this.Controls.Add(this.btnShowZebras);
												this.Controls.Add(this.lbxZebras);
												this.Name = "Form1";
												this.Text = "Form1";
												this.groupBox1.ResumeLayout(false);
												this.groupBox1.PerformLayout();
												this.ResumeLayout(false);
												this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxZebras;
        private System.Windows.Forms.Button btnShowZebras;
        private System.Windows.Forms.Button btnShowZebra;
        private System.Windows.Forms.Button btnAttemptBreeding;
        private System.Windows.Forms.TextBox tbxMotherId;
        private System.Windows.Forms.TextBox tbxFatherId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxZebraFilter;
        private System.Windows.Forms.TextBox tbxSearchZebra;
    }
}

