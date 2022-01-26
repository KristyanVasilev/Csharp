using System;
using System.IO;
using System.Linq;

namespace _09.ProcessLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("text.txt");
            //string[] lines = File.ReadAllLines(inputFilePath);

            for (int i = 0; i < lines.Length; i++)
            {
                int letterCount = lines[i].Count(symbol => char.IsLetterOrDigit(symbol));
                int punctuationCount = lines[i].Count(symbol => char.IsPunctuation(symbol));
                File.AppendAllText("../../../output.txt", $"Line {i + 1} : {lines[i]} ({letterCount})({punctuationCount}){Environment.NewLine}");
                //File.AppendAllText(outputFilePath, $"Line {i + 1} : {lines[i]} ({letterCount})({punctuationCount}){Environment.NewLine}");
            }
            /* Write a program that reads a text file (e. g. text.txt) and inserts line numbers in front of each of its lines and count all the letters and punctuation marks. The result should be written to another text file (e. g. output.txt). Use the static class File to read and write all the lines of the input and output files.*/
        }
    }
}
