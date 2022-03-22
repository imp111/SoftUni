using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.First_Bit
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int bitAtPosition1 = 1;
            int n = int.Parse(Console.ReadLine());
            n = n >> bitAtPosition1;

            Console.WriteLine(n & 1);
        }
    }
}