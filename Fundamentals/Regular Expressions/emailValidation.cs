using System;
using System.Text.RegularExpressions;

namespace proba
{
    class emailValidation
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"[A-z]+?[0-9]*@[a-z]{2,6}\.[a-z]{2,4}");

            Match match = regex.Match(Console.ReadLine());

            Console.WriteLine(match.Success);
            Console.WriteLine(match.Value);
            Console.WriteLine(match.Index);
        }
    }
}
