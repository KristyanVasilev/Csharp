using System;
using System.Collections.Generic;
using System.Text;

namespace _17._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder();
            Stack<string> newTxt = new Stack<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split();

                if (commands[0] == "1")
                {
                    newTxt.Push(text.ToString());
                    string textToAppend = commands[1];
                    text.Append(textToAppend);
                }
                else if (commands[0] == "2")
                {
                    newTxt.Push(text.ToString());
                    int count = int.Parse(commands[1]);
                    while (count > 0)
                    {
                        text.Remove(text.Length - 1, 1);
                        count--;
                    }
                }
                else if (commands[0] == "3")
                {
                    int index = int.Parse(commands[1]);
                    Console.WriteLine(text[index - 1]);
                }
                else if (commands[0] == "4")
                {
                    text.Clear();
                    text.Append(newTxt.Pop());
                }
            }
        }
    }
}
