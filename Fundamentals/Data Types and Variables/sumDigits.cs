using System;

namespace sumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double totalSum = 0;

            while (number > 0)
            {
                int sum = number % 10;
                number /= 10;
                totalSum += sum;
                sum = 0;
            }
            Console.WriteLine(totalSum);
        }
    }
}
