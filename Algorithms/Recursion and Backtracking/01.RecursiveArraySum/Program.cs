using System;
using System.Linq;

namespace _01.RecursiveArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = SumArray(numbers, 0);
            Console.WriteLine(sum);
        }

        private static int SumArray(int[] numbers, int index)
        {
            if (index == numbers.Length - 1)
            {
                return numbers[index];
            }

            return numbers[index] + SumArray(numbers, index + 1);
        }
    }
}
