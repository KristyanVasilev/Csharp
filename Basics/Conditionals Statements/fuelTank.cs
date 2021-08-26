using System;

namespace fuelTank
{
    class Program
    {
        static void Main(string[] args)
        {
         
            string fuel = Console.ReadLine().ToLower();
            double litres = double.Parse(Console.ReadLine());

            if (fuel == "diesel"  && litres >= 25)
            {
                Console.WriteLine($"You have enough {fuel}.");
            }
            else if (fuel == "diesel" && litres < 25)
            {
                Console.WriteLine($"Fill your tank with { fuel }!");
            }
            else if (fuel == "gasoline" && litres >= 25)
            {
                Console.WriteLine($"You have enough {fuel}.");
            }
            else if (fuel == "gasoline" && litres < 25)
            {
                Console.WriteLine($"Fill your tank with { fuel }!");
            }
            else if (fuel == "gas" && litres >= 25)
            {
                Console.WriteLine($"You have enough {fuel}.");
            }
           
            else if (fuel == "gas" && litres < 25)
            {
                Console.WriteLine($"Fill your tank with { fuel }!");
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }
        }
    }
}
