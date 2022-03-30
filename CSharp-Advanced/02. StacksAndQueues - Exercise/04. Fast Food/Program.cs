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
            Queue<int> queue = new Queue<int>();

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                queue.Enqueue(input[i]);
            }

            Console.WriteLine(queue.Max());

            for (int i = 0; i < input.Length; i++)
            {
                int buffer = 0;
                buffer = queue.Dequeue();

                if (quantityFood < buffer)
                {
                    quantityFood -= buffer;
                }
                else
                {
                    break;
                }
            }

            if (quantityFood > 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {quantityFood}");
            }
        }
    }
}