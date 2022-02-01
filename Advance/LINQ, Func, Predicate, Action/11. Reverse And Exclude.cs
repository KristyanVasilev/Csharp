using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int subtract = int.Parse(Console.ReadLine());
            Func<List<int>, List<int>> subtractNumbers = number => number.Where(x => !(x % subtract == 0)).Reverse().ToList();
            numbers = subtractNumbers(numbers);
            Action<List<int>> print = number => Console.WriteLine(string.Join(" ", number));
            print(numbers);
        }
    }
}
/*Create a program that reverses a collection and removes elements that are divisible by a given integer n. Use predicates/functions..*/
