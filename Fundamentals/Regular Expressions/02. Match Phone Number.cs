using System;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            MatchCollection mathces = Regex.Matches(Console.ReadLine(), @"\+[3][5][9]( ?-?)2(\1)[0-9]{3}(\1)[0-9]{4}\b");

            Console.WriteLine(string.Join(", ", mathces));
        }
    }
}
