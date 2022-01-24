using System;
using System.IO;

namespace _03.SliceFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            //Slice file on 4 equals parts
            FileStream fileStream = new FileStream(@"C:\Temp\countries.txt", FileMode.OpenOrCreate); //input path here
            var data = new byte[fileStream.Length];

            int bytesPerFile = (int)Math.Ceiling(fileStream.Length / 4.0);
            for (int i = 1; i <= 4; i++)
            {
                var buffer = new byte[bytesPerFile];
                fileStream.Read(buffer);

                using FileStream writer = new FileStream($"C:\\Temp\\Part -{i}.txt", FileMode.OpenOrCreate); //output path here
                writer.Write(buffer);
            }
        }
    }
}
