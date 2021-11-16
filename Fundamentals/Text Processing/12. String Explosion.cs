using System;

namespace _12._String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int bombDamage = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (bombDamage > 0 && text[i] != '>')
                {
                    text = text.Remove(i, 1); 
                    bombDamage--; 
                    i--; 
                }
                else if (text[i] == '>')
                {
                    bombDamage += int.Parse(text[i + 1].ToString());
                }
            }
            Console.WriteLine(text);
        }
    }
}
