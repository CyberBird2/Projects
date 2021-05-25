namespace Week_1_Assignment_1._2._1_Car_App
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
            this.carComboBox = new System.Windows.Forms.ComboBox();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnRefuel = new System.Windows.Forms.Button();
            this.btnMaintenance = new System.Windows.Forms.Button();
            this.lbInfo = new System.Windows.Forms.ListBox();
            this.tbLitre = new System.Windows.Forms.TextBox();
            this.cbMaintenance = new System.Windows.Forms.CheckBox();
            this.lblLitre = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.tBDistance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // carComboBox
            // 
            this.carComboBox.FormattingEnabled = true;
            this.carComboBox.Location = new System.Drawing.Point(37, 40);
            this.carComboBox.Name = "carComboBox";
            this.carComboBox.Size = new System.Drawing.Size(128, 24);
            this.carComboBox.TabIndex = 0;
            this.carComboBox.SelectedIndexChanged += new System.EventHandler(this.carComboBox_SelectedIndexChanged);
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(25, 371);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(201, 45);
            this.btnSell.TabIndex = 1;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnRefuel
            // 
            this.btnRefuel.Location = new System.Drawing.Point(74, 245);
            this.btnRefuel.Name = "btnRefuel";
            this.btnRefuel.Size = new System.Drawing.Size(128, 59);
            this.btnRefuel.TabIndex = 2;
            this.btnRefuel.Text = "Refuel";
            this.btnRefuel.UseVisualStyleBackColor = true;
            this.btnRefuel.Click += new System.EventHandler(this.btnRefuel_Click);
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.Location = new System.Drawing.Point(37, 122);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(128, 46);
            this.btnMaintenance.TabIndex = 3;
            this.btnMaintenance.Text = "Maintenance";
            this.btnMaintenance.UseVisualStyleBackColor = true;
            this.btnMaintenance.Click += new System.EventHandler(this.btnMaintenance_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.FormattingEnabled = true;
            this.lbInfo.ItemHeight = 16;
            this.lbInfo.Location = new System.Drawing.Point(232, 12);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(560, 404);
            this.lbInfo.TabIndex = 4;
            // 
            // tbLitre
            // 
            this.tbLitre.Location = new System.Drawing.Point(74, 205);
            this.tbLitre.Name = "tbLitre";
            this.tbLitre.Size = new System.Drawing.Size(128, 22);
            this.tbLitre.TabIndex = 5;
            // 
            // cbMaintenance
            // 
            this.cbMaintenance.AutoSize = true;
            this.cbMaintenance.Location = new System.Drawing.Point(196, 138);
            this.cbMaintenance.Name = "cbMaintenance";
            this.cbMaintenance.Size = new System.Drawing.Size(18, 17);
            this.cbMaintenance.TabIndex = 6;
            this.cbMaintenance.UseVisualStyleBackColor = true;
            // 
            // lblLitre
            // 
            this.lblLitre.AutoSize = true;
            this.lblLitre.Location = new System.Drawing.Point(22, 210);
            this.lblLitre.Name = "lblLitre";
            this.lblLitre.Size = new System.Drawing.Size(36, 17);
            this.lblLitre.TabIndex = 8;
            this.lblLitre.Text = "Litre";
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(841, 322);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(141, 84);
            this.btnInfo.TabIndex = 9;
            this.btnInfo.Text = "Show Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sell Your Car";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Choose Car";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Send Your Car To Maintenance";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(841, 247);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(141, 55);
            this.btnStart.TabIndex = 13;
            this.btnStart.Text = "Start Engine";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tBDistance
            // 
            this.tBDistance.Location = new System.Drawing.Point(882, 205);
            this.tBDistance.Name = "tBDistance";
            this.tBDistance.Size = new System.Drawing.Size(100, 22);
            this.tBDistance.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(798, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Distance";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBDistance);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.lblLitre);
            this.Controls.Add(this.cbMaintenance);
            this.Controls.Add(this.tbLitre);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.btnMaintenance);
            this.Controls.Add(this.btnRefuel);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.carComboBox);
            this.Name = "Form1";
            this.Text = "Car Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox carComboBox;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnRefuel;
        private System.Windows.Forms.Button btnMaintenance;
        private System.Windows.Forms.ListBox lbInfo;
        private System.Windows.Forms.TextBox tbLitre;
        private System.Windows.Forms.CheckBox cbMaintenance;
        private System.Windows.Forms.Label lblLitre;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tBDistance;
        private System.Windows.Forms.Label label4;
    }
}

