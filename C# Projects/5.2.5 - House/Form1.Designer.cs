namespace _5._2._5
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
												this.lblHousenumber = new System.Windows.Forms.Label();
												this.tbHousenumber = new System.Windows.Forms.TextBox();
												this.btnUpdate = new System.Windows.Forms.Button();
												this.pbMain = new System.Windows.Forms.PictureBox();
												((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
												this.SuspendLayout();
												// 
												// lblHousenumber
												// 
												this.lblHousenumber.AutoSize = true;
												this.lblHousenumber.Location = new System.Drawing.Point(14, 16);
												this.lblHousenumber.Name = "lblHousenumber";
												this.lblHousenumber.Size = new System.Drawing.Size(79, 13);
												this.lblHousenumber.TabIndex = 0;
												this.lblHousenumber.Text = "House number:";
												// 
												// tbHousenumber
												// 
												this.tbHousenumber.Location = new System.Drawing.Point(99, 13);
												this.tbHousenumber.Name = "tbHousenumber";
												this.tbHousenumber.Size = new System.Drawing.Size(100, 20);
												this.tbHousenumber.TabIndex = 1;
												// 
												// btnUpdate
												// 
												this.btnUpdate.Location = new System.Drawing.Point(17, 40);
												this.btnUpdate.Name = "btnUpdate";
												this.btnUpdate.Size = new System.Drawing.Size(182, 23);
												this.btnUpdate.TabIndex = 2;
												this.btnUpdate.Text = "Update house";
												this.btnUpdate.UseVisualStyleBackColor = true;
												this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
												// 
												// pbMain
												// 
												this.pbMain.Location = new System.Drawing.Point(206, 13);
												this.pbMain.Name = "pbMain";
												this.pbMain.Size = new System.Drawing.Size(582, 425);
												this.pbMain.TabIndex = 3;
												this.pbMain.TabStop = false;
												this.pbMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pbMain_Paint);
												// 
												// Form1
												// 
												this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
												this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
												this.ClientSize = new System.Drawing.Size(800, 450);
												this.Controls.Add(this.pbMain);
												this.Controls.Add(this.btnUpdate);
												this.Controls.Add(this.tbHousenumber);
												this.Controls.Add(this.lblHousenumber);
												this.Name = "Form1";
												this.Text = "Form1";
												((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
												this.ResumeLayout(false);
												this.PerformLayout();

								}

								#endregion

								private System.Windows.Forms.Label lblHousenumber;
								private System.Windows.Forms.TextBox tbHousenumber;
								private System.Windows.Forms.Button btnUpdate;
								private System.Windows.Forms.PictureBox pbMain;
				}
}

