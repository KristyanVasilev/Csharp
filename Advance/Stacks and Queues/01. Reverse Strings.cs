using System;
using System.Collections.Generic;

namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> myStack = new Stack<char>();

            foreach (var ch in input)
            {
                myStack.Push(ch);
            }

            while (myStack.Count > 0)
            {
                Console.Write(myStack.Pop());
            }
        }
    }
}
