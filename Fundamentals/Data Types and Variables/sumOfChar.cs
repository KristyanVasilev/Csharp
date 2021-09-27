using System;

namespace sumOfChar
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                int letter = char.Parse(Console.ReadLine());
                sum += letter;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
