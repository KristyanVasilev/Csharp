using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _11._Directory_Traversal
{
    class Program
    {
        static void Main(string[] args)
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
    }
}
