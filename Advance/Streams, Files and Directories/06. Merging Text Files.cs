using System;
using System.IO;

namespace _06._Merging_Text_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads the contents of two input text files and merges them line by line together into a third text file
            using StreamReader firstStreamReader = new StreamReader(@"C:\Temp\Resources - Lab\04. Merge Files\input1.txt"); //input path here
            using StreamReader secondStreamReader = new StreamReader(@"C:\Temp\Resources - Lab\04. Merge Files\input2.txt"); //input path here
            using StreamWriter streamWriter = new StreamWriter(@"C:\Temp\Resources - Lab\04. Merge Files\mergedUotput.txt"); //output path here

            while (!firstStreamReader.EndOfStream && !secondStreamReader.EndOfStream)
            {
                var line = firstStreamReader.ReadLine();
                var secondLine = secondStreamReader.ReadLine();
                streamWriter.WriteLine(line);
                streamWriter.WriteLine(secondLine);
            }         
        }
    }
}
