using System;
using System.Collections.Generic;

namespace _06.MoneyTransactions
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, BankAccount> bankAccounts = new Dictionary<string, BankAccount>();
            ReadBankAccountsInfo(bankAccounts);

            string[] command = Console.ReadLine().Split();

            while (command[0] != "End")
            {
                try
                {
                    string name = command[1];
                    double sum = double.Parse(command[2]);
                    if (!bankAccounts.ContainsKey(name))
                    {
                        throw new InvalidOperationException("Invalid account!");
                    }

                    if (command[0] == "Withdraw")
                    {
                        bankAccounts[name].Withdraw(sum);
                    }
                    else if (command[0] == "Deposit")
                    {
                        bankAccounts[name].Deposit(sum);
                    }
                    else
                    {
                        throw new InvalidOperationException("Invalid command!");
                    }

                    Console.WriteLine($"Account {name} has new balance: {bankAccounts[name].Balance:f2}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("Enter another command");
                    command = Console.ReadLine().Split();
                }
            }
        }

        private static void ReadBankAccountsInfo(Dictionary<string, BankAccount> bankAccounts)
        {
            string[] accountsInfo = Console.ReadLine().Split(',');
            for (int i = 0; i < accountsInfo.Length; i++)
            {
                var info = accountsInfo[i].Split('-');
                string name = info[0];
                double balance = double.Parse(info[1]);

                var account = new BankAccount(name, balance);
                bankAccounts.Add(name, account);
            }
        }
    }
}
