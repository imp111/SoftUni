using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Recursive_Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long output = Factorial(n);
            Console.WriteLine(output);
        }

        public static long Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return n * Factorial(n - 1);
        }
    }
}
