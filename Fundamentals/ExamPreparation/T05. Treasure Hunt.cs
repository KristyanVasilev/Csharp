using System;
using System.Linq;
using System.Collections.Generic;

namespace T05._Treasure_Hunt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> initialLoot = Console.ReadLine().Split("|").ToList();
            string[] commands = Console.ReadLine().Split();

            while (commands[0] != "Yohoho!")
            {
                if (commands[0] == "Loot")
                {
                    for (int i = 1; i < commands.Length; i++)
                    {
                        if (!initialLoot.Contains(commands[i]))
                        {
                            initialLoot.Insert(0, commands[i]);
                        }
                    }
                }

                else if (commands[0] == "Drop")
                {
                    int index = int.Parse(commands[1]);
                    if (index > 0 && index <= initialLoot.Count)
                    {
                        string dropedMatirial = initialLoot[index];
                        initialLoot.RemoveAt(index);
                        initialLoot.Add(dropedMatirial);
                    }
                }
                else if (commands[0] == "Steal")
                {
                    if (int.Parse(commands[1]) > initialLoot.Count)
                    {
                        while (initialLoot.Count != 0)
                        {
                            initialLoot.RemoveAt(0);
                        }
                    }
                    else
                    {
                        List<string> stealed = new List<string>();
                        for (int i = initialLoot.Count - int.Parse(commands[1]); i < commands.Length; i++)
                        {
                            stealed.Add(initialLoot[i]);
                            initialLoot.RemoveAt(i);
                            i--;
                        }

                        Console.WriteLine(string.Join(", ", stealed));
                    }
                }
                commands = Console.ReadLine().Split();
            }
            double sum = 0;
            for (int i = 0; i < initialLoot.Count; i++)
            {
                sum += initialLoot[i].Length;
            }

            double average = 0;
            if (sum != 0) average = sum / initialLoot.Count;
            if (sum != 0)
            {
                Console.WriteLine($"Average treasure gain: {average:f2} pirate credits.");
            }
            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }
        }
    }
}
