using System;

namespace spiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            const int DAIYLY_CONSUME = 26;
            int dayCounter = 0;

            int startinYield = int.Parse(Console.ReadLine());
            int totalSpices = 0;

            while (startinYield >= 100)
            {
                totalSpices += startinYield - DAIYLY_CONSUME;
                totalSpices -= 10;
                dayCounter++;
                if (startinYield < 100)
                {
                    totalSpices -= DAIYLY_CONSUME;
                }
            }
            Console.WriteLine(dayCounter);
            Console.WriteLine(totalSpices);
        }
    }
}
