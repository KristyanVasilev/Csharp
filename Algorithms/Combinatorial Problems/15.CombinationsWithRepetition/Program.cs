using System;

namespace _15.CombinationsWithRepetition
{
    internal class Program
    {
        public static string[] elements;
        public static string[] combinations;
        public static int k;

        static void Main(string[] args)
        {
            elements = Console.ReadLine().Split(" ");
            k = int.Parse(Console.ReadLine());
            combinations = new string[k];

            GetCombinations(0, 0);
        }

        private static void GetCombinations(int index, int startIndex)
        {
            if (index == combinations.Length)
            {
                Console.WriteLine(String.Join(" ", combinations));
                return;
            }

            for (int i = startIndex; i < elements.Length; i++)
            {
                combinations[index] = elements[i];
                GetCombinations(index + 1, i);
            }
        }
    }
}
