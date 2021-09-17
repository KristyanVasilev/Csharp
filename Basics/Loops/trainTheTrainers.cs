using System;

namespace trainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {

            int numOfJudges = int.Parse(Console.ReadLine());
            string nameOfPresentation = Console.ReadLine();
            double totalGrades = 0;
            int counter = 0;
            double avgGrade = 0;

            while (nameOfPresentation != "Finish")
            {
                for (int i = 1; i <= numOfJudges; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    counter++;
                    totalGrades += grade;
                    avgGrade += grade;
                }

                Console.WriteLine($"{nameOfPresentation} - {totalGrades / numOfJudges :f2}.");
                totalGrades = 0;
                nameOfPresentation = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {avgGrade / counter:f2}.");
        }
    }
}
