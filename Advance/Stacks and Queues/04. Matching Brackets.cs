using System;
using System.Collections.Generic;

namespace _04._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            Stack<int> myStack = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    myStack.Push(i);
                }
                else if (expression[i] == ')')
                {
                    var openIndex = myStack.Pop();
                    var closeIndex = i;
                    Console.WriteLine(expression.Substring(openIndex, closeIndex - openIndex + 1));
                }
            }
        }
    }
}
