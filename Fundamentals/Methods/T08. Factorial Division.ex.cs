using System;

namespace T08._Factorial_Division.ex
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());

            double divideOfFact = PrintFacturial(number1, number2);
            Console.WriteLine($"{Math.Abs(divideOfFact):f2}");
        }

        static double PrintFacturial(double number1, double number2)
        {
            double sumOfFirstFactorial = 1;
            double sumOfSecondFactorial = 1;

            for (double firstFact = number1; firstFact > 0; firstFact--)
            {
                sumOfFirstFactorial *= firstFact;
            }

            for (double secondFact = number2; secondFact > 0; secondFact--)
            {
                sumOfSecondFactorial *= secondFact;
            }

            double divideOfFact =  sumOfFirstFactorial  / sumOfSecondFactorial;
            return divideOfFact;
        }
    }
}
