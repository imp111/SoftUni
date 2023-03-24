using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Sum_Matrix_Columns
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            int[] buffer;
            int[] sum = new int[input[1]];
            int[,] matrix = new int[input[0], input[1]];

            for (int i = 0; i < input[0]; i++) //row
            {
                buffer = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int j = 0; j < input[1]; j++) //column
                {
                    matrix[i, j] = buffer[j];
                }
            }

            for (int i = 0; i < input[1]; i++)
            {
                for (int j = 0; j < input[0]; j++)
                {
                    sum[i] += matrix[j, i];
                }
                Console.WriteLine(sum[i]);
            }
        }
    }
}