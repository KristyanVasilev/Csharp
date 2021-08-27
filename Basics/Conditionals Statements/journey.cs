using System;

namespace journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();

            if (budget <= 100) // bg
            {
                switch (season)
                {
                    case "summer":
                        budget *= 0.3;
                        Console.WriteLine($"Somewhere in Bulgaria");
                        Console.WriteLine($"Camp - {budget:f2}");
                        break;
                    case "winter":
                        budget *= 0.7;
                        Console.WriteLine($"Somewhere in Bulgaria");
                        Console.WriteLine($"Hotel - {budget:f2}");
                        break;
                }               
            }
            else if (budget <= 1000) // balkans
            {
                switch (season)
                {
                    case "summer":
                        budget *= 0.4;
                        Console.WriteLine($"Somewhere in Balkans");
                        Console.WriteLine($"Camp - {budget:f2}");
                        break;
                    case "winter":
                        budget *= 0.8;
                        Console.WriteLine($"Somewhere in Balkans");
                        Console.WriteLine($"Hotel - {budget:f2}");
                        break;
                }
            }
            else if (budget > 1000) // europe
            {               
                        budget *= 0.9;
                        Console.WriteLine($"Somewhere in Europe");
                        Console.WriteLine($"Hotel - {budget:f2}");
                                    
            }
           


        }
    }
}
