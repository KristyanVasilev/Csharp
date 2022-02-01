using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string commands = Console.ReadLine();
            while (commands != "end")
            {
                if (commands == "add")
                {
                    Func<List<int>, List<int>> addOne = number => number.Select(x => x += 1).ToList();
                    numbers = addOne(numbers);
                }
                else if (commands == "subtract")
                {
                    Func<List<int>, List<int>> subtractOne = number => number.Select(x => x -= 1).ToList();
                    numbers = subtractOne(numbers);
                }
                else if (commands == "multiply")
                {
                    Func<List<int>, List<int>> multiply = number => number.Select(x => x *= 2).ToList();
                    numbers = multiply(numbers);
                }
                else if (commands == "print")
                {
                    Action<List<int>> print = number => Console.WriteLine(string.Join(" ", number));
                    print(numbers);
                }

                commands = Console.ReadLine();
            }
        }
    }
}
/*Create a program that executes some mathematical operations on a given collection. On the first line, you are given a list of numbers. On the next lines you are passed different commands that you need to apply to all the numbers in the list:
•	"add" -> add 1 to each number
•	"multiply" -> multiply each number by 2
•	"subtract" -> subtract 1 from each number
•	"print" -> print the collection
•	"end" -> ends the input 
*/
