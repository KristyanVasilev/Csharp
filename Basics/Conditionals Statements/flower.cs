using System;

namespace flower
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int flowerCounter = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double moneyForFlower = 0;

            switch (flowerType)
            {
                case "Roses":
                    moneyForFlower = flowerCounter * 5;
                    if (flowerCounter > 80)
                    {
                        moneyForFlower = moneyForFlower * 0.90;
                    }
                    break;
                case "Dahlias":
                    moneyForFlower = flowerCounter * 3.80;
                    if (flowerCounter > 90)
                    {
                        moneyForFlower = moneyForFlower * 0.85;
                    }
                    break;
                case "Tulips":
                    moneyForFlower = flowerCounter * 2.80;
                    if (flowerCounter > 80)
                    {
                        moneyForFlower = moneyForFlower * 0.85;
                    }
                    break;
                case "Narcissus":
                    moneyForFlower = flowerCounter * 3;
                    if (flowerCounter < 120)
                    {
                        moneyForFlower = moneyForFlower * 1.15;
                    }
                    break;
                case "Gladiolus":
                    moneyForFlower = flowerCounter * 2.50;
                    if (flowerCounter < 80)
                    {
                        moneyForFlower = moneyForFlower * 1.20;
                    }
                    break;


            }
            if (moneyForFlower <= budget)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowerCounter} {flowerType} and {(budget - moneyForFlower):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {(moneyForFlower - budget):f2} leva more.");
            }


        }
    }
}
