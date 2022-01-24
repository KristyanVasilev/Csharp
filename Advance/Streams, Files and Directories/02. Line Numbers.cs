using System;
using System.IO;

namespace _02._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Numbering every line
            using StreamReader sr = new StreamReader(@"C:\Temp\Resources - Lab\02. Line Numbers\input.txt"); //input path here
            using StreamWriter sw = new StreamWriter(@"C:\Temp\Resources - Lab\02. Line Numbers\output.txt"); // output path here

            int linecount = 1;
            while (!sr.EndOfStream)
            {
                var line = sr.ReadLine();
                sw.WriteLine($"{linecount}. {line}");
                linecount++;
            }
        }
    }
}
