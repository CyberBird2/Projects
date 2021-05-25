namespace _2._2._2___ArrayMerging
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
												this.tbArray1 = new System.Windows.Forms.TextBox();
												this.lblArray1 = new System.Windows.Forms.Label();
												this.lblArray2 = new System.Windows.Forms.Label();
												this.tbArray2 = new System.Windows.Forms.TextBox();
												this.lblSep = new System.Windows.Forms.Label();
												this.btnOne = new System.Windows.Forms.Button();
												this.lblResult = new System.Windows.Forms.Label();
												this.tbResult = new System.Windows.Forms.TextBox();
												this.btnTwo = new System.Windows.Forms.Button();
												this.btnThree = new System.Windows.Forms.Button();
												this.btnFour = new System.Windows.Forms.Button();
												this.SuspendLayout();
												// 
												// tbArray1
												// 
												this.tbArray1.Location = new System.Drawing.Point(58, 28);
												this.tbArray1.Name = "tbArray1";
												this.tbArray1.Size = new System.Drawing.Size(237, 20);
												this.tbArray1.TabIndex = 0;
												this.tbArray1.Text = "1, 7, 3, 9, 2, 8, 5, 7, 2, 1, 9, 1, 3, 7";
												// 
												// lblArray1
												// 
												this.lblArray1.AutoSize = true;
												this.lblArray1.Location = new System.Drawing.Point(12, 31);
												this.lblArray1.Name = "lblArray1";
												this.lblArray1.Size = new System.Drawing.Size(40, 13);
												this.lblArray1.TabIndex = 1;
												this.lblArray1.Text = "Array 1";
												// 
												// lblArray2
												// 
												this.lblArray2.AutoSize = true;
												this.lblArray2.Location = new System.Drawing.Point(12, 58);
												this.lblArray2.Name = "lblArray2";
												this.lblArray2.Size = new System.Drawing.Size(40, 13);
												this.lblArray2.TabIndex = 2;
												this.lblArray2.Text = "Array 2";
												// 
												// tbArray2
												// 
												this.tbArray2.Location = new System.Drawing.Point(58, 55);
												this.tbArray2.Name = "tbArray2";
												this.tbArray2.Size = new System.Drawing.Size(237, 20);
												this.tbArray2.TabIndex = 3;
												this.tbArray2.Text = "6, 2, 9, 5, 9, 7, 3, 2, 6, 4, 5, 0, 9, 5";
												// 
												// lblSep
												// 
												this.lblSep.AutoSize = true;
												this.lblSep.Location = new System.Drawing.Point(12, 9);
												this.lblSep.Name = "lblSep";
												this.lblSep.Size = new System.Drawing.Size(110, 13);
												this.lblSep.TabIndex = 4;
												this.lblSep.Text = "Number seperator: \",\"";
												// 
												// btnOne
												// 
												this.btnOne.Location = new System.Drawing.Point(12, 107);
												this.btnOne.Name = "btnOne";
												this.btnOne.Size = new System.Drawing.Size(137, 23);
												this.btnOne.TabIndex = 5;
												this.btnOne.Text = "Array1 + Array2";
												this.btnOne.UseVisualStyleBackColor = true;
												this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
												// 
												// lblResult
												// 
												this.lblResult.AutoSize = true;
												this.lblResult.Location = new System.Drawing.Point(15, 84);
												this.lblResult.Name = "lblResult";
												this.lblResult.Size = new System.Drawing.Size(37, 13);
												this.lblResult.TabIndex = 6;
												this.lblResult.Text = "Result";
												// 
												// tbResult
												// 
												this.tbResult.Location = new System.Drawing.Point(58, 81);
												this.tbResult.Name = "tbResult";
												this.tbResult.ReadOnly = true;
												this.tbResult.Size = new System.Drawing.Size(237, 20);
												this.tbResult.TabIndex = 7;
												// 
												// btnTwo
												// 
												this.btnTwo.Location = new System.Drawing.Point(12, 136);
												this.btnTwo.Name = "btnTwo";
												this.btnTwo.Size = new System.Drawing.Size(137, 23);
												this.btnTwo.TabIndex = 8;
												this.btnTwo.Text = "One at a time";
												this.btnTwo.UseVisualStyleBackColor = true;
												this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
												// 
												// btnThree
												// 
												this.btnThree.Location = new System.Drawing.Point(155, 107);
												this.btnThree.Name = "btnThree";
												this.btnThree.Size = new System.Drawing.Size(140, 23);
												this.btnThree.TabIndex = 9;
												this.btnThree.Text = "Symmetric difference";
												this.btnThree.UseVisualStyleBackColor = true;
												this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
												// 
												// btnFour
												// 
												this.btnFour.Location = new System.Drawing.Point(155, 136);
												this.btnFour.Name = "btnFour";
												this.btnFour.Size = new System.Drawing.Size(140, 23);
												this.btnFour.TabIndex = 10;
												this.btnFour.Text = "Intersection";
												this.btnFour.UseVisualStyleBackColor = true;
												this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
												// 
												// Form1
												// 
												this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
												this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
												this.ClientSize = new System.Drawing.Size(307, 168);
												this.Controls.Add(this.btnFour);
												this.Controls.Add(this.btnThree);
												this.Controls.Add(this.btnTwo);
												this.Controls.Add(this.tbResult);
												this.Controls.Add(this.lblResult);
												this.Controls.Add(this.btnOne);
												this.Controls.Add(this.lblSep);
												this.Controls.Add(this.tbArray2);
												this.Controls.Add(this.lblArray2);
												this.Controls.Add(this.lblArray1);
												this.Controls.Add(this.tbArray1);
												this.Name = "Form1";
												this.Text = "Form1";
												this.ResumeLayout(false);
												this.PerformLayout();

								}

								#endregion

								private System.Windows.Forms.TextBox tbArray1;
								private System.Windows.Forms.Label lblArray1;
								private System.Windows.Forms.Label lblArray2;
								private System.Windows.Forms.TextBox tbArray2;
								private System.Windows.Forms.Label lblSep;
								private System.Windows.Forms.Button btnOne;
								private System.Windows.Forms.Label lblResult;
								private System.Windows.Forms.TextBox tbResult;
								private System.Windows.Forms.Button btnTwo;
								private System.Windows.Forms.Button btnThree;
								private System.Windows.Forms.Button btnFour;
				}
}

