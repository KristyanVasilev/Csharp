using System;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Func<string, bool> isUpper = word => char.IsUpper(word[0]);
            var upperChar = input.Where(isUpper);
            foreach (var word in upperChar)
            {
                Console.WriteLine(word);
            }
        }
    }
}
