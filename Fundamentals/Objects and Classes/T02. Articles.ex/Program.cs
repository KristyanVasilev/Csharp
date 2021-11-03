using System;

namespace T02._Articles.ex
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] currArticle = Console.ReadLine().Split(", ");
            Article article = new Article(currArticle[0], currArticle[1], currArticle[2]);
            int NumOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < NumOfCommands; i++)
            {
                string[] cmd = Console.ReadLine().Split(": ");
                string mainCmd = cmd[0];
                string argument = cmd[1];

                switch (mainCmd)
                {
                    case "Edit":
                        article.Edit(argument);
                        break;

                    case "ChangeAuthor":
                        article.ChangeAuthor(argument);
                        break;

                    case "Rename":
                        article.Rename(argument);
                        break;
                }
            }
            Console.WriteLine(article);
        }
    }
}
