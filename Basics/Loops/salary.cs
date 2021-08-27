using System;

namespace salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int openTabs = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());
            int facebook = 150;
            int instagram = 100;
            int reddit = 50;

            for (int i = 0; i < openTabs; i++)
            {
                string tabs = Console.ReadLine().ToLower();

                if (tabs == "facebook")
                {
                    salary -= facebook;
                }
                else if (tabs == "instagram")
                {
                    salary -= instagram;
                }
                else if (tabs == "reddit")
                {
                    salary -= reddit;
                }
            }
            if (salary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(salary);
            }



        }
    }
}
