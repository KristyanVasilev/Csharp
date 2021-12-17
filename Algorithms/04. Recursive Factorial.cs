using System;

namespace _04._Recursive_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(CalcFacturielRecur(n));
        }

        private static int CalcFacturielRecur(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * CalcFacturielRecur(n - 1);
        }
    }
}
