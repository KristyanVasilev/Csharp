using System;
using System.Linq;
using System.Collections.Generic;

namespace _11._SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new Dictionary<string, int>(); // user, points
            var submissions = new Dictionary<string, int>(); //language, count
            string input = Console.ReadLine();

            while (input != "exam finished")
            {
                var commands = input.Split("-");
                string user = commands[0];
                if (commands.Length > 2)
                {
                    string language = commands[1];
                    int points = int.Parse(commands[2]);
                    if (!students.ContainsKey(user))
                    {
                        students.Add(user, points);
                    }
                    else
                    {
                        if (students[user] < points)
                        {
                            students[user] = points;
                        }
                    }
                    if (!submissions.ContainsKey(language))
                    {
                        submissions.Add(language, 0);
                    }
                    submissions[language]++;
                }
                else
                {
                    if (students.ContainsKey(user))
                    {
                        students.Remove(user);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Results:");
            students = students.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, v => v.Value);
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key} | {student.Value}");
            }

            Console.WriteLine("Submissions:");
            submissions = submissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, v => v.Value);
            foreach (var submission in submissions)
            {
                Console.WriteLine($"{submission.Key} - {submission.Value}");
            }
        }
    }
}
