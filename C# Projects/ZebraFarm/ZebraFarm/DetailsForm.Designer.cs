namespace ZebraFarm
{
    partial class DetailsForm
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
												this.gbxZebra = new System.Windows.Forms.GroupBox();
												this.tbxZebraName = new System.Windows.Forms.TextBox();
												this.btnUpdateAndClose = new System.Windows.Forms.Button();
												this.label1 = new System.Windows.Forms.Label();
												this.rbnZebraGenderUnknown = new System.Windows.Forms.RadioButton();
												this.label2 = new System.Windows.Forms.Label();
												this.rbnZebraGenderStallion = new System.Windows.Forms.RadioButton();
												this.rbnZebraGenderMare = new System.Windows.Forms.RadioButton();
												this.gbxZebra.SuspendLayout();
												this.SuspendLayout();
												// 
												// gbxZebra
												// 
												this.gbxZebra.Controls.Add(this.tbxZebraName);
												this.gbxZebra.Controls.Add(this.btnUpdateAndClose);
												this.gbxZebra.Controls.Add(this.label1);
												this.gbxZebra.Controls.Add(this.rbnZebraGenderUnknown);
												this.gbxZebra.Controls.Add(this.label2);
												this.gbxZebra.Controls.Add(this.rbnZebraGenderStallion);
												this.gbxZebra.Controls.Add(this.rbnZebraGenderMare);
												this.gbxZebra.Location = new System.Drawing.Point(12, 12);
												this.gbxZebra.Name = "gbxZebra";
												this.gbxZebra.Size = new System.Drawing.Size(217, 177);
												this.gbxZebra.TabIndex = 31;
												this.gbxZebra.TabStop = false;
												this.gbxZebra.Text = "Zebra with <id>";
												// 
												// tbxZebraName
												// 
												this.tbxZebraName.Location = new System.Drawing.Point(57, 30);
												this.tbxZebraName.Name = "tbxZebraName";
												this.tbxZebraName.Size = new System.Drawing.Size(144, 20);
												this.tbxZebraName.TabIndex = 25;
												// 
												// btnUpdateAndClose
												// 
												this.btnUpdateAndClose.Location = new System.Drawing.Point(12, 138);
												this.btnUpdateAndClose.Name = "btnUpdateAndClose";
												this.btnUpdateAndClose.Size = new System.Drawing.Size(189, 23);
												this.btnUpdateAndClose.TabIndex = 29;
												this.btnUpdateAndClose.Text = "Update zebra and close form";
												this.btnUpdateAndClose.UseVisualStyleBackColor = true;
												this.btnUpdateAndClose.Click += new System.EventHandler(this.btnUpdateAndClose_Click);
												// 
												// label1
												// 
												this.label1.AutoSize = true;
												this.label1.Location = new System.Drawing.Point(12, 33);
												this.label1.Name = "label1";
												this.label1.Size = new System.Drawing.Size(38, 13);
												this.label1.TabIndex = 23;
												this.label1.Text = "Name:";
												// 
												// rbnZebraGenderUnknown
												// 
												this.rbnZebraGenderUnknown.AutoSize = true;
												this.rbnZebraGenderUnknown.Location = new System.Drawing.Point(57, 110);
												this.rbnZebraGenderUnknown.Name = "rbnZebraGenderUnknown";
												this.rbnZebraGenderUnknown.Size = new System.Drawing.Size(71, 17);
												this.rbnZebraGenderUnknown.TabIndex = 28;
												this.rbnZebraGenderUnknown.TabStop = true;
												this.rbnZebraGenderUnknown.Text = "Unknown";
												this.rbnZebraGenderUnknown.UseVisualStyleBackColor = true;
												// 
												// label2
												// 
												this.label2.AutoSize = true;
												this.label2.Location = new System.Drawing.Point(12, 64);
												this.label2.Name = "label2";
												this.label2.Size = new System.Drawing.Size(45, 13);
												this.label2.TabIndex = 24;
												this.label2.Text = "Gender:";
												// 
												// rbnZebraGenderStallion
												// 
												this.rbnZebraGenderStallion.AutoSize = true;
												this.rbnZebraGenderStallion.Location = new System.Drawing.Point(57, 87);
												this.rbnZebraGenderStallion.Name = "rbnZebraGenderStallion";
												this.rbnZebraGenderStallion.Size = new System.Drawing.Size(59, 17);
												this.rbnZebraGenderStallion.TabIndex = 27;
												this.rbnZebraGenderStallion.TabStop = true;
												this.rbnZebraGenderStallion.Text = "Stallion";
												this.rbnZebraGenderStallion.UseVisualStyleBackColor = true;
												// 
												// rbnZebraGenderMare
												// 
												this.rbnZebraGenderMare.AutoSize = true;
												this.rbnZebraGenderMare.Location = new System.Drawing.Point(57, 64);
												this.rbnZebraGenderMare.Name = "rbnZebraGenderMare";
												this.rbnZebraGenderMare.Size = new System.Drawing.Size(49, 17);
												this.rbnZebraGenderMare.TabIndex = 26;
												this.rbnZebraGenderMare.TabStop = true;
												this.rbnZebraGenderMare.Text = "Mare";
												this.rbnZebraGenderMare.UseVisualStyleBackColor = true;
												// 
												// DetailsForm
												// 
												this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
												this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
												this.ClientSize = new System.Drawing.Size(241, 201);
												this.Controls.Add(this.gbxZebra);
												this.Name = "DetailsForm";
												this.Text = "DetailsForm";
												this.gbxZebra.ResumeLayout(false);
												this.gbxZebra.PerformLayout();
												this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxZebra;
        private System.Windows.Forms.TextBox tbxZebraName;
        private System.Windows.Forms.Button btnUpdateAndClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbnZebraGenderUnknown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbnZebraGenderStallion;
        private System.Windows.Forms.RadioButton rbnZebraGenderMare;
    }
}