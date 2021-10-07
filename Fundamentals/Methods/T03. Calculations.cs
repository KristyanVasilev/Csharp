using System;

namespace T03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            switch (type)
            {
                case "add":
                    PrintAdd(number1, number2);
                    break;

                case "multiply":
                    PrintMultiply(number1, number2);
                    break;
                case "subtract":
                    PrintSubstract(number1, number2);
                    break;

                case "divide":
                    PrintDivide(number1, number2);
                    break;
            }
        }

        private static void PrintSubstract(int number1, int number2)
        {
            int sum = number1 - number2;
            Console.WriteLine(sum);
        }

        private static void PrintDivide(int number1, int number2)
        {
            int sum = number1 / number2;
            Console.WriteLine(sum);
        }

        private static void PrintMultiply(int number1, int number2)
        {
            int sum = number1 * number2;
            Console.WriteLine(sum);
        }

        private static void PrintAdd(int number1, int number2)
        {
            int sum = number1 + number2;
            Console.WriteLine(sum);
        }
    }
}
