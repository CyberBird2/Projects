namespace _4._2._5___FindAndReplace
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
            this.lblOriginal = new System.Windows.Forms.Label();
            this.rtbOriginal = new System.Windows.Forms.RichTextBox();
            this.lblFind = new System.Windows.Forms.Label();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.lblReplace = new System.Windows.Forms.Label();
            this.tbReplace = new System.Windows.Forms.TextBox();
            this.btnReplace = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblOriginal
            // 
            this.lblOriginal.AutoSize = true;
            this.lblOriginal.Location = new System.Drawing.Point(17, 16);
            this.lblOriginal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOriginal.Name = "lblOriginal";
            this.lblOriginal.Size = new System.Drawing.Size(57, 17);
            this.lblOriginal.TabIndex = 0;
            this.lblOriginal.Text = "Original";
            // 
            // rtbOriginal
            // 
            this.rtbOriginal.Location = new System.Drawing.Point(91, 16);
            this.rtbOriginal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbOriginal.Name = "rtbOriginal";
            this.rtbOriginal.Size = new System.Drawing.Size(608, 117);
            this.rtbOriginal.TabIndex = 1;
            this.rtbOriginal.Text = resources.GetString("rtbOriginal.Text");
            // 
            // lblFind
            // 
            this.lblFind.AutoSize = true;
            this.lblFind.Location = new System.Drawing.Point(87, 146);
            this.lblFind.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(39, 17);
            this.lblFind.TabIndex = 2;
            this.lblFind.Text = "Find:";
            // 
            // tbFind
            // 
            this.tbFind.Location = new System.Drawing.Point(135, 143);
            this.tbFind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(132, 22);
            this.tbFind.TabIndex = 3;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(276, 140);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(100, 28);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Find all";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lblReplace
            // 
            this.lblReplace.AutoSize = true;
            this.lblReplace.Location = new System.Drawing.Point(384, 145);
            this.lblReplace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReplace.Name = "lblReplace";
            this.lblReplace.Size = new System.Drawing.Size(64, 17);
            this.lblReplace.TabIndex = 5;
            this.lblReplace.Text = "Replace:";
            // 
            // tbReplace
            // 
            this.tbReplace.Location = new System.Drawing.Point(459, 142);
            this.tbReplace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbReplace.Name = "tbReplace";
            this.tbReplace.Size = new System.Drawing.Size(132, 22);
            this.tbReplace.TabIndex = 6;
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(600, 140);
            this.btnReplace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(100, 28);
            this.btnReplace.TabIndex = 7;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(17, 175);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(48, 17);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "Result";
            // 
            // rtbResult
            // 
            this.rtbResult.Location = new System.Drawing.Point(91, 175);
            this.rtbResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.ReadOnly = true;
            this.rtbResult.Size = new System.Drawing.Size(608, 117);
            this.rtbResult.TabIndex = 9;
            this.rtbResult.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 303);
            this.Controls.Add(this.rtbResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.tbReplace);
            this.Controls.Add(this.lblReplace);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.tbFind);
            this.Controls.Add(this.lblFind);
            this.Controls.Add(this.rtbOriginal);
            this.Controls.Add(this.lblOriginal);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Find and Replace";
            this.ResumeLayout(false);
            this.PerformLayout();

								}

								#endregion

								private System.Windows.Forms.Label lblOriginal;
								private System.Windows.Forms.RichTextBox rtbOriginal;
								private System.Windows.Forms.Label lblFind;
								private System.Windows.Forms.TextBox tbFind;
								private System.Windows.Forms.Button btnFind;
								private System.Windows.Forms.Label lblReplace;
								private System.Windows.Forms.TextBox tbReplace;
								private System.Windows.Forms.Button btnReplace;
								private System.Windows.Forms.Label lblResult;
								private System.Windows.Forms.RichTextBox rtbResult;
				}
}

