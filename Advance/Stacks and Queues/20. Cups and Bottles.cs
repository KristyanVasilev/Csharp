using System;
using System.Collections.Generic;
using System.Linq;

namespace _20._Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> cupsCapacity = new Queue<int>(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Stack<int> filledBottles = new Stack<int>(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            int wastedWater = 0;

            while (cupsCapacity.Count > 0 && filledBottles.Count > 0)
            {
                int currCup = cupsCapacity.Peek();
                while (currCup > 0 && filledBottles.Count > 0)
                {
                    currCup -= filledBottles.Pop();
                    if (currCup <= 0)
                    {
                        cupsCapacity.Dequeue();
                        wastedWater += Math.Abs(currCup);
                        break;
                    }
                }
            }

            Console.WriteLine(cupsCapacity.Count > 0 ? $"Cups: {string.Join(" ", cupsCapacity)}" : $"Bottles: {string.Join(" ", filledBottles)}");
            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
