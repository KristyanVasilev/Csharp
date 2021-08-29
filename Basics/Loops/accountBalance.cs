using System;

namespace accountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string transaction = Console.ReadLine();
            double account = 0;

            while (transaction != "NoMoreMoney")
            {
                double currentTransaction = double.Parse(transaction);
                if (currentTransaction < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                account += currentTransaction;
                Console.WriteLine($"Increase: {currentTransaction:f2}");
                transaction = Console.ReadLine();
            }
            Console.WriteLine($"Total: {account:f2}");
        }
    }
}
