using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.BirthdayCelebration
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> guestsCapacity = new Queue<int>(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Stack<int> preparedPlates = new Stack<int>(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            int wastedFood = 0;

            while (guestsCapacity.Count > 0 && preparedPlates.Count > 0)
            {
                int currCup = guestsCapacity.Peek();
                while (currCup > 0 && preparedPlates.Count > 0)
                {
                    currCup -= preparedPlates.Pop();
                    if (currCup <= 0)
                    {
                        guestsCapacity.Dequeue();
                        wastedFood += Math.Abs(currCup);
                        break;
                    }
                }
            }

            Console.WriteLine(guestsCapacity.Count > 0 ? $"Guests: {string.Join(" ", guestsCapacity)}" : $"Plates: {string.Join(" ", preparedPlates)}");
            Console.WriteLine($"Wasted grams of food: {wastedFood}");
        }
    }
}
