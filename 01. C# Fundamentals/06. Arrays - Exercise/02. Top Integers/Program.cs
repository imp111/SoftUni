using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] odd = new int[n];
            int[] even = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] input;
                if (i % 2 == 0)
                {
                    input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                }
                else
                {
                    input = Console.ReadLine().Split().Select(int.Parse).Reverse().ToArray();
                }

                for (int j = 0; j < input.Length; j++)
                {
                    for (int k = j; k < input.Length - 1; k++)
                    {
                        odd[i] = input[k];
                    }
                    even[i] = input[j];
                }
            }

            Console.WriteLine(string.Join(" ", odd));
            Console.WriteLine(string.Join(" ", even));
        }
    }
}
