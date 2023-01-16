using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Articles
{
    internal class Article
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

        public void Rename(string newTitle)
        {
            Title = newTitle;
        }

        public void Edit(string newContent)
        {
            Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(',');

            int numberOfCommands = int.Parse(Console.ReadLine());

            string content = input[0];
            string author = input[1];
            string title = input[2];

            Article newArticle = new Article(title, content, author);
            int counter = 0;
            for (int i = 1; i <= numberOfCommands; i++)
            {
                string command = Console.ReadLine();

                counter++;

                if (counter == 1)
                {
                    newArticle.Edit(command);
                }
                else if (counter == 2)
                {
                    newArticle.ChangeAuthor(command);
                }
                else if (counter == 3)
                {
                    newArticle.Rename(command);
                }

                if (i % 3 == 0)
                {
                    counter = 0;
                }
            }

            Console.WriteLine(newArticle.ToString());
        }
    }
}