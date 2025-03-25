using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Jagged_Arrays_Modification
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[,] matrix = new int[input, input];
            int[] buffer;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                buffer = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = buffer[j];
                }
            }

            string[] command = { " ", " ", " " };
            while (command[0].ToLower() != "end") // command {row} {col} {value}
            {
                switch (command[0].ToLower())
                {
                    case "add":
                        if (int.Parse(command[1]) <= matrix.GetLength(0) - 1 && int.Parse(command[1]) >= 0 && int.Parse(command[2]) >= 0 && int.Parse(command[2]) <= matrix.GetLength(1) - 1)
                        {
                            matrix[int.Parse(command[1]), int.Parse(command[2])] += int.Parse(command[3]);
                        }
                        else
                        {
                            Console.WriteLine("Invalid coordinates");
                        }

                        break;

                    case "subtract":
                        if (int.Parse(command[1]) <= matrix.GetLength(0) - 1 && int.Parse(command[1]) >= 0 && int.Parse(command[2]) >= 0 && int.Parse(command[2]) <= matrix.GetLength(1) - 1)
                        {
                            matrix[int.Parse(command[1]), int.Parse(command[2])] -= int.Parse(command[3]);
                        }
                        else
                        {
                            Console.WriteLine("Invalid coordinates");
                        }
                        break;

                    default:
                        break;
                }

                command = Console.ReadLine().Split().ToArray();
            }

            int counter = 0;
            foreach (var item in matrix)
            {
                counter++;
                Console.Write(item + " ");

                if (matrix.GetLength(1) == counter)
                {
                    Console.WriteLine();
                    counter = 0;
                }
            }
        }
    }
}