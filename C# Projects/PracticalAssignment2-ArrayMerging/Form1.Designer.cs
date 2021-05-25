namespace Week2PracticalAssignment2_ArrayMerging
{
    partial class ArrayMerging
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbC1 = new System.Windows.Forms.ListBox();
            this.lbC2 = new System.Windows.Forms.ListBox();
            this.btC1PlusC2 = new System.Windows.Forms.Button();
            this.lbAdd = new System.Windows.Forms.ListBox();
            this.lbMerge = new System.Windows.Forms.ListBox();
            this.lbDiff = new System.Windows.Forms.ListBox();
            this.lbIntersect = new System.Windows.Forms.ListBox();
            this.btInterMerge = new System.Windows.Forms.Button();
            this.btSymmetricDiff = new System.Windows.Forms.Button();
            this.btIntersection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "c1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "c2:";
            // 
            // lbC1
            // 
            this.lbC1.Enabled = false;
            this.lbC1.FormattingEnabled = true;
            this.lbC1.ItemHeight = 25;
            this.lbC1.Location = new System.Drawing.Point(18, 123);
            this.lbC1.Name = "lbC1";
            this.lbC1.Size = new System.Drawing.Size(100, 704);
            this.lbC1.TabIndex = 2;
            // 
            // lbC2
            // 
            this.lbC2.Enabled = false;
            this.lbC2.FormattingEnabled = true;
            this.lbC2.ItemHeight = 25;
            this.lbC2.Location = new System.Drawing.Point(141, 123);
            this.lbC2.Name = "lbC2";
            this.lbC2.Size = new System.Drawing.Size(100, 704);
            this.lbC2.TabIndex = 3;
            // 
            // btC1PlusC2
            // 
            this.btC1PlusC2.Location = new System.Drawing.Point(313, 27);
            this.btC1PlusC2.Name = "btC1PlusC2";
            this.btC1PlusC2.Size = new System.Drawing.Size(136, 71);
            this.btC1PlusC2.TabIndex = 4;
            this.btC1PlusC2.Text = "c1+c2";
            this.btC1PlusC2.UseVisualStyleBackColor = true;
            this.btC1PlusC2.Click += new System.EventHandler(this.BtC1PlusC2_Click);
            // 
            // lbAdd
            // 
            this.lbAdd.Enabled = false;
            this.lbAdd.FormattingEnabled = true;
            this.lbAdd.ItemHeight = 25;
            this.lbAdd.Location = new System.Drawing.Point(313, 123);
            this.lbAdd.Name = "lbAdd";
            this.lbAdd.Size = new System.Drawing.Size(136, 704);
            this.lbAdd.TabIndex = 5;
            // 
            // lbMerge
            // 
            this.lbMerge.Enabled = false;
            this.lbMerge.FormattingEnabled = true;
            this.lbMerge.ItemHeight = 25;
            this.lbMerge.Location = new System.Drawing.Point(457, 123);
            this.lbMerge.Name = "lbMerge";
            this.lbMerge.Size = new System.Drawing.Size(138, 704);
            this.lbMerge.TabIndex = 6;
            // 
            // lbDiff
            // 
            this.lbDiff.Enabled = false;
            this.lbDiff.FormattingEnabled = true;
            this.lbDiff.ItemHeight = 25;
            this.lbDiff.Location = new System.Drawing.Point(601, 123);
            this.lbDiff.Name = "lbDiff";
            this.lbDiff.Size = new System.Drawing.Size(138, 704);
            this.lbDiff.TabIndex = 7;
            // 
            // lbIntersect
            // 
            this.lbIntersect.Enabled = false;
            this.lbIntersect.FormattingEnabled = true;
            this.lbIntersect.ItemHeight = 25;
            this.lbIntersect.Location = new System.Drawing.Point(745, 123);
            this.lbIntersect.Name = "lbIntersect";
            this.lbIntersect.Size = new System.Drawing.Size(146, 704);
            this.lbIntersect.TabIndex = 8;
            // 
            // btInterMerge
            // 
            this.btInterMerge.Location = new System.Drawing.Point(457, 27);
            this.btInterMerge.Name = "btInterMerge";
            this.btInterMerge.Size = new System.Drawing.Size(138, 71);
            this.btInterMerge.TabIndex = 9;
            this.btInterMerge.Text = "InterMerge";
            this.btInterMerge.UseVisualStyleBackColor = true;
            this.btInterMerge.Click += new System.EventHandler(this.BtInterMerge_Click);
            // 
            // btSymmetricDiff
            // 
            this.btSymmetricDiff.Location = new System.Drawing.Point(601, 27);
            this.btSymmetricDiff.Name = "btSymmetricDiff";
            this.btSymmetricDiff.Size = new System.Drawing.Size(138, 71);
            this.btSymmetricDiff.TabIndex = 10;
            this.btSymmetricDiff.Text = "Symmetric Difference";
            this.btSymmetricDiff.UseVisualStyleBackColor = true;
            this.btSymmetricDiff.Click += new System.EventHandler(this.BtSymmetricDiff_Click);
            // 
            // btIntersection
            // 
            this.btIntersection.Location = new System.Drawing.Point(745, 27);
            this.btIntersection.Name = "btIntersection";
            this.btIntersection.Size = new System.Drawing.Size(146, 71);
            this.btIntersection.TabIndex = 11;
            this.btIntersection.Text = "Intersection";
            this.btIntersection.UseVisualStyleBackColor = true;
            this.btIntersection.Click += new System.EventHandler(this.BtIntersection_Click);
            // 
            // ArrayMerging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 860);
            this.Controls.Add(this.btIntersection);
            this.Controls.Add(this.btSymmetricDiff);
            this.Controls.Add(this.btInterMerge);
            this.Controls.Add(this.lbIntersect);
            this.Controls.Add(this.lbDiff);
            this.Controls.Add(this.lbMerge);
            this.Controls.Add(this.lbAdd);
            this.Controls.Add(this.btC1PlusC2);
            this.Controls.Add(this.lbC2);
            this.Controls.Add(this.lbC1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ArrayMerging";
            this.Text = "Array Merging";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbC1;
        private System.Windows.Forms.ListBox lbC2;
        private System.Windows.Forms.Button btC1PlusC2;
        private System.Windows.Forms.ListBox lbAdd;
        private System.Windows.Forms.ListBox lbMerge;
        private System.Windows.Forms.ListBox lbDiff;
        private System.Windows.Forms.ListBox lbIntersect;
        private System.Windows.Forms.Button btInterMerge;
        private System.Windows.Forms.Button btSymmetricDiff;
        private System.Windows.Forms.Button btIntersection;
    }
}

