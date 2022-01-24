using System;
using System.IO;

namespace _01._Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print only odd lines
            using StreamReader sr = new StreamReader(@"C:\Temp\Resources - Lab\01. Odd Lines\input.txt");
            using StreamWriter sw = new StreamWriter(@"C:\Temp\Resources - Lab\01. Odd Lines\output.txt");

            int linecount = 0;
            while (!sr.EndOfStream)
            {
                var line = sr.ReadLine();
                if (linecount % 2 == 1)
                {
                    sw.WriteLine(line);
                }
                linecount++;
            }
        }
    }
}
