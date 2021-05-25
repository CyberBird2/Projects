namespace assignment_1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudAmountOfSeats = new System.Windows.Forms.NumericUpDown();
            this.btAddFlight = new System.Windows.Forms.Button();
            this.tbCostPerSeat = new System.Windows.Forms.TextBox();
            this.tbDestination = new System.Windows.Forms.TextBox();
            this.tbFlightNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btBookSeat = new System.Windows.Forms.Button();
            this.tbBookFlightNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbAvailableFlights = new System.Windows.Forms.ListBox();
            this.gbProfit = new System.Windows.Forms.GroupBox();
            this.tbProfit = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbFullFlights = new System.Windows.Forms.ListBox();
            this.btnProfit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountOfSeats)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gbProfit.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudAmountOfSeats);
            this.groupBox1.Controls.Add(this.btAddFlight);
            this.groupBox1.Controls.Add(this.tbCostPerSeat);
            this.groupBox1.Controls.Add(this.tbDestination);
            this.groupBox1.Controls.Add(this.tbFlightNo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(333, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add new Flight";
            // 
            // nudAmountOfSeats
            // 
            this.nudAmountOfSeats.Location = new System.Drawing.Point(145, 84);
            this.nudAmountOfSeats.Margin = new System.Windows.Forms.Padding(4);
            this.nudAmountOfSeats.Name = "nudAmountOfSeats";
            this.nudAmountOfSeats.Size = new System.Drawing.Size(160, 22);
            this.nudAmountOfSeats.TabIndex = 9;
            // 
            // btAddFlight
            // 
            this.btAddFlight.Location = new System.Drawing.Point(13, 156);
            this.btAddFlight.Margin = new System.Windows.Forms.Padding(4);
            this.btAddFlight.Name = "btAddFlight";
            this.btAddFlight.Size = new System.Drawing.Size(292, 28);
            this.btAddFlight.TabIndex = 8;
            this.btAddFlight.Text = "Add Flight";
            this.btAddFlight.UseVisualStyleBackColor = true;
            this.btAddFlight.Click += new System.EventHandler(this.btAddFlight_Click);
            // 
            // tbCostPerSeat
            // 
            this.tbCostPerSeat.Location = new System.Drawing.Point(145, 124);
            this.tbCostPerSeat.Margin = new System.Windows.Forms.Padding(4);
            this.tbCostPerSeat.Name = "tbCostPerSeat";
            this.tbCostPerSeat.Size = new System.Drawing.Size(159, 22);
            this.tbCostPerSeat.TabIndex = 7;
            // 
            // tbDestination
            // 
            this.tbDestination.Location = new System.Drawing.Point(145, 50);
            this.tbDestination.Margin = new System.Windows.Forms.Padding(4);
            this.tbDestination.Name = "tbDestination";
            this.tbDestination.Size = new System.Drawing.Size(159, 22);
            this.tbDestination.TabIndex = 5;
            // 
            // tbFlightNo
            // 
            this.tbFlightNo.Location = new System.Drawing.Point(145, 15);
            this.tbFlightNo.Margin = new System.Windows.Forms.Padding(4);
            this.tbFlightNo.Name = "tbFlightNo";
            this.tbFlightNo.Size = new System.Drawing.Size(159, 22);
            this.tbFlightNo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 127);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "uFly cost per seat:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount of seats:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destination:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flight number:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btBookSeat);
            this.groupBox2.Controls.Add(this.tbBookFlightNo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lbAvailableFlights);
            this.groupBox2.Location = new System.Drawing.Point(373, 31);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(593, 202);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Available Flight";
            // 
            // btBookSeat
            // 
            this.btBookSeat.Location = new System.Drawing.Point(347, 162);
            this.btBookSeat.Margin = new System.Windows.Forms.Padding(4);
            this.btBookSeat.Name = "btBookSeat";
            this.btBookSeat.Size = new System.Drawing.Size(176, 28);
            this.btBookSeat.TabIndex = 3;
            this.btBookSeat.Text = "Book seat";
            this.btBookSeat.UseVisualStyleBackColor = true;
            this.btBookSeat.Click += new System.EventHandler(this.btBookSeat_Click);
            // 
            // tbBookFlightNo
            // 
            this.tbBookFlightNo.Location = new System.Drawing.Point(151, 166);
            this.tbBookFlightNo.Margin = new System.Windows.Forms.Padding(4);
            this.tbBookFlightNo.Name = "tbBookFlightNo";
            this.tbBookFlightNo.Size = new System.Drawing.Size(132, 22);
            this.tbBookFlightNo.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 169);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Flight number:";
            // 
            // lbAvailableFlights
            // 
            this.lbAvailableFlights.FormattingEnabled = true;
            this.lbAvailableFlights.ItemHeight = 16;
            this.lbAvailableFlights.Location = new System.Drawing.Point(9, 25);
            this.lbAvailableFlights.Margin = new System.Windows.Forms.Padding(4);
            this.lbAvailableFlights.Name = "lbAvailableFlights";
            this.lbAvailableFlights.Size = new System.Drawing.Size(575, 116);
            this.lbAvailableFlights.TabIndex = 0;
            // 
            // gbProfit
            // 
            this.gbProfit.Controls.Add(this.tbProfit);
            this.gbProfit.Location = new System.Drawing.Point(17, 226);
            this.gbProfit.Margin = new System.Windows.Forms.Padding(4);
            this.gbProfit.Name = "gbProfit";
            this.gbProfit.Padding = new System.Windows.Forms.Padding(4);
            this.gbProfit.Size = new System.Drawing.Size(333, 208);
            this.gbProfit.TabIndex = 2;
            this.gbProfit.TabStop = false;
            this.gbProfit.Text = "Profit";
            // 
            // tbProfit
            // 
            this.tbProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProfit.Location = new System.Drawing.Point(13, 23);
            this.tbProfit.Margin = new System.Windows.Forms.Padding(4);
            this.tbProfit.Multiline = true;
            this.tbProfit.Name = "tbProfit";
            this.tbProfit.Size = new System.Drawing.Size(312, 163);
            this.tbProfit.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbFullFlights);
            this.groupBox4.Location = new System.Drawing.Point(373, 265);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(593, 208);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Full Flight";
            // 
            // lbFullFlights
            // 
            this.lbFullFlights.FormattingEnabled = true;
            this.lbFullFlights.ItemHeight = 16;
            this.lbFullFlights.Location = new System.Drawing.Point(8, 25);
            this.lbFullFlights.Margin = new System.Windows.Forms.Padding(4);
            this.lbFullFlights.Name = "lbFullFlights";
            this.lbFullFlights.Size = new System.Drawing.Size(575, 180);
            this.lbFullFlights.TabIndex = 0;
            // 
            // btnProfit
            // 
            this.btnProfit.Location = new System.Drawing.Point(29, 441);
            this.btnProfit.Name = "btnProfit";
            this.btnProfit.Size = new System.Drawing.Size(292, 32);
            this.btnProfit.TabIndex = 4;
            this.btnProfit.Text = "Profit";
            this.btnProfit.UseVisualStyleBackColor = true;
            this.btnProfit.Click += new System.EventHandler(this.btnProfit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 554);
            this.Controls.Add(this.btnProfit);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gbProfit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountOfSeats)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbProfit.ResumeLayout(false);
            this.gbProfit.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btAddFlight;
        private System.Windows.Forms.TextBox tbCostPerSeat;
        private System.Windows.Forms.TextBox tbDestination;
        private System.Windows.Forms.TextBox tbFlightNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btBookSeat;
        private System.Windows.Forms.TextBox tbBookFlightNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbAvailableFlights;
        private System.Windows.Forms.GroupBox gbProfit;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lbFullFlights;
        private System.Windows.Forms.NumericUpDown nudAmountOfSeats;
        private System.Windows.Forms.TextBox tbProfit;
        private System.Windows.Forms.Button btnProfit;
    }
}

