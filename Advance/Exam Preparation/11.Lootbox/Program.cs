using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.Lootbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> firstBox = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> secondBox = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int value = 0;

            while (firstBox.Count > 0 && secondBox.Count > 0)
            {

                if ((firstBox.Peek() + secondBox.Peek()) % 2 == 0)
                {
                    value += (firstBox.Dequeue() + secondBox.Pop());
                }
                else
                {
                    firstBox.Enqueue(secondBox.Pop());
                }               
            }

            Console.WriteLine(firstBox.Count <= 0 ? "First lootbox is empty" : "Second lootbox is empty");

            Console.WriteLine(value >= 100 ?
                $"Your loot was epic! Value: {value}"
                : $"Your loot was poor... Value: {value}");
        }
    }
}
