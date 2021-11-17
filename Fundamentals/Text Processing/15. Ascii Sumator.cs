using System;

namespace _15._Ascii_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string newText = "";
            int sum = 0;

            foreach (char symbol in input)
            {
                if (symbol > start && symbol < end)
                {
                    newText += symbol;
                }
            }
            foreach (char newSymbol in newText)
            {
                int currPosition = newSymbol;
                sum += newSymbol;
            }
            Console.WriteLine(sum);
        }
    }
}
