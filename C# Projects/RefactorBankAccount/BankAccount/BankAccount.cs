using System;
using System.Collections.Generic;

namespace BankAccount
{
    public class BankAccount
    {
        private string clientName;
        private int accountNr;
        private double balance;
        private List<double> transactions;

        public BankAccount(string clientName, int accountNr)
        {
            this.clientName = clientName;
            this.accountNr = accountNr;
            this.transactions = new List<double>();
        }

        public string GetClientName()
        { return this.clientName; }

        public int GetAccountNr()
        { return this.accountNr; }

        public double GetBalance()
        { return this.balance; }
        private void setBalance(double nwBalance)
        {
            if (nwBalance >= 0)
            {
                this.balance = nwBalance;
            }
        }
        
        public string GetTransactions()
        {
            string label = this.transactions.Count + " transaction(s):" + Environment.NewLine;
            string typeOfTransaction;
            foreach (double t in this.transactions)
            {
                if (t >= 0)
                { typeOfTransaction = " deposited"; }
                else
                { typeOfTransaction = " withdrawn"; }
                label += t + typeOfTransaction + Environment.NewLine;
            }
            return label;
        }

        public bool Deposit(double amount)
        {
            if (amount > 0)
            {
                this.setBalance(this.GetBalance() + amount);
                this.transactions.Add(amount);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Withdraw(double amount)
        {
            if (this.GetBalance() - amount > 0)
            {
                this.setBalance(this.GetBalance() - amount);
                this.transactions.Add(-1 * amount);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string GetInfo()
        {
            return String.Format("{0} (nr. {1}) - {2:0.00}", this.clientName, this.accountNr, this.GetBalance());
        }
    }
}
