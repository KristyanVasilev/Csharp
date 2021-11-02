using System;
using System.Collections.Generic;
using System.Linq;

namespace T04._Students.exercise
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < countOfStudents; i++)
            {
                string[] currStudent = Console.ReadLine().Split(" ");
                Student student = new Student();
                student.FirstName = currStudent[0]; 
                student.LastName = currStudent[1]; 
                student.Grade = double.Parse(currStudent[2]);
                students.Add(student);
            }
            students = students.OrderByDescending(student => student.Grade).ToList();

            foreach (var student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
    }
}
