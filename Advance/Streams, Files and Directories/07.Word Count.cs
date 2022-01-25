using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _07.Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            var wordsCounter = new Dictionary<string, int>();
            string[] words = File.ReadAllLines(@"C:\Temp\Resources - Lab\03. Word Count\words.txt"); //input path here
            string[] data = File.ReadAllLines(@"C:\Temp\Resources - Lab\03. Word Count\text.txt"); //input path here
            using StreamWriter streamWriter = new StreamWriter(@"C:\Temp\Resources - Lab\03. Word Count\output.txt"); //output path here

            var currWord = words[0].Split();
            for (int i = 0; i < currWord.Length; i++)
            {
                wordsCounter.Add(currWord[i], 0);
                for (int k = 0; k < data.Length; k++)
                {
                    var currData = data[k].Split(new char[] { '-', '.', ' ', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int j = 0; j < currData.Length; j++)
                    {
                        if (currData[j].ToLower() == currWord[i].ToLower())
                        {
                            wordsCounter[currWord[i]]++;
                        }
                    }
                }
            }

            wordsCounter = wordsCounter.OrderByDescending(x => x.Value).ToDictionary(k => k.Key, v => v.Value);
            foreach (var word in wordsCounter)
            {
                streamWriter.WriteLine($"{word.Key} - {word.Value}");
            }
        }
    }
}
//Write a program that reads a list of words from a given file (e. g. words.txt) and finds how many times each of the words occurs in another file (e. g. text.txt). Matching should be case-insensitive. The result should be written to an output text file (e. g. output.txt). Sort the words by frequency in descending order.
