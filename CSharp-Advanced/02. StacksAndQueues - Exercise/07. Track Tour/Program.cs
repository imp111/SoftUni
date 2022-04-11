using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Track_Tour
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] petrolValues = new int[n];

            for (int i = 0; i < n; i++)
            {
                petrolValues = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }
        }
    }
}