using System;
using System.Numerics;

namespace T02._Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            FactorialCalculator calculator = new FactorialCalculator(n);

            Console.WriteLine(calculator.Calculate());

        }
    }   
}
