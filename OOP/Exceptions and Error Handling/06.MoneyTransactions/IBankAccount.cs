using System;
using System.Collections.Generic;
using System.Text;

namespace _06.MoneyTransactions
{
    public interface IBankAccount
    {
        public string AccountName { get; }
        public double Balance { get; }

        void Withdraw(double sum);
        void Deposit(double sum);
    }
}
