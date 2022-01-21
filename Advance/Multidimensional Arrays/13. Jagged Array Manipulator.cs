using System;
using System.Linq;

namespace _13._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfArr = int.Parse(Console.ReadLine());
            double[][] jaggedArray = ReadJaggedArray(numOfArr);

            for (int i = 0; i < numOfArr; i++)
            {
                if (i + 1 < numOfArr)
                {
                    if (jaggedArray[i].Length == jaggedArray[i + 1].Length) MultiplyRowsBy2(jaggedArray, i);
                    else DivideRowsBy2(jaggedArray, i);
                }
            }
            ManipulateJaggedArray(jaggedArray);
            PrintJaggedArray(jaggedArray);
        }

        private static void ManipulateJaggedArray(double[][] jaggedArray)
        {
            string[] command = Console.ReadLine().Split();
            while (command[0] != "End")
            {
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                int value = int.Parse(command[3]);
                if (command[0] == "Add")
                {
                    if (row >= 0 && row <= jaggedArray.Length-1 && col >= 0 && col <= jaggedArray[row].Length-1)
                    {
                        jaggedArray[row][col] += value;
                    }
                }
                else if (command[0] == "Subtract")
                {
                    if (row >= 0 && row <= jaggedArray.Length-1 && col >= 0 && col <= jaggedArray[row].Length-1)
                    {
                        jaggedArray[row][col] -= value;
                    }
                }

                command = Console.ReadLine().Split();
            }
        }

        private static void PrintJaggedArray(double[][] jaggedArray)
        {
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine(string.Join(" ", jaggedArray[i]));
            }
        }

        private static void DivideRowsBy2(double[][] jaggedArray, int i)
        {
            for (int row = i; row <= i + 1; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    jaggedArray[row][col] /= 2;
                }
            }
        }

        private static void MultiplyRowsBy2(double[][] jaggedArray, int i)
        {
            for (int row = i; row <= i + 1; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    jaggedArray[row][col] *= 2;
                }
            }
        }

        private static double[][] ReadJaggedArray(int numOfArr)
        {
            double[][] jaggedArray = new double[numOfArr][];
            for (int i = 0; i < numOfArr; i++)
            {
                double[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
                jaggedArray[i] = new double[input.Length];
                for (int j = 0; j < input.Length; j++)
                {
                    jaggedArray[i][j] = input[j];
                }
            }
            return jaggedArray;
        }
    }
}
