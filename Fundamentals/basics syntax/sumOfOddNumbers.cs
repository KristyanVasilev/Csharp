using System;

namespace sumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= num; i++)
            {
                int odd = i * 2 - 1;
                Console.WriteLine(odd);
                sum += odd;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
