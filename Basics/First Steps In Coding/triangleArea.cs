using System;

namespace triangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
          

            double Trianglearea = a * h / 2;

            Console.WriteLine(String.Format("{0:0.00}", Trianglearea));
        }
    }
}
