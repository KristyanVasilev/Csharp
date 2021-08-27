using System;

namespace skiTrip
{
    class Program
    {
        static void Main(string[] args)
        {

            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string feedback = Console.ReadLine();

            int nights = days - 1;
            double finalSum = 0;

            switch (roomType)
            {
                case "room for one person":
                    finalSum = nights * 18;
                    break;
                case "apartment":
                    if (nights < 10)
                    {
                        finalSum = nights * 25 * 0.70;
                    }
                    else if (nights <= 15)
                    {
                        finalSum = nights * 25 * 0.65;
                    }
                    else if (nights > 15)
                    {
                        finalSum = nights * 25 * 0.50;
                    }
                    break;
                case "president apartment":
                    if (nights < 10)
                    {
                        finalSum = nights * 35 * 0.90;
                    }
                    else if (nights <= 15)
                    {
                        finalSum = nights * 35 * 0.85;
                    }
                    else if (nights > 15)
                    {
                        finalSum = nights * 35 * 0.80;
                    }
                    break;
            }
            if (feedback == "positive")
            {
                finalSum *= 1.25;
            }
            else if (feedback == "negative")
            {
                finalSum *= 0.90;
            }
            Console.WriteLine($"{finalSum:f2}");
        }
    }
}