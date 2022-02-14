using System;

namespace _07.Tuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            var personInput = Console.ReadLine().Split();
            var beerInput = Console.ReadLine().Split();
            var myTupleInput = Console.ReadLine().Split();

            var personInfo = new MyTuple<string, string>($"{personInput[0]} {personInput[1]}", personInput[2]);

            var litres = int.Parse(beerInput[1]);
            var beerrInfo = new MyTuple<string, int>(beerInput[0], litres);

            var integer = int.Parse(myTupleInput[0]);
            var dbl = double.Parse(myTupleInput[1]);
            var myTuple = new MyTuple<int, double>(integer, dbl);

            Console.WriteLine(personInfo);
            Console.WriteLine(beerrInfo);
            Console.WriteLine(myTuple);
        }
    }
}
