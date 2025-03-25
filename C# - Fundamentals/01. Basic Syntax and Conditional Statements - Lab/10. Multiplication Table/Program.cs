using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int sum = input * i;
                Console.WriteLine($"{input} X {i} = {sum}");
            }
        }
    }
}
