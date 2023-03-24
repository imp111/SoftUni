using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] parameters = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = parameters[0]; // number of elements to enqueue
            int s = parameters[1]; // number of elments to dequeue
            int x = parameters[2]; // number to look for in the queue

            int[] storage = new int[n];
            storage = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(storage[i]);
            }

            for (int i = 0; i < s; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count == 0)
            {
                Console.WriteLine(queue.Count);
            }
            else if (queue.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
