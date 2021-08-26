using System;

namespace circleAreaandPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double area = Math.PI * r * r;
            double perimeter = Math.PI * r * 2;

            Console.WriteLine(String.Format("{0:0.00}", area));
            Console.WriteLine(String.Format("{0:0.00}", perimeter));
        }
    }
}
