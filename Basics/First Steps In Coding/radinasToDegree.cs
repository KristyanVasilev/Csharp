using System;

namespace RadinasToDegree
{
    class Program
    {
        static void Main(string[] args)
        {
            double radians = double.Parse(Console.ReadLine());
            double degree = radians * 180 / Math.PI;

            Console.WriteLine(Math.Round(degree));
        }
    }
}
