using System;
using System.Text.RegularExpressions;

namespace names
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"[A-Z][a-z]+ [A-Z][a-z]+");

            MatchCollection matches = regex.Matches("Gosho Petrov e priqtel na Pesho Peshov");

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Success);
                Console.WriteLine(match.Value);
                Console.WriteLine(match.Index);
            }
        }
    }
}
