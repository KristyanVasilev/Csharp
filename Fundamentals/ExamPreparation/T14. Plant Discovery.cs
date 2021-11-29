using System;
using System.Collections.Generic;
using System.Linq;

namespace T14._Plant_Discovery
{
    class Plant
    {
        public int rarity { get; set; }

        public List<double> rates = new List<double>();
        public double averageValue { get; set; }

        public void addRate(double rate)
        {
            averageValue = 0;
            rates.Add(rate);
            for (int i = 0; i < rates.Count; i++)
            {
                averageValue += rates[i];
            }
            averageValue /= rates.Count;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var plants = new Dictionary<string, Plant>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] plantsParts = Console.ReadLine().Split("<->");
                string plantName = plantsParts[0];
                if (!plants.ContainsKey(plantName))
                {
                    Plant currPlant = new Plant();
                    currPlant.rarity = int.Parse(plantsParts[1]);
                    plants.Add(plantName, currPlant);
                }
                else
                {
                    plants[plantName].rarity = int.Parse(plantsParts[1]);
                }
            }

            string plantParts = Console.ReadLine();

            while (plantParts != "Exhibition")
            {
                string[] currPlantsPart = plantParts.Split();
                string currCmd = currPlantsPart[0];
                string plantName = currPlantsPart[1];

                switch (currCmd)
                {
                    case "Rate:":
                        double rating = double.Parse(currPlantsPart[3]);
                        if (plants.ContainsKey(plantName))
                        {
                            plants[plantName].addRate(rating);
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;

                    case "Update:":
                        int rarity = int.Parse(currPlantsPart[3]);
                        if (plants.ContainsKey(plantName))
                        {
                            plants[plantName].rarity = rarity;
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;

                    case "Reset:":
                        if (plants.ContainsKey(plantName))
                        {
                            plants[plantName].rates.Clear();
                            plants[plantName].averageValue = 0;
                            
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;
                }

                plantParts = Console.ReadLine();
            }

            Console.WriteLine("Plants for the exhibition:");
            foreach (var item in plants.OrderByDescending(x => x.Value.rarity).ThenByDescending(x => x.Value.averageValue))
            {
                Console.WriteLine($"- {item.Key}; Rarity: {item.Value.rarity}; Rating: {item.Value.averageValue:f2}");
            }
        }
    }
}
