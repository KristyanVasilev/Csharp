using System;
using System.Text.RegularExpressions;

namespace _06._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double totalIncome = 0;
            int quantity = 0;

            while (input != "end of shift")
            {
                Regex regex = new Regex(@"%([A-Z][a-z]+)%[^|$%.]*<([\w]+)>[^|$%.]*\|([\d]+)\|[^|$%.]*?([\d]+[.]?[\d]+)?\$");
                bool isValid = regex.IsMatch(input);
                if (isValid)
                {
                    string customer = regex.Match(input).Groups[1].Value;
                    string product = regex.Match(input).Groups[2].Value;
                    double price = double.Parse(regex.Match(input).Groups[4].Value);
                    quantity = int.Parse(regex.Match(input).Groups[3].Value);
                    double totalSpend = price * quantity;
                    totalIncome += totalSpend;
                    Console.WriteLine($"{customer}: {product} - {totalSpend:f2}");
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
