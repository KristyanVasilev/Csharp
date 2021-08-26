using System;

namespace Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            const int PlusTime = 15;

            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += PlusTime;

            if (minutes >= 60)
            {
                hour += 1;
                minutes -= 60;
            }
            else if (hour >= 24)
            {
                hour = 0;
            }
            Console.WriteLine($"{hour}:{minutes:d2}");
        }
    }
}
