using System;

namespace worldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
        
            
            const double plusTime = 12.5;

            double recordInSec = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeInSec = double.Parse(Console.ReadLine());

            

            double totalTime1 = distanceInMeters * timeInSec;
           // Console.WriteLine($"{totalTime1:f2}");
            double totalTime2 = Math.Floor(distanceInMeters / 15 );
           // Console.WriteLine($"{totalTime2:f2}");
            double totalTime3 = totalTime2 * plusTime;
            //Console.WriteLine($"{totalTime3:f2}");
            double totalTime = totalTime1 + totalTime3;
            // Console.WriteLine($"{totalTime:f2}");

            if (totalTime >= recordInSec)
            {
                double secNeeded = totalTime - recordInSec;
                Console.WriteLine($"No, he failed! He was {secNeeded:f2} seconds slower.");
            }
            else
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }


        }
    }
}
