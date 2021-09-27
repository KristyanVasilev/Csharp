using System;

namespace printPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                int val = i;
                char ch = (char)val;
                Console.Write($"{ch} ");
            }

        }
    }
}
