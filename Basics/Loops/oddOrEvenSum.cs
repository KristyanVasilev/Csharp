using System;

namespace oddOrEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int evenNumber = 0;
            int oddNumber = 0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenNumber += number;
                }
                else
                {
                    oddNumber += number;
                }
            }

            if (evenNumber == oddNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {oddNumber}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(oddNumber - evenNumber)}");
            }
        }
    }
}
