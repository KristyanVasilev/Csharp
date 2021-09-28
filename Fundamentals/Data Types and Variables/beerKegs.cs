using System;

namespace beerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double biggestKeg = double.MinValue;
            string biggestKegModelName = "";

            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volumeOfCurrentKeg = Math.PI * Math.Pow(radius, 2) * height;
                if (volumeOfCurrentKeg > biggestKeg)
                {
                    biggestKeg = volumeOfCurrentKeg;
                    biggestKegModelName = model;
                }
            }
            Console.WriteLine(biggestKegModelName);
        }
    }
}
