using System;
using System.Linq;

namespace _10._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            int[,] matrix = ReadMatrix(rows, cols);
            int sum = 0;
            int rowIndex = 0;
            int columnIndex = 0;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int currSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (currSum > sum)
                    {
                        sum = currSum;
                        rowIndex = row;
                        columnIndex = col;
                    }
                }
            }
            Console.WriteLine($"Sum = {sum}");
            PrintMatrix(matrix, rowIndex, columnIndex);
        }

        private static void PrintMatrix(int[,] matrix, int rowIndex, int columnIndex)
        {
            for (int row = rowIndex; row < rowIndex + 3; row++)
            {
                for (int col = columnIndex; col < columnIndex + 3; col++)
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
                int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            return matrix;
        }
    }
}
