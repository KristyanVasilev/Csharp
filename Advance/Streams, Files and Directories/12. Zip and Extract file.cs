using System;
using System.IO.Compression;

namespace _12._Zip_and_Extract_file
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceDirectory = @"C:\Users\HP\Desktop\MyFolder";
            string targetDirectory = @"C:\Users\HP\Desktop\result.zip";
            string destinationDirectory = @"C:\Users\HP\Desktop\result";
            ZipFile.CreateFromDirectory(sourceDirectory, targetDirectory);
            ZipFile.ExtractToDirectory(targetDirectory, destinationDirectory);
            /* Create a program that creates a zip file in a given directory and extracts it in another one. Use the copyMe.png file from your resources and zip it in a directory of your choice. Extract the zip file in another directory, again, by your choice. */
        }
    }
}
