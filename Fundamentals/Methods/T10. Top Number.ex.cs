using System;
using System.Collections.Generic;
using System.Linq;

namespace T10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (isTopNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool isTopNumber(int number)
        {
            return isDivisibleBy(number, 8) && ContainsOddDigit(number);
        }

        private static bool ContainsOddDigit(int number)
        {
            while (number != 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 != 0)
                {
                    return true;
                }
                number /= 10;
            }
            return false;
        }

        private static bool isDivisibleBy(int number, int divider)
        {
            int sum = 0;
            while (number != 0)
            {
                int lastDigit = number % 10;
                sum += lastDigit;
                number /= 10;
            }
            return sum % divider == 0;          //дали можем да разделим сумата на делителя без остатък
        }
    }
}
