using System;
using System.IO;
using System.Linq;

namespace _05._Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = ReadFile(@"C:\Temp\Resources - Lab\04. Merge Files\input1.txt"); //input path here

            using FileStream fileStream = new FileStream(@"C:\Temp\binaryOutput.txt", FileMode.OpenOrCreate); //output path here
            fileStream.Write(data, 0, data.Length);
        }

        private static byte[] ReadFile(string filePath)
        {
            using FileStream fileReader = new FileStream(filePath, FileMode.OpenOrCreate);
            byte[] buffer = new byte[fileReader.Length];
            fileReader.Read(buffer, 0, (int)fileReader.Length);
            return buffer;
        }
    }
}
