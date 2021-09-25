using System;

namespace convertMetersToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            decimal km = meters / 1000m;
            Console.WriteLine($"{km:f2}");

        }
    }
}
