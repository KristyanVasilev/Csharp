using System;
using System.Linq;

namespace _10.Warships
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] cordinates = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int playerOne = 0;
            int playerTwo = 0;

            char[,] field = new char[fieldSize, fieldSize];
            for (int row = 0; row < fieldSize; row++)
            {
                char[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < fieldSize; col++)
                {
                    field[row, col] = input[col];
                    if (field[row, col] == '<')
                    {
                        playerOne++;
                    }
                    else if (field[row, col] == '>')
                    {
                        playerTwo++;
                    }
                }
            }
            var totalShips = playerOne + playerTwo;

            for (int i = 0; i < cordinates.Length - 1; i += 2)
            {
                int row = cordinates[i];
                int col = cordinates[i + 1];

                if (IsInRange(field, row, col))
                {
                    if (field[row, col] == '<') // first player ship
                    {
                        field[row, col] = 'X';
                        playerOne--;
                    }
                    else if (field[row, col] == '>') // second player ship
                    {
                        field[row, col] = 'X';
                        playerTwo--;
                    }
                    else if (field[row, col] == '#') // bomb
                    {
                        int currRows = row - 1;
                        int currCols = col - 1;
                        for (int k = 0; k < 3; k++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                if (IsInRange(field, currRows, currCols))
                                {
                                    if (field[currRows, currCols] == '<') // first player ship
                                    {
                                        field[currRows, currCols] = 'X';
                                        playerOne--;
                                    }
                                    else if (field[currRows, currCols] == '>') // second player ship
                                    {
                                        field[currRows, col] = 'X';
                                        playerTwo--;
                                    }
                                }
                                currCols++;
                            }
                            currCols = col - 1;
                            currRows++;
                        }
                    }
                }

                if (playerOne == 0 || playerTwo == 0)
                {
                    break;
                }
            }

            if (playerOne > 0 && playerTwo > 0)
            {
                Console.WriteLine($"It's a draw! Player One has {playerOne} ships left. Player Two has {playerTwo} ships left.");
            }
            else if (playerOne > 0)
            {
                Console.WriteLine($"Player One has won the game! {Math.Abs(totalShips - (playerTwo + playerOne))} ships have been sunk in the battle.");
            }
            else
            {
                Console.WriteLine($"Player Two has won the game! {Math.Abs(totalShips - (playerTwo + playerOne))} ships have been sunk in the battle.");
            }
        }

        private static bool IsInRange(char[,] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
        }
    }
}
