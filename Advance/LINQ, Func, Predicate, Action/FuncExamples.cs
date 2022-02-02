using System;

namespace FuncExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, long> func = Multiply;
            //Console.WriteLine(func(5,6));
            PrintResuly(1, 2, func);
            PrintResuly(1, 2, Multiply); // 2-order
        }

        private static void PrintResuly(int a, int b, Func<int, int, long> func)
        {
            for (int i = 0; i < 5; i++)
            {
                var result = func(a + i, b + i);
                Console.WriteLine(new string('=',50));
                Console.WriteLine($"result -> {result}");
                Console.WriteLine(new string('=',50));
            }
        }

        static long Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
