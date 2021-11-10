using System;
using System.Linq;
using System.Collections.Generic;

namespace _13._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentsGrade = new Dictionary<string, List<double>>();
            int studentsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < studentsCount; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!studentsGrade.ContainsKey(name))
                {
                    studentsGrade.Add(name, new List<double>());
                }
                studentsGrade[name].Add(grade);
            }

            foreach (var grade in studentsGrade.OrderByDescending(x => x.Value.Average()))
            {
                if (grade.Value.Average() >= 4.5)
                {
                    Console.WriteLine($"{grade.Key} -> {grade.Value.Average():f2}");
                }
            }
        }
    }
}
