using System;
using System.Linq;

namespace evenOddSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int evenSum = 0;
            int oddSum = 0;

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNum = numbers[i];
                if (currentNum % 2 == 0)
                {
                    evenSum += currentNum;
                }
                else
                {
                    oddSum += currentNum;
                }
                
            }
            int diference = evenSum - oddSum;
            Console.WriteLine(diference);
            //Console.WriteLine(evenSum);



        }
    }
}
