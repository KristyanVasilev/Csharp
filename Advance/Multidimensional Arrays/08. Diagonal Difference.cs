using System;
using System.Linq;

namespace _08._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfSquareMatrix = int.Parse(Console.ReadLine());
            int rows = sizeOfSquareMatrix;
            int cols = sizeOfSquareMatrix;
            int[,] matrix = ReadMatrix(rows, cols);
            int leftSum = SumLeftMatrixDiagonal(matrix);
            int rightSum = SumRightMatrixDiagonal(matrix);
            Console.WriteLine(Math.Abs(leftSum - rightSum));
        }

        private static int SumRightMatrixDiagonal(int[,] matrix)
        {
            int sum = 0;
            int count = matrix.GetLength(0) - 1;
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                sum += matrix[count, col];
                count--;
            }
            return sum;
        }

        private static int SumLeftMatrixDiagonal(int[,] matrix)
        {
            int sum = 0;
            int count = 0;
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                sum += matrix[count, col];
                count++;
            }
            return sum;
        }

        private static int[,] ReadMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            return matrix;
        }
    }
}
