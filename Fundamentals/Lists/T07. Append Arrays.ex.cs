using System;
using System.Collections.Generic;
using System.Linq;

namespace T07._Append_Arrays.ex
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = Console.ReadLine().Split("|").Reverse().ToList();
            List<int> myListInReverse = new List<int>();

            foreach (var item in myList)
            {
                myListInReverse.AddRange(item.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            }

            Console.WriteLine(string.Join(" ", myListInReverse));

        }
    }
}
