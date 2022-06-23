using System;

namespace _19.NestedLoopsToRecursion
{
    public class Program
    {
        private static int[] arr;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            arr = new int[n];
            GenerateNumbers(0);
        }

        private static void GenerateNumbers(int index)
        {
            if (index >= arr.Length)
            {
                Console.WriteLine(String.Join(" ", arr));
                return;
            }
            for (int i = 1; i <= arr.Length; i++)
            {
                arr[index] = i;
                GenerateNumbers(index + 1);
            }
        }
    }
}
