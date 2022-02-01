using System;
using System.Collections.Generic;
using System.Linq;

namespace _13._List_Of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int endIndex = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> numbers = Enumerable.Range(1, endIndex).ToList();
            for (int i = 0; i < dividers.Length; i++)
            {
                Func<List<int>, List<int>> divide = number => number.Where(x => x % dividers[i] == 0).ToList();
                numbers = divide(numbers);
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
/*Find all numbers in the range 1...N that is divisible by the numbers of a given sequence. On the first line, you will be given an integer N – which is the end of the range. On the second line, you will be given a sequence of integers which are the dividers. Use predicates/functions.*/
