using System;
using System.Collections.Generic;
using System.Linq;


namespace T02._Change_List.ex
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string commands = Console.ReadLine();

            while (commands != "end")
            {
                string[] tokens = commands.Split();
                string command = tokens[0];

                if (command == "Delete")
                {
                    int element = int.Parse(tokens[1]);
                    numbers.RemoveAll(el => el == element);
                    // RemoveAll equals to =>
                    //for (int i = 0; i < numbers.Count; i++)
                    //{
                    //    int el = int.Parse(tokens[1]);
                    //    if (numbers[i] == el)
                    //    {
                    //        numbers.Remove(numbers[i]);
                    //    }
                    //}
                }
                else if (command == "Insert")
                {
                    int element = int.Parse(tokens[1]);
                    int index = int.Parse(tokens[2]);
                    numbers.Insert(index, element);
                }

                commands = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
