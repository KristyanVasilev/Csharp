using System;

namespace charToString
{
    class Program
    {
        static void Main(string[] args)
        {
            Char fisrt = Console.ReadLine()[0];
            Char second = Console.ReadLine()[0];
            Char third = Console.ReadLine()[0];

            Console.WriteLine($"{fisrt}{second}{third}");
        }
    }
}
