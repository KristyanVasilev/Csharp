using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _04._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double totalSum = 0;
            int quantity = 0;
            
            Console.WriteLine("Bought furniture:");
            while (input != "Purchase")
            {
                MatchCollection matches = Regex.Matches(input, @">>([A-Z][a-z]+|[A-Z]+)<<([0-9]+.[0-9]+|[0-9]+)!([0-9]+)");
                foreach (Match match in matches)
                {
                    Console.WriteLine(match.Groups[1]);
                    quantity = int.Parse(match.Groups[3].Value);
                    totalSum += double.Parse(match.Groups[2].Value) * quantity;
                    break;
                }
                quantity = 0;
                input = Console.ReadLine();
            }

            Console.WriteLine($"Total money spend: {totalSum:f2}");
        }
    }
}
