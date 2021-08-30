using System;

namespace cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            string stop = Console.ReadLine();
            int cakePieces = 0;
            int cakeSize = a * b;

            while (stop != "STOP")
            {
                int pieces = int.Parse(stop);
                if (cakeSize >= cakePieces)
                {
                    cakePieces += pieces;
                    if (cakeSize < cakePieces)
                    {
                        Console.WriteLine($"No more cake left! You need {Math.Abs(cakeSize - cakePieces)} pieces more.");
                        return;
                    }                   
                }
                stop = Console.ReadLine();
            }
            Console.WriteLine($"{Math.Abs(cakeSize-cakePieces)} pieces are left.");
        }
    }
}
