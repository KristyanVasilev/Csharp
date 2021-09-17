using System;

namespace numberPyramide
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isBigger = false;
            int current = 1;

            for (int rows = 1; rows <= n; rows++)
            {
                for (int colums = 1; colums <= rows; colums++)
                {
                    if (current > n)
                    {
                        isBigger = true;
                        break;
                    }
                    Console.Write(current + " ");
                    current++;
                }
                if (isBigger)
                {
                    break;
                }
                Console.WriteLine();
            }

        }
    }
}
