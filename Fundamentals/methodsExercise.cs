using System;

namespace methodsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintSign(number);

        }
        static void PrintSign(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"Number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"Number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"Number {number} is zero.");
            }

        }
    }
}
