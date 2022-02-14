using System;

namespace ImplementingCustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var myStack = new MyStack<int>();

            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5); // myStack = 1 2 3 4 5

            Console.WriteLine(myStack.Peek()); // 5

            myStack.Pop();
            myStack.Pop();
            myStack.Pop(); // myStack -> 1 2

            Console.WriteLine(myStack.Contains(2)); // -> true , slow operation
            Console.WriteLine(myStack.Contains(124)); // -> false, slow operation

            myStack.Shrink(); // works like garbage collector

            myStack.ForEach(Console.WriteLine); // 1 2
        }
    }
}
