using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.P_th_bit
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int bitAtPosition1 = int.Parse(Console.ReadLine());
            n = n >> bitAtPosition1;

            Console.WriteLine(n & 1);
        }
    }
}