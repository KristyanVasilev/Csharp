using System;
using System.Collections.Generic;
using System.Linq;

namespace T03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> mergedList = new List<int>();


            int biggestLenght = list1.Count;
            if (biggestLenght < list2.Count)
            {
                biggestLenght = list2.Count;
            }

            for (int i = 0; i < biggestLenght; i++)
            {
                if (list1.Count > i)
                {
                    mergedList.Add(list1[i]);
                }

                if (list2.Count > i)
                {
                    mergedList.Add(list2[i]);
                }
            }

            Console.WriteLine(string.Join(" ", mergedList));

        }
    }
}
