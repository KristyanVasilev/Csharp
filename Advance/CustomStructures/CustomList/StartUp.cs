using System;

namespace ImplementingCustomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var myList = new MyList<int>();

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5); // myList = 1 2 3 4 5

            Console.WriteLine(myList.RemoveAt(0)); // -> return 1
            myList.RemoveAt(1); // myList = 2 4 5
            // myList.RemoveAt(325); -> throw new IndexOutOfRangeException();

            Console.WriteLine(myList.Contains(2)); // -> true
            Console.WriteLine(myList.Contains(124)); // -> false

            myList.Shrink(); // works like garbage collector

            myList[0] = 3; // myList = 3 4 5
            // myList[123] = 5; -> throw new IndexOutOfRangeException();

            myList.Swap(0, 2); // myList = 5 4 3

            myList.ForEach(Console.WriteLine); // write on the console 5 4 3
        }
    }
}
