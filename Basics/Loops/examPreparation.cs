using System;

namespace examPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());
            string problemName = Console.ReadLine();
            int numOfProblems = 0;
            int gradecounter = 0;
            double gradeScore = 0;
            int badGradesCounter = 0;
            string lastProblem = "";


            while (problemName != "Enough")
            {
                double grade = double.Parse(Console.ReadLine());
                gradeScore += grade;
                gradecounter++;
                if (grade <= 4)
                {
                    badGradesCounter++;
                    if (badGradesCounter == badGrades)
                    {
                        break;
                    }
                }
               
                numOfProblems++;
                lastProblem = problemName;
                problemName = Console.ReadLine();
            }
            if (problemName == "Enough")
            {
                double avarageGrade = gradeScore / gradecounter;
                Console.WriteLine($"Average score: {avarageGrade:f2}");
                Console.WriteLine($"Number of problems: {numOfProblems}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
            else
            {
                Console.WriteLine($"You need a break, {badGrades} poor grades.");
            }

        }
    }
}