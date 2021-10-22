using System;
using System.Linq;
using System.Collections.Generic;

namespace T08._Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            double avarageNum = numbers.Average();
            List<int> greaterThanAVG = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > avarageNum) greaterThanAVG.Add(numbers[i]);                
            }
            if (greaterThanAVG.Count <= 0) Console.WriteLine("No");
            
            var result = greaterThanAVG.OrderByDescending(x => x).Take(5);           
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
