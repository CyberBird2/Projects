namespace Agenda
{
    partial class WeeklyAgendaForm
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
            this.tbNote = new System.Windows.Forms.TextBox();
            this.cbDay = new System.Windows.Forms.ComboBox();
            this.btnAppointment = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbEndDay = new System.Windows.Forms.ComboBox();
            this.cbStartDay = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbAppointments = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbNote);
            this.groupBox1.Controls.Add(this.cbDay);
            this.groupBox1.Controls.Add(this.btnAppointment);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Appointment";
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(50, 46);
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(139, 20);
            this.tbNote.TabIndex = 3;
            // 
            // cbDay
            // 
            this.cbDay.FormattingEnabled = true;
            this.cbDay.Location = new System.Drawing.Point(41, 19);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(92, 21);
            this.cbDay.TabIndex = 0;
            // 
            // btnAppointment
            // 
            this.btnAppointment.Location = new System.Drawing.Point(6, 78);
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.Size = new System.Drawing.Size(183, 23);
            this.btnAppointment.TabIndex = 4;
            this.btnAppointment.Text = "&Add Appointment";
            this.btnAppointment.UseVisualStyleBackColor = true;
            this.btnAppointment.Click += new System.EventHandler(this.btnAppointment_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Notes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Day:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbEndDay);
            this.groupBox2.Controls.Add(this.cbStartDay);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 104);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Appointments";
            // 
            // cbEndDay
            // 
            this.cbEndDay.FormattingEnabled = true;
            this.cbEndDay.Location = new System.Drawing.Point(64, 51);
            this.cbEndDay.Name = "cbEndDay";
            this.cbEndDay.Size = new System.Drawing.Size(92, 21);
            this.cbEndDay.TabIndex = 6;
            // 
            // cbStartDay
            // 
            this.cbStartDay.FormattingEnabled = true;
            this.cbStartDay.Location = new System.Drawing.Point(64, 24);
            this.cbStartDay.Name = "cbStartDay";
            this.cbStartDay.Size = new System.Drawing.Size(92, 21);
            this.cbStartDay.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(6, 78);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "&Search by days";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "End day:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Start day:";
            // 
            // lbAppointments
            // 
            this.lbAppointments.FormattingEnabled = true;
            this.lbAppointments.Location = new System.Drawing.Point(12, 122);
            this.lbAppointments.Name = "lbAppointments";
            this.lbAppointments.Size = new System.Drawing.Size(375, 147);
            this.lbAppointments.TabIndex = 8;
            // 
            // AgendaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 280);
            this.Controls.Add(this.lbAppointments);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AgendaForm";
            this.Text = "Weekly Agenda";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.ComboBox cbDay;
        private System.Windows.Forms.Button btnAppointment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbEndDay;
        private System.Windows.Forms.ComboBox cbStartDay;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbAppointments;
    }
}

