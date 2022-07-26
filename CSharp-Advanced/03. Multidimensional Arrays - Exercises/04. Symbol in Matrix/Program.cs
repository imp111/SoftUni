using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Symbol_in_Matrix
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            char[,] matrix = new char[input, input];
            string buffer;

            for (int i = 0; i < input; i++)
            {
                buffer = Console.ReadLine();

                for (int j = 0; j < input; j++)
                {
                    matrix[i, j] = buffer[j];
                }
            }

            char item = Console.ReadLine()[0];
            bool check = false;
            for (int i = 0; i < input; i++)
            {
                for (int j = 0; j < input; j++)
                {
                    if (item == matrix[i, j])
                    {
                        Console.WriteLine($"({i}, {j})");
                        check = true;
                        break;
                    }
                }
            }

            if (check == false)
            {
                Console.WriteLine($"{item} does not occur in the matrix");
            }
        }
    }
}