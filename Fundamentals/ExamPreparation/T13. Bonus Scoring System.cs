using System;

namespace T13._Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOFStudents = int.Parse(Console.ReadLine());
            int totalNumOfLecture = int.Parse(Console.ReadLine());
            double additionalBonus = double.Parse(Console.ReadLine());
            double maxBonus = double.MinValue;
            double student = double.MinValue;

            for (int i = 1; i <= numOFStudents; i++)
            {
                double studentAttendance = double.Parse(Console.ReadLine());

                double totalBonus = studentAttendance / totalNumOfLecture * (5 + additionalBonus);
                if (totalBonus > maxBonus)
                {
                    maxBonus = totalBonus;
                    student = studentAttendance;
                }

            }
            Console.WriteLine($"Max Bonus: {Math.Round(maxBonus)}.");
            Console.WriteLine($"The student has attended {student} lectures.");
        }
    }
}
