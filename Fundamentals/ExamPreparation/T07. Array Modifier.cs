using System;
using System.Linq;
using System.Collections.Generic;

namespace T07._Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] cmd = Console.ReadLine().Split();

            while (cmd[0] != "end")
            {
                if (cmd[0] == "swap")
                {
                    int firstIndex = int.Parse(cmd[1]);
                    int secondtIndex = int.Parse(cmd[2]);
                    int currElement = numbers[firstIndex];
                    numbers[firstIndex] = numbers[secondtIndex];
                    numbers[secondtIndex] = currElement;
                }
                else if (cmd[0] == "multiply")
                {
                    int firstIndex = int.Parse(cmd[1]);
                    int secondtIndex = int.Parse(cmd[2]);
                    int sum = numbers[firstIndex] * numbers[secondtIndex];
                    numbers[firstIndex] = sum;                    
                }
                else if (cmd[0] == "decrease")
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] -= 1;
                    }
                }
                cmd = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
