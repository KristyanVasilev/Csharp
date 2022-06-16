using System;

namespace _12.VariationsWithoutRepetition
{
    internal class Program
    {
        public static string[] elements;
        public static string[] varations;
        public static bool[] used;
        public static int k;

        static void Main(string[] args)
        {
            elements = Console.ReadLine().Split(" ");
            k = int.Parse(Console.ReadLine());
            varations = new string[k];
            used = new bool[elements.Length];

            GetVarations(0);
        }

        private static void GetVarations(int index)
        {
            if (index == varations.Length)
            {
                Console.WriteLine(String.Join(" ", varations));
                return;
            }

            for (int i = 0; i < elements.Length; i++)
            {
                if (!used[i])
                {
                    used[i] = true;
                    varations[index] = elements[i];
                    GetVarations(index + 1);
                    used[i] = false;
                }
            }
        }
    }
}
