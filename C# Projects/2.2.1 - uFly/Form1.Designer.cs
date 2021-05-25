namespace _2._2._1___uFly
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
												this.gbAddFlight = new System.Windows.Forms.GroupBox();
												this.nudSeats = new System.Windows.Forms.NumericUpDown();
												this.label2 = new System.Windows.Forms.Label();
												this.lblSeatamount = new System.Windows.Forms.Label();
												this.lblDestination = new System.Windows.Forms.Label();
												this.btnAddflight = new System.Windows.Forms.Button();
												this.tbCostperseat = new System.Windows.Forms.TextBox();
												this.tbDestination = new System.Windows.Forms.TextBox();
												this.lblFlightnumber = new System.Windows.Forms.Label();
												this.tbFlightnumber = new System.Windows.Forms.TextBox();
												this.gbProfit = new System.Windows.Forms.GroupBox();
												this.rtbProfit = new System.Windows.Forms.RichTextBox();
												this.gbAvailableflights = new System.Windows.Forms.GroupBox();
												this.btnBook = new System.Windows.Forms.Button();
												this.lbFlights = new System.Windows.Forms.ListBox();
												this.gbFull = new System.Windows.Forms.GroupBox();
												this.lbFull = new System.Windows.Forms.ListBox();
												this.nudBookSeats = new System.Windows.Forms.NumericUpDown();
												this.gbAddFlight.SuspendLayout();
												((System.ComponentModel.ISupportInitialize)(this.nudSeats)).BeginInit();
												this.gbProfit.SuspendLayout();
												this.gbAvailableflights.SuspendLayout();
												this.gbFull.SuspendLayout();
												((System.ComponentModel.ISupportInitialize)(this.nudBookSeats)).BeginInit();
												this.SuspendLayout();
												// 
												// gbAddFlight
												// 
												this.gbAddFlight.Controls.Add(this.nudSeats);
												this.gbAddFlight.Controls.Add(this.label2);
												this.gbAddFlight.Controls.Add(this.lblSeatamount);
												this.gbAddFlight.Controls.Add(this.lblDestination);
												this.gbAddFlight.Controls.Add(this.btnAddflight);
												this.gbAddFlight.Controls.Add(this.tbCostperseat);
												this.gbAddFlight.Controls.Add(this.tbDestination);
												this.gbAddFlight.Controls.Add(this.lblFlightnumber);
												this.gbAddFlight.Controls.Add(this.tbFlightnumber);
												this.gbAddFlight.Location = new System.Drawing.Point(13, 13);
												this.gbAddFlight.Name = "gbAddFlight";
												this.gbAddFlight.Size = new System.Drawing.Size(225, 160);
												this.gbAddFlight.TabIndex = 0;
												this.gbAddFlight.TabStop = false;
												this.gbAddFlight.Text = "Add new Flight";
												// 
												// nudSeats
												// 
												this.nudSeats.Location = new System.Drawing.Point(120, 74);
												this.nudSeats.Name = "nudSeats";
												this.nudSeats.Size = new System.Drawing.Size(99, 20);
												this.nudSeats.TabIndex = 3;
												this.nudSeats.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
												// 
												// label2
												// 
												this.label2.AutoSize = true;
												this.label2.Location = new System.Drawing.Point(20, 104);
												this.label2.Name = "label2";
												this.label2.Size = new System.Drawing.Size(93, 13);
												this.label2.TabIndex = 8;
												this.label2.Text = "uFly cost per seat:";
												// 
												// lblSeatamount
												// 
												this.lblSeatamount.AutoSize = true;
												this.lblSeatamount.Location = new System.Drawing.Point(27, 76);
												this.lblSeatamount.Name = "lblSeatamount";
												this.lblSeatamount.Size = new System.Drawing.Size(86, 13);
												this.lblSeatamount.TabIndex = 7;
												this.lblSeatamount.Text = "Amount of seats:";
												// 
												// lblDestination
												// 
												this.lblDestination.AutoSize = true;
												this.lblDestination.Location = new System.Drawing.Point(50, 50);
												this.lblDestination.Name = "lblDestination";
												this.lblDestination.Size = new System.Drawing.Size(63, 13);
												this.lblDestination.TabIndex = 6;
												this.lblDestination.Text = "Destination:";
												// 
												// btnAddflight
												// 
												this.btnAddflight.Location = new System.Drawing.Point(6, 128);
												this.btnAddflight.Name = "btnAddflight";
												this.btnAddflight.Size = new System.Drawing.Size(213, 23);
												this.btnAddflight.TabIndex = 5;
												this.btnAddflight.Text = "Add Flight";
												this.btnAddflight.UseVisualStyleBackColor = true;
												this.btnAddflight.Click += new System.EventHandler(this.btnAddflight_Click);
												// 
												// tbCostperseat
												// 
												this.tbCostperseat.Location = new System.Drawing.Point(119, 101);
												this.tbCostperseat.Name = "tbCostperseat";
												this.tbCostperseat.Size = new System.Drawing.Size(100, 20);
												this.tbCostperseat.TabIndex = 4;
												this.tbCostperseat.Text = "50";
												// 
												// tbDestination
												// 
												this.tbDestination.Location = new System.Drawing.Point(119, 47);
												this.tbDestination.Name = "tbDestination";
												this.tbDestination.Size = new System.Drawing.Size(100, 20);
												this.tbDestination.TabIndex = 2;
												this.tbDestination.Text = "Milan";
												// 
												// lblFlightnumber
												// 
												this.lblFlightnumber.AutoSize = true;
												this.lblFlightnumber.Location = new System.Drawing.Point(40, 22);
												this.lblFlightnumber.Name = "lblFlightnumber";
												this.lblFlightnumber.Size = new System.Drawing.Size(73, 13);
												this.lblFlightnumber.TabIndex = 1;
												this.lblFlightnumber.Text = "Flight number:";
												// 
												// tbFlightnumber
												// 
												this.tbFlightnumber.Location = new System.Drawing.Point(119, 19);
												this.tbFlightnumber.Name = "tbFlightnumber";
												this.tbFlightnumber.Size = new System.Drawing.Size(100, 20);
												this.tbFlightnumber.TabIndex = 0;
												this.tbFlightnumber.Text = "KL4567";
												// 
												// gbProfit
												// 
												this.gbProfit.Controls.Add(this.rtbProfit);
												this.gbProfit.Location = new System.Drawing.Point(13, 180);
												this.gbProfit.Name = "gbProfit";
												this.gbProfit.Size = new System.Drawing.Size(225, 164);
												this.gbProfit.TabIndex = 1;
												this.gbProfit.TabStop = false;
												this.gbProfit.Text = "Profit";
												// 
												// rtbProfit
												// 
												this.rtbProfit.Location = new System.Drawing.Point(6, 19);
												this.rtbProfit.Name = "rtbProfit";
												this.rtbProfit.ReadOnly = true;
												this.rtbProfit.Size = new System.Drawing.Size(213, 135);
												this.rtbProfit.TabIndex = 1;
												this.rtbProfit.Text = "";
												// 
												// gbAvailableflights
												// 
												this.gbAvailableflights.Controls.Add(this.nudBookSeats);
												this.gbAvailableflights.Controls.Add(this.btnBook);
												this.gbAvailableflights.Controls.Add(this.lbFlights);
												this.gbAvailableflights.Location = new System.Drawing.Point(245, 13);
												this.gbAvailableflights.Name = "gbAvailableflights";
												this.gbAvailableflights.Size = new System.Drawing.Size(329, 160);
												this.gbAvailableflights.TabIndex = 2;
												this.gbAvailableflights.TabStop = false;
												this.gbAvailableflights.Text = "Available flights";
												// 
												// btnBook
												// 
												this.btnBook.Location = new System.Drawing.Point(7, 131);
												this.btnBook.Name = "btnBook";
												this.btnBook.Size = new System.Drawing.Size(113, 23);
												this.btnBook.TabIndex = 1;
												this.btnBook.Text = "Book seat";
												this.btnBook.UseVisualStyleBackColor = true;
												this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
												// 
												// lbFlights
												// 
												this.lbFlights.FormattingEnabled = true;
												this.lbFlights.Location = new System.Drawing.Point(7, 20);
												this.lbFlights.Name = "lbFlights";
												this.lbFlights.Size = new System.Drawing.Size(316, 108);
												this.lbFlights.TabIndex = 0;
												// 
												// gbFull
												// 
												this.gbFull.Controls.Add(this.lbFull);
												this.gbFull.Location = new System.Drawing.Point(245, 180);
												this.gbFull.Name = "gbFull";
												this.gbFull.Size = new System.Drawing.Size(329, 160);
												this.gbFull.TabIndex = 3;
												this.gbFull.TabStop = false;
												this.gbFull.Text = "Full flights";
												// 
												// lbFull
												// 
												this.lbFull.FormattingEnabled = true;
												this.lbFull.Location = new System.Drawing.Point(7, 20);
												this.lbFull.Name = "lbFull";
												this.lbFull.Size = new System.Drawing.Size(316, 134);
												this.lbFull.TabIndex = 0;
												// 
												// nudBookSeats
												// 
												this.nudBookSeats.Location = new System.Drawing.Point(126, 134);
												this.nudBookSeats.Name = "nudBookSeats";
												this.nudBookSeats.Size = new System.Drawing.Size(38, 20);
												this.nudBookSeats.TabIndex = 2;
												// 
												// Form1
												// 
												this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
												this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
												this.ClientSize = new System.Drawing.Size(584, 352);
												this.Controls.Add(this.gbFull);
												this.Controls.Add(this.gbAvailableflights);
												this.Controls.Add(this.gbProfit);
												this.Controls.Add(this.gbAddFlight);
												this.Name = "Form1";
												this.Text = "uFly";
												this.gbAddFlight.ResumeLayout(false);
												this.gbAddFlight.PerformLayout();
												((System.ComponentModel.ISupportInitialize)(this.nudSeats)).EndInit();
												this.gbProfit.ResumeLayout(false);
												this.gbAvailableflights.ResumeLayout(false);
												this.gbFull.ResumeLayout(false);
												((System.ComponentModel.ISupportInitialize)(this.nudBookSeats)).EndInit();
												this.ResumeLayout(false);

								}

								#endregion

								private System.Windows.Forms.GroupBox gbAddFlight;
								private System.Windows.Forms.Label label2;
								private System.Windows.Forms.Label lblSeatamount;
								private System.Windows.Forms.Label lblDestination;
								private System.Windows.Forms.Button btnAddflight;
								private System.Windows.Forms.TextBox tbCostperseat;
								private System.Windows.Forms.TextBox tbDestination;
								private System.Windows.Forms.Label lblFlightnumber;
								private System.Windows.Forms.TextBox tbFlightnumber;
								private System.Windows.Forms.NumericUpDown nudSeats;
								private System.Windows.Forms.GroupBox gbProfit;
								private System.Windows.Forms.GroupBox gbAvailableflights;
								private System.Windows.Forms.Button btnBook;
								private System.Windows.Forms.ListBox lbFlights;
								private System.Windows.Forms.GroupBox gbFull;
								private System.Windows.Forms.ListBox lbFull;
								private System.Windows.Forms.RichTextBox rtbProfit;
								private System.Windows.Forms.NumericUpDown nudBookSeats;
				}
}

