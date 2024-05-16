using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int start = int.Parse(Console.ReadLine());
            int sum2 = num * start;

            if (start > 10)
            {
                Console.WriteLine($"{num} X {start} = {sum2}");
            }
            else
            {
                for (int i = start; i <= 10; i++)
                {
                    int sum = num * i;
                    Console.WriteLine($"{num} X {i} = {sum}");
                }
            }
        }
    }
}
