using System;
using System.Collections.Generic;
using System.Linq;

namespace T06._Cards_Game.ex
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sum = 0;

            for (int i = 0; i < firstPlayer.Count +1; i++)
            {
                if (firstPlayer.Count <= 0)
                {
                    for (int j = 0; j < secondPlayer.Count; j++)
                    {
                        sum += secondPlayer[j];
                    }
                    Console.WriteLine($"Second player wins! Sum: {sum}");
                    break;
                }
                else if (secondPlayer.Count <= 0)
                {
                    for (int k = 0; k < firstPlayer.Count; k++)
                    {
                        sum += firstPlayer[k];
                    }
                    Console.WriteLine($"First player wins! Sum: {sum}");
                    break;
                }

                if (firstPlayer[i] == secondPlayer[i])
                {
                    firstPlayer.RemoveAt(i);
                    secondPlayer.RemoveAt(i);
                }
                else if (firstPlayer[i] > secondPlayer[i])
                {
                    firstPlayer.Add(firstPlayer[i]);
                    firstPlayer.Add(secondPlayer[i]);
                    secondPlayer.RemoveAt(i);
                    firstPlayer.RemoveAt(i);
                }
                else if (firstPlayer[i] < secondPlayer[i])
                {
                    secondPlayer.Add(secondPlayer[i]);
                    secondPlayer.Add(firstPlayer[i]);
                    firstPlayer.RemoveAt(i);
                    secondPlayer.RemoveAt(i);
                }
                i = -1;

            }
        }
    }
}
