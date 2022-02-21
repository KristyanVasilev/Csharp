using System;
using System.Collections.Generic;
using System.Linq;


namespace _2ra
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            Stack<char> klon = new Stack<char>();

            char[,] field = new char[size, size];
            int heroRow = 0;
            int heroCol = 0;
            int wood = 0;

            for (int row = 0; row < size; row++)
            {
                char[] rowInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int col = 0; col < size; col++)
                {
                    field[row, col] = rowInfo[col];
                    if (rowInfo[col] == 'B')
                    {
                        heroRow = row;
                        heroCol = col;
                    }
                    if (char.IsLower(rowInfo[col]))
                    {
                        wood++;
                    }
                }
            }

            string command = Console.ReadLine();
            while (command != "end")
            {
                field[heroRow, heroCol] = '-';

                if (command == "up")
                {
                    heroRow--;
                    if (!IsInRange(field, heroRow, heroCol))
                    {
                        heroRow++;
                        if (klon.Count > 0)
                        {
                            klon.Pop();
                        }
                    }
                    if (field[heroRow, heroCol] == 'F')
                    {
                        field[heroRow, heroCol] = '-';
                        if (!IsInRange(field, heroRow - 1, heroCol))
                        {
                            heroRow = field.GetLength(0) - 1;
                        }
                        else
                        {
                            heroRow = 0;
                        }
                    }
                }
                else if (command == "down")
                {
                    heroRow++;
                    if (!IsInRange(field, heroRow, heroCol))
                    {
                        heroRow--;
                        if (klon.Count > 0)
                        {
                            klon.Pop();
                        }
                    }
                    if (field[heroRow, heroCol] == 'F')
                    {
                        field[heroRow, heroCol] = '-';

                        if (!IsInRange(field, heroRow + 1, heroCol))
                        {
                            heroRow = 0;
                        }
                        else
                        {
                            heroRow = field.GetLength(0) - 1;
                        }
                    }
                }
                else if (command == "right")
                {
                    heroCol++;
                    if (!IsInRange(field, heroRow, heroCol))
                    {
                        heroCol--;
                        if (klon.Count > 0)
                        {
                            klon.Pop();
                        }
                    }
                    if (field[heroRow, heroCol] == 'F')
                    {
                        field[heroRow, heroCol] = '-';

                        if (!IsInRange(field, heroRow, heroCol + 1))
                        {
                            heroCol = 0;
                        }
                        else
                        {
                            heroCol = field.GetLength(1) - 1;
                        }
                    }
                }
                else if (command == "left")
                {
                    heroCol--;
                    if (!IsInRange(field, heroRow, heroCol))
                    {
                        heroCol++;
                        if (klon.Count > 0)
                        {
                            klon.Pop();
                        }
                    }
                    if (field[heroRow, heroCol] == 'F')
                    {
                        field[heroRow, heroCol] = '-';

                        if (!IsInRange(field, heroRow, heroCol - 1))
                        {
                            heroCol = field.GetLength(1) - 1;
                        }
                        else
                        {
                            heroCol = 0;
                        }
                    }
                }

                if (char.IsLower(field[heroRow, heroCol]))
                {
                    wood--;
                    klon.Push(field[heroRow, heroCol]);
                }

                field[heroRow, heroCol] = 'B';
               // Console.WriteLine();
               // PrintMatrix(field);
                if (wood == 0)
                {
                    break;
                }
                command = Console.ReadLine();
            }
            Stack<char> stack = new Stack<char>();

            while (klon.Count > 0)
            {
                stack.Push(klon.Pop());
            }

            if (wood > 0)
            {
                Console.WriteLine($"The Beaver failed to collect every wood branch. There are {wood} branches left.");
            }
            else
            {
                Console.WriteLine($"The Beaver successfully collect {stack.Count} wood branches: {string.Join(", ", stack)}.");
            }

            PrintMatrix(field);
        }
        private static bool IsInRange(char[,] field, int row, int col)
        {
            return row >= 0 && row < field.GetLength(0) && col >= 0 && col < field.GetLength(1);
        }
        private static void PrintMatrix(char[,] field)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    Console.Write(field[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
