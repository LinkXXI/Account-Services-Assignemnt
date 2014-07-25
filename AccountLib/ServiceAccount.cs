using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AccountLib
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ServiceAccount : IServiceAccount
    {
        private Dictionary<string, List<Transaction>> dictTransactions = new Dictionary<string, List<Transaction>>();

        public bool AddTransaction(string accountName, Transaction transaction)
        {
            if (dictTransactions.ContainsKey(accountName))
            {
                double balance = getBalance(accountName);

                if (transaction.TransType == TransactionType.WITHDRAW)
                {
                    if (balance - transaction.Amount < 0)
                    {
                        Console.WriteLine("Insuffecient Funds for for withdrawl from account for " + accountName);
                        throw new FaultException("Insuffecient Funds!");
                    }
                }
                dictTransactions[accountName].Add(transaction);
                Console.WriteLine((transaction.TransType == TransactionType.DEPOSIT) ? "Deposited " : "Withdrew " + transaction.Amount + " from account for " + accountName);
                return true;
            }
            else
            {
                Console.WriteLine("Transaction failed, account " + accountName + " does not exist!");
                throw new FaultException("Account Does Not Exist!");
            }
        }

        private double getBalance(string accountName)
        {
            double balance = 0.0;
            foreach (Transaction record in dictTransactions[accountName])
            {
                if (record.TransType == TransactionType.DEPOSIT)
                {
                    balance += record.Amount;
                }
                else if (record.TransType == TransactionType.WITHDRAW)
                {
                    balance -= record.Amount;
                }
            }
            return balance;

        }

        public double GetBalance(string accountName)
        {
            if (dictTransactions.ContainsKey(accountName))
            {
                double balance = 0.0;
                foreach (Transaction record in dictTransactions[accountName])
                {
                    if (record.TransType == TransactionType.DEPOSIT)
                    {
                        balance += record.Amount;
                    }
                    else if (record.TransType == TransactionType.WITHDRAW)
                    {
                        balance -= record.Amount;
                    }
                }
                Console.WriteLine("Balance of " + String.Format("{0:c}", balance) + " retrived for " + accountName);
                return balance;
            }
            else
            {
                Console.WriteLine("Account " + accountName + " does not exist!");
                throw new FaultException("Account does not exist!");
            }
        }

        public bool CreateAccount(string accountName)
        {
            if (dictTransactions.ContainsKey(accountName))
            {
                Console.WriteLine("Account " + accountName + " already exists");
                throw new FaultException("An Account for " + accountName + " Already Exists!");
            }
            else
            {
                dictTransactions.Add(accountName, new List<Transaction>());
                Console.WriteLine("Account for " + accountName + " has been created");
                return true;
            }
        }

        public List<Transaction> GetTransactions(string accountName)
        {
            if (dictTransactions.ContainsKey(accountName))
            {
                Console.WriteLine("Account Owner: " + accountName + " Transaction Count: " + dictTransactions[accountName].Count);
                return dictTransactions[accountName];
            }
            else
            {
                throw new FaultException("Account Does Not Exist!");
            }
        }
    }
}
