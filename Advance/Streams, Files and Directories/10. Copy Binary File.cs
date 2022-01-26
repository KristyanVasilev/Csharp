using System;
using System.IO;

namespace _10._Copy_Binary_File
{
    class Program
    {
        static void Main(string[] args)
        {
            //File.Copy("copyMe.png", "copyMeCopy.png"); This code on 1 line
            using FileStream fileReader = new FileStream("copyMe.png", FileMode.Open); // <- File path here
            using FileStream fileWriter = new FileStream("copyMeCopy.png", FileMode.Create); // <- output file path here
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
    }
}
