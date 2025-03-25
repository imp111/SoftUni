using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            int numToRemove = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>();
            int i = 0;

            for (i = 0; i < input.Length; i++)
            {
                queue.Enqueue(input[i]);
            }

            i = 1;
            while (queue.Count > 1)
            {
                string personToCheck = queue.Dequeue();

                if (i == numToRemove)
                {
                    Console.WriteLine($"Removed {personToCheck}");
                    i = 0;
                }
                else
                {
                    queue.Enqueue(personToCheck);
                }

                i++;
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
