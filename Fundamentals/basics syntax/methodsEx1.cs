using System;
using System.Linq;

namespace methodsEx1
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            int result = GetMultiple(Math.Abs(number));

            Console.WriteLine(result);

        }
        static int GetMultiple(int number)
        {
            int evenResult = GetSumOfEvenDigits(number);
            int oddResult = GetSumOfOddDigits(number);
            return evenResult * oddResult;
        }
        static int GetSumOfOddDigits(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                int last = number % 10;
                number /= 10;

                if (last % 2 ==1)
                {
                    sum += last;
                }
            }

            return sum;
        }
        static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                int last = number % 10;
                number /= 10;

                if (last % 2 == 0)
                {
                    sum += last;
                }
            }

            return sum;
        }
        

    }
}
