using System;

namespace Sumseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalTime = 0;
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirthTime = int.Parse(Console.ReadLine());

            totalTime = firstTime + secondTime + thirthTime;

            int minutes = 0;
            int seconds = 0;

            if (totalTime >= 120)
            {
                minutes = 2;
                seconds = totalTime - 120;
            }
            else if (totalTime >= 60)
            {
                minutes = 1;
                seconds = totalTime - 60;
            }
            else
            {
                seconds = totalTime;
            }

            Console.WriteLine($"{minutes}:{seconds:d2}");
        }
    }
}
