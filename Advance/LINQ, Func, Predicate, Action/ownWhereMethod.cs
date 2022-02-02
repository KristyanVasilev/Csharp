using System;
using System.Collections.Generic;
using System.Linq;

namespace ownWhereMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var evenList = list.Where(x => x % 2 == 0);
            var evenList = MyWhere(list, x => x % 2 == 0);

            Console.WriteLine(string.Join(", ", evenList));
        }

        static List<int> MyWhere(IEnumerable<int> list, Func<int, bool> predicate)
        {
            var evenList = new List<int>();

            foreach (var item in list)
            {
                if (predicate(item))
                {
                    evenList.Add(item);
                }
            }
            return evenList;
        }
    }
}
