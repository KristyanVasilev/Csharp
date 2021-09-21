using System;
using System.Linq;
using System.Collections.Generic;

namespace mergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> secondNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> result = new List<int>();

            int minCount = Math.Min(firstNumbers.Count, secondNumbers.Count);

            for (int i = 0; i < minCount; i++)
            {
                result.Add(firstNumbers[i]);
                result.Add(secondNumbers[i]);
            }

            List<int> biggerList;

            if (minCount == firstNumbers.Count)
            {
                biggerList = secondNumbers;
            }
            else
            {
                biggerList = firstNumbers;
            }

            for (int j = minCount; j < biggerList.Count; j++)
            {
                result.Add(biggerList[j]);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
