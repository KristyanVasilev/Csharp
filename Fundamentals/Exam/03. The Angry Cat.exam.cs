using System;
using System.Linq;
using System.Collections.Generic;


namespace Angry_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> priceRatings = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            int entryPoint = int.Parse(Console.ReadLine());
            string itemType = Console.ReadLine();

            int resultRight = 0;
            int resultLeft = 0;

            for (int i = entryPoint + 1; i <= priceRatings.Count - 1; i++)
            {
                switch (itemType)
                {
                    case "cheap":
                        if (priceRatings[i] < priceRatings[entryPoint])
                        {
                            resultRight += priceRatings[i];
                        }
                        break;
                    case "expensive":
                        if (priceRatings[i] >= priceRatings[entryPoint])
                        {
                            resultRight += priceRatings[i];
                        }
                        break;
                }
            }
            for (int j = entryPoint - 1; j >= 0; j--)
            {
                switch (itemType)
                {
                    case "cheap":
                        if (priceRatings[j] < priceRatings[entryPoint])
                        {
                            resultLeft += priceRatings[j];
                        }
                        break;
                    case "expensive":
                        if (priceRatings[j] >= priceRatings[entryPoint])
                        {
                            resultLeft += priceRatings[j];
                        }
                        break;
                }
            }
            if (resultLeft >= resultRight)
            {
                Console.WriteLine($"Left - {resultLeft}");
            }
            else
            {
                Console.WriteLine($"Right - {resultRight}");
            }
        }
    }
}