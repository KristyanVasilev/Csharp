using System;

namespace multiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int start = int.Parse(Console.ReadLine());

            if (start > 10)
            {
                int product = number * start;
                Console.WriteLine($"{number} X {start} = {product}");
            }
            else
            {
                for (int i = start; i <= 10; i++)
                {
                    int times = i;
                    int product = number * i;
                    Console.WriteLine($"{number} X {times} = {product}");
                }
            }
        }
    }
}
