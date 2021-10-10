using System;

namespace T11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            string operatorr = Console.ReadLine();
            int number2 = int.Parse(Console.ReadLine());

            switch (operatorr)
            {
                case "*":
                    Console.WriteLine(Multoply(number1, number2));
                    break;

                case "/":
                    Console.WriteLine(Divide(number1, number2));
                    break;

                case "+":
                    Console.WriteLine(add(number1, number2));
                    break;

                case "-":
                    Console.WriteLine(Substract(number1, number2));
                    break;

            }           
        }

        private static int Divide(int number1, int number2)
        {
            return number1 /= number2;
        }

        private static int Substract(int number1, int number2)
        {
            return number1 -= number2;
        }

        private static int add(int number1, int number2)
        {
            return number1 += number2;
        }

        static int Multoply(int number1, int number2)
        {
            return number1 *= number2;
        }
    }
}
