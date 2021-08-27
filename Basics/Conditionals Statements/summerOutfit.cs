using System;

namespace summerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            switch (time)
            {
                case "Morning":
                    if (temp >= 10 && temp <= 18)
                    {
                        Console.WriteLine($"It's {temp} degrees, get your Sweatshirt and Sneakers.");
                    }
                    else if (temp > 18 && temp <= 24)
                    {
                        Console.WriteLine($"It's {temp} degrees, get your Shirt and Moccasins.");
                    }
                    else if (temp >= 25)
                    {
                        Console.WriteLine($"It's {temp} degrees, get your T-Shirt and Sandals.");
                    }
                    break;
                case "Afternoon":
                    if (temp >= 10 && temp <= 18)
                    {
                        Console.WriteLine($"It's {temp} degrees, get your Shirt and Moccasins.");
                    }
                    else if (temp > 18 && temp <= 24)
                    {
                        Console.WriteLine($"It's {temp} degrees, get your T-Shirt and Sandals.");
                    }
                    else if (temp >= 25)
                    {
                        Console.WriteLine($"It's {temp} degrees, get your Swim Suit and Barefoot.");
                    }
                    break;
                case "Evening":
                    if (temp >= 10 && temp <= 18)
                    {
                        Console.WriteLine($"It's {temp} degrees, get your Shirt and Moccasins.");
                    }
                    else if (temp > 18 && temp <= 24)
                    {
                        Console.WriteLine($"It's {temp} degrees, get your Shirt and Moccasins.");
                    }
                    else if (temp >= 25)
                    {
                        Console.WriteLine($"It's {temp} degrees, get your Shirt and Moccasins.");
                    }
                    break;
            }

        }
    }
}
