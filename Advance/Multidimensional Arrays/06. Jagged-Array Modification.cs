using System;
using System.Linq;

namespace _06._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] arrays = new int[n][];

            for (int i = 0; i < n; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                arrays[i] = new int[numbers.Length];
                for (int j = 0; j < numbers.Length; j++)
                {
                    arrays[i][j] = numbers[j];
                }
            }

            string commands = Console.ReadLine();
            while (commands != "END")
            {
                string[] curCmd = commands.Split();
                int row = int.Parse(curCmd[1]);
                int col = int.Parse(curCmd[2]);
                int value = int.Parse(curCmd[3]);
                if (row < 0 || row >= arrays.Length || col < 0 || col >= arrays[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    commands = Console.ReadLine();
                    continue;
                }
                if (curCmd[0] == "Add")
                {
                    arrays[row][col] += value;
                }
                else if (curCmd[0] == "Subtract")
                {
                    arrays[row][col] -= value;
                }

                commands = Console.ReadLine();
            }

            for (int i = 0; i < arrays.Length; i++)
            {
                Console.WriteLine(string.Join(" ", arrays[i]));
            }
        }
    }
}
