using System;

namespace _08._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split("\\");
            string extractFile = input[input.Length - 1];
            var splited = extractFile.Split(".");
            string fileName = splited[0];
            string extension= splited[splited.Length-1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
