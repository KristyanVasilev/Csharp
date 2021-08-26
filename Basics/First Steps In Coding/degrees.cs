using System;

namespace celsiustofh
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());

            double FH = (celsius * 1.8) + 32;

            Console.WriteLine( String.Format("{0:0.00}", FH));
        }
    }
}
