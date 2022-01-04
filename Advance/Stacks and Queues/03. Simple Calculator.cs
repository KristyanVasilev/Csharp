using System;
using System.Collections.Generic;
using System.Text;

namespace _03._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var expression = Console.ReadLine();
            Stack<int> numbers = new Stack<int>();
            Stack<char> operators = new Stack<char>();

            for (int i = 0; i < expression.Length; i++)
            {
                var @char = expression[i];
                if (char.IsDigit(@char))
                {
                    var number = new StringBuilder();
                    while (char.IsDigit(@char))
                    {
                        number.Append(@char);
                        i++;
                        if (i >= expression.Length)
                        {
                            break;
                        }
                        @char = expression[i];
                    }
                    numbers.Push(int.Parse(number.ToString()));
                }
                else if (@char == '+' || @char == '-')
                {
                    operators.Push(@char);
                }
                if (numbers.Count > 1)
                {
                    var operand1 = numbers.Pop();
                    var operand2 = numbers.Pop();
                    var operation = operators.Pop();
                    switch (operation)
                    {
                        case '+':
                            var number = operand1 + operand2;
                            numbers.Push(number);
                            break;
                        case '-':
                            var number2 = operand2 - operand1;
                            numbers.Push(number2);
                            break;
                    }
                }
            }
            Console.WriteLine(numbers.Pop());
        }
    }
}
