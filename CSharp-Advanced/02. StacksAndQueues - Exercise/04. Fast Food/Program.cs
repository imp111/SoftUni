using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fast_Food
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int quantityFood = int.Parse(Console.ReadLine());

            if (quantityFood > 1000 || quantityFood < 0)
            {
                System.Environment.Exit(0);
            }

            Queue<int> queue = new Queue<int>();

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                queue.Enqueue(input[i]);
            }

            Console.WriteLine(queue.Max());

            int buffer = 0;
            for (int i = 0; i < input.Length; i++)
            {
                buffer = queue.Peek();

                if (quantityFood >= buffer)
                {
                    quantityFood -= queue.Dequeue();
                }
                else
                {
                    break;
                }
            }

            if (quantityFood >= 0 && queue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                buffer = queue.Count;
                Console.Write("Orders left: ");
                for (int i = 0; i < buffer; i++)
                {
                    Console.Write($"{queue.Dequeue()} ");
                }

                Console.WriteLine();
            }
        }
    }
}