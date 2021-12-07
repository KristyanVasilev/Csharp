using System;
using System.Text;

namespace T25._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string rawActivationKey = Console.ReadLine();
            string commands = Console.ReadLine();

            while (commands != "Generate")
            {
                string[] currCmd = commands.Split(">>>");
                if (currCmd[0] == "Contains")
                {
                    string substring = currCmd[1];
                    if (rawActivationKey.Contains(substring))
                    {
                        Console.WriteLine($"{rawActivationKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (currCmd[0] == "Flip")
                {
                    string upperOrLower = currCmd[1];
                    int startIndex = int.Parse(currCmd[2]);
                    int endIndex = int.Parse(currCmd[3]);
                    if (upperOrLower == "Upper")
                    {
                        rawActivationKey = rawActivationKey.Substring(0, startIndex) + rawActivationKey.Substring(startIndex, endIndex - startIndex).ToUpper() + rawActivationKey.Substring(endIndex);
                        Console.WriteLine(rawActivationKey);
                    }
                    else
                    {
                        rawActivationKey = rawActivationKey.Substring(0, startIndex) + rawActivationKey.Substring(startIndex, endIndex - startIndex).ToLower() + rawActivationKey.Substring(endIndex);
                        Console.WriteLine(rawActivationKey);
                    }
                }
                else if (currCmd[0] == "Slice")
                {
                    int startIndex = int.Parse(currCmd[1]);
                    int endIndex = int.Parse(currCmd[2]);
                    rawActivationKey = rawActivationKey.Remove(startIndex, endIndex-startIndex);
                    Console.WriteLine(rawActivationKey);
                }
                commands = Console.ReadLine();
            }
            Console.WriteLine($"Your activation key is: {rawActivationKey}");
        }
    }
}
