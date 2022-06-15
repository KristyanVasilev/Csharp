using System;

namespace _05.Generating01Vectors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var arr = new int[n];
            GenerateVectors(arr, 0);
        }

        private static void GenerateVectors(int[] arr, int index)
        {
            if (index == arr.Length)
            {
                Console.WriteLine(String.Join("", arr));
                return;
            }
            for (int i = 0; i <= 1 ; i++)
            {
                arr[index] = i;
                GenerateVectors(arr, index + 1);
            }
        }
    }
}
