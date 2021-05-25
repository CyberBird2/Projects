using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3_Assignment_3._2._3_Increment
{
    class BankAccount
    {
        private static int NumberOfAccountNumbers = 1001;
        private int AccountNr;
        private double Balance;
        private List<double> transactions;
        private List<int> AccountNumbers;
        private string clientName;

        public BankAccount(string ClientName, int accountNr)
        {        
            this.AccountNr = accountNr;
            this.clientName = ClientName;
            this.transactions = new List<double>();
            this.AccountNumbers = new List<int>();
            
        }
        public BankAccount(int NwAccountNo)
        {
           
            NwAccountNo = NumberOfAccountNumbers;
            
                NumberOfAccountNumbers++;


            
        }
        public static int GetCount()
        {
          
            return NumberOfAccountNumbers;
        }
        public string ClientName
        {
            get { return clientName; }
            set
            {
                if (value == "")
                {
                    clientName = value;
                }
                else
                {
                    clientName = "Anonymus";
                }
            }
        }
        public void AddAcount(int accountNr)
        {
            bool exists = false;         
            foreach (int searchaccountNr in AccountNumbers)
            {
                if (GetAccountNumber==accountNr)
                {
                    exists = true;
                }
            }
            if (!exists && GetAccountNumber != accountNr)
            {
                AccountNumbers.Add(accountNr);
            }
        }
        public int GetAccountNumber
        {
            get { return AccountNr; }
        }
        public void Deposit(double amount,int accountNumber)
        {
            bool existandadd = false;
            foreach(int searchaccountNumber in AccountNumbers)
            {
                if (accountNumber == GetAccountNumber)
                {
                    existandadd = true;
                }
               
            }
            if (!existandadd && amount > 0)
            {
                    this.MyBalance = this.Balance + amount;
                transactions.Add(amount);

            }
            else
            {
                string info = "Invalid Amount";
            }
        }
        public void WithDraw(double amount,int accountnumber)
        {
            bool existandwithdraw = false;

            foreach (int searchaccountnumber in AccountNumbers)
            {
                if (accountnumber == GetAccountNumber)
                {
                    existandwithdraw = true;
                }
            }
            if (!existandwithdraw &&amount>0)
            {
                this.MyBalance = Balance - amount;
                transactions.Add(amount);
            }
            else
            {

            }
        }
        public double MyBalance
        {
            get { return Balance; }
            private set
            {
                Balance = value;
            }
        }
        public string GetTransactions()
        {
            string TransactionsInfo = this.transactions.Count + " transactions:  " + Environment.NewLine;
            string TypeOfTransactions = "";
            foreach(double t in this.transactions)
            {
                if (t >= 0)
                {
                    TypeOfTransactions = "Deposited";
                }
                else 
                {
                    TypeOfTransactions = "WithDrawn";
                }             
            }
            TransactionsInfo += TypeOfTransactions + Environment.NewLine;
            return TransactionsInfo;
        }
        public string GetInfo()
        {
            string info;
            info = " Client Name: " +this.ClientName + Environment.NewLine+
                " Account Number: "+ Environment.NewLine
                + this.GetAccountNumber +Environment.NewLine+
                " Balance: " + this.MyBalance;
            return info;
        }
    }
}
