using System;
using System.Collections.Generic;
using System.Linq;

namespace T10._SoftUni_Course_Planning.ex
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine().Split(", ").ToList();

            while (true)
            {
                var commands = Console.ReadLine().Split(':').ToArray();
                var firstCommand = commands[0];
                if (firstCommand == "course start") // Чупим цикъла.
                {
                    break;
                }
                if (firstCommand == "Add")
                {
                    if (!lessons.Contains(commands[1]))
                    {
                        lessons.Add(commands[1]);
                    }
                }
                else if (firstCommand == "Insert")
                {
                    if (!lessons.Contains(commands[1]))
                    {
                        int index = int.Parse(commands[2]);
                        lessons.Insert(index, commands[1]);
                    }
                }
                else if (firstCommand == "Remove")
                {
                    lessons.Remove(commands[1]);
                    lessons.Remove($"{commands[1]}-Exercise");
                }
                else if (firstCommand == "Swap")
                {
                    string lessonOneTilte = commands[1];// Намираме заглавията на лекциите.
                    string lessonTwoTilte = commands[2];
                    int indexOfLessonOne = lessons.IndexOf(lessonOneTilte); //Намираме на коя позиция стоят индексите на лекциите.
                    int indexOfLessonTwo = lessons.IndexOf(lessonTwoTilte);
                    if (indexOfLessonOne != -1 && indexOfLessonTwo != -1) //Проверяваме дали ги има в листа.
                    {
                        lessons[indexOfLessonOne] = lessonTwoTilte; //Разменяме позииците.
                        lessons[indexOfLessonTwo] = lessonOneTilte;
                        if (indexOfLessonOne + 1 < lessons.Count && lessons[indexOfLessonOne + 1] == $"{lessonOneTilte}-Exercise")//Проверяваме дали има упр.
                        {
                            lessons.RemoveAt(indexOfLessonOne + 1);
                            indexOfLessonOne = lessons.IndexOf(lessonOneTilte);
                            lessons.Insert(indexOfLessonOne + 1, $"{lessonOneTilte}-Exercise");
                        }
                        if (indexOfLessonTwo + 1 < lessons.Count && lessons[indexOfLessonTwo + 1] == $"{lessonTwoTilte}-Exercise")//Проверяваме дали има упр.
                        {
                            lessons.RemoveAt(indexOfLessonTwo + 1);
                            indexOfLessonTwo = lessons.IndexOf(lessonTwoTilte);
                            lessons.Insert(indexOfLessonTwo + 1, $"{lessonTwoTilte}-Exercise");
                        }
                    }
                }
                else if (firstCommand == "Exercise")
                {
                    int index = lessons.IndexOf(commands[1]); //Намираме индекса на лекцията
                    if (lessons.Contains(commands[1]) && !lessons.Contains($"{commands[1]}-Exercise")) //Проверяваме дали съществува лекцията, a не съществува упр.
                    {
                        lessons.Insert(index + 1, $"{commands[1]}-Exercise"); //ако не, го добавяме
                    }
                    else if (!lessons.Contains(commands[1])) //Проверяваме дали съществува лекцията
                    {
                        lessons.Add(commands[1]); //Ако не, добавяме я.
                        lessons.Add($"{commands[1]}-Exercise");//Добавяме и упр след нея.
                    }
                }
            }

            for (int i = 0; i < lessons.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{lessons[i]}");
            }
        }
    }
}
