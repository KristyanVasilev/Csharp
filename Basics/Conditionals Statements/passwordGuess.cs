using System;

namespace passwordGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            //s3cr3t!P @ssw0rd

            string password = Console.ReadLine();

            if (password == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");    
            }
        }
    }
}
