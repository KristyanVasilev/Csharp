using System;
using System.Text;

namespace _10._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int multiplyer = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            int reminder = 0;

            //save guard
            if (input == "0" || multiplyer == 0)
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = input.Length - 1; i >= 0; i--)
            {
                int currDigit = int.Parse(input[i].ToString());
                int product = currDigit * multiplyer + reminder;
                int result = product % 10;
                reminder = product / 10;
                sb.Insert(0, result);
            }
            if (reminder > 0)
            {
                sb.Insert(0, reminder);
            }
            Console.WriteLine(sb);
        }
    }
}
