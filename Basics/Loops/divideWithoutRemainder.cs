using System;

namespace divideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;


            for (int i = 0; i < number; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if (n % 2 == 0)
                {
                    p1++;
                }
                if (n % 3 == 0)
                {
                    p2++;
                }
                if (n % 4 == 0)
                {
                    p3++;
                }

            }

            double percentConverter1 = 1.0 * p1 / number * 100;
            double percentConverter2 = (double)p2 / number * 100;
            double percentConverter3 = 1.0 * p3 / number * 100;


            Console.WriteLine($"{percentConverter1:f2}%");
            Console.WriteLine($"{percentConverter2:f2}%");
            Console.WriteLine($"{percentConverter3:f2}%");

        }
    }
}
