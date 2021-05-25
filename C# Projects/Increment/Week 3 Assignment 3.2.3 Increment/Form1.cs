using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_3_Assignment_3._2._3_Increment
{
    public partial class BankAccountManagement : Form
    {
       
        BankAccount MyBankAccount;
        BankAccount BanKKK;
       
        
        public BankAccountManagement()
        {
            InitializeComponent();

           
        }
        private void btnAccountNumber_Click(object sender, EventArgs e)
        {
            int accountNr = Convert.ToInt32(tbAccountNr.Text);
            string client = tbClient.Text;

            
           
                     
           
           
            bool containsitem = false;        
            foreach (int item in comboBox1.Items)
            {
                if (comboBox1.Items.Contains(accountNr))
                {
                    MessageBox.Show("This Account Number Already Exist");
                    containsitem = true;
                }             
            }
            if (!containsitem)
            {
                MyBankAccount = new BankAccount(client, accountNr);
                lbInfo.Items.Add(MyBankAccount.GetInfo().ToString());
                comboBox1.Items.Add(accountNr);
                MyBankAccount.ClientName = client;
                MyBankAccount.AddAcount(accountNr);

            }

            lbBankAccounts.Text = BankAccount.GetCount().ToString();

        }
        private void btnWithdrawn_Click(object sender, EventArgs e)
        {
            lbInfo.Items.Clear();
            double amount = Convert.ToDouble(tbAmountWithDrawn.Text);
            int accountNumber = Convert.ToInt32(comboBox1.SelectedItem);
            MyBankAccount.WithDraw(amount, accountNumber);
            lbInfo.Items.Add(MyBankAccount.GetInfo().ToString());

            lbTransactions.Items.Add(MyBankAccount.GetTransactions().ToString());
        }
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            lbInfo.Items.Clear();
            double amount = Convert.ToDouble(tbAmountDeposit.Text);
            int accountNumber = Convert.ToInt32(comboBox1.SelectedItem);
            MyBankAccount.Deposit(amount, accountNumber);
            lbInfo.Items.Add(MyBankAccount.GetInfo().ToString());

            lbTransactions.Items.Add(MyBankAccount.GetTransactions().ToString());

        
        }
       
    }
}
