using System;
using System.Linq;

namespace _02._Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int sumColums = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sumColums += matrix[row, col];
                }
                Console.WriteLine(sumColums);
            }
        }
    }
}
