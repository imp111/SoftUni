using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[i + 1])
                {
                    Console.WriteLine(array[i]);
                }
            }

        }
    }
}
