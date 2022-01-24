using System;
using System.Collections.Generic;
using System.Linq;

namespace _17._Radioactive_Mutant_Vampire_Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            char[,] field = ReadMatrix(size[0], size[1]);
            string commands = Console.ReadLine();
            int[] rowColIndexes = FindingTheStart(field);
            int row = rowColIndexes[0];
            int col = rowColIndexes[1];
            bool won = false;

            for (int i = 0; i < commands.Length; i++)
            {
                field[row, col] = '.';
                if (commands[i] == 'U')
                {
                    row -= 1;
                    if (row < 0)
                    {
                        won = true;
                        row += 1;
                    }
                }
                else if (commands[i] == 'D')
                {
                    row += 1;
                    if (row < 0)
                    {
                        won = true;
                        row -= 1;
                    }
                }
                else if (commands[i] == 'L')
                {
                    col -= 1;
                    if (col < 0)
                    {
                        won = true;
                        col += 1;
                    }
                }
                else if (commands[i] == 'R')
                {
                    col += 1;
                    if (col < 0)
                    {
                        won = true;
                        col -= 1;
                    }                  
                }

                if (won)
                {
                    BunnySplit(field);
                    PrintField(field);
                    Console.WriteLine($"won: {row} {col}");
                    return;
                }
                BunnySplit(field);
                if (field[row, col] == 'B')
                {
                    PrintField(field);

                    Console.WriteLine($"dead: {row} {col}");
                    return;
                }
            }
        }

        private static void PrintField(char[,] field)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    Console.Write(field[row, col]);
                }
                Console.WriteLine();
            }
        }
        private static void BunnySplit(char[,] field)
        {
            int rows = 0;
            int cols = 0;
            List<int> bunniesPosition = new List<int>();
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    if (field[row, col] == 'B')
                    {
                        rows = row;
                        cols = col;
                        bunniesPosition.Add(row);
                        bunniesPosition.Add(col);
                    }
                }
            }
            for (int i = 0; i < bunniesPosition.Count; i += 2)
            {
                int currRow = bunniesPosition[i];
                int currCol = bunniesPosition[i + 1];
                if (IsInRange(field, currRow + 1, currCol) && field[currRow + 1, currCol] != 'B')
                {
                    field[currRow + 1, currCol] = 'B';
                }
                if (IsInRange(field, currRow - 1, currCol) && field[currRow - 1, currCol] != 'B')
                {
                    field[currRow - 1, currCol] = 'B';
                }
                if (IsInRange(field, currRow, currCol + 1) && field[currRow, currCol + 1] != 'B')
                {
                    field[currRow, currCol + 1] = 'B';
                }
                if (IsInRange(field, currRow, currCol - 1) && field[currRow, currCol - 1] != 'B')
                {
                    field[currRow, currCol - 1] = 'B';
                }
            }
        }

        private static bool IsInRange(char[,] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
        }

        private static int[] FindingTheStart(char[,] field)
        {
            int[] rowCol = new int[2];
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    if (field[row, col] == 'P')
                    {
                        rowCol[0] = row;
                        rowCol[1] = col;
                    }
                }
            }
            return rowCol;
        }

        private static char[,] ReadMatrix(int rows, int cols)
        {
            char[,] field = new char[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < cols; col++)
                {
                    field[row, col] = input[col];
                }
            }
            return field;
        }
    }
}
