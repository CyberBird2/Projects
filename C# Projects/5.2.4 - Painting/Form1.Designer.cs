﻿namespace _5._2._4___Painting
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
            this.components = new System.ComponentModel.Container();
            this.timerPainter = new System.Windows.Forms.Timer(this.components);
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.btnToggle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.SuspendLayout();
            // 
            // timerPainter
            // 
            this.timerPainter.Interval = 1;
            this.timerPainter.Tick += new System.EventHandler(this.timerPainter_Tick);
            // 
            // pbMain
            // 
            this.pbMain.Location = new System.Drawing.Point(17, 16);
            this.pbMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(572, 62);
            this.pbMain.TabIndex = 0;
            this.pbMain.TabStop = false;
            this.pbMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pbMain_Paint);
            // 
            // btnToggle
            // 
            this.btnToggle.Location = new System.Drawing.Point(17, 86);
            this.btnToggle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(100, 28);
            this.btnToggle.TabIndex = 1;
            this.btnToggle.Text = "Toggle timer";
            this.btnToggle.UseVisualStyleBackColor = true;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 127);
            this.Controls.Add(this.btnToggle);
            this.Controls.Add(this.pbMain);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.ResumeLayout(false);

								}

								#endregion

								private System.Windows.Forms.Timer timerPainter;
								private System.Windows.Forms.PictureBox pbMain;
								private System.Windows.Forms.Button btnToggle;
				}
}

