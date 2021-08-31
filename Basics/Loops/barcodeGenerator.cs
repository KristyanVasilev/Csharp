using System;

namespace Exam_Prep
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int d1 = num1 % 10;
            num1 /= 10;
            int c1 = num1 % 10;
            num1 /= 10;
            int b1 = num1 % 10;
            num1 /= 10;
            int a1 = num1 % 10;

            int d2 = num2 % 10;
            num2 /= 10;
            int c2 = num2 % 10;
            num2 /= 10;
            int b2 = num2 % 10;
            num2 /= 10;
            int a2 = num2 % 10;


            for (int a = a1; a <= a2; a++)
            {
                if (a % 2 == 0)
                {
                    continue;
                }
                for (int b = b1; b <= b2; b++)
                {
                    if (b % 2 == 0)
                    {
                        continue;
                    }
                    for (int c = c1; c <= c2; c++)
                    {
                        if (c % 2 == 0)
                        {
                            continue;
                        }
                        for (int d = d1; d <= d2; d++)
                        {
                            if (d % 2 != 0)
                            {
                                Console.Write($"{a}{b}{c}{d} ");
                            }
                        }
                    }
                }
            }
        }
    }
}