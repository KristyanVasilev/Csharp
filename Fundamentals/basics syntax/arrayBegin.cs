using System;
using System.Linq;


namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] num = new int[4];
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(num);

            for (int j = 0; j < num.Length; j++)
            {
                Console.WriteLine(num[j]);
            }

            ////--------------------------------------------------------------------------------------

            int[] numbers = Console.ReadLine().Split(",").Select(int.Parse).ToArray();

            Array.Sort(numbers);

            Console.WriteLine(string.Join(",", numbers));


            ////---------------------------------------------------------------------------------------

            string[] movies = Console.ReadLine().Split(" ");

            Array.Sort(movies);

            Console.WriteLine(string.Join(", ", movies));
        }
    }
}