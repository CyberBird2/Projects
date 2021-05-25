namespace _5._2._1___SortingGrades
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
												this.lbResults = new System.Windows.Forms.ListBox();
												this.btnSort = new System.Windows.Forms.Button();
												this.btnRandomize = new System.Windows.Forms.Button();
												this.cbCourses = new System.Windows.Forms.ComboBox();
												this.btnShow = new System.Windows.Forms.Button();
												this.SuspendLayout();
												// 
												// lbResults
												// 
												this.lbResults.FormattingEnabled = true;
												this.lbResults.Location = new System.Drawing.Point(13, 13);
												this.lbResults.Name = "lbResults";
												this.lbResults.Size = new System.Drawing.Size(290, 394);
												this.lbResults.TabIndex = 0;
												// 
												// btnSort
												// 
												this.btnSort.Location = new System.Drawing.Point(13, 415);
												this.btnSort.Name = "btnSort";
												this.btnSort.Size = new System.Drawing.Size(142, 23);
												this.btnSort.TabIndex = 1;
												this.btnSort.Text = "Sort";
												this.btnSort.UseVisualStyleBackColor = true;
												this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
												// 
												// btnRandomize
												// 
												this.btnRandomize.Location = new System.Drawing.Point(161, 415);
												this.btnRandomize.Name = "btnRandomize";
												this.btnRandomize.Size = new System.Drawing.Size(142, 23);
												this.btnRandomize.TabIndex = 2;
												this.btnRandomize.Text = "Randomize";
												this.btnRandomize.UseVisualStyleBackColor = true;
												this.btnRandomize.Click += new System.EventHandler(this.btnRandomize_Click);
												// 
												// cbCourses
												// 
												this.cbCourses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
												this.cbCourses.FormattingEnabled = true;
												this.cbCourses.Location = new System.Drawing.Point(13, 445);
												this.cbCourses.Name = "cbCourses";
												this.cbCourses.Size = new System.Drawing.Size(193, 21);
												this.cbCourses.TabIndex = 3;
												// 
												// btnShow
												// 
												this.btnShow.Location = new System.Drawing.Point(212, 443);
												this.btnShow.Name = "btnShow";
												this.btnShow.Size = new System.Drawing.Size(91, 23);
												this.btnShow.TabIndex = 4;
												this.btnShow.Text = "Show result";
												this.btnShow.UseVisualStyleBackColor = true;
												this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
												// 
												// Form1
												// 
												this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
												this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
												this.ClientSize = new System.Drawing.Size(317, 478);
												this.Controls.Add(this.btnShow);
												this.Controls.Add(this.cbCourses);
												this.Controls.Add(this.btnRandomize);
												this.Controls.Add(this.btnSort);
												this.Controls.Add(this.lbResults);
												this.Name = "Form1";
												this.Text = "Form1";
												this.ResumeLayout(false);

								}

								#endregion

								private System.Windows.Forms.ListBox lbResults;
								private System.Windows.Forms.Button btnSort;
								private System.Windows.Forms.Button btnRandomize;
								private System.Windows.Forms.ComboBox cbCourses;
								private System.Windows.Forms.Button btnShow;
				}
}

