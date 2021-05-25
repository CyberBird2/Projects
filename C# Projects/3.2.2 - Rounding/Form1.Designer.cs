namespace _3._2._2___Rounding
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
												this.lblNumber = new System.Windows.Forms.Label();
												this.tbNumber = new System.Windows.Forms.TextBox();
												this.rbWhole = new System.Windows.Forms.RadioButton();
												this.rbTenth = new System.Windows.Forms.RadioButton();
												this.rbHundred = new System.Windows.Forms.RadioButton();
												this.btnAct = new System.Windows.Forms.Button();
												this.lbOutp = new System.Windows.Forms.ListBox();
												this.SuspendLayout();
												// 
												// lblNumber
												// 
												this.lblNumber.AutoSize = true;
												this.lblNumber.Location = new System.Drawing.Point(14, 16);
												this.lblNumber.Name = "lblNumber";
												this.lblNumber.Size = new System.Drawing.Size(47, 13);
												this.lblNumber.TabIndex = 0;
												this.lblNumber.Text = "Number:";
												// 
												// tbNumber
												// 
												this.tbNumber.Location = new System.Drawing.Point(67, 13);
												this.tbNumber.Name = "tbNumber";
												this.tbNumber.Size = new System.Drawing.Size(100, 20);
												this.tbNumber.TabIndex = 1;
												this.tbNumber.Text = "6,7459";
												// 
												// rbWhole
												// 
												this.rbWhole.AutoSize = true;
												this.rbWhole.Checked = true;
												this.rbWhole.Location = new System.Drawing.Point(67, 40);
												this.rbWhole.Name = "rbWhole";
												this.rbWhole.Size = new System.Drawing.Size(69, 17);
												this.rbWhole.TabIndex = 2;
												this.rbWhole.TabStop = true;
												this.rbWhole.Text = "To whole";
												this.rbWhole.UseVisualStyleBackColor = true;
												// 
												// rbTenth
												// 
												this.rbTenth.AutoSize = true;
												this.rbTenth.Location = new System.Drawing.Point(67, 63);
												this.rbTenth.Name = "rbTenth";
												this.rbTenth.Size = new System.Drawing.Size(65, 17);
												this.rbTenth.TabIndex = 3;
												this.rbTenth.Text = "To tenth";
												this.rbTenth.UseVisualStyleBackColor = true;
												// 
												// rbHundred
												// 
												this.rbHundred.AutoSize = true;
												this.rbHundred.Location = new System.Drawing.Point(67, 86);
												this.rbHundred.Name = "rbHundred";
												this.rbHundred.Size = new System.Drawing.Size(83, 17);
												this.rbHundred.TabIndex = 4;
												this.rbHundred.Text = "To hundreth";
												this.rbHundred.UseVisualStyleBackColor = true;
												// 
												// btnAct
												// 
												this.btnAct.Location = new System.Drawing.Point(174, 13);
												this.btnAct.Name = "btnAct";
												this.btnAct.Size = new System.Drawing.Size(99, 99);
												this.btnAct.TabIndex = 5;
												this.btnAct.Text = "Round 10x";
												this.btnAct.UseVisualStyleBackColor = true;
												this.btnAct.Click += new System.EventHandler(this.btnAct_Click);
												// 
												// lbOutp
												// 
												this.lbOutp.FormattingEnabled = true;
												this.lbOutp.Location = new System.Drawing.Point(12, 119);
												this.lbOutp.Name = "lbOutp";
												this.lbOutp.Size = new System.Drawing.Size(260, 186);
												this.lbOutp.TabIndex = 6;
												// 
												// Form1
												// 
												this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
												this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
												this.ClientSize = new System.Drawing.Size(290, 317);
												this.Controls.Add(this.lbOutp);
												this.Controls.Add(this.btnAct);
												this.Controls.Add(this.rbHundred);
												this.Controls.Add(this.rbTenth);
												this.Controls.Add(this.rbWhole);
												this.Controls.Add(this.tbNumber);
												this.Controls.Add(this.lblNumber);
												this.Name = "Form1";
												this.Text = "Form1";
												this.ResumeLayout(false);
												this.PerformLayout();

								}

								#endregion

								private System.Windows.Forms.Label lblNumber;
								private System.Windows.Forms.TextBox tbNumber;
								private System.Windows.Forms.RadioButton rbWhole;
								private System.Windows.Forms.RadioButton rbTenth;
								private System.Windows.Forms.RadioButton rbHundred;
								private System.Windows.Forms.Button btnAct;
								private System.Windows.Forms.ListBox lbOutp;
				}
}

