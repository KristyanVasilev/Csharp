using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.FindAllPathsInALabyrinth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            var labyrinth = ReadMatrix(rows, cols);
           
            var directions = new List<string>();
            string direction = string.Empty;

            FindAllPathsInALabyrinth(labyrinth, 0, 0, directions, direction);
        }

        private static void FindAllPathsInALabyrinth(char[,] labyrinth, int row, int col, List<string> directions, string direction)
        {
            //Console.WriteLine();
            //PrintMatrix(labyrinth);
            if (row < 0 || row >= labyrinth.GetLength(0) || col < 0 || col >= labyrinth.GetLength(1))
            {
                return;
            }

            if (labyrinth[row,col] == '*' || labyrinth[row,col] == 'x')
            {                
                return;
            }

            directions.Add(direction);

            if (labyrinth[row,col] == 'e')
            {
                Console.WriteLine(String.Join(string.Empty, directions));
                directions.RemoveAt(directions.Count - 1);
                return;
            }

            labyrinth[row, col] = 'x';

            FindAllPathsInALabyrinth(labyrinth, row - 1, col, directions, "U"); // Up
            FindAllPathsInALabyrinth(labyrinth, row + 1, col, directions, "D"); // Down
            FindAllPathsInALabyrinth(labyrinth, row, col - 1, directions, "L"); // Left
            FindAllPathsInALabyrinth(labyrinth, row, col + 1, directions, "R"); // Right

            labyrinth[row, col] = '-';
            directions.RemoveAt(directions.Count - 1);
        }

        private static char[,] ReadMatrix(int rows, int cols)
        {
            char[,] matrix = new char[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            return matrix;
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
