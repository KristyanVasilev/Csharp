using System;

namespace wheaterForecast
{
    class Program
    {
        static void Main(string[] args)
        {
            double degree = double.Parse(Console.ReadLine());

            if (degree >=26 && degree <= 35)
            {
                Console.WriteLine("Hot");
            }
            else if (degree >= 20.1 && degree <= 25.9)
            {
                Console.WriteLine("Warm");
            }
            else if (degree >= 15 && degree <= 20)
            {
                Console.WriteLine("Mild");
            }
            else if (degree >= 12 && degree<= 14.9)
            {
                Console.WriteLine("Cool");
            }
            else if (degree >= 5 && degree <= 11.9)
            {
                Console.WriteLine("Cold");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
