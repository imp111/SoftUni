using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Advertisement_Message
{
    internal class Parts
    {
        public string Phrases { get; set; }
        public string Events { get; set; }
        public string Authors { get; set; }
        public string Cities { get; set; }

        public Parts(string phrases, string events, string authors, string cities)
        {
            Phrases = phrases;
            Events = events;
            Authors = authors;
            Cities = cities;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            List<string> phrases = new List<string>(6) { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            List<string> events = new List<string>(6) { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            List<string> authors = new List<string>(6) { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            List<string> cities = new List<string>(6) { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            int numberOfReps = int.Parse(Console.ReadLine());

            var random = new Random();

            for (int i = 0; i < numberOfReps; i++)
            {
                int indexPhrase = random.Next(phrases.Count);
                int indexEvents = random.Next(events.Count);
                int indexAuthors = random.Next(authors.Count);
                int indexCities = random.Next(cities.Count);

                Parts newMessage = new Parts(phrases[indexPhrase], events[indexEvents], authors[indexAuthors], cities[indexCities]);

                Console.WriteLine($"{newMessage.Phrases} {newMessage.Events} - {newMessage.Cities}");
            }
        }
    }
}