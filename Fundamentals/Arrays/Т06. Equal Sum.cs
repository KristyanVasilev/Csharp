using System;
using System.Linq;

namespace Т06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rightSum = 0;
            int leftSum = 0;

            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                if (numbers.Length == 1)
                {
                    Console.WriteLine(0);
                    return;
                }

                //leftSum
                leftSum = 0;
                for (int sumLeft = i ; sumLeft > 0; sumLeft--)
                {
                    int nextElemntPosition = sumLeft - 1; //Взимаме първия елемент от лявата ни страна, който ще ни бъде [0].
                    if (sumLeft >0)
                    {
                        leftSum += numbers[nextElemntPosition];
                    }
                }

                //rightSum
                rightSum = 0;
                for (int sumRight = i; sumRight < numbers.Length; sumRight++)
                {
                    int nextElemntPosition = (sumRight + 1);
                    if (sumRight < numbers.Length - 1)
                    {
                        rightSum += numbers[nextElemntPosition];
                    }
                }

                if (rightSum == leftSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");

        }
    }
}
