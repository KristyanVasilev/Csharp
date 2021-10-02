using System;
using System.Linq;

namespace equalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;

            //if (array1.Length != array2.Length)
            //{

            //}
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
                sum += array1[i];
            }
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}
