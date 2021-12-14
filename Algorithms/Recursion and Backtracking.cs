using System;
using System.Linq;

namespace Recursion_and_Backtracking
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(SumRecursively(numbers,0));
        }

        private static int SumRecursively(int[] numbers, int index)
        {
            if (index == numbers.Length-1)
            {
                return numbers[index];
            }
            return numbers[index] += SumRecursively(numbers, index + 1);
        }
    }
}
