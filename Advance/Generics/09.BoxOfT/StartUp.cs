using System;

namespace BoxOfT
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var box = new Box<int>();
            box.Add(1);
            box.Add(2);
            box.Add(3);
            Console.WriteLine(box.Remove());
            box.Add(4);
            box.Add(5);
            Console.WriteLine(box.Remove());

            var boxOfStrings = new Box<string>();
            boxOfStrings.Add("sosho");
            boxOfStrings.Add("dasfff");
            boxOfStrings.Add("qwwq");
            Console.WriteLine(boxOfStrings.Remove());
            boxOfStrings.Add("dfff");
            boxOfStrings.Add("ads");
            Console.WriteLine(boxOfStrings.Remove());
        }
    }
}
/*Create a generic class Box that can be initialized with any type and store the value. Override the ToString() method and print the type and stored value.*/
