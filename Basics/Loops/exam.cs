using System;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int rent = int.Parse(Console.ReadLine());

            double statue = rent * 0.70;
            double catering = statue * 0.85;
            double voice = catering * 0.5;

            double total = rent + statue + catering + voice;
            Console.WriteLine($"{total:f2}");


        }
    }
}
