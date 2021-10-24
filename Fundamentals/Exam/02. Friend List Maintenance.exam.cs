using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Friend_List_Maintenance.exam
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(", ").ToList();
            string[] cmd = Console.ReadLine().Split().ToArray();
            int countBlacklist = 0;
            int countError = 0;

            while (cmd[0] != "Report")
            {
                if (cmd[0] == "Blacklist")
                {
                    string name = cmd[1];
                    if (!names.Contains(name))
                    {
                        Console.WriteLine($"{name} was not found.");
                    }
                    else
                    {
                        Console.WriteLine($"{name} was blacklisted.");
                        int index = names.IndexOf(name);
                        names[index] = "Blacklisted";
                        countBlacklist++;
                    }
                }
                else if (cmd[0] == "Error")
                {
                    int index = int.Parse(cmd[1]);
                    string name = names[index];
                    if (index >= 0 && index < names.Count)
                    {
                        if (names[index] != "Blacklisted" && names[index] != "Lost")
                        {
                            Console.WriteLine($"{name} was lost due to an error.");
                            names[index] = "Lost";
                            countError++;
                        }
                    }
                }
                else if (cmd[0] == "Change")
                {
                    int index = int.Parse(cmd[1]);
                    string newName = cmd[2];
                    if (index >= 0 && index < names.Count)
                    {
                        string currName = names[index];
                        names[index] = newName;
                        Console.WriteLine($"{currName} changed his username to {newName}.");
                    }
                }
                cmd = Console.ReadLine().Split().ToArray();
            }
            Console.WriteLine($"Blacklisted names: {countBlacklist}");
            Console.WriteLine($"Lost names: {countError}");
            Console.WriteLine(string.Join(" ", names));
        }
    }
}
