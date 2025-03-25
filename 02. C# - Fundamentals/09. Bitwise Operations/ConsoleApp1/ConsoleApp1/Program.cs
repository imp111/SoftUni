using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            string binary = Convert.ToString(input, 2);
            Console.WriteLine(binary);
        }
    }
}