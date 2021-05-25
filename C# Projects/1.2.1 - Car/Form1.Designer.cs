namespace _1._2._1___Car
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
												this.cbCar = new System.Windows.Forms.ComboBox();
												this.btnMaintenence = new System.Windows.Forms.Button();
												this.btnAddFuel = new System.Windows.Forms.Button();
												this.nudFuel = new System.Windows.Forms.NumericUpDown();
												this.btnSell = new System.Windows.Forms.Button();
												this.lblStatus = new System.Windows.Forms.Label();
												this.pbSteer = new System.Windows.Forms.PictureBox();
												this.nudKilomiter = new System.Windows.Forms.NumericUpDown();
												((System.ComponentModel.ISupportInitialize)(this.nudFuel)).BeginInit();
												((System.ComponentModel.ISupportInitialize)(this.pbSteer)).BeginInit();
												((System.ComponentModel.ISupportInitialize)(this.nudKilomiter)).BeginInit();
												this.SuspendLayout();
												// 
												// cbCar
												// 
												this.cbCar.FormattingEnabled = true;
												this.cbCar.Location = new System.Drawing.Point(13, 13);
												this.cbCar.Name = "cbCar";
												this.cbCar.Size = new System.Drawing.Size(121, 21);
												this.cbCar.TabIndex = 0;
												this.cbCar.SelectedIndexChanged += new System.EventHandler(this.cbCar_SelectedIndexChanged);
												// 
												// btnMaintenence
												// 
												this.btnMaintenence.Location = new System.Drawing.Point(13, 41);
												this.btnMaintenence.Name = "btnMaintenence";
												this.btnMaintenence.Size = new System.Drawing.Size(121, 23);
												this.btnMaintenence.TabIndex = 1;
												this.btnMaintenence.Text = "Toggle maintenence";
												this.btnMaintenence.UseVisualStyleBackColor = true;
												this.btnMaintenence.Click += new System.EventHandler(this.btnMaintenence_Click);
												// 
												// btnAddFuel
												// 
												this.btnAddFuel.Location = new System.Drawing.Point(59, 68);
												this.btnAddFuel.Name = "btnAddFuel";
												this.btnAddFuel.Size = new System.Drawing.Size(75, 23);
												this.btnAddFuel.TabIndex = 2;
												this.btnAddFuel.Text = "Add fuel";
												this.btnAddFuel.UseVisualStyleBackColor = true;
												this.btnAddFuel.Click += new System.EventHandler(this.btnAddFuel_Click);
												// 
												// nudFuel
												// 
												this.nudFuel.Location = new System.Drawing.Point(13, 71);
												this.nudFuel.Name = "nudFuel";
												this.nudFuel.Size = new System.Drawing.Size(39, 20);
												this.nudFuel.TabIndex = 3;
												// 
												// btnSell
												// 
												this.btnSell.Location = new System.Drawing.Point(13, 98);
												this.btnSell.Name = "btnSell";
												this.btnSell.Size = new System.Drawing.Size(121, 23);
												this.btnSell.TabIndex = 4;
												this.btnSell.Text = "Sell car";
												this.btnSell.UseVisualStyleBackColor = true;
												this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
												// 
												// lblStatus
												// 
												this.lblStatus.AutoSize = true;
												this.lblStatus.Location = new System.Drawing.Point(13, 128);
												this.lblStatus.Name = "lblStatus";
												this.lblStatus.Size = new System.Drawing.Size(0, 13);
												this.lblStatus.TabIndex = 5;
												// 
												// pbSteer
												// 
												this.pbSteer.Image = ((System.Drawing.Image)(resources.GetObject("pbSteer.Image")));
												this.pbSteer.Location = new System.Drawing.Point(141, 13);
												this.pbSteer.Name = "pbSteer";
												this.pbSteer.Size = new System.Drawing.Size(129, 108);
												this.pbSteer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
												this.pbSteer.TabIndex = 6;
												this.pbSteer.TabStop = false;
												this.pbSteer.Click += new System.EventHandler(this.pbSteer_Click);
												// 
												// nudKilomiter
												// 
												this.nudKilomiter.Location = new System.Drawing.Point(233, 126);
												this.nudKilomiter.Name = "nudKilomiter";
												this.nudKilomiter.Size = new System.Drawing.Size(37, 20);
												this.nudKilomiter.TabIndex = 7;
												// 
												// Form1
												// 
												this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
												this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
												this.ClientSize = new System.Drawing.Size(282, 151);
												this.Controls.Add(this.nudKilomiter);
												this.Controls.Add(this.pbSteer);
												this.Controls.Add(this.lblStatus);
												this.Controls.Add(this.btnSell);
												this.Controls.Add(this.nudFuel);
												this.Controls.Add(this.btnAddFuel);
												this.Controls.Add(this.btnMaintenence);
												this.Controls.Add(this.cbCar);
												this.Name = "Form1";
												this.Text = "Form1";
												((System.ComponentModel.ISupportInitialize)(this.nudFuel)).EndInit();
												((System.ComponentModel.ISupportInitialize)(this.pbSteer)).EndInit();
												((System.ComponentModel.ISupportInitialize)(this.nudKilomiter)).EndInit();
												this.ResumeLayout(false);
												this.PerformLayout();

								}

								#endregion

								private System.Windows.Forms.ComboBox cbCar;
								private System.Windows.Forms.Button btnMaintenence;
								private System.Windows.Forms.Button btnAddFuel;
								private System.Windows.Forms.NumericUpDown nudFuel;
								private System.Windows.Forms.Button btnSell;
								private System.Windows.Forms.Label lblStatus;
								private System.Windows.Forms.PictureBox pbSteer;
								private System.Windows.Forms.NumericUpDown nudKilomiter;
				}
}

