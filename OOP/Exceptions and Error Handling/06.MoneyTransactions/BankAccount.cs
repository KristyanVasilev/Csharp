using System;

namespace _06.MoneyTransactions
{
    public class BankAccount : IBankAccount
    {
        private string accountName;
        private double balance;

        public BankAccount(string accountName, double balance)
        {
            AccountName = accountName;
            Balance = balance;
        }

        public string AccountName
        {
            get { return accountName; }
            private set { accountName = value; }
        }

        public double Balance
        {
            get { return balance; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Balance cannot be negative number!");
                }
                balance = value;
            }
        }

        public void Withdraw(double sum)
        {
            if (sum > this.balance)
            {
                throw new InvalidOperationException("Insufficient balance!");
            }
            this.balance -= sum;
        }
        public void Deposit(double sum)
        {
            this.balance += sum;
        }
    }
}
