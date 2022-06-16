using System;

namespace _13.VariationsWithtRepetition
{
    internal class Program
    {
        public static string[] elements;
        public static string[] varations;
        public static int k;

        static void Main(string[] args)
        {
            elements = Console.ReadLine().Split(" ");
            k = int.Parse(Console.ReadLine());
            varations = new string[k];

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
                varations[index] = elements[i];
                GetVarations(index + 1);
            }
        }
    }
}
