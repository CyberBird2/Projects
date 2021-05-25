namespace Week_3_Assignment_3._2._3_Increment
{
    partial class BankAccountManagement
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
            this.btnWithdrawn = new System.Windows.Forms.Button();
            this.tbAmountWithDrawn = new System.Windows.Forms.TextBox();
            this.lblAmountWithDrawn = new System.Windows.Forms.Label();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.lblAccountNr = new System.Windows.Forms.Label();
            this.tbAmountDeposit = new System.Windows.Forms.TextBox();
            this.lblDepositAmount = new System.Windows.Forms.Label();
            this.tbAccountNr = new System.Windows.Forms.TextBox();
            this.btnAccountNumber = new System.Windows.Forms.Button();
            this.lbInfo = new System.Windows.Forms.ListBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.tbClient = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblChoose = new System.Windows.Forms.Label();
            this.lbTransactions = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbBankAccounts = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnWithdrawn
            // 
            this.btnWithdrawn.Location = new System.Drawing.Point(28, 390);
            this.btnWithdrawn.Name = "btnWithdrawn";
            this.btnWithdrawn.Size = new System.Drawing.Size(247, 37);
            this.btnWithdrawn.TabIndex = 3;
            this.btnWithdrawn.Text = "WithDrawn";
            this.btnWithdrawn.UseVisualStyleBackColor = true;
            this.btnWithdrawn.Click += new System.EventHandler(this.btnWithdrawn_Click);
            // 
            // tbAmountWithDrawn
            // 
            this.tbAmountWithDrawn.Location = new System.Drawing.Point(150, 353);
            this.tbAmountWithDrawn.Name = "tbAmountWithDrawn";
            this.tbAmountWithDrawn.Size = new System.Drawing.Size(118, 22);
            this.tbAmountWithDrawn.TabIndex = 0;
            // 
            // lblAmountWithDrawn
            // 
            this.lblAmountWithDrawn.AutoSize = true;
            this.lblAmountWithDrawn.Location = new System.Drawing.Point(13, 356);
            this.lblAmountWithDrawn.Name = "lblAmountWithDrawn";
            this.lblAmountWithDrawn.Size = new System.Drawing.Size(126, 17);
            this.lblAmountWithDrawn.TabIndex = 4;
            this.lblAmountWithDrawn.Text = "Amount Withdrawn";
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(21, 288);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(247, 40);
            this.btnDeposit.TabIndex = 2;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // lblAccountNr
            // 
            this.lblAccountNr.AutoSize = true;
            this.lblAccountNr.Location = new System.Drawing.Point(12, 12);
            this.lblAccountNr.Name = "lblAccountNr";
            this.lblAccountNr.Size = new System.Drawing.Size(109, 17);
            this.lblAccountNr.TabIndex = 2;
            this.lblAccountNr.Text = "AccountNumber";
            // 
            // tbAmountDeposit
            // 
            this.tbAmountDeposit.Location = new System.Drawing.Point(127, 236);
            this.tbAmountDeposit.Name = "tbAmountDeposit";
            this.tbAmountDeposit.Size = new System.Drawing.Size(141, 22);
            this.tbAmountDeposit.TabIndex = 1;
            // 
            // lblDepositAmount
            // 
            this.lblDepositAmount.AutoSize = true;
            this.lblDepositAmount.Location = new System.Drawing.Point(13, 239);
            this.lblDepositAmount.Name = "lblDepositAmount";
            this.lblDepositAmount.Size = new System.Drawing.Size(108, 17);
            this.lblDepositAmount.TabIndex = 5;
            this.lblDepositAmount.Text = "Amount Deposit";
            // 
            // tbAccountNr
            // 
            this.tbAccountNr.Location = new System.Drawing.Point(150, 12);
            this.tbAccountNr.Name = "tbAccountNr";
            this.tbAccountNr.Size = new System.Drawing.Size(100, 22);
            this.tbAccountNr.TabIndex = 1;
            // 
            // btnAccountNumber
            // 
            this.btnAccountNumber.Location = new System.Drawing.Point(15, 90);
            this.btnAccountNumber.Name = "btnAccountNumber";
            this.btnAccountNumber.Size = new System.Drawing.Size(246, 41);
            this.btnAccountNumber.TabIndex = 0;
            this.btnAccountNumber.Text = "Create Account";
            this.btnAccountNumber.UseVisualStyleBackColor = true;
            this.btnAccountNumber.Click += new System.EventHandler(this.btnAccountNumber_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.FormattingEnabled = true;
            this.lbInfo.ItemHeight = 16;
            this.lbInfo.Location = new System.Drawing.Point(365, 21);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(574, 132);
            this.lbInfo.TabIndex = 0;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(25, 47);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(84, 17);
            this.lblClient.TabIndex = 2;
            this.lblClient.Text = "Client Name";
            // 
            // tbClient
            // 
            this.tbClient.Location = new System.Drawing.Point(150, 44);
            this.tbClient.Name = "tbClient";
            this.tbClient.Size = new System.Drawing.Size(100, 22);
            this.tbClient.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(172, 158);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(149, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.Location = new System.Drawing.Point(12, 161);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(145, 17);
            this.lblChoose.TabIndex = 7;
            this.lblChoose.Text = "Choose Your Account";
            // 
            // lbTransactions
            // 
            this.lbTransactions.FormattingEnabled = true;
            this.lbTransactions.ItemHeight = 16;
            this.lbTransactions.Location = new System.Drawing.Point(365, 224);
            this.lbTransactions.Name = "lbTransactions";
            this.lbTransactions.Size = new System.Drawing.Size(578, 180);
            this.lbTransactions.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 9;
            // 
            // lbBankAccounts
            // 
            this.lbBankAccounts.AutoSize = true;
            this.lbBankAccounts.Location = new System.Drawing.Point(589, 178);
            this.lbBankAccounts.Name = "lbBankAccounts";
            this.lbBankAccounts.Size = new System.Drawing.Size(98, 17);
            this.lbBankAccounts.TabIndex = 10;
            this.lbBankAccounts.Text = "BankAccounts";
            // 
            // BankAccountManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 450);
            this.Controls.Add(this.lbBankAccounts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTransactions);
            this.Controls.Add(this.lblChoose);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.lblAmountWithDrawn);
            this.Controls.Add(this.tbAmountWithDrawn);
            this.Controls.Add(this.lblDepositAmount);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.btnWithdrawn);
            this.Controls.Add(this.tbClient);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnAccountNumber);
            this.Controls.Add(this.tbAmountDeposit);
            this.Controls.Add(this.lblAccountNr);
            this.Controls.Add(this.tbAccountNr);
            this.Name = "BankAccountManagement";
            this.Text = "BankAccountManagement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAccountNr;
        private System.Windows.Forms.TextBox tbAccountNr;
        private System.Windows.Forms.Button btnAccountNumber;
        private System.Windows.Forms.Label lblDepositAmount;
        private System.Windows.Forms.Label lblAmountWithDrawn;
        private System.Windows.Forms.Button btnWithdrawn;
        private System.Windows.Forms.TextBox tbAmountDeposit;
        private System.Windows.Forms.TextBox tbAmountWithDrawn;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.ListBox lbInfo;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.TextBox tbClient;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.ListBox lbTransactions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbBankAccounts;
    }
}

