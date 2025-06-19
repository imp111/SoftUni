using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Zoo
{
    internal class StartUp
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Gorilla gorilla1 = new Gorilla(input);
            Console.WriteLine(gorilla1);
        }
    }
}