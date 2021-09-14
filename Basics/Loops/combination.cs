using System;

namespace combination
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int combinationCounter = 0;
            

            for (int num1 = 0; num1 <= N; num1++)
            {
                for (int num2 = 0; num2 <= N; num2++)
                {
                    for (int num3 = 0; num3 <= N; num3++)
                    {
                        if (num1 + num2 + num3 == N)
                        {
                            combinationCounter++;                           
                        }
                    }
                }
            }
                            Console.WriteLine(combinationCounter);
        }
    }
}
