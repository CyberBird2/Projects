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
												this.gbManage = new System.Windows.Forms.GroupBox();
												this.nudKilomiter = new System.Windows.Forms.NumericUpDown();
												this.pbSteer = new System.Windows.Forms.PictureBox();
												this.lblStatus = new System.Windows.Forms.Label();
												this.btnSell = new System.Windows.Forms.Button();
												this.nudFuel = new System.Windows.Forms.NumericUpDown();
												this.btnAddFuel = new System.Windows.Forms.Button();
												this.btnMaintenence = new System.Windows.Forms.Button();
												this.cbCar = new System.Windows.Forms.ComboBox();
												this.gbAdd = new System.Windows.Forms.GroupBox();
												this.tbLicence = new System.Windows.Forms.TextBox();
												this.lblLicence = new System.Windows.Forms.Label();
												this.lblFuel = new System.Windows.Forms.Label();
												this.nudFuelLevel = new System.Windows.Forms.NumericUpDown();
												this.btnAddCar = new System.Windows.Forms.Button();
												this.gbManage.SuspendLayout();
												((System.ComponentModel.ISupportInitialize)(this.nudKilomiter)).BeginInit();
												((System.ComponentModel.ISupportInitialize)(this.pbSteer)).BeginInit();
												((System.ComponentModel.ISupportInitialize)(this.nudFuel)).BeginInit();
												this.gbAdd.SuspendLayout();
												((System.ComponentModel.ISupportInitialize)(this.nudFuelLevel)).BeginInit();
												this.SuspendLayout();
												// 
												// gbManage
												// 
												this.gbManage.Controls.Add(this.nudKilomiter);
												this.gbManage.Controls.Add(this.pbSteer);
												this.gbManage.Controls.Add(this.lblStatus);
												this.gbManage.Controls.Add(this.btnSell);
												this.gbManage.Controls.Add(this.nudFuel);
												this.gbManage.Controls.Add(this.btnAddFuel);
												this.gbManage.Controls.Add(this.btnMaintenence);
												this.gbManage.Controls.Add(this.cbCar);
												this.gbManage.Location = new System.Drawing.Point(13, 131);
												this.gbManage.Name = "gbManage";
												this.gbManage.Size = new System.Drawing.Size(270, 166);
												this.gbManage.TabIndex = 8;
												this.gbManage.TabStop = false;
												this.gbManage.Text = "Manage car";
												// 
												// nudKilomiter
												// 
												this.nudKilomiter.Location = new System.Drawing.Point(226, 137);
												this.nudKilomiter.Name = "nudKilomiter";
												this.nudKilomiter.Size = new System.Drawing.Size(37, 20);
												this.nudKilomiter.TabIndex = 15;
												// 
												// pbSteer
												// 
												this.pbSteer.Image = ((System.Drawing.Image)(resources.GetObject("pbSteer.Image")));
												this.pbSteer.Location = new System.Drawing.Point(134, 24);
												this.pbSteer.Name = "pbSteer";
												this.pbSteer.Size = new System.Drawing.Size(129, 108);
												this.pbSteer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
												this.pbSteer.TabIndex = 14;
												this.pbSteer.TabStop = false;
												this.pbSteer.Click += new System.EventHandler(this.pbSteer_Click);
												// 
												// lblStatus
												// 
												this.lblStatus.AutoSize = true;
												this.lblStatus.Location = new System.Drawing.Point(0, 134);
												this.lblStatus.Name = "lblStatus";
												this.lblStatus.Size = new System.Drawing.Size(0, 13);
												this.lblStatus.TabIndex = 13;
												// 
												// btnSell
												// 
												this.btnSell.Location = new System.Drawing.Point(6, 109);
												this.btnSell.Name = "btnSell";
												this.btnSell.Size = new System.Drawing.Size(121, 23);
												this.btnSell.TabIndex = 12;
												this.btnSell.Text = "Sell car";
												this.btnSell.UseVisualStyleBackColor = true;
												this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
												// 
												// nudFuel
												// 
												this.nudFuel.Location = new System.Drawing.Point(6, 82);
												this.nudFuel.Name = "nudFuel";
												this.nudFuel.Size = new System.Drawing.Size(39, 20);
												this.nudFuel.TabIndex = 11;
												// 
												// btnAddFuel
												// 
												this.btnAddFuel.Location = new System.Drawing.Point(52, 79);
												this.btnAddFuel.Name = "btnAddFuel";
												this.btnAddFuel.Size = new System.Drawing.Size(75, 23);
												this.btnAddFuel.TabIndex = 10;
												this.btnAddFuel.Text = "Add fuel";
												this.btnAddFuel.UseVisualStyleBackColor = true;
												this.btnAddFuel.Click += new System.EventHandler(this.btnAddFuel_Click);
												// 
												// btnMaintenence
												// 
												this.btnMaintenence.Location = new System.Drawing.Point(6, 52);
												this.btnMaintenence.Name = "btnMaintenence";
												this.btnMaintenence.Size = new System.Drawing.Size(121, 23);
												this.btnMaintenence.TabIndex = 9;
												this.btnMaintenence.Text = "Toggle maintenence";
												this.btnMaintenence.UseVisualStyleBackColor = true;
												this.btnMaintenence.Click += new System.EventHandler(this.btnMaintenence_Click);
												// 
												// cbCar
												// 
												this.cbCar.FormattingEnabled = true;
												this.cbCar.Location = new System.Drawing.Point(6, 24);
												this.cbCar.Name = "cbCar";
												this.cbCar.Size = new System.Drawing.Size(121, 21);
												this.cbCar.TabIndex = 8;
												this.cbCar.SelectedIndexChanged += new System.EventHandler(this.cbCar_SelectedIndexChanged);
												// 
												// gbAdd
												// 
												this.gbAdd.Controls.Add(this.btnAddCar);
												this.gbAdd.Controls.Add(this.nudFuelLevel);
												this.gbAdd.Controls.Add(this.lblFuel);
												this.gbAdd.Controls.Add(this.lblLicence);
												this.gbAdd.Controls.Add(this.tbLicence);
												this.gbAdd.Location = new System.Drawing.Point(13, 13);
												this.gbAdd.Name = "gbAdd";
												this.gbAdd.Size = new System.Drawing.Size(270, 112);
												this.gbAdd.TabIndex = 9;
												this.gbAdd.TabStop = false;
												this.gbAdd.Text = "Add car";
												// 
												// tbLicence
												// 
												this.tbLicence.Location = new System.Drawing.Point(89, 17);
												this.tbLicence.Name = "tbLicence";
												this.tbLicence.Size = new System.Drawing.Size(174, 20);
												this.tbLicence.TabIndex = 0;
												// 
												// lblLicence
												// 
												this.lblLicence.AutoSize = true;
												this.lblLicence.Location = new System.Drawing.Point(7, 20);
												this.lblLicence.Name = "lblLicence";
												this.lblLicence.Size = new System.Drawing.Size(71, 13);
												this.lblLicence.TabIndex = 1;
												this.lblLicence.Text = "Licence plate";
												// 
												// lblFuel
												// 
												this.lblFuel.AutoSize = true;
												this.lblFuel.Location = new System.Drawing.Point(6, 46);
												this.lblFuel.Name = "lblFuel";
												this.lblFuel.Size = new System.Drawing.Size(72, 13);
												this.lblFuel.TabIndex = 2;
												this.lblFuel.Text = "Max fuel level";
												// 
												// nudFuelLevel
												// 
												this.nudFuelLevel.Location = new System.Drawing.Point(89, 44);
												this.nudFuelLevel.Name = "nudFuelLevel";
												this.nudFuelLevel.Size = new System.Drawing.Size(174, 20);
												this.nudFuelLevel.TabIndex = 4;
												// 
												// btnAddCar
												// 
												this.btnAddCar.Location = new System.Drawing.Point(6, 79);
												this.btnAddCar.Name = "btnAddCar";
												this.btnAddCar.Size = new System.Drawing.Size(258, 23);
												this.btnAddCar.TabIndex = 5;
												this.btnAddCar.Text = "Add car";
												this.btnAddCar.UseVisualStyleBackColor = true;
												this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
												// 
												// Form1
												// 
												this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
												this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
												this.ClientSize = new System.Drawing.Size(296, 307);
												this.Controls.Add(this.gbAdd);
												this.Controls.Add(this.gbManage);
												this.Name = "Form1";
												this.Text = "Form1";
												this.gbManage.ResumeLayout(false);
												this.gbManage.PerformLayout();
												((System.ComponentModel.ISupportInitialize)(this.nudKilomiter)).EndInit();
												((System.ComponentModel.ISupportInitialize)(this.pbSteer)).EndInit();
												((System.ComponentModel.ISupportInitialize)(this.nudFuel)).EndInit();
												this.gbAdd.ResumeLayout(false);
												this.gbAdd.PerformLayout();
												((System.ComponentModel.ISupportInitialize)(this.nudFuelLevel)).EndInit();
												this.ResumeLayout(false);

								}

								#endregion

								private System.Windows.Forms.GroupBox gbManage;
								private System.Windows.Forms.NumericUpDown nudKilomiter;
								private System.Windows.Forms.PictureBox pbSteer;
								private System.Windows.Forms.Label lblStatus;
								private System.Windows.Forms.Button btnSell;
								private System.Windows.Forms.NumericUpDown nudFuel;
								private System.Windows.Forms.Button btnAddFuel;
								private System.Windows.Forms.Button btnMaintenence;
								private System.Windows.Forms.ComboBox cbCar;
								private System.Windows.Forms.GroupBox gbAdd;
								private System.Windows.Forms.Label lblLicence;
								private System.Windows.Forms.TextBox tbLicence;
								private System.Windows.Forms.Button btnAddCar;
								private System.Windows.Forms.NumericUpDown nudFuelLevel;
								private System.Windows.Forms.Label lblFuel;
				}
}

