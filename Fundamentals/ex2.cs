using System;
using System.Linq;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = new string[7];

            days[0] = "Monday";
            days[1] = "tuesday";
            days[2] = "Wednesday";
            days[days.Length - 1] = "Sunday";

            //Array.Sort(days);


            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine(days[i]);
            }
        }
    }
}
