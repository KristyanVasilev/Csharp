using System;
using System.Collections.Generic;
using System.Linq;

namespace _15._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int[]> truckTour = new Queue<int[]>();

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                truckTour.Enqueue(input);
            }

            int startIndex = 0;

            while (true)
            {
                int currPetrol = 0;
                foreach (var tour in truckTour)
                {
                    int petrolAmount = tour[0];
                    int truckDistance = tour[1];

                    currPetrol += petrolAmount;
                    currPetrol -= truckDistance;
                    if (currPetrol < 0)
                    {
                        int[] petrolStation = truckTour.Dequeue();
                        truckTour.Enqueue(petrolStation);
                        startIndex++;
                        break;
                    }
                }

                if (currPetrol >= 0)
                {
                    Console.WriteLine(startIndex);
                    break;
                }
            }
        }
    }
}
