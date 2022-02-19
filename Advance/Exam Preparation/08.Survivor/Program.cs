using System;
using System.Linq;

namespace _08.Survivor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfRows = int.Parse(Console.ReadLine());
            var field = ReadJaggedArray(numOfRows);
            int playerOnePoints = 0;
            int playerTwoPoints = 0;

            string commands = Console.ReadLine();
            while (commands != "Gong")
            {
                var currCmd = commands.Split();
                string playerRole = currCmd[0];
                int row = int.Parse(currCmd[1]);
                int col = int.Parse(currCmd[2]);

                if (playerRole == "Find")
                {
                    if (IsInRange(field, row, col, numOfRows) && field[row][col] == 'T')
                    {
                        field[row][col] = '-';
                        playerOnePoints++;
                    }
                }
                else if (playerRole == "Opponent")
                {
                    string direction = currCmd[3];
                    if (IsInRange(field, row, col, numOfRows) && field[row][col] == 'T')
                    {
                        field[row][col] = '-';
                        playerTwoPoints++;
                    }
                    if (direction == "up")
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            row--;
                            if (IsInRange(field, row, col, numOfRows) && field[row][col] == 'T')
                            {
                                field[row][col] = '-';
                                playerTwoPoints++;
                            }
                        }
                    }
                    if (direction == "down")
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            row++;
                            if (IsInRange(field, row, col, numOfRows) && field[row][col] == 'T')
                            {
                                field[row][col] = '-';
                                playerTwoPoints++;
                            }
                        }
                    }
                    if (direction == "right")
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            col++;
                            if (IsInRange(field, row, col, numOfRows) && field[row][col] == 'T')
                            {
                                field[row][col] = '-';
                                playerTwoPoints++;
                            }
                        }
                    }
                    if (direction == "left")
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            col--;
                            if (IsInRange(field, row, col, numOfRows) && field[row][col] == 'T')
                            {
                                field[row][col] = '-';
                                playerTwoPoints++;
                            }
                        }
                    }
                }

                commands = Console.ReadLine();
            }

            PrintJaggedArray(field);
            Console.WriteLine($"Collected tokens: {playerOnePoints}");
            Console.WriteLine($"Opponent's tokens: {playerTwoPoints}");
        }
        private static bool IsInRange(char[][] field, int row, int col, int numOfRows)
        {
            return row >= 0 && row < numOfRows && col >= 0 && col < field[row].Length;
        }
        private static char[][] ReadJaggedArray(int numOfRows)
        {
            char[][] jaggedArray = new char[numOfRows][];
            for (int i = 0; i < numOfRows; i++)
            {
                char[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                jaggedArray[i] = new char[input.Length];
                for (int j = 0; j < input.Length; j++)
                {
                    jaggedArray[i][j] = input[j];
                }
            }
            return jaggedArray;
        }
        private static void PrintJaggedArray(char[][] jaggedArray)
        {
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine(string.Join(" ", jaggedArray[i]));
            }
        }
    }
}
