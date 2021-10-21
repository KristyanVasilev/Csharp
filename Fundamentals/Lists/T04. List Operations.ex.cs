using System;
using System.Linq;
using System.Collections.Generic;

namespace T04.List.ex
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<string> cmd = Console.ReadLine().Split().ToList();

            while (cmd[0] != "End")
            {
                if (cmd[0] == "Add") numbers.Add(int.Parse(cmd[1]));

                else if (cmd[0] == "Insert")
                {
                    if (int.Parse(cmd[2]) > numbers.Count) Console.WriteLine("Invalid index");
                    else numbers.Insert(int.Parse(cmd[2]), int.Parse(cmd[1]));
                }
                else if (cmd[0] == "Remove")
                {
                    if (int.Parse(cmd[1]) > numbers.Count) Console.WriteLine("Invalid index");
                    else numbers.RemoveAt(int.Parse(cmd[1]));
                }
                else if (cmd[1] == "left")
                {
                    int end = int.Parse(cmd[2]);
                    for (int i = 0; i < end; i++)
                    {
                        numbers.Add(numbers[0]);
                        numbers.RemoveAt(0);
                    }
                }
                else if (cmd[1] == "right")
                {
                    int end = int.Parse(cmd[2]);
                    for (int i = 0; i < end; i++)
                    {
                        numbers.Insert(0, numbers[numbers.Count - 1]);
                        numbers.RemoveAt(numbers.Count - 1);
                    }
                }
                cmd = Console.ReadLine().Split().ToList();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
