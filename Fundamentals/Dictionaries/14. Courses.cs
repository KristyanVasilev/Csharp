using System;
using System.Linq;
using System.Collections.Generic;

namespace _14._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var SoftUniCourses = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();

            while (input != "end")
            {
                var cmd = input.Split(" : ");
                string course = cmd[0];
                string studentName = cmd[1];

                if (!SoftUniCourses.ContainsKey(course))
                {
                    SoftUniCourses.Add(course, new List<string>());
                }
                SoftUniCourses[course].Add(studentName);
                
                input = Console.ReadLine();
            }

            foreach (var course in SoftUniCourses.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{course.Key.Trim()}: {course.Value.Count}");

                foreach (var name in course.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {name}");
                }
            }
        }
    }
}
