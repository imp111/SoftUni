using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02.Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger factorial = 1;
            int num = int.Parse(Console.ReadLine());

            for (int i = 2; i <= num; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }
    }
}
