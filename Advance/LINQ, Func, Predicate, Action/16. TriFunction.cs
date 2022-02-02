using System;
using System.Collections.Generic;
using System.Linq;

namespace _16._TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();

            Func<string, int, bool> isNameLenghtLargerOrEqualToSum = (name, sum) => name.Sum(x => x) >= sum;
            foreach (var name in names)
            {
                bool isTrue = isNameLenghtLargerOrEqualToSum(name, sum);
                if (isTrue)
                {
                    Console.WriteLine(name);
                    return;
                }
            }
        }
    }
}
