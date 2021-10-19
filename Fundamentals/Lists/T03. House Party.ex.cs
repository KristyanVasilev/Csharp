using System;
using System.Collections.Generic;
using System.Linq;

namespace T03._House_Party.ex
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> persons = new List<string>();
            int numberOfPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPeople; i++)
            {
                List<string> commands = Console.ReadLine().Split().ToList();
                if (persons.Contains(commands[0]) && commands[2] == "going!")
                {
                    Console.WriteLine($"{commands[0]} is already in the list!");
                }            
                else if (!persons.Contains(commands[0]) && commands[2] == "not")
                {
                    Console.WriteLine($"{commands[0]} is not in the list!");
                }
                else if (persons.Contains(commands[0]) && commands[2] == "not")
                {
                    persons.Remove(commands[0]);
                }
                else
                {
                    persons.Add(commands[0]);
                }
            }
            foreach (var person in persons)
            {
                Console.WriteLine(person);
            }
        }
    }
}
