using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Songs_Queue
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] commands = new string[2];
            Queue<string> queue = new Queue<string>();
            string[] songs = Console.ReadLine().Split(',').ToArray();

            for (int i = 0; i < songs.Length; i++)
            {
                queue.Enqueue(songs[i].Trim());
            }

            while (queue.Count != 0)
            {
                commands = Console.ReadLine().Split().ToArray();

                switch (commands[0].ToLower())
                {
                    case "play":
                        queue.Dequeue();
                        break;

                    case "add":
                        string song = "";
                        for (int i = 1; i < commands.Length; i++)
                        {
                            song += commands[i];
                            if (i == commands.Length - 1)
                            {
                                break;
                            }
                            else
                            {
                                song += " ";
                            }
                        }

                        if (queue.Contains(song))
                        {
                            Console.WriteLine($"{song} is already contained!");
                            break;
                        }
                        else
                        {
                            queue.Enqueue(song);
                        }
                        break;

                    case "show":
                        string[] display = queue.ToArray();
                        for (int i = 0; i < display.Length; i++)
                        {
                            Console.Write(display[i]);
                            if (i != display.Length - 1)
                            {
                                Console.Write(", ");
                            }
                        }

                        Console.WriteLine();
                        break;

                    default:
                        break;
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}