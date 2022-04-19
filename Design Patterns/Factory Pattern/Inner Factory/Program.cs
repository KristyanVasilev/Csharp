using System;

namespace InnerFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            var point = Point.Factory.NewCartesianPoint(5.4, 4);
            Console.WriteLine(point);
        }       
    }
}

