using System;

namespace recordTobeat
{
    class Program
    {
        static void Main(string[] args)
        {

            double recordInSec = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timePerMeter = double.Parse(Console.ReadLine());

            double totalTime = distance * timePerMeter;
            double delay = Math.Floor(distance / 50) * 30;

            totalTime += delay;

            if (totalTime < recordInSec)
            {
                Console.WriteLine($" Yes! The new record is {totalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No! He was {totalTime - recordInSec:f2} seconds slower.");
            }
            
           
        }
    }
}
