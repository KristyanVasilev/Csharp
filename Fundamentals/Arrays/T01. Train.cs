using System;

namespace T01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int[] passengers = new int[wagons];
            int sum = 0;

            for (int i = 0; i < wagons; i++)
            {
                passengers[i] = int.Parse(Console.ReadLine());
                sum += passengers[i];
            }
            Console.WriteLine(string.Join(" ", passengers));
            Console.WriteLine(sum);
        }
    }
}
