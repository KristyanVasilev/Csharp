using System;
using System.Linq;

namespace textReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] texts = Console.ReadLine().Split();

            Array.Reverse(texts);

            for (int i = 0; i < texts.Length; i++)
            {
                Console.Write(texts[i] + " ");
            }

            

            
           
        }
    }
}
