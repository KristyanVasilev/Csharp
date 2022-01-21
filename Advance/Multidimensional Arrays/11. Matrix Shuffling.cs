using System;
using System.Linq;

namespace _11._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            string[,] matrix = RedaMatrix(rows, cols);
            string[] commands = Console.ReadLine().Split();
            while (commands[0] != "END")
            {
                if (commands[0] == "swap" && commands.Length == 5)
                {
                    int row1 = int.Parse(commands[1]);
                    int col1 = int.Parse(commands[2]);
                    int row2 = int.Parse(commands[3]);
                    int col2 = int.Parse(commands[4]);
                    if (row1 >= 0 && row2 >= 0 && col1 >= 0 && col2 >= 0 && row1 <= rows - 1 && row2 <= rows - 1 && col1 <= cols - 1 && col2 <= cols - 1)
                    {
                        string swapItem = matrix[row1, col1];
                        matrix[row1,col1] = matrix[row2, col2];
                        matrix[row2,col2] = swapItem;
                        PrintMatrix(matrix);
                    }
                    else Console.WriteLine("Invalid input!");
                }
                else Console.WriteLine("Invalid input!");

                commands = Console.ReadLine().Split();
            }
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row,col]} ");
                }
                Console.WriteLine();
            }
        }

        private static string[,] RedaMatrix(int rows, int cols)
        {
            string[,] matrix = new string[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            return matrix;
        }
    }
}
