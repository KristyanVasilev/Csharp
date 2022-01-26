using System;
using System.IO;
using System.Linq;

namespace _08.Even_Lines
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamReader streamReader = new StreamReader("text.txt"); // <- File path here
            string[] specialSymbols = new[] { "-", ",", ".", "!", "?" };

            int linecount = 0;
            while (!streamReader.EndOfStream)
            {
                var line = streamReader.ReadLine();
                foreach (var symbol in specialSymbols)
                {
                    line = line.Replace(symbol, "@");
                }
                if (linecount % 2 == 0)
                {
                    Console.WriteLine(string.Join(" ", line.Split().Reverse()));
                }
                linecount++;
            }
            /* Create a program that reads a text file and prints on the console its even lines. Line numbers start from 0. Use StreamReader. Before you print the result replace {"-", ",", ".", "!", "?"} with "@" and reverse the order of the words. */
        }
    }
}
