using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            SortedDictionary<double, int> occurances = new SortedDictionary<double, int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (!occurances.ContainsKey(numbers[i]))
                {
                    occurances.Add(numbers[i],0);
                }

                occurances[numbers[i]]++;
            }

            foreach (var item in occurances)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
