using System;

namespace _01._The_Biscuit_Factory.exam
{
    class Program
    {
        static void Main(string[] args)
        {
            double producedBiscuitsPerWorker = double.Parse(Console.ReadLine());
            double countOfWorkers = double.Parse(Console.ReadLine());
            double otherFactory = double.Parse(Console.ReadLine());

            double totalBuscuits = producedBiscuitsPerWorker * countOfWorkers;
            double thirdDay = Math.Floor(totalBuscuits * 0.75);
            double total = Math.Floor((totalBuscuits * 20) + (thirdDay * 10));
            double difference = total - otherFactory;
            double totalDiff = (difference / otherFactory) * 100;

            Console.WriteLine($"You have produced {total} biscuits for the past month.");
            if (total < otherFactory)
            {
                Console.WriteLine($"You produce {Math.Abs(totalDiff):f2} percent less biscuits.");
            }
            else
            {
                Console.WriteLine($"You produce {Math.Abs(totalDiff):f2} percent more biscuits.");
            }
        }
    }
}
