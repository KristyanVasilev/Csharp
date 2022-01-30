using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ").Select(double.Parse).Select(x => x * 1.2).ToList();
            foreach (var item in input)
            {
                Console.WriteLine($"{item:f2}");
            }
        }
    }
}
