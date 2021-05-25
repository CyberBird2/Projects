namespace Drawing_a_House_Delal
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
            this.pBHouse = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBHouse)).BeginInit();
            this.SuspendLayout();
            // 
            // pBHouse
            // 
            this.pBHouse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pBHouse.Location = new System.Drawing.Point(169, 12);
            this.pBHouse.Name = "pBHouse";
            this.pBHouse.Size = new System.Drawing.Size(619, 517);
            this.pBHouse.TabIndex = 0;
            this.pBHouse.TabStop = false;
            this.pBHouse.Click += new System.EventHandler(this.pBHouse_Click);
            this.pBHouse.Paint += new System.Windows.Forms.PaintEventHandler(this.pBHouse_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.pBHouse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBHouse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pBHouse;
    }
}

