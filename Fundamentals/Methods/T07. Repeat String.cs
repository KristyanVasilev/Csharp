using System;

namespace T07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            RepeatString(input, n);
        }

        static void RepeatString(string input, int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(input);
            }
        }
    }
}
