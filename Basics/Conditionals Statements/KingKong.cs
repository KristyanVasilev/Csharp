using System;

namespace KingKong
{
    class Program
    {
        static void Main(string[] args)
        {




            


            double budget = double.Parse(Console.ReadLine());
            int numOfStats = int.Parse(Console.ReadLine());
            double priceOfclothes = double.Parse(Console.ReadLine());

            double decor = budget * 0.10;
            double totalPriceForClothes = numOfStats * priceOfclothes;

            if (numOfStats > 150)
            {
                totalPriceForClothes *= 0.90;
            }

            double total = decor + totalPriceForClothes;

            if (total > budget)
            {
                double totalMoneuNeed = total - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalMoneuNeed:f2} leva more.");
            }
            else 
            {
                double totalMoneyLeft = budget - total;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {totalMoneyLeft:f2} leva left.");
            }
            




        }
    }
}
