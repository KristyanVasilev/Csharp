using System;
using System.Collections.Generic;
using System.Linq;

namespace T08._Anonymous_Threat.ex
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = Console.ReadLine().Split().ToList();

            while (true)
            {
                string[] commands = Console.ReadLine().Split();
                if (commands[0] == "3:1")
                {
                    break;
                }

                int startIndex = int.Parse(commands[1]);
                int endIndex = int.Parse(commands[2]);
                string concatedWord = "";

                if (startIndex < 0 || startIndex > myList.Count)
                {
                    startIndex = 0;
                }
                if (endIndex < 0 || endIndex > myList.Count - 1)
                {
                    endIndex = myList.Count - 1;
                }

                if (commands[0] == "merge")
                {
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        concatedWord += myList[i];
                    }
                    myList.RemoveRange(startIndex, endIndex - startIndex + 1); //Махаме нещата от листа от тези индекси
                    myList.Insert(startIndex, concatedWord);
                }
                else if(commands[0] == "divide")
                {
                    List<string> dividedList = new List<string>();
                    int divide = int.Parse(commands[2]); //Намираме на колко части да разделим думата.
                    string word = myList[startIndex]; // Намираме думата.
                    myList.RemoveAt(startIndex); // Махаме думата от листа.
                    int parts = word.Length / divide; //Разделяме думата на части;
                    for (int i = 0; i < divide; i++)
                    {
                        if (i == divide -1)
                        {
                            dividedList.Add(word.Substring(i * parts));
                        }
                        else
                        {
                            dividedList.Add(word.Substring(i * parts, parts));
                        }
                    }
                    myList.InsertRange(startIndex, dividedList);
                }
            }
            Console.WriteLine(string.Join(" ", myList));
        }
    }
}
