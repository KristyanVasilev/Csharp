using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            Console.WriteLine(input.Count);
            Console.WriteLine(input.Sum());
        }
    }
}
