
using System;

namespace poundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            double GBP = double.Parse(Console.ReadLine());
            double USD = 1.31;

            decimal fxConverter = (decimal)GBP * (decimal)USD;
            Console.WriteLine($"{fxConverter:f3}");
        }
    }
}
