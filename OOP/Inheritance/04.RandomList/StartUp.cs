using System;
using System.Linq;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var list = new RandomList();
            list.Add("Pesho");
            list.Add("Lube");
            list.Add("Mitko");
            list.Add("Gosho");
            list.Add("Pepi");

            Console.WriteLine(list.RandomString());
        }
    }
}
