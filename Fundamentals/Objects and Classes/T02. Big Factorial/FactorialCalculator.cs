using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace T02._Big_Factorial
{
    class FactorialCalculator
    {
        public FactorialCalculator(int n)
        {
            N = n;

        }

        public int N { get; set; }

        public BigInteger Calculate()
        {
            BigInteger factorial = 1;

            for (int i = 2; i <= N; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
