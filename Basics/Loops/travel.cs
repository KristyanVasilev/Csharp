using System;

namespace travel
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            while (destination != "End")
            {
                double budget = double.Parse(Console.ReadLine());
                double savings = 0;

                while (savings < budget)
                {
                    savings += double.Parse(Console.ReadLine());
                }
                    Console.WriteLine($"Going to {destination}!");

                destination = Console.ReadLine();
            }
        }
    }
}
