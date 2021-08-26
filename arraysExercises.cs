using System;

namespace arraysExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days =
                {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine(days[i]);
            }

        }
    }
}
