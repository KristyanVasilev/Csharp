using System;
using System.Linq;

namespace _08._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int[], int> printSmallestNum = number =>
            {
                int smallestNum = int.MaxValue;
                foreach (var num in number)
                {
                    if (num < smallestNum)
                    {
                        smallestNum = num;
                    }
                }
                return smallestNum;
            };
            Console.WriteLine(printSmallestNum(input));
        }

    }
}
/*Create a simple program that reads from the console a set of integers and prints back on the console the smallest number from the collection. Use Func<T, T>.*/
