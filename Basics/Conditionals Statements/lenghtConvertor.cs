using System;

namespace proba
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string inputvalue = Console.ReadLine();
            string outPutValue = Console.ReadLine();

            if (inputvalue == "mm" && outPutValue == "sm")
            {
                number = number / 10;
            }
            else if (inputvalue == "sm" && outPutValue == "mm")
            {
                number = number * 10;
            }
            else if (inputvalue == "m" && outPutValue == "sm")
            {
                number = number * 100;
            }
            else if (inputvalue == "sm" && outPutValue == "m")
            {
                number = number / 100;
            }
            else if (inputvalue == "mm" && outPutValue == "m")
            {
                number = number / 1000;

            }
            else if (inputvalue == "m" && outPutValue == "mm")
            {
                number = number * 1000;
            }


            Console.WriteLine($"{number:f3}");
        }
    }
}
