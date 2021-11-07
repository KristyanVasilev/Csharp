using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resourcesQuantity = new Dictionary<string, int>();
            string line = Console.ReadLine();

            while (line != "stop")
            {
                string resources = line;
                int quantity = int.Parse(Console.ReadLine());

                if (!resourcesQuantity.ContainsKey(resources))
                {
                    resourcesQuantity.Add(resources, 0);
                }
                resourcesQuantity[resources]+= quantity;
                line = Console.ReadLine();
            }

            foreach (var item in resourcesQuantity)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
