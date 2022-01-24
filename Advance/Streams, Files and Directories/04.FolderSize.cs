using System;
using System.IO;

namespace _04.FolderSize
{
    class Program
    {
        static void Main(string[] args)
        {
            //Find folder size
            string direcotyPath = @"C:\Temp"; //input path here
            long totalLenght = GetTotalLenght(direcotyPath);
            Console.WriteLine(totalLenght);
        }

        private static long GetTotalLenght(string direcotyPath)
        {
            string[] files = Directory.GetFiles(direcotyPath);
            long totalLenght = 0;

            foreach (var file in files)
            {
                //Console.WriteLine(new FileInfo(file).Length);
                totalLenght += new FileInfo(file).Length;
            }
            var subDirectories = Directory.GetDirectories(direcotyPath);
            foreach (var directory in subDirectories)
            {
                totalLenght += GetTotalLenght(directory);
            }
            return totalLenght;
        }
    }
}
