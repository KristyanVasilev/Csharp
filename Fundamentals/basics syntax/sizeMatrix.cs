using System;

namespace sizeMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeMatrix = int.Parse(Console.ReadLine());

            PrintSize(sizeMatrix);
        }
        static void PrintSize(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(size + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
