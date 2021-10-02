using System;
using System.Linq;

namespace condenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] condensed = new int[nums.Length];
            int counter = 1;
            int lenght = nums.Length;

            if (lenght == 1)
            {
                Console.WriteLine(nums[0]);
                return;
            }

            while (true)
            {
                for (int i = 0; i < nums.Length - counter; i++)
                {
                    condensed[i] = nums[i] + nums[i + 1];
                }
                counter++;

                nums = condensed;
                if (lenght == counter)
                {
                    break;
                }

            }

            Console.WriteLine(condensed[0]);

        }

    }
}
