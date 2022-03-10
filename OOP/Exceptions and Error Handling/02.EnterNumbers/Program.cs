using System;
using System.Collections.Generic;

namespace _02.EnterNumbers
{
    class Program
    {
           
        static void Main(string[] args)
        {
            int start = 1;
            int end = 100;

            List<int> numbers = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                try
                {
                    int number = ReadNumber(numbers, start, end);
                    numbers.Add(number);
                }
                catch (Exception ex)
                {
                    i--;
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }

        private static int ReadNumber(List<int> numbers, int start, int end)
        {
            string input = Console.ReadLine();

            int num;

            if (!int.TryParse(input, out num))
            {
                throw new FormatException("Invalid Number!");
            }

            if (numbers.Count > 0 && num <= numbers[^1])
            {
                throw new ArgumentOutOfRangeException($"Your number is not in range {numbers[^1]} - {end}!");
            }

            if (num <= start || num >= end)
            {
                throw new ArgumentOutOfRangeException($"Your number is not in range {start} - {end}!");
            }

            return num;
        }
    }
}
