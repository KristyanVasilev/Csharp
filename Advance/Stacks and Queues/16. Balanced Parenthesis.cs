using System;
using System.Collections.Generic;

namespace _16._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            Stack<char> paranthese = new Stack<char>();
            bool isValid = true;

            for (int i = 0; i < expression.Length; i++)
            {               
                if (expression[i] == '{' || expression[i] == '[' || expression[i] == '(')
                {
                    paranthese.Push(expression[i]);
                }
                else
                {
                    if (paranthese.Count == 0)
                    {
                        isValid = false;
                        break;
                    }
                    else if (expression[i] == ')' && paranthese.Peek() == '(') paranthese.Pop();
                    else if (expression[i] == ']' && paranthese.Peek() == '[') paranthese.Pop();
                    else if (expression[i] == '}' && paranthese.Peek() == '{') paranthese.Pop();
                    else isValid = false;
                }
            }
            Console.WriteLine(isValid? "YES" : "NO");
        }
    }
}
