using System;
using System.Linq;

namespace _09._Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            char[,] matrix = ReadMatrix(rows, cols);
            Console.WriteLine(EqualSqaureSymbols(matrix)); ;
        }

        private static int EqualSqaureSymbols(char[,] matrix)
        {
            int count = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if ((char)matrix[row, col] == (char)matrix[row, col + 1] && (char)matrix[row, col] == (char)matrix[row + 1, col] && (char)matrix[row, col] == (char)matrix[row + 1, col + 1])
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        private static char[,] ReadMatrix(int rows, int cols)
        {
            char[,] matrix = new char[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                char[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            };
            return matrix;
        }
    }
}


