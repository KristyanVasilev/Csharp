using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> numbers = new Stack<int>();
            foreach (var num in input)
            {
                numbers.Push(num);
            }

            string command = Console.ReadLine().ToLower();
            while (command != "end")
            {
                string[] currCmd = command.Split();
                if (currCmd[0] == "add")
                {
                    numbers.Push(int.Parse(currCmd[1]));
                    numbers.Push(int.Parse(currCmd[2]));
                }
                else if (currCmd[0] == "remove")
                {
                    int elemtsToRemove = int.Parse(currCmd[1]);
                    if (elemtsToRemove <= numbers.Count)
                    {
                        for (int i = 0; i < elemtsToRemove; i++)
                        {
                            numbers.Pop();
                        }
                    }
                }

                command = Console.ReadLine().ToLower();
            }

            Console.WriteLine($"Sum: {numbers.Sum()}");
        }
    }
}
