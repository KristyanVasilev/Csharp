using System;
using System.Linq;

namespace _12._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowCol = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string snakeSymbols = Console.ReadLine();
            char[,] matrix = new char[rowCol[0], rowCol[1]];
            bool leftToRight = true;
            int count = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (leftToRight)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = snakeSymbols[count++];
                        if (count == snakeSymbols.Length) count = 0;
                    }
                    leftToRight = false;
                }
                else
                {

                    for (int cols = matrix.GetLength(1) - 1; cols >= 0; cols--)
                    {
                        matrix[row, cols] = snakeSymbols[count++];
                        if (count == snakeSymbols.Length) count = 0;
                    }
                    leftToRight = true;
                }
            }
            PrintMatrix(matrix);
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
