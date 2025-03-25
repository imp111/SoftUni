using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = int.Parse(Console.ReadLine());

            while (i % 2 == 1 || i % 2 == 0)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine("Please write an even number.");
                    i = int.Parse(Console.ReadLine());
                }
                else if (i % 2 == 0)
                {
                    Console.WriteLine($"The number is: {Math.Abs(i)}");
                    break;
                }
            }
        }
    }
}
