namespace Week_3_Assignment_3._2._5_Project2
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
            this.tBStudentNumber = new System.Windows.Forms.TextBox();
            this.tBStudentName = new System.Windows.Forms.TextBox();
            this.tBProjectGroupName = new System.Windows.Forms.TextBox();
            this.btnAddStudentToProjectGroups = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbStudents = new System.Windows.Forms.ListBox();
            this.lbGroups = new System.Windows.Forms.ListBox();
            this.lbStudensAndTheirGroups = new System.Windows.Forms.ListBox();
            this.ShowStudents = new System.Windows.Forms.Button();
            this.ShowGroups = new System.Windows.Forms.Button();
            this.ShowStudentAndTheirGroups = new System.Windows.Forms.Button();
            this.SearchStudentByStudentNumber = new System.Windows.Forms.TextBox();
            this.tbSearchStudenByGroup = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tBStudentNumber
            // 
            this.tBStudentNumber.Location = new System.Drawing.Point(155, 102);
            this.tBStudentNumber.Name = "tBStudentNumber";
            this.tBStudentNumber.Size = new System.Drawing.Size(100, 22);
            this.tBStudentNumber.TabIndex = 0;
            // 
            // tBStudentName
            // 
            this.tBStudentName.Location = new System.Drawing.Point(155, 74);
            this.tBStudentName.Name = "tBStudentName";
            this.tBStudentName.Size = new System.Drawing.Size(100, 22);
            this.tBStudentName.TabIndex = 1;
            // 
            // tBProjectGroupName
            // 
            this.tBProjectGroupName.Location = new System.Drawing.Point(155, 133);
            this.tBProjectGroupName.Name = "tBProjectGroupName";
            this.tBProjectGroupName.Size = new System.Drawing.Size(100, 22);
            this.tBProjectGroupName.TabIndex = 2;
            // 
            // btnAddStudentToProjectGroups
            // 
            this.btnAddStudentToProjectGroups.Location = new System.Drawing.Point(12, 182);
            this.btnAddStudentToProjectGroups.Name = "btnAddStudentToProjectGroups";
            this.btnAddStudentToProjectGroups.Size = new System.Drawing.Size(243, 45);
            this.btnAddStudentToProjectGroups.TabIndex = 3;
            this.btnAddStudentToProjectGroups.Text = "Add Student ";
            this.btnAddStudentToProjectGroups.UseVisualStyleBackColor = true;
            this.btnAddStudentToProjectGroups.Click += new System.EventHandler(this.btnAddStudentToProjectGroups_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Student Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Student Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Project Group Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Add Student To Project Group";
            // 
            // lbStudents
            // 
            this.lbStudents.FormattingEnabled = true;
            this.lbStudents.ItemHeight = 16;
            this.lbStudents.Location = new System.Drawing.Point(582, 26);
            this.lbStudents.Name = "lbStudents";
            this.lbStudents.Size = new System.Drawing.Size(183, 180);
            this.lbStudents.TabIndex = 8;
            // 
            // lbGroups
            // 
            this.lbGroups.FormattingEnabled = true;
            this.lbGroups.ItemHeight = 16;
            this.lbGroups.Location = new System.Drawing.Point(582, 219);
            this.lbGroups.Name = "lbGroups";
            this.lbGroups.Size = new System.Drawing.Size(183, 212);
            this.lbGroups.TabIndex = 9;
            // 
            // lbStudensAndTheirGroups
            // 
            this.lbStudensAndTheirGroups.FormattingEnabled = true;
            this.lbStudensAndTheirGroups.ItemHeight = 16;
            this.lbStudensAndTheirGroups.Location = new System.Drawing.Point(315, 27);
            this.lbStudensAndTheirGroups.Name = "lbStudensAndTheirGroups";
            this.lbStudensAndTheirGroups.Size = new System.Drawing.Size(250, 404);
            this.lbStudensAndTheirGroups.TabIndex = 10;
            // 
            // ShowStudents
            // 
            this.ShowStudents.Location = new System.Drawing.Point(12, 415);
            this.ShowStudents.Name = "ShowStudents";
            this.ShowStudents.Size = new System.Drawing.Size(240, 23);
            this.ShowStudents.TabIndex = 11;
            this.ShowStudents.Text = "Show Students";
            this.ShowStudents.UseVisualStyleBackColor = true;
            // 
            // ShowGroups
            // 
            this.ShowGroups.Location = new System.Drawing.Point(15, 347);
            this.ShowGroups.Name = "ShowGroups";
            this.ShowGroups.Size = new System.Drawing.Size(237, 23);
            this.ShowGroups.TabIndex = 12;
            this.ShowGroups.Text = "Show Groups";
            this.ShowGroups.UseVisualStyleBackColor = true;
            // 
            // ShowStudentAndTheirGroups
            // 
            this.ShowStudentAndTheirGroups.Location = new System.Drawing.Point(12, 245);
            this.ShowStudentAndTheirGroups.Name = "ShowStudentAndTheirGroups";
            this.ShowStudentAndTheirGroups.Size = new System.Drawing.Size(243, 43);
            this.ShowStudentAndTheirGroups.TabIndex = 13;
            this.ShowStudentAndTheirGroups.Text = "Show Students And Their Groups";
            this.ShowStudentAndTheirGroups.UseVisualStyleBackColor = true;
            // 
            // SearchStudentByStudentNumber
            // 
            this.SearchStudentByStudentNumber.Location = new System.Drawing.Point(195, 376);
            this.SearchStudentByStudentNumber.Name = "SearchStudentByStudentNumber";
            this.SearchStudentByStudentNumber.Size = new System.Drawing.Size(100, 22);
            this.SearchStudentByStudentNumber.TabIndex = 14;
            // 
            // tbSearchStudenByGroup
            // 
            this.tbSearchStudenByGroup.Location = new System.Drawing.Point(188, 317);
            this.tbSearchStudenByGroup.Name = "tbSearchStudenByGroup";
            this.tbSearchStudenByGroup.Size = new System.Drawing.Size(100, 22);
            this.tbSearchStudenByGroup.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Search Student By Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Show Student By Group";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbSearchStudenByGroup);
            this.Controls.Add(this.SearchStudentByStudentNumber);
            this.Controls.Add(this.ShowStudentAndTheirGroups);
            this.Controls.Add(this.ShowGroups);
            this.Controls.Add(this.ShowStudents);
            this.Controls.Add(this.lbStudensAndTheirGroups);
            this.Controls.Add(this.lbGroups);
            this.Controls.Add(this.lbStudents);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddStudentToProjectGroups);
            this.Controls.Add(this.tBProjectGroupName);
            this.Controls.Add(this.tBStudentName);
            this.Controls.Add(this.tBStudentNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBStudentNumber;
        private System.Windows.Forms.TextBox tBStudentName;
        private System.Windows.Forms.TextBox tBProjectGroupName;
        private System.Windows.Forms.Button btnAddStudentToProjectGroups;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbStudents;
        private System.Windows.Forms.ListBox lbGroups;
        private System.Windows.Forms.ListBox lbStudensAndTheirGroups;
        private System.Windows.Forms.Button ShowStudents;
        private System.Windows.Forms.Button ShowGroups;
        private System.Windows.Forms.Button ShowStudentAndTheirGroups;
        private System.Windows.Forms.TextBox SearchStudentByStudentNumber;
        private System.Windows.Forms.TextBox tbSearchStudenByGroup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

