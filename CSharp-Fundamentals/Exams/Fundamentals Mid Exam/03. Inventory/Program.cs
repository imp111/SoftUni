using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Inventory
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] items = Console.ReadLine().Split(',').ToArray();
            List<string> inventory = new List<string>();
            string[] data = { };
            string input = Console.ReadLine();

            while (input != "Craft!")
            {
                data = input.Split('-', ' ', ',').ToArray();

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", data));
            Console.WriteLine(string.Join(" ", items));
            Console.WriteLine(string.Join(" ", input));
        }
    }
}