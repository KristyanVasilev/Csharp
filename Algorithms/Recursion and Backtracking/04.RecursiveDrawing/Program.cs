using System;

namespace _04.RecursiveDrawing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            RecursiveDrawing(num);
        }

        private static void RecursiveDrawing(int num)
        {
            if (num <= 0)
            {
                return;
            }
            Console.WriteLine(new string('*', num));
            RecursiveDrawing(num - 1);
            Console.WriteLine(new string('#', num));
        }
    }
}
