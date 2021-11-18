using System;
using System.Text.RegularExpressions;

namespace ReplaceRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"[A-Z][a-z]+ [A-Z][a-z]+");

            string replaced = regex.Replace("Gosho Petrov e priqtel na Pesho Peshov", "***** *****");

            Console.WriteLine(replaced);
        }
    }
}
