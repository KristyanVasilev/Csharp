using System;
using System.Linq;
using System.Collections.Generic;

namespace _16._Treasure_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string decryptMessage = Console.ReadLine();
            string message = "";
            int count = 0;

            while (decryptMessage != "find")
            {
                for (int i = 0; i < decryptMessage.Length; i++)
                {
                    int currPosition = decryptMessage[i];
                    if (count >= numbers.Length)
                    {
                        count = 0;
                    }
                    for (int j = count; j < numbers.Length; j++)
                    {
                        int newPosition = currPosition - numbers[j];
                        message += (char)newPosition;
                        count++;
                        break;
                    }
                }
                int materialStartIndex = message.IndexOf('&');
                int materialEndIndex = message.IndexOf('&',materialStartIndex+1);
                string material = message.Substring(materialStartIndex + 1, materialEndIndex - materialStartIndex - 1);
                int coordinatesStartIndex = message.IndexOf('<');
                int coordinatesEndIndex = message.IndexOf('>');
                string coordinates = message.Substring(coordinatesStartIndex + 1, coordinatesEndIndex - coordinatesStartIndex - 1);

                Console.WriteLine($"Found {material} at {coordinates}");
                count = 0;
                message = "";
                decryptMessage = Console.ReadLine();
            }
        }
    }
}
