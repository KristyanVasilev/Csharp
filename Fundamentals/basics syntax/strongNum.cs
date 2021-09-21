using System;

namespace strongNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int temNum = num;
            int factoroilalSum = 0;

            while (temNum > 0)
            {
                int currentNum = temNum % 10;
                temNum /= 10;
                int curFactorialNum = 1;

                for (int i = 1; i <= currentNum; i++)
                {
                    curFactorialNum *= i;
                }
                factoroilalSum += curFactorialNum;
            }

            if (factoroilalSum == num)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
