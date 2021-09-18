using System;

namespace evenNum
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            while (number % 2 == 1)
            {
                Console.WriteLine("Please write an even number.");
                number = double.Parse(Console.ReadLine());
            }

            Console.WriteLine($"The number is: {Math.Abs(number)}");
        }
    }
}
