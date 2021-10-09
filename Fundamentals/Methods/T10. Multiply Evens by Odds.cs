using System;

namespace T10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Math.Abs(int.Parse(Console.ReadLine()));
            int sum = 0;
            int evenSum = 0;
            int oddSum = 0;

            while (input > 0)
            {
                sum = input % 10;
                input /= 10;
                if (sum % 2 == 0)
                {
                    evenSum += sum;
                }
                else
                {
                    oddSum += sum;
                }
            }
            Console.WriteLine(GetMultipleOfEvenAndOdds(evenSum, oddSum));
        }

        static int GetMultipleOfEvenAndOdds(int evenSum, int oddSum)
        {
            int sum = evenSum * oddSum;
            return sum;
        }
    }
}
