using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfQueries = int.Parse(Console.ReadLine());
            Stack<int> numbers = new Stack<int>();
            for (int i = 0; i < numOfQueries; i++)
            {
                int[] command = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (command[0] == 1)
                {
                    numbers.Push(command[1]);
                }
                else if (command[0] == 2)
                {
                    if (numbers.Count > 0)
                    {
                        numbers.Pop();
                    }
                }
                else if (command[0] == 3)
                {
                    if (numbers.Count > 0)
                    {
                        int maxElement = int.MinValue;
                        foreach (var number in numbers)
                        {
                            if (maxElement < number)
                            {
                                maxElement = number;
                            }
                        }
                        Console.WriteLine(maxElement);
                    }
                }
                else if (command[0] == 4)
                {
                    if (numbers.Count > 0)
                    {
                        int minElement = int.MaxValue;
                        foreach (var number in numbers)
                        {
                            if (minElement > number)
                            {
                                minElement = number;
                            }
                        }
                        Console.WriteLine(minElement);
                    }
                }
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}

/*You have an empty sequence, and you will be given N queries. Each query is one of these three types:
1 x – Push the element x into the stack.
2 – Delete the element present at the top of the stack.
3 – Print the maximum element in the stack.
4 – Print the minimum element in the stack.
After you go through all of the queries, print the stack in the following format:
"{n}, {n1}, {n2} …, {nn}"
*/
