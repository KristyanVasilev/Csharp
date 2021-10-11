using System;

namespace T04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isBetween6And10Symbols = CheckLenghtPasword(password);
            if (isBetween6And10Symbols == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            bool isOnlyDigitsAndLetters = CheckDigitsAndLetters(password);
            if (isOnlyDigitsAndLetters == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            bool isContainsMin2Digits = CheckDigits(password);
            if (isContainsMin2Digits == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isBetween6And10Symbols && isOnlyDigitsAndLetters && isContainsMin2Digits)
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool CheckDigits(string password)
        {
            int count = 0;
            for (int i = 0; i < password.Length; i++)
            {
                char symbol = password[i];
                if (char.IsDigit(symbol))
                {
                    count++;
                }
            }

            return count >= 2 ? true : false;
           
        }
        static bool CheckDigitsAndLetters(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                char symbol = password[i];
                if (!char.IsLetterOrDigit(symbol))
                {
                    return false;
                }
            }
            return true;
        }
        static bool CheckLenghtPasword(string password)
        {
            return password.Length >= 6 && password.Length <= 10 ? true : false;

        }
    }
}

