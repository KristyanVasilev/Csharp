using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int nameLenght = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().Where(x => x.Length <= nameLenght).ToList();
            names.ForEach(x => Console.WriteLine(x));
        }
    }
}
/*Write a program that filters a list of names according to their length. On the first line, you will be given an integer n, representing a name's length. On the second line, you will be given some names as strings separated by space. Write a function that prints only the names whose length is less than or equal to n.*/