using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfCarsToPass = int.Parse(Console.ReadLine());
            string command = "";
            Queue<string> queue = new Queue<string>();
            int counter = 0;
            while (command.ToLower() != "end")
            {
                command = Console.ReadLine();

                if (command == "green")
                {
                    for (int i = 0; i < numOfCarsToPass; i++)
                    {
                        if (queue.Count == 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"{queue.Dequeue()} passed!");
                            counter++;
                        }
                    }
                }
                else if (command == "end")
                {
                    break;
                }
                else
                {
                    queue.Enqueue(command);
                }
            }

            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
