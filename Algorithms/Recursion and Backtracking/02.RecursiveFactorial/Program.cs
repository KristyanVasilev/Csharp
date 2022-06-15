using System;
using System.Linq;

namespace _02.RecursiveFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = GetFactoriel(n);
            Console.WriteLine(sum);
        }

        private static int GetFactoriel(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return n * GetFactoriel(n - 1);
        }
    }
}
