using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Multidimensional_Arrays___Exercises
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            int[] buffer;
            int[,] matrix = new int[input[0], input[1]];

            for (int i = 0; i < input[0]; i++)
            {
                buffer = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

                for (int j = 0; j < buffer.Length; j++)
                {
                    matrix[i, j] = buffer[j];
                }
            }
            int sum = 0;
            foreach (var item in matrix)
            {
                sum += item;
            }

            Console.WriteLine(input[0]);
            Console.WriteLine(input[1]);
            Console.WriteLine(sum);
        }
    }
}