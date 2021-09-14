using System;

namespace calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int num = 1; num <= 10; num++)
            {
                for (int multi = 1; multi <= 10; multi++)
                {
                    int product = num * multi;
                    Console.WriteLine($"{num} * {multi} = {product}");
                }
            }
        }
    }
}
