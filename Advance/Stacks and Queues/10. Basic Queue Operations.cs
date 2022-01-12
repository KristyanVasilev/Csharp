using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Basic_Queue_Operations
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
            Queue<int> numbers = new Queue<int>();

            for (int i = 0; i < numOfElementsToPush; i++)
            {
                numbers.Enqueue(elements[i]);
            }
            for (int i = 0; i < numOfElementsToPop; i++)
            {
                numbers.Dequeue();
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

/*Play around with a queue. You will be given an integer N representing the number of elements to enqueue (add), an integer S representing the number of elements to dequeue (remove) from the queue and finally an integer X, an element that you should look for in the queue. If it is, print true on the console. If it’s not print the smallest element currently present in the queue. If there are no elements in the sequence, print 0 on the console.
*/ 
