using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Generating_Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] set = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int generateNumber = int.Parse(Console.ReadLine());
            int[] vector = new int[generateNumber];
            GenCombs(set, vector, 0, -1);
        }

        public static void GenCombs(int[] set, int[] vector, int index, int border) 
        {
            if (index >= vector.Length)
            {
                Console.WriteLine(string.Join(" ", vector));
            }
            else
            {
                for (int i = border + 1; i < set.Length; i++)
                {
                    vector[index] = set[i];
                    GenCombs(set, vector, index + 1, i);
                }
            }
        }
    }
}
