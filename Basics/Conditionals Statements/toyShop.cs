using System;

namespace toyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double holidayPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double total = puzzles * 2.60 + dolls * 3 + bears * 4.10 + minions * 8.20 + trucks * 2;

            int numOfToys = puzzles + dolls + bears + minions + trucks;

            if (numOfToys >= 50)
            {
                total = total - total * 0.25;
            }

            total = total - total * 0.10;

            if (total >= holidayPrice)
            {
                Console.WriteLine($"Yes! {total-holidayPrice:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {holidayPrice - total:f2} lv needed.");
            }
        }
    }
}
