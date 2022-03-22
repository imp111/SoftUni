using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Tri_Bit_Switch
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int mask = 0; int result;
            mask = n << p;
            result = n ^ mask;

            Console.WriteLine(result);
        }
    }
}