using System;

namespace CMtoinches
{
    class Program
    {
        static void Main(string[] args)
        {
            double cm = double.Parse(Console.ReadLine());

            double inches = cm * 2.54;

            Console.WriteLine(inches);
        }
    }
}
