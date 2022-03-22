using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Solution #1
            string input = "";
            Queue<string> queue = new Queue<string>();
            int counter = 0;
            int paidIndex = 0;
            while (input.ToLower() != "end")
            {
                input = Console.ReadLine();

                if (input.ToLower() == "paid")
                {
                    paidIndex = queue.Count();
                    counter = counter - queue.Count();
                }
                else if (input.ToLower() == "end")
                {
                    continue;
                }
                else
                {
                    queue.Enqueue(input);
                    counter++;
                }
            }
            
            if (counter <= 3)
            {
                Console.WriteLine($"{queue.Count} people remaining.");
            }
            else
            {
                for (int i = 0; i < paidIndex; i++)
                {
                    Console.WriteLine(queue.Dequeue());
                }
                Console.WriteLine($"{queue.Count} people remaining.");
            }*/

            string input = "";
            Queue<string> queue = new Queue<string>();
            int counter = 0;

            while (input.ToLower() != "end")
            {
                input = Console.ReadLine();

                if (input.ToLower() == "paid")
                {
                    int length = queue.Count();

                    for (int i = 0; i < length; i++)
                    {
                        Console.WriteLine(queue.Dequeue()); 
                    }
                }
                else if (input.ToLower() == "end")
                {
                    continue;
                }
                else
                {
                    queue.Enqueue(input);
                    counter++;
                }
            }

            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
