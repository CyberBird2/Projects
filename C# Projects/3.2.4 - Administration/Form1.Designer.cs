namespace _3._2._4___Administration
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
												this.gbAddStudent = new System.Windows.Forms.GroupBox();
												this.btnAddStudent = new System.Windows.Forms.Button();
												this.nudStudentNumber = new System.Windows.Forms.NumericUpDown();
												this.lblStudentNumber = new System.Windows.Forms.Label();
												this.tbStudentName = new System.Windows.Forms.TextBox();
												this.lblStudentName = new System.Windows.Forms.Label();
												this.groupBox1 = new System.Windows.Forms.GroupBox();
												this.tbStudentSearch = new System.Windows.Forms.TextBox();
												this.btnStudentSearch = new System.Windows.Forms.Button();
												this.lbStudents = new System.Windows.Forms.ListBox();
												this.gbGroups = new System.Windows.Forms.GroupBox();
												this.lbGroups = new System.Windows.Forms.ListBox();
												this.gbGroupMembers = new System.Windows.Forms.GroupBox();
												this.tbSearchGroupM = new System.Windows.Forms.TextBox();
												this.btnSearchGroupM = new System.Windows.Forms.Button();
												this.lbGroupMembers = new System.Windows.Forms.ListBox();
												this.gbAddStudent.SuspendLayout();
												((System.ComponentModel.ISupportInitialize)(this.nudStudentNumber)).BeginInit();
												this.groupBox1.SuspendLayout();
												this.gbGroups.SuspendLayout();
												this.gbGroupMembers.SuspendLayout();
												this.SuspendLayout();
												// 
												// gbAddStudent
												// 
												this.gbAddStudent.Controls.Add(this.btnAddStudent);
												this.gbAddStudent.Controls.Add(this.nudStudentNumber);
												this.gbAddStudent.Controls.Add(this.lblStudentNumber);
												this.gbAddStudent.Controls.Add(this.tbStudentName);
												this.gbAddStudent.Controls.Add(this.lblStudentName);
												this.gbAddStudent.Location = new System.Drawing.Point(13, 13);
												this.gbAddStudent.Name = "gbAddStudent";
												this.gbAddStudent.Size = new System.Drawing.Size(161, 105);
												this.gbAddStudent.TabIndex = 0;
												this.gbAddStudent.TabStop = false;
												this.gbAddStudent.Text = "Add student";
												// 
												// btnAddStudent
												// 
												this.btnAddStudent.Location = new System.Drawing.Point(9, 74);
												this.btnAddStudent.Name = "btnAddStudent";
												this.btnAddStudent.Size = new System.Drawing.Size(141, 23);
												this.btnAddStudent.TabIndex = 3;
												this.btnAddStudent.Text = "Add student";
												this.btnAddStudent.UseVisualStyleBackColor = true;
												this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
												// 
												// nudStudentNumber
												// 
												this.nudStudentNumber.Location = new System.Drawing.Point(60, 47);
												this.nudStudentNumber.Name = "nudStudentNumber";
												this.nudStudentNumber.Size = new System.Drawing.Size(90, 20);
												this.nudStudentNumber.TabIndex = 2;
												// 
												// lblStudentNumber
												// 
												this.lblStudentNumber.AutoSize = true;
												this.lblStudentNumber.Location = new System.Drawing.Point(6, 49);
												this.lblStudentNumber.Name = "lblStudentNumber";
												this.lblStudentNumber.Size = new System.Drawing.Size(47, 13);
												this.lblStudentNumber.TabIndex = 2;
												this.lblStudentNumber.Text = "Number:";
												// 
												// tbStudentName
												// 
												this.tbStudentName.Location = new System.Drawing.Point(50, 20);
												this.tbStudentName.Name = "tbStudentName";
												this.tbStudentName.Size = new System.Drawing.Size(100, 20);
												this.tbStudentName.TabIndex = 1;
												// 
												// lblStudentName
												// 
												this.lblStudentName.AutoSize = true;
												this.lblStudentName.Location = new System.Drawing.Point(6, 23);
												this.lblStudentName.Name = "lblStudentName";
												this.lblStudentName.Size = new System.Drawing.Size(38, 13);
												this.lblStudentName.TabIndex = 0;
												this.lblStudentName.Text = "Name:";
												// 
												// groupBox1
												// 
												this.groupBox1.Controls.Add(this.tbStudentSearch);
												this.groupBox1.Controls.Add(this.btnStudentSearch);
												this.groupBox1.Controls.Add(this.lbStudents);
												this.groupBox1.Location = new System.Drawing.Point(180, 13);
												this.groupBox1.Name = "groupBox1";
												this.groupBox1.Size = new System.Drawing.Size(201, 381);
												this.groupBox1.TabIndex = 1;
												this.groupBox1.TabStop = false;
												this.groupBox1.Text = "Students";
												// 
												// tbStudentSearch
												// 
												this.tbStudentSearch.Location = new System.Drawing.Point(7, 354);
												this.tbStudentSearch.Name = "tbStudentSearch";
												this.tbStudentSearch.Size = new System.Drawing.Size(107, 20);
												this.tbStudentSearch.TabIndex = 2;
												this.tbStudentSearch.TextChanged += new System.EventHandler(this.tbStudentSearch_TextChanged);
												// 
												// btnStudentSearch
												// 
												this.btnStudentSearch.Location = new System.Drawing.Point(120, 352);
												this.btnStudentSearch.Name = "btnStudentSearch";
												this.btnStudentSearch.Size = new System.Drawing.Size(75, 23);
												this.btnStudentSearch.TabIndex = 1;
												this.btnStudentSearch.Text = "Search";
												this.btnStudentSearch.UseVisualStyleBackColor = true;
												this.btnStudentSearch.Click += new System.EventHandler(this.btnStudentSearch_Click);
												// 
												// lbStudents
												// 
												this.lbStudents.FormattingEnabled = true;
												this.lbStudents.Location = new System.Drawing.Point(7, 20);
												this.lbStudents.Name = "lbStudents";
												this.lbStudents.Size = new System.Drawing.Size(188, 329);
												this.lbStudents.TabIndex = 0;
												// 
												// gbGroups
												// 
												this.gbGroups.Controls.Add(this.lbGroups);
												this.gbGroups.Location = new System.Drawing.Point(13, 124);
												this.gbGroups.Name = "gbGroups";
												this.gbGroups.Size = new System.Drawing.Size(161, 270);
												this.gbGroups.TabIndex = 2;
												this.gbGroups.TabStop = false;
												this.gbGroups.Text = "Groups";
												// 
												// lbGroups
												// 
												this.lbGroups.FormattingEnabled = true;
												this.lbGroups.Location = new System.Drawing.Point(7, 20);
												this.lbGroups.Name = "lbGroups";
												this.lbGroups.Size = new System.Drawing.Size(143, 238);
												this.lbGroups.TabIndex = 0;
												// 
												// gbGroupMembers
												// 
												this.gbGroupMembers.Controls.Add(this.tbSearchGroupM);
												this.gbGroupMembers.Controls.Add(this.btnSearchGroupM);
												this.gbGroupMembers.Controls.Add(this.lbGroupMembers);
												this.gbGroupMembers.Location = new System.Drawing.Point(388, 13);
												this.gbGroupMembers.Name = "gbGroupMembers";
												this.gbGroupMembers.Size = new System.Drawing.Size(200, 381);
												this.gbGroupMembers.TabIndex = 3;
												this.gbGroupMembers.TabStop = false;
												this.gbGroupMembers.Text = "Group members";
												// 
												// tbSearchGroupM
												// 
												this.tbSearchGroupM.Location = new System.Drawing.Point(6, 355);
												this.tbSearchGroupM.Name = "tbSearchGroupM";
												this.tbSearchGroupM.Size = new System.Drawing.Size(107, 20);
												this.tbSearchGroupM.TabIndex = 5;
												this.tbSearchGroupM.TextChanged += new System.EventHandler(this.tbSearchGroupM_TextChanged);
												// 
												// btnSearchGroupM
												// 
												this.btnSearchGroupM.Location = new System.Drawing.Point(119, 352);
												this.btnSearchGroupM.Name = "btnSearchGroupM";
												this.btnSearchGroupM.Size = new System.Drawing.Size(75, 23);
												this.btnSearchGroupM.TabIndex = 4;
												this.btnSearchGroupM.Text = "Search";
												this.btnSearchGroupM.UseVisualStyleBackColor = true;
												this.btnSearchGroupM.Click += new System.EventHandler(this.btnSearchGroupM_Click);
												// 
												// lbGroupMembers
												// 
												this.lbGroupMembers.FormattingEnabled = true;
												this.lbGroupMembers.Location = new System.Drawing.Point(6, 20);
												this.lbGroupMembers.Name = "lbGroupMembers";
												this.lbGroupMembers.Size = new System.Drawing.Size(188, 329);
												this.lbGroupMembers.TabIndex = 3;
												// 
												// Form1
												// 
												this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
												this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
												this.ClientSize = new System.Drawing.Size(600, 405);
												this.Controls.Add(this.gbGroupMembers);
												this.Controls.Add(this.gbGroups);
												this.Controls.Add(this.groupBox1);
												this.Controls.Add(this.gbAddStudent);
												this.Name = "Form1";
												this.Text = "Form1";
												this.gbAddStudent.ResumeLayout(false);
												this.gbAddStudent.PerformLayout();
												((System.ComponentModel.ISupportInitialize)(this.nudStudentNumber)).EndInit();
												this.groupBox1.ResumeLayout(false);
												this.groupBox1.PerformLayout();
												this.gbGroups.ResumeLayout(false);
												this.gbGroupMembers.ResumeLayout(false);
												this.gbGroupMembers.PerformLayout();
												this.ResumeLayout(false);

								}

								#endregion

								private System.Windows.Forms.GroupBox gbAddStudent;
								private System.Windows.Forms.Button btnAddStudent;
								private System.Windows.Forms.NumericUpDown nudStudentNumber;
								private System.Windows.Forms.Label lblStudentNumber;
								private System.Windows.Forms.TextBox tbStudentName;
								private System.Windows.Forms.Label lblStudentName;
								private System.Windows.Forms.GroupBox groupBox1;
								private System.Windows.Forms.ListBox lbStudents;
								private System.Windows.Forms.GroupBox gbGroups;
								private System.Windows.Forms.ListBox lbGroups;
								private System.Windows.Forms.TextBox tbStudentSearch;
								private System.Windows.Forms.Button btnStudentSearch;
								private System.Windows.Forms.GroupBox gbGroupMembers;
								private System.Windows.Forms.TextBox tbSearchGroupM;
								private System.Windows.Forms.Button btnSearchGroupM;
								private System.Windows.Forms.ListBox lbGroupMembers;
				}
}

