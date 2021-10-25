using System;


namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 150 * 75 / 100; // *1.0
            double b = 150 * 0.75;
            double c = 150 / 100 * 75; // *1.0
            bool isEqual = false;

            if (a == b && a == c && b == c)
            {
                isEqual = true;
            }
            Console.WriteLine(a); //112 
            Console.WriteLine(b); //112.5
            Console.WriteLine(c); //75
            Console.WriteLine(isEqual);
        }
    }
}