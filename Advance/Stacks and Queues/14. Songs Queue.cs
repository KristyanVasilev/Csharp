using System;
using System.Collections.Generic;
using System.Text;

namespace _14._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            Queue<string> songs = new Queue<string>(input);

            while (songs.Count > 0)
            {
                string commands = Console.ReadLine();
                if (commands == "Play")
                {
                    if(songs.Count > 0) songs.Dequeue();
                    else return;                  
                }
                else if (commands.Contains("Add"))
                {
                    string songName = commands.Substring(4);
                    if (songs.Contains(songName))
                    {
                        Console.WriteLine($"{songName} is already contained!");
                        continue;
                    }
                    songs.Enqueue(songName.ToString());
                }
                else if (commands == "Show")
                {
                    Console.WriteLine(string.Join(", ", songs));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
