using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2._1___Refactor
{
				class BankAccount
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

								public string ClientName
								{
												get { return clientName; }
								}

								public int AccountNr
								{
												get { return accountNr; }
								}

								public double Balance
								{
												get { return balance; }
												private set
												{
																if (value >= 0)
																				this.balance = value;
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
