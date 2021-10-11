using System;

namespace T05._Add_and_Subtract.ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int result = Add(num1, num2);
            Console.WriteLine(Result(result, num3));
        }

        private static int Result(int result, int num3)
        {
            return result -= num3;
        }

        static int Add(int num1, int num2)
        {
            return num1 += num2;
        }
    }
}
