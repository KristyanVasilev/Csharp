using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string letters = "";
            string numbers = "";
            string symbols = "";

            foreach (char symbol in input)
            {
                if (char.IsDigit(symbol))
                {
                    numbers += symbol;
                }
                else if (char.IsLetter(symbol))
                {
                    letters += symbol;
                }
                else
                {
                    symbols += symbol;
                }
            }

            Console.WriteLine(numbers);
            Console.WriteLine(letters);
            Console.WriteLine(symbols);
        }
    }
}
