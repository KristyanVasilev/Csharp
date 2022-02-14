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

            var personInfo = new MyTuple<string, string, string>($"{personInput[0]} {personInput[1]}", personInput[2], personInput[3]);

            var litres = int.Parse(beerInput[1]);
            bool IsDrunk = beerInput[2] == "drunk";
            var beerrInfo = new MyTuple<string, int, bool>(beerInput[0], litres, IsDrunk);

            var dbl = double.Parse(myTupleInput[1]);
            var myTuple = new MyTuple<string, double, string>(myTupleInput[0], dbl, myTupleInput[2]);

            Console.WriteLine(personInfo);
            Console.WriteLine(beerrInfo);
            Console.WriteLine(myTuple);
        }
    }
}
