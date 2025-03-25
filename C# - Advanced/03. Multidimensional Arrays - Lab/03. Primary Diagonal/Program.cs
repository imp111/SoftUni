using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Primary_Diagonal
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[,] matrix = new int[input, input];
            int[] buffer;
            int sum = 0;
            for (int i = 0; i < input; i++)
            {
                buffer = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int j = 0; j < input; j++)
                {
                    matrix[i, j] = buffer[j];

                    if (i == j)
                    {
                        sum += matrix[i, j];
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}