using System;
using System.Collections.Generic;
using System.Linq;

namespace OwnSelectMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var numberOnSqrt = list.Select(x => x * x);
            var numberOnSqrt = MySelect(list, x => x * x);

            Console.WriteLine(string.Join(", ", numberOnSqrt));
        }

        static List<int> MySelect(IEnumerable<int> list, Func<int, int> selector)
        {
            var sqrtList = new List<int>();
            foreach (var num in list)
            {
                sqrtList.Add(selector(num));
            }
            return sqrtList;
        }
    }
}
