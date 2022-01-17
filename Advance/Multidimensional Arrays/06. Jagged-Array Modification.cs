using System;
using System.Linq;

namespace _06._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] jaggedArray = ReadJaggedArray(n);
            
            string commands = Console.ReadLine();
            while (commands != "END")
            {
                string[] curCmd = commands.Split();
                int row = int.Parse(curCmd[1]);
                int col = int.Parse(curCmd[2]);
                int value = int.Parse(curCmd[3]);
                if (row < 0 || row >= jaggedArray.Length || col < 0 || col >= jaggedArray[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    commands = Console.ReadLine();
                    continue;
                }
                if (curCmd[0] == "Add") jaggedArray[row][col] += value;
                else if (curCmd[0] == "Subtract") jaggedArray[row][col] -= value;

                commands = Console.ReadLine();
            }

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine(string.Join(" ", jaggedArray[i]));
            }
        }

        private static int[][] ReadJaggedArray(int n)
        {
            int[][] jaggedArray = new int[n][];
            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jaggedArray[i] = new int[input.Length];
                for (int j = 0; j < input.Length; j++)
                {
                    jaggedArray[i][j] = input[j];
                }
            }
            return jaggedArray;
        }
    }
}
