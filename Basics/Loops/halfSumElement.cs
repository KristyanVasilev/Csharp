using System;

namespace halfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int elements = int.Parse(Console.ReadLine());
            int maxValue = int.MinValue;         
            double sum = 0;

            for (int i = 0; i < elements; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;

                if (number > maxValue)
                {
                    maxValue = number;
                }
            
            }

            double totalSum = sum - maxValue;

            if (totalSum == maxValue)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {maxValue}");
            }
            else
            {
                Console.WriteLine($"No");
                Console.WriteLine($"Diff = {Math.Abs(totalSum - maxValue)}");
            }
        }
    }
}
