namespace _5._2._1___SortingGrades
{
				partial class CourseResultsForm
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
												this.btnClose = new System.Windows.Forms.Button();
												this.SuspendLayout();
												// 
												// lbResults
												// 
												this.lbResults.FormattingEnabled = true;
												this.lbResults.Location = new System.Drawing.Point(13, 13);
												this.lbResults.Name = "lbResults";
												this.lbResults.Size = new System.Drawing.Size(341, 95);
												this.lbResults.TabIndex = 0;
												// 
												// btnClose
												// 
												this.btnClose.Location = new System.Drawing.Point(13, 115);
												this.btnClose.Name = "btnClose";
												this.btnClose.Size = new System.Drawing.Size(341, 23);
												this.btnClose.TabIndex = 1;
												this.btnClose.Text = "Close";
												this.btnClose.UseVisualStyleBackColor = true;
												this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
												// 
												// CourseResultsForm
												// 
												this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
												this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
												this.ClientSize = new System.Drawing.Size(366, 147);
												this.Controls.Add(this.btnClose);
												this.Controls.Add(this.lbResults);
												this.Name = "CourseResultsForm";
												this.Text = "Course results";
												this.ResumeLayout(false);

								}

								#endregion

								private System.Windows.Forms.ListBox lbResults;
								private System.Windows.Forms.Button btnClose;
				}
}