using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fashion_Boutique
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] clothesInBox = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacityRack = int.Parse(Console.ReadLine());
        }
    }
}