using System;

namespace T06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());            
            Console.WriteLine(CalculateArea(a, b));
            

        }

        private static int CalculateArea(int a, int b)
        {
            return a * b;
        }
    }
}

