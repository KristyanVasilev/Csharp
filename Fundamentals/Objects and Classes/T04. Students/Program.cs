using System;
using System.Linq;
using System.Collections.Generic;

namespace T04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string line = Console.ReadLine();

            while (line != "end")
            {
                string[] studentInfo = line.Split();
                string firstName = studentInfo[0];
                string lastName = studentInfo[1];
                int age = int.Parse(studentInfo[2]);
                string town = studentInfo[3];

                Student student = new Student();

                student.FirstName = firstName;
                student.LastName = lastName;
                student.Age = age;
                student.Town = town;

                students.Add(student);
                line = Console.ReadLine();
            }

            string cityFilter = Console.ReadLine();
            foreach (Student student in students)
            {
                if (student.Town == cityFilter)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }
}
