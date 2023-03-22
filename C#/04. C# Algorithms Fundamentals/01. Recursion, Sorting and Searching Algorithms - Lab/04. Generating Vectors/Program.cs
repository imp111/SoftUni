using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Generating_Vectors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            GenerateVector(array, 0);
        }

        public static void GenerateVector(int[] array, int index)
        {
            if (index == array.Length)
            {
                Console.WriteLine(string.Join("", array));
            }
            else
            {
                for (int i = 0; i <= 1; i++)
                {
                    array[index] = i;
                    GenerateVector(array, index + 1);
                }
            }
        }
    }
}
