using System;
using System.Linq;
using System.Collections.Generic;

namespace _09._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> legendaryMaterials = new Dictionary<string, int>();
            legendaryMaterials.Add("shards", 0);
            legendaryMaterials.Add("fragments", 0);
            legendaryMaterials.Add("motes", 0);
            Dictionary<string, int> junkMaterials = new Dictionary<string, int>();
            bool isLegendaryFound = false;

            while (!isLegendaryFound)
            {
                string[] input = Console.ReadLine().Split();
                for (int i = 1; i < input.Length; i += 2)
                {
                    string item = input[i].ToLower();
                    int count = int.Parse(input[i - 1]);

                    if (item == "shards" || item == "fragments" || item == "motes")
                    {
                        legendaryMaterials[item] += count;
                        if (legendaryMaterials[item] >= 250)
                        {
                            isLegendaryFound = true;
                            break;
                        }
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(item))
                        {
                            junkMaterials.Add(item, 0);
                        }
                        junkMaterials[item] += count;
                    }
                }
            }

            if (legendaryMaterials["shards"] >= 250)
            {
                Console.WriteLine("Shadowmourne obtained!");
                legendaryMaterials["shrads"] -= 250;
            }
            else if (legendaryMaterials["motes"] >= 250)
            {
                Console.WriteLine("Dragonwrath obtained!");
                legendaryMaterials["motes"] -= 250;
            }
            else if (legendaryMaterials["fragments"] >= 250)
            {
                Console.WriteLine("Valanyr obtained!");
                legendaryMaterials["fragments"] -= 250;
            }

            foreach (var item in legendaryMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in junkMaterials.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
