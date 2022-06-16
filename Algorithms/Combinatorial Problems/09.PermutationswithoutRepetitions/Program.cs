using System;
using System.Linq;

namespace _09.PermutationswithoutRepetitions
{
    public class Program
    {
        public static string[] elements;
        public static string[] permutation;
        public static bool[] used;

        static void Main(string[] args)
        {
            elements = Console.ReadLine().Split(" ").ToArray();
            permutation = new string[elements.Length];
            used = new bool[elements.Length];

            Permute(0);
        }

        private static void Permute(int index)
        {
            if (index == permutation.Length)
            {
                Console.WriteLine(String.Join(" ", permutation));
                return;
            }

            for (int i = 0; i < elements.Length; i++)
            {
                if (!used[i])
                {
                    used[i] = true;
                    permutation[index] = elements[i];
                    Permute(index + 1);
                    used[i] = false;
                }
            }
        }
    }
}
