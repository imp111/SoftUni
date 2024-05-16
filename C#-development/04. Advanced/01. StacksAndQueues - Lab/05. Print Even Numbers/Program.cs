using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 == 0)
                {
                    queue.Enqueue(input[i]);
                }
            }

            while (queue.Count > 0)
            {
                if (queue.Count == 1)
                {
                    Console.WriteLine(queue.Dequeue());
                }
                else
                {
                    Console.Write(queue.Dequeue() + ", ");
                } 
            }
        }
    }
}
