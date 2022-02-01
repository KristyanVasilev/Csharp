using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> numbers = Enumerable.Range(input[0], input[1] - input[0] + 1).ToList();
            Predicate<int> evenOrOdd = number => number % 2 == 0;
            Action<List<int>> print = number => Console.WriteLine(string.Join(" ", number));

            string evenOdd = Console.ReadLine();
            if (evenOdd == "even")
            {
                print(numbers.FindAll(evenOrOdd));
            }
            else
            {
                print(numbers.FindAll(x => !evenOrOdd(x)));
            }
        }
    }
}
/*You are given a lower and an upper bound for a range of integer numbers. Then a command specifies if you need to list all even or odd numbers in the given range. Use Predicate<T>.*/
