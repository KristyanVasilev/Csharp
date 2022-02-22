using System;
using System.Collections.Generic;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var myStack = new StackOfStrings<int>();
            Console.WriteLine(myStack.IsEmpty());
            var numbers = new List<int>(){ 1, 2, 3, 4, 5};
            myStack.AddRange(numbers);
            Console.WriteLine(myStack.IsEmpty());
        }
    }
}
