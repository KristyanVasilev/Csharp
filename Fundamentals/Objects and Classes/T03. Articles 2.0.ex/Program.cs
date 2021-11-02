using System;
using System.Collections.Generic;
using System.Linq;

namespace T03._Articles_2._0.ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOFArticles = int.Parse(Console.ReadLine());
            List<Articles> articles = new List<Articles>();

            for (int i = 0; i < numOFArticles; i++)
            {
                List<string> currArticle = Console.ReadLine().Split(", ").ToList();
                Articles article = new Articles(currArticle[0], currArticle[1], currArticle[2]);
                articles.Add(article);
                
            }

            string sortCommand = Console.ReadLine();

            switch (sortCommand)
            {
                case "title": articles.Sort((article1, article2) => article1.Title.CompareTo(article2.Title));
                    break;

                case "content":
                    articles.Sort((article1, article2) => article1.Content.CompareTo(article2.Content));
                    break;

                case "author":
                    articles.Sort((article1, article2) => article1.Author.CompareTo(article2.Author));
                    break;
            }

            foreach (var article in articles)
            {
                Console.WriteLine(article);
            }
        }
    }
}
