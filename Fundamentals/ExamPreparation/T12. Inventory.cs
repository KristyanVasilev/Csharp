using System;
using System.Collections.Generic;
using System.Linq;

namespace T12._Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inventory = Console.ReadLine().Split(", ").ToList();
            string[] cmd = Console.ReadLine().Split(" - ").ToArray();

            while (cmd[0] != "Craft!")
            {
                if (cmd[0] == "Collect")
                {
                    string newItem = cmd[1];
                    if (inventory.Contains(newItem)) break;
                    else inventory.Add(newItem);
                }
                else if (cmd[0] == "Drop")
                {
                    string item = cmd[1];
                    if (inventory.Contains(item)) inventory.Remove(item);
                }
                else if (cmd[0] == "Combine Items")
                {
                    string[] currCmd = cmd[1].Split(":").ToArray();
                    string oldItem = currCmd[0];
                    string newItem = currCmd[1];
                    int oldItemPlace = inventory.IndexOf(oldItem);

                    if (inventory.Contains(oldItem)) inventory.Insert(oldItemPlace + 1, newItem);
                }
                else if (cmd[0] == "Renew")
                {
                    string item = cmd[1];
                    if (inventory.Contains(item))
                    {
                        inventory.Remove(item);
                        inventory.Add(item);
                    }
                }
                cmd = Console.ReadLine().Split(" - ").ToArray();
            }
            Console.WriteLine(string.Join(", ", inventory));
        }
    }
}
