using System;

namespace histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;

            for (int i = 0; i < number; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if (n < 200)
                {
                    p1++;
                }
                else if (n < 400)
                {
                    p2++;
                }
                else if (n < 600)
                {
                    p3++;
                }
                else if (n < 800)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }
            }

            double percentConverter1 = 1.0 * p1 / number * 100;
            double percentConverter2 = (double) p2 / number * 100;
            double percentConverter3 = 1.0 * p3 / number * 100;
            double percentConverter4 = (double)p4 / number * 100;
            double percentConverter5 = 1.0 * p5 / number * 100;

            Console.WriteLine($"{percentConverter1:f2}%");
            Console.WriteLine($"{percentConverter2:f2}%");
            Console.WriteLine($"{percentConverter3:f2}%");
            Console.WriteLine($"{percentConverter4:f2}%");
            Console.WriteLine($"{percentConverter5:f2}%");
        }
    }
}
