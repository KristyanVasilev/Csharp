using System;
using System.Linq;

namespace _12.Re_Volt
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int numberOfCommands = int.Parse(Console.ReadLine());

            char[,] field = new char[size, size];
            int heroRow = 0;
            int heroCol = 0;

            for (int row = 0; row < size; row++)
            {
                string rowInfo = Console.ReadLine();

                for (int col = 0; col < size; col++)
                {
                    field[row, col] = rowInfo[col];
                    if (rowInfo[col] == 'f')
                    {
                        heroRow = row;
                        heroCol = col;
                    }
                }
            }
          
            for (int i = 0; i < numberOfCommands; i++)
            {
                string command = Console.ReadLine();
                field[heroRow, heroCol] = '-';
                int currRow = heroRow;
                int currCol = heroCol;

                if (command == "up")
                {                   
                    heroRow--;
                    if (!IsInRange(field, heroRow, heroCol))
                    {
                        heroRow = field.GetLength(0)-1;
                    }
                    if (field[heroRow, heroCol] == 'B')
                    {
                        heroRow--;
                        if (!IsInRange(field, heroRow, heroCol))
                        {
                            heroRow = field.GetLength(0)-1;
                        }
                    }
                }
                else if (command == "down")
                {
                    heroRow++;
                    if (!IsInRange(field, heroRow, heroCol))
                    {
                        heroRow = 0;
                    }
                    if (field[heroRow, heroCol] == 'B')
                    {
                        heroRow++;
                        if (!IsInRange(field, heroRow, heroCol))
                        {
                            heroRow = 0;
                        }
                    }
                }
                else if (command == "right")
                {
                    heroCol++;
                    if (!IsInRange(field, heroRow, heroCol))
                    {
                        heroCol = 0;
                    }
                    if (field[heroRow, heroCol] == 'B')
                    {
                        heroCol++;
                        if (!IsInRange(field, heroRow, heroCol))
                        {
                            heroCol = 0;
                        }
                    }
                }
                else if (command == "left")
                {
                    heroCol--;
                    if (!IsInRange(field, heroRow, heroCol))
                    {
                        heroCol = field.GetLength(1)-1;
                    }
                    if (field[heroRow, heroCol] == 'B')
                    {
                        heroCol--;
                        if (!IsInRange(field, heroRow, heroCol))
                        {
                            heroCol = field.GetLength(1)-1;
                        }
                    }
                }

                if (field[heroRow, heroCol] == 'F')
                {
                    Console.WriteLine("Player won!");
                    field[heroRow, heroCol] = 'f';

                    PrintMatrix(field);
                    return;
                }
                if (field[heroRow, heroCol] == 'T')
                {
                    heroRow = currRow;
                    heroCol = currCol;
                }
                
                field[heroRow, heroCol] = 'f';
                //PrintMatrix(field);

            }

            Console.WriteLine("Player lost!");
            PrintMatrix(field);
        }
        private static void PrintMatrix(char[,] field)
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
        private static bool IsInRange(char[,] field, int row, int col)
        {
            return row >= 0 && row < field.GetLength(0) && col >= 0 && col < field.GetLength(1);
        }
    }
}
