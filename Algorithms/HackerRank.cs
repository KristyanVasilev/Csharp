using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace _20.ConnectedAreasInAMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var MinMaxArr = new List<int> { 256741038, 623958417, 467905213, 714532089, 938071625 };//2063136757 2744467344
            //var findMedianArr = new List<int> { 0, 1, 2, 4, 5, 6, 3 };
            //var lonelyintegerArr = new List<int> { 1, 2, 3, 4, 1, 2, 3 };
            ////Console.WriteLine(timeConversion("12:40:22AM"));
            //Console.WriteLine(lonelyinteger(lonelyintegerArr));
            //        List<List<int>> matrix = new List<List<int>> {
            //new List<int>() { 7, 2, 3, 1 },
            //new List<int>() { 1, 8, 2, 2 },
            //new List<int>() { 3, 4, 7, 4 },
            //new List<int>() { 3, 4, 7, 1 }};
            //Console.WriteLine(diagonalDifference(matrix));

            //112 42 83 119
        }
        public static void plusMinus(List<int> arr)
        {
            var arrSize = arr.Count;
            double positive = 0;
            double negative = 0;
            double zero = 0;

            foreach (var item in arr)
            {
                if (item == 0)
                {
                    zero++;
                }
                else if (item > 0)
                {
                    positive++;
                }
                else
                {
                    negative++;
                }
            }

            Console.WriteLine($"{(positive / arrSize):f6}");
            Console.WriteLine($"{(negative / arrSize):f6}");
            Console.WriteLine($"{(zero / arrSize):f6}");
        }
        public static int diagonalDifference(List<List<int>> arr)
        {
            int right = 0;
            int left = 0;

            int count = arr.Count - 1;
            for (int col = 0; col < arr.Count; col++)
            {
                right += arr[count][col];
                count--;
            }

            int countLeft = 0;
            for (int col = 0; col < arr.Count; col++)
            {
                left += arr[countLeft][col];
                countLeft++;
            }

            return Math.Abs(right - left);
        } 

        public static int lonelyinteger(List<int> a)
        {
            var uniques = a.GroupBy(x => x)
                       .Where(x => x.Count() == 1)
                       .Select(x => x.Key)
                       .First();

            return uniques;
        }
        public static int findMedian(List<int> arr)
        {
            arr.Sort();
            var middleIndex = (int)arr.Count() / 2;
            return arr[middleIndex];
        }
        public static void FizzBuzz(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static string timeConversion(string s)
        {
            DateTime timeValue = Convert.ToDateTime(s);
            var time = timeValue.ToString("HH:mm:ss");
            return time;
        }
        public static void MinMax(List<int> arr)
        {
            long minValue = long.MaxValue;
            long maxValue = long.MinValue;
            long sum = 0;

            foreach (var item in arr)
            {
                sum += item;
            }

            for (int i = 0; i < arr.Count; i++)
            {         
                if ((sum - arr[i]) < minValue)
                {
                    minValue = sum - arr[i];
                }

                if ((sum - arr[i]) > maxValue)
                {
                    maxValue = sum - arr[i];
                }
            }

            Console.WriteLine($"{Math.Abs(minValue)} {Math.Abs(maxValue)}");
        }
    }
}
