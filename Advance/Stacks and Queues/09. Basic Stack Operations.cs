using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int numOfElementsToPush = input[0];
            int numOfElementsToPop = input[1];
            int element = input[2];
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < numOfElementsToPush; i++)
            {
                numbers.Push(elements[i]);
            }
            for (int i = 0; i < numOfElementsToPop; i++)
            {
                numbers.Pop();
            }
            if (numbers.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }
            int minElement = int.MaxValue;
            foreach (var number in numbers)
            {
                if (number == element)
                {
                    Console.WriteLine("true");
                    return;
                }
                if (minElement > number)
                {
                    minElement = number;
                }
            }
            Console.WriteLine(minElement);
        }
    }
}

/*Play around with a stack. You will be given an integer N representing the number of elements to push into the stack, an integer S representing the number of elements to pop from the stack and finally an integer X, an element that you should look for in the stack. If it’s found, print "true" on the console. If it isn't, print the smallest element currently present in the stack. If there are no elements in the sequence, print 0 on the console.
Input
•	On the first line you will be given N, S and X, separated by a single space
•	On the next line you will be given N number of integers
Output
•	On a single line print either true if X is present in the stack, otherwise print the smallest element in the stack. If the stack is empty, print 0
*/