using System;

namespace exe_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 50, 60, 100, 35 };

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] += 10;
            }
            Console.WriteLine(string.Join(",",nums));
        }
    }
}
