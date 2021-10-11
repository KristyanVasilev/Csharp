using System;

namespace T06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PrintMiddleChar(input);
        }

        private static void PrintMiddleChar(string input)
        {
            if (input.Length % 2 != 0)
            {
                Console.WriteLine(input[input.Length / 2]);
            }
            else
            {
                Console.Write(input[input.Length / 2 - 1]);
                Console.Write(input[input.Length / 2]);
            }
            Console.WriteLine();
        }
    }
}
