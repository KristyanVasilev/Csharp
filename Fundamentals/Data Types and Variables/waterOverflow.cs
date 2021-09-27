using System;

namespace waterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TANK_CAPACITY = 255;
            int n = int.Parse(Console.ReadLine());
            int capacity = TANK_CAPACITY;
            int totalLitres = 0;

            for (int i = 0; i < n; i++)
            {
                int litres = int.Parse(Console.ReadLine());
                if (litres > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    capacity -= litres;
                    totalLitres += litres;
                }
            }
            Console.WriteLine(totalLitres);
        }
    }
}
