using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SumOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            List<int> numbers = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                try
                {
                    int number = int.Parse(input[i]);
                    numbers.Add(number);
                }
                catch (FormatException)
                {
                    Console.WriteLine($"The element '{input[i]}' is in wrong format!");
                }
                catch 
                {
                    Console.WriteLine($"The element '{input[i]}' is out of range!");
                }
                finally
                {
                    Console.WriteLine($"Element '{input[i]}' processed - current sum: {numbers.Sum()}");
                }
            }

            Console.WriteLine($"The total sum of all integers is: {numbers.Sum()}");
        }
    }
}
