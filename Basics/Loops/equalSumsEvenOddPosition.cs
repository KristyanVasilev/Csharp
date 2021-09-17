using System;

namespace equalSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int value = start; value <= end; value++)
            {
                int curretNum = value;
                int evenSum = 0;
                int oddSum = 0;
                int count = 0;
                while (curretNum != 0)
                {
                    int diggit = curretNum % 10;
                    if (count % 2 == 0)
                    {
                        evenSum += diggit;
                    }
                    else
                    {
                        oddSum += diggit;
                    }
                    curretNum /= 10;
                    count++;
                }
                if (evenSum == oddSum)
                {
                    Console.Write(value + " ");
                }


            }

        }
    }
}
