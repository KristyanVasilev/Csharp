using System;
using System.Linq;


namespace _07._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            int finalSum = GetStringSum(input[0], input[1]);
            Console.WriteLine(finalSum);
        }

        private static int GetStringSum(string inputOne, string inputTwo)
        {
            int sum = 0;
            int minLenght = Math.Min(inputOne.Length, inputTwo.Length);
            for (int i = 0; i < minLenght; i++)
            {
                sum += inputOne[i] * inputTwo[i];
            }
            string longestString = inputOne;
            if (longestString.Length < inputTwo.Length)
            {
                longestString = inputTwo;
            }
            for (int i = minLenght; i < longestString.Length; i++)
            {
                sum += longestString[i];
            }

            return sum;
        }
    }
}
