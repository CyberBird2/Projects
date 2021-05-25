namespace _4._2._1___Regex
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
												System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
												this.groupBox1 = new System.Windows.Forms.GroupBox();
												this.btnValidAddresss = new System.Windows.Forms.Button();
												this.btnValidStreetname = new System.Windows.Forms.Button();
												this.btnDutchPhoneNumber = new System.Windows.Forms.Button();
												this.btnValidPhoneNumber = new System.Windows.Forms.Button();
												this.cbbInput = new System.Windows.Forms.ComboBox();
												this.label1 = new System.Windows.Forms.Label();
												this.groupBox2 = new System.Windows.Forms.GroupBox();
												this.btnPatternCount = new System.Windows.Forms.Button();
												this.cbbPattern = new System.Windows.Forms.ComboBox();
												this.label2 = new System.Windows.Forms.Label();
												this.tbxTestData = new System.Windows.Forms.TextBox();
												this.groupBox1.SuspendLayout();
												this.groupBox2.SuspendLayout();
												this.SuspendLayout();
												// 
												// groupBox1
												// 
												this.groupBox1.Controls.Add(this.btnValidAddresss);
												this.groupBox1.Controls.Add(this.btnValidStreetname);
												this.groupBox1.Controls.Add(this.btnDutchPhoneNumber);
												this.groupBox1.Controls.Add(this.btnValidPhoneNumber);
												this.groupBox1.Controls.Add(this.cbbInput);
												this.groupBox1.Controls.Add(this.label1);
												this.groupBox1.Location = new System.Drawing.Point(12, 12);
												this.groupBox1.Name = "groupBox1";
												this.groupBox1.Size = new System.Drawing.Size(455, 117);
												this.groupBox1.TabIndex = 0;
												this.groupBox1.TabStop = false;
												this.groupBox1.Text = "Regex: IsMatch";
												// 
												// btnValidAddresss
												// 
												this.btnValidAddresss.Location = new System.Drawing.Point(230, 78);
												this.btnValidAddresss.Name = "btnValidAddresss";
												this.btnValidAddresss.Size = new System.Drawing.Size(206, 23);
												this.btnValidAddresss.TabIndex = 5;
												this.btnValidAddresss.Text = "Valid address?";
												this.btnValidAddresss.UseVisualStyleBackColor = true;
												this.btnValidAddresss.Click += new System.EventHandler(this.btnValidAddresss_Click);
												// 
												// btnValidStreetname
												// 
												this.btnValidStreetname.Location = new System.Drawing.Point(18, 78);
												this.btnValidStreetname.Name = "btnValidStreetname";
												this.btnValidStreetname.Size = new System.Drawing.Size(206, 23);
												this.btnValidStreetname.TabIndex = 4;
												this.btnValidStreetname.Text = "Valid street name?";
												this.btnValidStreetname.UseVisualStyleBackColor = true;
												this.btnValidStreetname.Click += new System.EventHandler(this.btnValidStreetname_Click);
												// 
												// btnDutchPhoneNumber
												// 
												this.btnDutchPhoneNumber.Location = new System.Drawing.Point(230, 49);
												this.btnDutchPhoneNumber.Name = "btnDutchPhoneNumber";
												this.btnDutchPhoneNumber.Size = new System.Drawing.Size(206, 23);
												this.btnDutchPhoneNumber.TabIndex = 3;
												this.btnDutchPhoneNumber.Text = "Valid Dutch phone number?";
												this.btnDutchPhoneNumber.UseVisualStyleBackColor = true;
												this.btnDutchPhoneNumber.Click += new System.EventHandler(this.btnDutchPhoneNumber_Click);
												// 
												// btnValidPhoneNumber
												// 
												this.btnValidPhoneNumber.Location = new System.Drawing.Point(18, 49);
												this.btnValidPhoneNumber.Name = "btnValidPhoneNumber";
												this.btnValidPhoneNumber.Size = new System.Drawing.Size(206, 23);
												this.btnValidPhoneNumber.TabIndex = 2;
												this.btnValidPhoneNumber.Text = "Valid phone number?";
												this.btnValidPhoneNumber.UseVisualStyleBackColor = true;
												this.btnValidPhoneNumber.Click += new System.EventHandler(this.btnValidPhoneNumber_Click);
												// 
												// cbbInput
												// 
												this.cbbInput.FormattingEnabled = true;
												this.cbbInput.Location = new System.Drawing.Point(55, 22);
												this.cbbInput.Name = "cbbInput";
												this.cbbInput.Size = new System.Drawing.Size(381, 21);
												this.cbbInput.TabIndex = 1;
												// 
												// label1
												// 
												this.label1.AutoSize = true;
												this.label1.Location = new System.Drawing.Point(15, 25);
												this.label1.Name = "label1";
												this.label1.Size = new System.Drawing.Size(34, 13);
												this.label1.TabIndex = 0;
												this.label1.Text = "Input:";
												// 
												// groupBox2
												// 
												this.groupBox2.Controls.Add(this.btnPatternCount);
												this.groupBox2.Controls.Add(this.cbbPattern);
												this.groupBox2.Controls.Add(this.label2);
												this.groupBox2.Controls.Add(this.tbxTestData);
												this.groupBox2.Location = new System.Drawing.Point(12, 135);
												this.groupBox2.Name = "groupBox2";
												this.groupBox2.Size = new System.Drawing.Size(455, 219);
												this.groupBox2.TabIndex = 1;
												this.groupBox2.TabStop = false;
												this.groupBox2.Text = "Regex: Match";
												// 
												// btnPatternCount
												// 
												this.btnPatternCount.Location = new System.Drawing.Point(317, 184);
												this.btnPatternCount.Name = "btnPatternCount";
												this.btnPatternCount.Size = new System.Drawing.Size(119, 23);
												this.btnPatternCount.TabIndex = 6;
												this.btnPatternCount.Text = "Pattern count?";
												this.btnPatternCount.UseVisualStyleBackColor = true;
												this.btnPatternCount.Click += new System.EventHandler(this.btnPatternCount_Click);
												// 
												// cbbPattern
												// 
												this.cbbPattern.FormattingEnabled = true;
												this.cbbPattern.Location = new System.Drawing.Point(65, 186);
												this.cbbPattern.Name = "cbbPattern";
												this.cbbPattern.Size = new System.Drawing.Size(246, 21);
												this.cbbPattern.TabIndex = 7;
												// 
												// label2
												// 
												this.label2.AutoSize = true;
												this.label2.Location = new System.Drawing.Point(15, 189);
												this.label2.Name = "label2";
												this.label2.Size = new System.Drawing.Size(44, 13);
												this.label2.TabIndex = 6;
												this.label2.Text = "Pattern:";
												// 
												// tbxTestData
												// 
												this.tbxTestData.Location = new System.Drawing.Point(18, 19);
												this.tbxTestData.Multiline = true;
												this.tbxTestData.Name = "tbxTestData";
												this.tbxTestData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
												this.tbxTestData.Size = new System.Drawing.Size(418, 161);
												this.tbxTestData.TabIndex = 0;
												this.tbxTestData.Text = resources.GetString("tbxTestData.Text");
												// 
												// Form1
												// 
												this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
												this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
												this.ClientSize = new System.Drawing.Size(486, 366);
												this.Controls.Add(this.groupBox2);
												this.Controls.Add(this.groupBox1);
												this.Name = "Form1";
												this.Text = "Form1";
												this.groupBox1.ResumeLayout(false);
												this.groupBox1.PerformLayout();
												this.groupBox2.ResumeLayout(false);
												this.groupBox2.PerformLayout();
												this.ResumeLayout(false);

								}

								#endregion

								private System.Windows.Forms.GroupBox groupBox1;
								private System.Windows.Forms.Button btnValidAddresss;
								private System.Windows.Forms.Button btnValidStreetname;
								private System.Windows.Forms.Button btnDutchPhoneNumber;
								private System.Windows.Forms.Button btnValidPhoneNumber;
								private System.Windows.Forms.ComboBox cbbInput;
								private System.Windows.Forms.Label label1;
								private System.Windows.Forms.GroupBox groupBox2;
								private System.Windows.Forms.Button btnPatternCount;
								private System.Windows.Forms.ComboBox cbbPattern;
								private System.Windows.Forms.Label label2;
								private System.Windows.Forms.TextBox tbxTestData;
				}
}

