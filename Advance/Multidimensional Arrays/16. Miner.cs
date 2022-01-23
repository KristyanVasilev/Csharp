using System;
using System.Linq;

namespace _16._Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[] commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            char[,] field = ReadMatrix(size, size);
            int[] rowColIndexes = FindingTheStart(field);
            int row = rowColIndexes[0];
            int col = rowColIndexes[1];

            for (int i = 0; i < commands.Length; i++)
            {
                if (commands[i] == "up")
                {
                    if (IsInRange(field, row - 1, col))
                    {
                        row -= 1;
                        if (field[row, col] == 'e')
                        {
                            Console.WriteLine($"Game over! ({row}, {col})");
                            return;
                        }
                        else if (field[row, col] == 'c')
                        {
                            field[row, col] = '*';
                        }
                    }
                }
                else if (commands[i] == "down")
                {
                    if (IsInRange(field, row + 1, col))
                    {
                        row += 1;
                        if (field[row, col] == 'e')
                        {
                            Console.WriteLine($"Game over! ({row}, {col})");
                            return;
                        }
                        else if (field[row, col] == 'c')
                        {
                            field[row, col] = '*';
                        }
                    }
                }
                else if (commands[i] == "left")
                {
                    if (IsInRange(field, row, col - 1))
                    {
                        col -= 1;
                        if (field[row, col] == 'e')
                        {
                            Console.WriteLine($"Game over! ({row}, {col})");
                            return;
                        }
                        else if (field[row, col] == 'c')
                        {
                            field[row, col] = '*';
                        }
                    }
                }
                else if (commands[i] == "right")
                {
                    if (IsInRange(field, row, col + 1))
                    {
                        col += 1;
                        if (field[row, col] == 'e')
                        {
                            Console.WriteLine($"Game over! ({row}, {col})");
                            return;
                        }
                        else if (field[row, col] == 'c')
                        {
                            field[row, col] = '*';
                        }
                    }

                }
                if (!IsThereMoreCoals(field))
                {
                    Console.WriteLine($"You collected all coals! ({row}, {col})");
                }
            }
            if (IsThereMoreCoals(field))
            {
                int coalsLeft = CoalsCounter(field);
                Console.WriteLine($"{coalsLeft} coals left. ({row}, {col})");
            }
        }

        private static int CoalsCounter(char[,] field)
        {
            int coalCounter = 0;
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    if (field[row, col] == 'c')
                    {
                        coalCounter++;
                    }
                }
            }
            return coalCounter;
        }

        private static bool IsThereMoreCoals(char[,] field)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    if (field[row, col] == 'c')
                    {
                        return true;
                    }
                }
            }
            return false;
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
                    if (field[row, col] == 's')
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
                char[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    field[row, col] = input[col];
                }
            }
            return field;
        }
    }
}