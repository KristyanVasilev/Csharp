using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Queue<string> people = new Queue<string>();

            while (input != "End")
            {
                if (input == "Paid")
                {
                    foreach (var name in people)
                    {
                        Console.WriteLine(name);
                    }
                    people.Clear();
                }
                else
                {
                    var name = input;
                    people.Enqueue(name);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{people.Count} people remaining.");
        }
    }
}
