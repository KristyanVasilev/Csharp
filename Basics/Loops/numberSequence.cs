using System;

namespace numberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int smallest = int.MaxValue;
            int biggest = int.MinValue;           
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                if (numbers < smallest)
                {
                    smallest = numbers;
                }
                if (numbers > biggest)
                {
                    biggest = numbers;
                }

            }
            Console.WriteLine($"Max number: {biggest}");
            Console.WriteLine($"Min number: {smallest}");
        }
    }
}
