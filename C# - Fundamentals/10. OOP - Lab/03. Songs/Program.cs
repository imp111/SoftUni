using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Songs
{
    class Songs
    {
        public string Type;
        public string Name;
        public string Time;
    }

    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());
            List<Songs> songStorage = new List<Songs>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] dataInput = Console.ReadLine().Split('_');
                Songs song = new Songs();

                string type = dataInput[0];
                string name = dataInput[1];
                string time = dataInput[2];

                song.Type = type;
                song.Name = name;
                song.Time = time;

                songStorage.Add(song);
            }

            string typeList = Console.ReadLine().ToLower();

            if (typeList == "all")
            {
                foreach (Songs song in songStorage)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Songs song in songStorage)
                {
                    if (typeList == song.Type)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }
}
