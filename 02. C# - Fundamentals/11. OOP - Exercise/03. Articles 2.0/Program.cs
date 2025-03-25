using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Articles_2._0
{
    public class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public override string ToString()
        {
            return $"{Title} -{Content}:{Author}";
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            int numberOfArticles = int.Parse(Console.ReadLine());
            List<Article> newList = new List<Article>(numberOfArticles);
            string[] input;

            for (int i = 0; i < numberOfArticles; i++)
            {
                input = Console.ReadLine().Split(',');

                string title = input[0];
                string content = input[1];
                string author = input[2];

                Article newArticle = new Article(title, content, author);
                newList.Add(newArticle);
            }

            string orderBy = Console.ReadLine();

            switch (orderBy)
            {
                case "title":
                    newList = newList.OrderBy(x => x.Title).ToList();
                    break;

                case "content":
                    newList = newList.OrderBy(x => x.Content).ToList();
                    break;

                case "author":
                    newList = newList.OrderBy(x => x.Author).ToList();
                    break;

                default:
                    Console.WriteLine("wrong order parameter");
                    break;
            }

            Console.WriteLine(string.Join("\n", newList));
        }
    }
}