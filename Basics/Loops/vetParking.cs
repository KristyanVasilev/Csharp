using System;

namespace vetParking
{
    class Program
    {
        static void Main(string[] args)
        {

            int days = int.Parse(Console.ReadLine()); //1/5
            int hours = int.Parse(Console.ReadLine()); //1/24
            double totalSum = 0;
            double totalDaySum = 0;

            for (int i = 1; i <= days; i++)
            {

                for (int j = 1; j <= hours; j++)
                {
                    if (i % 2 == 0 && j % 2 == 1)
                    {
                        totalSum += 2.50;
                        totalDaySum += 2.50;
                    }
                    else if (i % 2 == 1 && j % 2 == 0)
                    {
                        totalSum += 1.25;
                        totalDaySum += 1.25;
                    }
                    else
                    {
                        totalSum += 1;
                        totalDaySum += 1;
                    }
                }

                Console.WriteLine($"Day: {i} - {totalDaySum:f2} leva");
                totalDaySum = 0;
            }

            Console.WriteLine($"Total: {totalSum:f2} leva");
        }
    }
}
