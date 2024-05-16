using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Odd_Times
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                result = input[i] ^ result;
            }

            Console.WriteLine(result);
        }
    }
}