using System;
using System.Linq;

namespace _15._Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = ReadMatrix(size, size);
            int[] bombs = Console.ReadLine()
                 .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            for (int i = 0; i < bombs.Length - 1; i+=2)
            {
                int row = bombs[i];
                int col = bombs[i + 1];

                if (matrix[row, col] <= 0) continue;

                BombTheMatrix(matrix, row, col);
            }
            PrintAliveCellsAndSum(matrix);
            PrintMatrix(matrix);
        }
        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }
        private static void PrintAliveCellsAndSum(int[,] matrix)
        {
            int count = 0;
            int sum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        count++;
                        sum += matrix[row, col];
                    }
                }
            }
            Console.WriteLine($"Alive cells: {count}");
            Console.WriteLine($"Sum: {sum}");
        }

        private static void BombTheMatrix(int[,] matrix, int rows, int cols)
        {
            //top
            if (IsInRange(matrix, rows - 1, cols) && matrix[rows - 1, cols] > 0)
            {
                matrix[rows - 1, cols] -= matrix[rows, cols];
            }
            if (IsInRange(matrix, rows - 1, cols - 1) && matrix[rows - 1, cols - 1] > 0)
            {
                matrix[rows - 1, cols - 1] -= matrix[rows, cols];
            }
            if (IsInRange(matrix, rows - 1, cols + 1) && matrix[rows - 1, cols + 1] > 0)
            {
                matrix[rows - 1, cols + 1] -= matrix[rows, cols];
            }
            //mid
            if (IsInRange(matrix, rows, cols + 1) && matrix[rows, cols + 1] > 0)
            {
                matrix[rows, cols + 1] -= matrix[rows, cols];
            }
            if (IsInRange(matrix, rows, cols - 1) && matrix[rows, cols - 1] > 0)
            {
                matrix[rows, cols - 1] -= matrix[rows, cols];
            }
            //bot
            if (IsInRange(matrix, rows + 1, cols) && matrix[rows + 1, cols] > 0)
            {
                matrix[rows + 1, cols] -= matrix[rows, cols];
            }
            if (IsInRange(matrix, rows + 1, cols - 1) && matrix[rows + 1, cols - 1] > 0)
            {
                matrix[rows + 1, cols - 1] -= matrix[rows, cols];
            }
            if (IsInRange(matrix, rows + 1, cols + 1) && matrix[rows + 1, cols + 1] > 0)
            {
                matrix[rows + 1, cols + 1] -= matrix[rows, cols];
            }
            matrix[rows, cols] = 0;
        }
        private static bool IsInRange(int[,] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
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
