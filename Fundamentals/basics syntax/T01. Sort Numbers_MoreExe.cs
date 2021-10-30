using System;

namespace T01._Sort_Numbers_MoreExe
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numbers);
            Array.Reverse(numbers);
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
