using System;

namespace _13._String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;

            foreach (var item in input)
            {
                char firstLetter = item[0];
                char lastLetter = item[^1];
                string numAsString = item[1..^1];
                double numFromstring = double.Parse(numAsString);

                if (char.IsUpper(firstLetter))
                {
                    int position = firstLetter - 64;
                    numFromstring /= position;
                }
                else
                {
                    int position = firstLetter - 96;
                    numFromstring *= position;
                }
                if (char.IsUpper(lastLetter))
                {
                    int position = lastLetter - 64;
                    numFromstring -= position;
                }
                else
                {
                    int position = lastLetter - 96;
                    numFromstring += position;
                }

                sum += numFromstring;
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
