using System;

namespace _14._Extract_Person_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();
                int nameStartIndex = text.IndexOf('@');
                int nameEndIndex = text.IndexOf('|');
                string name = text.Substring(nameStartIndex+1,nameEndIndex-nameStartIndex-1);
                int ageStartIndex = text.IndexOf('#');
                int ageEndIndex = text.IndexOf('*');
                string age = text.Substring(ageStartIndex + 1, ageEndIndex - ageStartIndex - 1);
                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
