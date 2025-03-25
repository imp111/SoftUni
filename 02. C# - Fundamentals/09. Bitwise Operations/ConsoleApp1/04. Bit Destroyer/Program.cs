using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Bit_Destroyer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // user input
            int p = int.Parse(Console.ReadLine()); // position
            int mask; int newNumber;

            mask = ~(1 << p);
            newNumber = n & mask;

            Console.WriteLine(newNumber);
        }
    }
}