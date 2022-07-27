using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Square_With_Maximum_Sum
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            int[,] matrix = new int[input[0], input[1]];
            int[] buffer;

            for (int i = 0; i < matrix.GetLength(0); i++) //rows
            {
                buffer = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++) //columns
                {
                    matrix[i, j] = buffer[j];
                }
            }

            int output = 0;
            int sum = 0;
            int[,] outputArray = new int[2, 2];
            for (int i = 0; i < matrix.GetLength(0) - 1; i++) //rows
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++) //columns
                {
                    sum = matrix[i, j] + matrix[i + 1, j] + matrix[i, j + 1] + matrix[i + 1, j + 1];

                    if (sum > output)
                    {
                        output = sum;
                        outputArray[0, 0] = matrix[i, j];
                        outputArray[1, 0] = matrix[i + 1, j];
                        outputArray[0, 1] = matrix[i, j + 1];
                        outputArray[1, 1] = matrix[i + 1, j + 1];
                    }
                }
            }

            int counter = 0;
            foreach (var item in outputArray)
            {
                counter++;
                Console.Write(item + " ");

                if (outputArray.GetLength(1) == counter)
                {
                    Console.WriteLine();
                    counter = 0;
                }
            }

            Console.WriteLine(output);
        }
    }
}