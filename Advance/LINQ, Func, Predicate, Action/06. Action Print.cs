using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Action_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();
            Action<List<string>> action = input => input.ForEach(x => Console.WriteLine(x));
            action(input);
        }
    }
}
/*Create a program that reads a collection of strings from the console and then prints them onto the console. Each name should be printed on a new line. Use Action<T>.*/