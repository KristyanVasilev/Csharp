using System;

namespace T01._Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            PrintGrade(grade);
        }

        static void PrintGrade(double grade)
        {
            if (grade <= 2.99)
            {
                Console.WriteLine("Fail");
            }
            else if (grade <= 3.49)
            {
                Console.WriteLine("Poor");
            }
            else if (grade <= 4.49)
            {
                Console.WriteLine("Good");
            }
            else if (grade <= 5.49)
            {
                Console.WriteLine("Very good");
            }
            else if (grade <= 6.00)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
