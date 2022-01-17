using System;
using System.Linq;

namespace _05._Square_With_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            int[,] matrix = ReadMatrix(rows, cols);
            int sum = 0;
            int rowIndex = 0;
            int columnIndex = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int currSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (currSum > sum)
                    {
                        sum = currSum;
                        rowIndex = row;
                        columnIndex = col;
                    }
                }
            }
            PrintMatrix(matrix, rowIndex, columnIndex);
            Console.WriteLine(sum);
        }

        private static void PrintMatrix(int[,] matrix, int rowIndex, int columnIndex)
        {
            for (int row = rowIndex; row < rowIndex + 2; row++)
            {
                for (int col = columnIndex; col < columnIndex + 2; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }

        private static int[,] ReadMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            return matrix;
        }
    }
}
