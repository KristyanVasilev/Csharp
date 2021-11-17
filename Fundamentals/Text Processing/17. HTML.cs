using System;

namespace _17._HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string article = Console.ReadLine();
            string textInArticle = Console.ReadLine();
            Console.WriteLine("<h1>");
            Console.WriteLine($"    {article}");
            Console.WriteLine("</h1>");
            Console.WriteLine("<article>");
            Console.WriteLine($"    {textInArticle}");
            Console.WriteLine("</article>");
            string comments = Console.ReadLine();

            while (comments != "end of comments")
            {
                Console.WriteLine("<div>");
                Console.WriteLine($"    {comments}");
                Console.WriteLine("</div>");

                comments = Console.ReadLine();
            }
        }
    }
}
