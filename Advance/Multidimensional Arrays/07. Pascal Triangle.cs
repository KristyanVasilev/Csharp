using System;
using System.Linq;

namespace _07._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[][] pascal = new long[n][];

            for (int i = 0; i < n; i++)
            {
                pascal[i] = new long[i + 1];
                pascal[i][0] = 1;
                pascal[i][pascal[i].Length - 1] = 1;
                for (int j = 1; j < pascal[i].Length - 1; j++)
                {
                    pascal[i][j] = pascal[i - 1][j] + pascal[i - 1][j - 1];
                }
            }

            for (int i = 0; i < pascal.Length; i++)
            {
                Console.WriteLine(string.Join(" ", pascal[i]));
            }
        }
    }
}
