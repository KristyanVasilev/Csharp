using System;
using System.Collections.Generic;
using System.Linq;

namespace _13._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> racks = new Stack<int>(clothes);
            int rackCapacity = int.Parse(Console.ReadLine());
            int sum = 0;
            int rackCount = 0;

            while (racks.Count > 0)
            {
                int piece = racks.Peek();
                sum += piece;
                if (sum < rackCapacity) racks.Pop();

                if (sum == rackCapacity)
                {
                    racks.Pop();
                    sum = 0;
                    rackCount++;
                }
                else if (sum > rackCapacity)
                {
                    sum = 0;
                    rackCount++;
                }
            }
            if (sum > 0) rackCount++;
            Console.WriteLine(rackCount);
        }
    }
}
