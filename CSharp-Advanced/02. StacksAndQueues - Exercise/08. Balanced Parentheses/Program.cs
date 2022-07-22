using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Balanced_Parentheses
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Queue<char> queue = new Queue<char>(input);

            int counter = 0;
            bool check = true;

            if (queue.Count % 2 != 0)
            {
                Console.WriteLine("NO");
                return;
            }

            while (queue.Count != 0)
            {
                char first = queue.Dequeue();
                char next = queue.Peek();

                switch (first)
                {
                    case '{':
                        if (next == '}')
                        {
                            queue.Dequeue();
                            counter = 0;
                            continue;
                        }
                        else
                        {
                            queue.Enqueue(first);
                            continue;
                        }

                    case '[':
                        if (next == ']')
                        {
                            queue.Dequeue();
                            counter = 0;
                            continue;
                        }
                        else
                        {
                            queue.Enqueue(first);
                            continue;
                        }

                    case '(':
                        if (next == ')')
                        {
                            queue.Dequeue();
                            counter = 0;
                            continue;
                        }
                        else
                        {
                            queue.Enqueue(first);
                            continue;
                        }
                    default:
                        queue.Enqueue(first);
                        break;
                }

                counter++;

                if (counter == queue.Count)
                {
                    check = false;
                    break;
                }
            }

            if (check)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}