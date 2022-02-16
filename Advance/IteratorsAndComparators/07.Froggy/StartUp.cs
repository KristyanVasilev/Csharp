using System;
using System.Linq;
using System.Collections.Generic;

namespace ListyIterator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var elements = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var lake = new Lake(elements);

            Console.WriteLine(string.Join(", ", lake));
        }
    }
}
