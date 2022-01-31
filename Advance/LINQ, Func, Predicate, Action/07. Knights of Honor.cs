using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            Action<List<string>> print = input => input.ForEach(x => Console.WriteLine($"Sir {x}"));
            print(names);
        }

    }
}
/*Create a program that reads a collection of names as strings from the console, appends "Sir" in front of every name, and prints it back on the console. Use Action<T>.*/