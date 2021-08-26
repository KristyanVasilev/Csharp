using System;

namespace sleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int freeDays = int.Parse(Console.ReadLine());

            //solving
            //•	Когато е на работа, стопанинът му си играе с него по 63 минути на ден.
            //•	Когато почива, стопанинът му си играе с него по 127 минути на ден.


            int gameInFreeDays = freeDays * 127;
            int workDays = (365 - freeDays) * 63;
            int totalGameTime = gameInFreeDays + workDays;
            //Console.WriteLine(totalGameTime);
                     
            if (totalGameTime > 30000)
            {
                int timeNeed = totalGameTime - 30000;
                int hour1 = timeNeed / 60;
                int minutes1 = timeNeed - hour1 * 60;
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hour1} hours and {minutes1} minutes more for play");
            }
            else
            {
                int totalT = 30000 - totalGameTime;
                int hour = totalT / 60;
                int minutes = totalT - hour * 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hour} hours and {minutes} minutes less for play");
            }

        }
    }
}
