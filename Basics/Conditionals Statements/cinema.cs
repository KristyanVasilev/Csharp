using System;

namespace cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projectType = Console.ReadLine();
            int numberOfLines = int.Parse(Console.ReadLine());
            int numOfColums = int.Parse(Console.ReadLine());

            double finalPrice = 0;
            int totalseats = numberOfLines * numOfColums;

            switch (projectType)
            {
                case "Premiere":
                    finalPrice = totalseats * 12;
                    Console.WriteLine($"{finalPrice:f2} leva");
                    break;
                case "Normal":
                    finalPrice = totalseats * 7.50;
                    Console.WriteLine($"{finalPrice:f2} leva");
                    break;
                case "Discount":
                    finalPrice = totalseats * 5;
                    Console.WriteLine($"{finalPrice:f2} leva");
                    break;

            }

        }
    }
}
