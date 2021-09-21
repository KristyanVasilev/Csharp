using System;
using System.Linq;
using System.Collections.Generic;

namespace removeNegativesInReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> possitiveNum = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] >= 0)
                {
                    possitiveNum.Add(numbers[i]);
                }
            }

            if (possitiveNum.Count > 0)
            {
                possitiveNum.Reverse();
                Console.WriteLine(string.Join(" ", possitiveNum));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
