using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;

namespace StreamExe
{
    class StreamExe
    {
        static void Main(string[] args)
        {
            
        }

        private static void ZipAndExtract()
        {
            string sourceDirectory = @"C:\Users\HP\Desktop\MyFolder";
            string targetDirectory = @"C:\Users\HP\Desktop\result.zip";
            string destinationDirectory = @"C:\Users\HP\Desktop\result";
            ZipFile.CreateFromDirectory(sourceDirectory, targetDirectory);
            ZipFile.ExtractToDirectory(targetDirectory, destinationDirectory);
            /* Create a program that creates a zip file in a given directory and extracts it in another one. Use the copyMe.png file from your resources and zip it in a directory of your choice. Extract the zip file in another directory, again, by your choice. */
        }

        private static void DirectoryTraversal()
        {
            // . - return all files
            // *.txt - return all txt files
            string[] allFiles = Directory.GetFiles("../../../", "."); //Path here
            Dictionary<string, Dictionary<string, double>> groupedFile = new Dictionary<string, Dictionary<string, double>>();

            foreach (var file in allFiles)
            {
                FileInfo fileInfo = new FileInfo(file);
                if (!groupedFile.ContainsKey(fileInfo.Extension))
                {
                    groupedFile.Add(fileInfo.Extension, new Dictionary<string, double>());
                }
                double size = (double)fileInfo.Length / 1024;
                groupedFile[fileInfo.Extension].Add(fileInfo.Name, size);
            }

            var sortedFiles = groupedFile.OrderByDescending(x => x.Value.Count()).ThenBy(x => x.Key);
            List<string> lines = new List<string>();
            foreach (var file in sortedFiles)
            {
                lines.Add(file.Key);
                foreach (var item in file.Value.OrderBy(x => x.Value))
                {
                    lines.Add($"--{item.Key} - {item.Value:f3}kb");
                }
            }
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/report.txt";
            File.WriteAllLines(path, lines);
            /* Create a program that traverses a given directory for all files with the given extension. Search through the first level of the directory only and write information about each found file in report.txt. The files should be grouped by their extension. Extensions should be ordered by the count of their files descending, then by name alphabetically. Files under an extension should be ordered by their size. File "report.txt" should be saved on the Desktop. Ensure the desktop path is always valid, regardless of the user. */
        }

        private static void CopyBinaryFile()
        {
            //File.Copy("copyMe.png", "copyMeCopy.png"); This code on 1 line
            using FileStream fileReader = new FileStream("copyMe.png", FileMode.Open);
            using FileStream fileWriter = new FileStream("copyMeCopy.png", FileMode.Create);
            byte[] buffer = new byte[256];

            while (true)
            {
                int currBytes = fileReader.Read(buffer, 0, buffer.Length);

                if (currBytes == 0)
                {                   
                    break;
                }

                fileWriter.Write(buffer, 0, buffer.Length);
            }
            /* Write a program that copies the contents of a binary file(e.g.copyMe.png) to another binary file(e.g.copyMe-copy.png) using FileStream.You are not allowed to use the File class or similar helper classes. */
        }

        private static void WordCount()
        {
            var wordsCounter = new Dictionary<string, int>();
            string[] words = File.ReadAllLines("words.txt");
            string[] data = File.ReadAllLines("text.txt");
            using StreamWriter streamWriter = new StreamWriter("../../../output.txt");

            for (int i = 0; i < words.Length; i++)
            {
                wordsCounter.Add(words[i], 0);
                for (int k = 0; k < data.Length; k++)
                {
                    var currData = data[k].Split(new char[] { '-', '.', ' ', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int j = 0; j < currData.Length; j++)
                    {
                        if (currData[j].ToLower() == words[i].ToLower())
                        {
                            wordsCounter[words[i]]++;
                        }
                    }
                }
            }

            wordsCounter = wordsCounter.OrderByDescending(x => x.Value).ToDictionary(k => k.Key, v => v.Value);
            foreach (var word in wordsCounter)
            {
                streamWriter.WriteLine($"{word.Key} - {word.Value}");
            }
            /* Create a program that reads a list of words from the file words.txt and finds how many times each of the words is contained in another file text.txt. Matching should be case-insensitive. Write the results in file actualResults.txt. Sort the words by frequency in descending order, read the expected results from expectedResult.txt and then compare your actual and expected results. Use the File class. */
        }

        private static void ProcessLines()
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

        private static void EvenLines()
        {
            StreamReader streamReader = new StreamReader("text.txt");
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
