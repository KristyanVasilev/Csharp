using System;
using System.Linq;

namespace _05.Armory
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] field = new char[size, size];
            int officerRow = 0;
            int officerCol = 0;

            for (int row = 0; row < size; row++)
            {
                string rowInfo = Console.ReadLine();

                for (int col = 0; col < size; col++)
                {
                    field[row, col] = rowInfo[col];
                    if (rowInfo[col] == 'A')
                    {
                        officerRow = row;
                        officerCol = col;
                    }
                }
            }

            int officerExpences = 0;

            while (true)
            {
                var position = Console.ReadLine();
                field[officerRow, officerCol] = '-';

                if (position == "up")
                {
                    officerRow--;
                }
                else if (position == "down")
                {
                    officerRow++;
                }
                else if (position == "left")
                {
                    officerCol--;
                }
                else if (position == "right")
                {
                    officerCol++;
                }

                if (!IsInRange(field, officerRow, officerCol))
                {
                    Console.WriteLine("I do not need more swords!");
                    break;
                }

                if (char.IsDigit(field[officerRow, officerCol]))
                {
                    int swordValue = field[officerRow, officerCol] - '0';
                    officerExpences += swordValue;
                }
                else if (field[officerRow, officerCol] == 'M')
                {
                    field[officerRow, officerCol] = '-';
                    var nextMirror = FindNextMirror(field);
                    officerRow = nextMirror[0];
                    officerCol = nextMirror[1];
                }

                field[officerRow, officerCol] = 'A';

                if (officerExpences >= 65)
                {
                    Console.WriteLine("Very nice swords, I will come back for more!");
                    break;
                }
            }

            Console.WriteLine($"The king paid {officerExpences} gold coins.");
            PrintMatrix(field);
        }

        private static int[] FindNextMirror(char[,] field)
        {
            int[] rowCol = new int[2];
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    if (field[row, col] == 'M')
                    {
                        rowCol[0] = row;
                        rowCol[1] = col;
                    }
                }
            }
            return rowCol;
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

        private static bool IsInRange(char[,] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
        }
    }
}
/*
You will be given an integer n for the size of the armory with a square shape. On the next n lines, you will receive the rows of the armory. The army officer will be placed in a random position, marked with the letter 'A'. On random positions, there will be swords, marked with a single digit (the price of the sword). There may also be mirrors, the count will be either 0 or 2 and they are marked with the letter - 'M'. All of the empty positions will be marked with '-'.
Each turn, you will tell the army officer which direction he should move. Move commands will be: "up", "down", "left", "right". If the army officer moves to a sword, he buys the sword for a price equal to the digit there and the sword disappears. If the army officer moves to a mirror, he teleports on the position of the other mirror, and then both mirrors disappear. If you guide the army officer out of the armory, he leaves with the swords that he has bought. In advance, you negotiate with the king, that he'll buy at least 65 gold coins worth of blades.
The program ends when the army officer buys blades for at least 65 gold coins, or you guide him out of the armory.
*/
