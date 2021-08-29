using System;

namespace graduationPt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int schoolYear = 1;
            int fails = 0;
            double grades1 = 0;

            while (schoolYear <= 12)
            {
                double grades = double.Parse(Console.ReadLine());
                if (grades < 4)
                {
                    if (fails == 1)
                    {
                        break;
                    }
                    fails++;
                    continue;
                    
                }

                grades1 += grades;
                schoolYear++;
            }
            double avarageGrade = grades1 / 12;
            if (schoolYear > 12)
            {
                Console.WriteLine($"{name} graduated. Average grade: {avarageGrade:f2}");
            }
            else
            {
                Console.WriteLine($"{name} has been excluded at {schoolYear} grade");
            }
        }
    }
}
