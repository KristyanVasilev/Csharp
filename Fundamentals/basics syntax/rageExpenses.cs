using System;

namespace rageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {

            double lostGamesCount = double.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            double totalSum = 0;

            if (lostGamesCount >= 2)
            {
                double headsetCount = Math.Floor(lostGamesCount / 2);
                double headsetCost = headsetCount * headsetPrice;
                totalSum += headsetCost;
            }
            if (lostGamesCount >= 3)
            {
                double mouseCount = Math.Floor(lostGamesCount / 3);
                double mouseCost = mouseCount * mousePrice;
                totalSum += mouseCost;
            }
            if (lostGamesCount >= 6)
            {
                double keyboardCount = Math.Floor(lostGamesCount / 6);
                double keyboardCost = keyboardCount * keyboardPrice;
                totalSum += keyboardCost;
            }
            if (lostGamesCount >= 12)
            {
                double displayCount = Math.Floor(lostGamesCount / 12);
                double displayCost = displayCount * displayPrice;
                totalSum += displayCost;
            }

            Console.WriteLine($"Rage expenses: {totalSum:f2} lv.");

        }
    }
}
