using System;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int vineyardSize = int.Parse(Console.ReadLine());
            double grapesPer1m2 = double.Parse(Console.ReadLine());
            int needLitresForWine = int.Parse(Console.ReadLine());
            int numbersOfWorkers = int.Parse(Console.ReadLine());

        
            double totalGrapes = vineyardSize * grapesPer1m2;
            double totalWIne = 0.4 * totalGrapes / 2.5;

            if (totalWIne < needLitresForWine)
            {
                double wineneeded = needLitresForWine - totalWIne;
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(wineneeded)} liters wine needed.");
                
            }
            else 
            {
                
                double wineLeft = totalWIne - needLitresForWine;
                double litrePerPerson = wineLeft / numbersOfWorkers;
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(totalWIne)} liters.");
                Console.WriteLine($"{Math.Ceiling(wineLeft)} liters left -> {Math.Ceiling(litrePerPerson)} liters per person.");
            }

        }
    }
}
