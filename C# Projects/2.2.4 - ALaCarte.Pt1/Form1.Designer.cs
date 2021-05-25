namespace _2._2._4___ALaCarte.Pt1
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
												this.gbAdd = new System.Windows.Forms.GroupBox();
												this.btnAdd = new System.Windows.Forms.Button();
												this.tbName = new System.Windows.Forms.TextBox();
												this.lblName = new System.Windows.Forms.Label();
												this.gbQueue = new System.Windows.Forms.GroupBox();
												this.btnRemove = new System.Windows.Forms.Button();
												this.tbQueue = new System.Windows.Forms.ListBox();
												this.gbSeating = new System.Windows.Forms.GroupBox();
												this.lblTable6 = new System.Windows.Forms.Label();
												this.lblTable5 = new System.Windows.Forms.Label();
												this.lblTable4 = new System.Windows.Forms.Label();
												this.lblTable3 = new System.Windows.Forms.Label();
												this.lblTable2 = new System.Windows.Forms.Label();
												this.lblTable1 = new System.Windows.Forms.Label();
												this.gbAdd.SuspendLayout();
												this.gbQueue.SuspendLayout();
												this.gbSeating.SuspendLayout();
												this.SuspendLayout();
												// 
												// gbAdd
												// 
												this.gbAdd.Controls.Add(this.btnAdd);
												this.gbAdd.Controls.Add(this.tbName);
												this.gbAdd.Controls.Add(this.lblName);
												this.gbAdd.Location = new System.Drawing.Point(13, 13);
												this.gbAdd.Name = "gbAdd";
												this.gbAdd.Size = new System.Drawing.Size(165, 84);
												this.gbAdd.TabIndex = 0;
												this.gbAdd.TabStop = false;
												this.gbAdd.Text = "Add group";
												// 
												// btnAdd
												// 
												this.btnAdd.Location = new System.Drawing.Point(11, 47);
												this.btnAdd.Name = "btnAdd";
												this.btnAdd.Size = new System.Drawing.Size(140, 23);
												this.btnAdd.TabIndex = 2;
												this.btnAdd.Text = "Add client";
												this.btnAdd.UseVisualStyleBackColor = true;
												this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
												// 
												// tbName
												// 
												this.tbName.Location = new System.Drawing.Point(52, 20);
												this.tbName.Name = "tbName";
												this.tbName.Size = new System.Drawing.Size(100, 20);
												this.tbName.TabIndex = 1;
												// 
												// lblName
												// 
												this.lblName.AutoSize = true;
												this.lblName.Location = new System.Drawing.Point(8, 23);
												this.lblName.Name = "lblName";
												this.lblName.Size = new System.Drawing.Size(38, 13);
												this.lblName.TabIndex = 0;
												this.lblName.Text = "Name:";
												// 
												// gbQueue
												// 
												this.gbQueue.Controls.Add(this.btnRemove);
												this.gbQueue.Controls.Add(this.tbQueue);
												this.gbQueue.Location = new System.Drawing.Point(13, 104);
												this.gbQueue.Name = "gbQueue";
												this.gbQueue.Size = new System.Drawing.Size(165, 266);
												this.gbQueue.TabIndex = 1;
												this.gbQueue.TabStop = false;
												this.gbQueue.Text = "Queue";
												// 
												// btnRemove
												// 
												this.btnRemove.Location = new System.Drawing.Point(6, 237);
												this.btnRemove.Name = "btnRemove";
												this.btnRemove.Size = new System.Drawing.Size(145, 23);
												this.btnRemove.TabIndex = 1;
												this.btnRemove.Text = "Remove";
												this.btnRemove.UseVisualStyleBackColor = true;
												this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
												// 
												// tbQueue
												// 
												this.tbQueue.FormattingEnabled = true;
												this.tbQueue.Location = new System.Drawing.Point(7, 20);
												this.tbQueue.Name = "tbQueue";
												this.tbQueue.Size = new System.Drawing.Size(144, 212);
												this.tbQueue.TabIndex = 0;
												// 
												// gbSeating
												// 
												this.gbSeating.Controls.Add(this.lblTable6);
												this.gbSeating.Controls.Add(this.lblTable5);
												this.gbSeating.Controls.Add(this.lblTable4);
												this.gbSeating.Controls.Add(this.lblTable3);
												this.gbSeating.Controls.Add(this.lblTable2);
												this.gbSeating.Controls.Add(this.lblTable1);
												this.gbSeating.Location = new System.Drawing.Point(185, 13);
												this.gbSeating.Name = "gbSeating";
												this.gbSeating.Size = new System.Drawing.Size(507, 356);
												this.gbSeating.TabIndex = 2;
												this.gbSeating.TabStop = false;
												this.gbSeating.Text = "Seating";
												// 
												// lblTable6
												// 
												this.lblTable6.AutoSize = true;
												this.lblTable6.Location = new System.Drawing.Point(446, 169);
												this.lblTable6.Name = "lblTable6";
												this.lblTable6.Size = new System.Drawing.Size(43, 13);
												this.lblTable6.TabIndex = 5;
												this.lblTable6.Text = "Table 6";
												this.lblTable6.Click += new System.EventHandler(this.lblTable_Click);
												// 
												// lblTable5
												// 
												this.lblTable5.AutoSize = true;
												this.lblTable5.Location = new System.Drawing.Point(357, 283);
												this.lblTable5.Name = "lblTable5";
												this.lblTable5.Size = new System.Drawing.Size(43, 13);
												this.lblTable5.TabIndex = 4;
												this.lblTable5.Text = "Table 5";
												this.lblTable5.Click += new System.EventHandler(this.lblTable_Click);
												// 
												// lblTable4
												// 
												this.lblTable4.AutoSize = true;
												this.lblTable4.Location = new System.Drawing.Point(105, 283);
												this.lblTable4.Name = "lblTable4";
												this.lblTable4.Size = new System.Drawing.Size(43, 13);
												this.lblTable4.TabIndex = 3;
												this.lblTable4.Text = "Table 4";
												this.lblTable4.Click += new System.EventHandler(this.lblTable_Click);
												// 
												// lblTable3
												// 
												this.lblTable3.AutoSize = true;
												this.lblTable3.Location = new System.Drawing.Point(357, 57);
												this.lblTable3.Name = "lblTable3";
												this.lblTable3.Size = new System.Drawing.Size(43, 13);
												this.lblTable3.TabIndex = 2;
												this.lblTable3.Text = "Table 3";
												this.lblTable3.Click += new System.EventHandler(this.lblTable_Click);
												// 
												// lblTable2
												// 
												this.lblTable2.AutoSize = true;
												this.lblTable2.Location = new System.Drawing.Point(105, 57);
												this.lblTable2.Name = "lblTable2";
												this.lblTable2.Size = new System.Drawing.Size(43, 13);
												this.lblTable2.TabIndex = 1;
												this.lblTable2.Text = "Table 2";
												this.lblTable2.Click += new System.EventHandler(this.lblTable_Click);
												// 
												// lblTable1
												// 
												this.lblTable1.AutoSize = true;
												this.lblTable1.Location = new System.Drawing.Point(24, 169);
												this.lblTable1.Name = "lblTable1";
												this.lblTable1.Size = new System.Drawing.Size(43, 13);
												this.lblTable1.TabIndex = 0;
												this.lblTable1.Text = "Table 1";
												this.lblTable1.Click += new System.EventHandler(this.lblTable_Click);
												// 
												// Form1
												// 
												this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
												this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
												this.ClientSize = new System.Drawing.Size(707, 381);
												this.Controls.Add(this.gbSeating);
												this.Controls.Add(this.gbQueue);
												this.Controls.Add(this.gbAdd);
												this.Name = "Form1";
												this.Text = "Form1";
												this.gbAdd.ResumeLayout(false);
												this.gbAdd.PerformLayout();
												this.gbQueue.ResumeLayout(false);
												this.gbSeating.ResumeLayout(false);
												this.gbSeating.PerformLayout();
												this.ResumeLayout(false);

								}

								#endregion

								private System.Windows.Forms.GroupBox gbAdd;
								private System.Windows.Forms.Button btnAdd;
								private System.Windows.Forms.TextBox tbName;
								private System.Windows.Forms.Label lblName;
								private System.Windows.Forms.GroupBox gbQueue;
								private System.Windows.Forms.Button btnRemove;
								private System.Windows.Forms.ListBox tbQueue;
								private System.Windows.Forms.GroupBox gbSeating;
								private System.Windows.Forms.Label lblTable6;
								private System.Windows.Forms.Label lblTable5;
								private System.Windows.Forms.Label lblTable4;
								private System.Windows.Forms.Label lblTable3;
								private System.Windows.Forms.Label lblTable2;
								private System.Windows.Forms.Label lblTable1;
				}
}

