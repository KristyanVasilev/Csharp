using System;
using System.Linq;

namespace _02.TheBattleОfTheFiveArmies
{
    class Program
    {
        static void Main(string[] args)
        {
            int armor = int.Parse(Console.ReadLine());
            int numOfRows = int.Parse(Console.ReadLine());
            var field = ReadJaggedArray(numOfRows);

            var heroPositon = FindHeroPositon(field);
            int heroRow = heroPositon[0];
            int heroCol = heroPositon[1];

            while (true)
            {
                var commandLine = Console.ReadLine();
                var commandParts = commandLine.Split(' ');
                var command = commandParts[0];
                var orcRow = int.Parse(commandParts[1]);
                var orcCol = int.Parse(commandParts[2]);

                armor--;
                field[orcRow][orcCol] = 'O';
                field[heroRow][heroCol] = '-';

                // Move
                if (command == "up" && heroRow - 1 >= 0)
                {
                    heroRow--;
                }
                else if (command == "down" && heroRow + 1 < numOfRows)
                {
                    heroRow++;
                }
                else if (command == "left" && heroCol - 1 >= 0)
                {
                    heroCol--;
                }
                else if (command == "right" && heroCol + 1 < field[heroRow].Length)
                {
                    heroCol++;
                }

                // Already moved
                if (field[heroRow][heroCol] == 'O')
                {
                    armor -= 2;
                }

                if (field[heroRow][heroCol] == 'M')
                {
                    field[heroRow][heroCol] = '-';
                    Console.WriteLine($"The army managed to free the Middle World! Armor left: {armor}");
                    break;
                }

                if (armor <= 0)
                {
                    field[heroRow][heroCol] = 'X';
                    Console.WriteLine($"The army was defeated at {heroRow};{heroCol}.");
                    break;
                }

                field[heroRow][heroCol] = 'A';
            }

            PrintJaggedArray(field);
        }

        private static int[] FindHeroPositon(char[][] field)
        {
            var heroPosition = new int[2];
            for (int i = 0; i < field.Length; i++)
            {
                for (int j = 0; j < field[i].Length; j++)
                {
                    if (field[i][j] == 'A')
                    {
                        heroPosition[0] = i;
                        heroPosition[1] = j;
                    }
                }
            }
            return heroPosition;
        }

        private static char[][] ReadJaggedArray(int numOfRows)
        {
            char[][] jaggedArray = new char[numOfRows][];
            for (int i = 0; i < numOfRows; i++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                
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
                Console.WriteLine(string.Join("", jaggedArray[i]));
            }
        }
    }
}
