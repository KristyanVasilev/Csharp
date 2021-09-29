using System;
using System.Numerics;
namespace EX11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberSnowballs = int.Parse(Console.ReadLine());
            BigInteger bestValue = 0;
            int bestSnow = 0;
            int bestTime = 0;
            int bestQuality = 0;
            for (int i = 0; i < numberSnowballs; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                if (snowballTime > 0)
                {
                    BigInteger snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);
                    if (bestValue <= snowballValue)
                    {
                        bestSnow = snowballSnow;
                        bestTime = snowballTime;
                        bestQuality = snowballQuality;
                        bestValue = snowballValue;
                    }
                }
            }
            Console.WriteLine($"{bestSnow} : {bestTime} = {bestValue} ({bestQuality})");
        }
    }
}